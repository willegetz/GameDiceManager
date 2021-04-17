using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DiceTypeTests.DieTypes
{
    [TestClass]
    public class PercentileDiceTests
    {
        // The percentile dice are two D10s
        //  The faces on the first D10 (the tens) number 1 to 10
        //  The faces on the second D10 (the ones) number 0 to 9
        // The percentage result is the concatination of the first and second D10 and
        //  not a random number between 1 and 100.
        // The face numbers are reported as above explicitly stating which die each set
        //  belongs to

        // To make testing easier for the time being, two random seeds will be used in order
        //  to ensure the appropriate roll results.

        [TestMethod]
        public void ReportsItsType()
        {
            var percentile = new PercentileDice(0, 0);
            var dieType = percentile.GetDieType();

            var expectedDieType = "Percentile (2D10)";

            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var percentile = new PercentileDice(0, 0);
            var faceNumbers = percentile.GetFaceNumbers();

            var expectedFaceNumbers = @"Tens Die: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
Ones Die: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9";

            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns48WhenRolled()
        {
            var tensSeed = 5;
            var onesSeed = 4;

            var percentile = new PercentileDice(tensSeed, onesSeed);
            var result = percentile.RollDice();

            var expectedResult = 48;
            Assert.AreEqual(expectedResult, result);
        }
    }
}
