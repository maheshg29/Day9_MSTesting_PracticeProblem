using Day9_MSTesting_PracticeProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Day9TestProject
{
    [TestClass]
    public class UnitTest_Purches
    {
        [TestMethod]
        public void TestMethodOnlyOne()
        {
            // Arrange
            Purches purches = new Purches();
            string inputPrices = "10 20 10 30 40 40";

            // Act
            List<string> result = purches.OnlyOnce(inputPrices);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "20", "30" }, result);
        }

        [TestMethod]
        public void TestMethodOnlyOneForNull()
        {
            // Arrange
            Purches purches = new Purches();
            string inputPrices = "10 20 20 30 10 30 40 40";

            // Act
            List<string> result = purches.OnlyOnce(inputPrices);

            // Assert
            CollectionAssert.AreEqual(new List<string> { null }, result);
        }
    }
}
