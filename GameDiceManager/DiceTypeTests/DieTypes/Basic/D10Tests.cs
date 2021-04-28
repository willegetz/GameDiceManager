﻿using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DiceTypeTests.DieTypes.Basic
{
    [TestClass]
    public class D10Tests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var d10 = new D10();
            var dieType = d10.GetDieType();

            var expectedDieType = "D10";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var d10 = new D10();
            string faceNumbers = d10.GetFaceNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void MakeOnesDieReportsItsNewFaceNumbers()
        {
            var d10 = new D10();
            d10.MakeOnesDie();

            var faceNumbers = d10.GetFaceNumbers();

            var expectedFaceNumbers = "0, 1, 2, 3, 4, 5, 6, 7, 8, 9";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns9WhenRolled()
        {
            var seedValue = 4;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d10 = new D10(mockSeedGenerator.Object);
            var rollResult = d10.RollDie();

            var expectedRollResult = 9;

            Assert.AreEqual(expectedRollResult, rollResult);
        }
    }
}
