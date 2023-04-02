using Day9_MSTesting_PracticeProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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


        [TestMethod]
        public void TestMethodMoreThanOne()
        {
            // Arrange
            Purches purches = new Purches();
            string inputPrices = "10 20 10 30 40 40";

            // Act
            List<string> result = purches.moreThanOne(inputPrices);

            // Assert
            CollectionAssert.AreEqual(new List<string> { "10", "40" }, result);
        }

        [TestMethod]
        public void TestMethodMoreThanOneForNull()
        {
            // Arrange
            Purches purches = new Purches();
            string inputPrices = "10 20 30 40";

            // Act
            List<string> result = purches.moreThanOne(inputPrices);

            // Assert
            CollectionAssert.AreEqual(new List<string> { null }, result);
        }

        
        [TestMethod]
        public void TestMethodCompetition()
        {

            // Arrange
            SwapCompetition swapCompetition = new SwapCompetition();
            var expectedNextRound = new List<int> { 1, 2 };
            var input = new StringReader("3\nabc\ncba\ndef\nfed\nghj\ntyu");
            Console.SetIn(input);

            // Act
            var actualNextRound = swapCompetition.Competition();

            // Assert
            CollectionAssert.AreEqual(expectedNextRound, actualNextRound);
        }

    }

    
}
