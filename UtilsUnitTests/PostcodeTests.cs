using System;
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

    }
}
 