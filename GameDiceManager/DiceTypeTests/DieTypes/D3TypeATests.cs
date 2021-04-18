using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace DiceTypeTests.DieTypes
{
    [TestClass]
    public class D3TypeATests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var d3TypeA = new D3TypeA(0);
            var dieType = d3TypeA.GetDieType();

            var expectedDieType = "D3 Type A (D6 result / 2 rounded up)";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportsItsFaces()
        {
            var d3TypeA = new D3TypeA(0);
            var faceNumbers = d3TypeA.GetFaceNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4, 5, 6";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns3When5IsRolled()
        {
            var d3TypeA = new D3TypeA(0);
            var result = d3TypeA.RollDie();

            var expectedResult = 3;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Returns2When3IsRolled()
        {
            var d3TypeA = new D3TypeA(5);
            var result = d3TypeA.RollDie();

            var expectedResult = 2;
            Assert.AreEqual(expectedResult, result);
        }
    }
}
