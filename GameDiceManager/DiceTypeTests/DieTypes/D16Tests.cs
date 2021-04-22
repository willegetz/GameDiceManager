using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace DiceTypeTests.DieTypes
{
    // From World Builder's Guidebook
    // In orrder to generate a d16, roll a d6 and a d8 simultaneously.
    // If the d6 comes up 1-3, read the d8 without modification.
    // If the d6 comes up 4-6, read the d8 as d8+8.
    // This gernerates a random number between 1 and 16.

    [TestClass]
    public class D16Tests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var d16 = new D16(0, 0);
            var dieType = d16.GetDieType();

            var expectedDieType = "D16";

            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var d16 = new D16(0, 0);
            var faceNumbers = d16.GetFaceNumbers();

            var expectedFaceNumbers = @"D8: 1, 2, 3, 4, 5, 6, 7, 8
D6: 1, 2, 3, 4, 5, 6";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns4WhenD6ResultIs1()
        {
            var d8RandomSeed = 11;
            var d6RandomSeed = 14;

            var d16 = new D16(d8RandomSeed, d6RandomSeed);
            var rollResult = d16.RollDie();

            var expectedResult = 4;

            Assert.AreEqual(expectedResult, rollResult);
        }

        [TestMethod]
        public void Returns9WhenD6ResultIs6()
        {
            var d8RandomSeed = 14;
            var d6RandomSeed = 6;

            var d16 = new D16(d8RandomSeed, d6RandomSeed);
            var rollResult = d16.RollDie();

            var expectedResult = 9;

            Assert.AreEqual(expectedResult, rollResult);
        }
    }
}
