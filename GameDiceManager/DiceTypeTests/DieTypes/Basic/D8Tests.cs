﻿using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DiceTypeTests.DieTypes.Basic
{
    [TestClass]
    public class D8Tests
    {
        [TestMethod]
        public void ReportItsType()
        {
            var d8 = new D8();
            var dieType = d8.GetDieType();

            var expectedDieType = "D8";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var d8 = new D8();
            var faceNumbers = d8.GetFaceNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4, 5, 6, 7, 8";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns7WhenRolled()
        {
            var seedValue = 2;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d8 = new D8(mockSeedGenerator.Object);
            var rollResult = d8.RollDie();
            
            var expectedRollResult = 7;
            Assert.AreEqual(expectedRollResult, rollResult);
        }
    }
}
