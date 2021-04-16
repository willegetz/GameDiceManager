using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DiceTypeTests.DieTypes
{
    [TestClass]
    public class D6Tests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var d6 = new D6(13);
            var dieType = d6.GetDieType();

            var expectedDieType = "D6";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var d6 = new D6(13);
            var faceNumbers = d6.GetFaceNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4, 5, 6";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns4WhenRolled()
        {
            var randomSeed = 13;

            var d6 = new D6(randomSeed);
            var rollResult = d6.RollDie();

            var expectedResult = 4;

            Assert.AreEqual(expectedResult, rollResult);
        }
    }
}
