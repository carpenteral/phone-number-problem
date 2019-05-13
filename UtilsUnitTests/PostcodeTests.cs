using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils;

namespace UtilsUnitTests {
    [TestClass]
    public class PostcodeTests {

        [TestMethod]
        public void MyPostcode_Valid() {
            // Act
            bool ok = PostcodeUtils.IsValid("EH4 3HN");
            // Assert
            Assert.IsTrue(ok, "My postcode should be valid");
        }
        [TestMethod]
        public void ShortPostcode_InValid() {
            // Act
            bool ok = PostcodeUtils.IsValid("AB1");
            // Assert
            Assert.IsFalse(ok, "Short postcode should be invalid");
        }
        [TestMethod]
        public void test_areas_with_single_digit_districts()
        {
            // Arrange
            string[] singleDigitPostCodeAreas = { "BR", "FY", "HA", "HD", "HG", "HR", "HS", "HX", "JE", "LD", "SM", "SR", "WC", "WN", "ZE" };
            foreach (string area in singleDigitPostCodeAreas)
            {
                // Act
                bool ok = PostcodeUtils.IsValid(area + "22 1AB");
                // Assert
                ok.Should().BeFalse($"Only single-digit districts allowed. Area={area}");
            }
        }

    }
}
 