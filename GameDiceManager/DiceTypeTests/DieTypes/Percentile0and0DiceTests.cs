using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DiceTypeTests.DieTypes
{
    [TestClass]
    public class Percentile0and0DiceTests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var percentile = new PercentileDice0and0(0, 0);
            var dieType = percentile.GetDieType();

            var expectedDieType = "Percentile (2D10 with face range 0 to 9 each)";

            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var percentile = new PercentileDice0and0(0, 0);
            var faceNumbers = percentile.GetFaceNumbers();

            var expectedFaceNumbers = @"Tens Die: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
Ones Die: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9";

            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }
    }
}
