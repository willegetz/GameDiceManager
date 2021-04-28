using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DiceTypeTests.DieTypes
{
    [TestClass]
    public class D4Tests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var d6 = new D4();
            var dieType = d6.GetDieType();

            var expectedDieType = "D4";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var d6 = new D4();
            var faceNumbers = d6.GetFaceNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }
    }
}
