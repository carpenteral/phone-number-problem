using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils;

namespace UtilsUnitTests {
    [TestClass]
    public class PhoneNumberTests {
        // Arrange
        string expected = "91234567890";

        [TestMethod]
        public void Valid_With_Hyphens() {
            // Act
            string actual = PhoneUtils.NormalizedPhoneNumber("912-3456-7890");
            // Assert
            Assert.AreEqual(expected, actual, "Number with hyphens failed");
        }
    }
}
 