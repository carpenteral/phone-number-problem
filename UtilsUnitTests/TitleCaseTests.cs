using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils;

namespace UtilsUnitTests {
    [TestClass]
    public class TitleCaseTests {
        [TestMethod]
        public void Regular_OK() {
            SuccessTest(
                input: "the quick brown fox jumped over the lazy dog",
                expected: "The Quick Brown Fox Jumped Over The Lazy Dog",
                errorPrefix: "Regular string");
        }
        [TestMethod]
        public void German_Aristocracy_OK() {
            SuccessTest(
                input: "ludwig van beethoven",
                expected: "Ludwig van Beethoven",
                errorPrefix: "'van'");
        }
        [TestMethod]
        public void The_von_Trapp_Family_OK() {
            SuccessTest(
                input: "von trapp",
                expected: "von Trapp",
                errorPrefix: "'von'");
        }
        [TestMethod]
        public void Name_with_Initial_OK() {
            SuccessTest(
                input: "f.flintstone",
                expected: "F.Flintstone",
                errorPrefix: "initial");
        }
        [TestMethod]
        public void Name_with_Letters_OK() {
            SuccessTest(
                input: "f.flintstone MA", 
                expected: "F.Flintstone MA",
                errorPrefix: "letters");
        }

        private static void SuccessTest(string input, string expected, string errorPrefix) {
            // Act
            string actual = StringUtils.ToTitleCase(input);
            // Assert
            Assert.AreEqual(expected, actual, errorPrefix + " not capitalized correctly");
        }
    }
}
 