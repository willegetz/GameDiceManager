using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DiceTypeTests.DieTypes
{
    [TestClass]
    public class D66Tests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var d66 = new D66();
            var dieType = d66.GetDieType();

            var expectedDieType = "D66 (2D6)";

            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var d66 = new D66();
            var faceNumbers = d66.GetFaceNumbers();

            var expectedFaceNumbers = @"Tens Die: 1, 2, 3, 4, 5, 6
Ones Die: 1, 2, 3, 4, 5, 6";

            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns61WhenRolled()
        {
            var d66 = new D66();
            var result = d66.RollDie();

            var expectedResult = 61;
            Assert.AreEqual(expectedResult, result);
        }
    }
}
