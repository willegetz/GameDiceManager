using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DiceTypeTests.DieTypes
{
    [TestClass]
    public class D3TypeATests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var d3TypeA = new D3TypeA();
            var dieType = d3TypeA.GetDieType();

            var expectedDieType = "D3 Type A (D6 result / 2 rounded up)";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportsItsFaces()
        {
            var d3TypeA = new D3TypeA();
            var faceNumbers = d3TypeA.GetFaceNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4, 5, 6";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }
    }
}
