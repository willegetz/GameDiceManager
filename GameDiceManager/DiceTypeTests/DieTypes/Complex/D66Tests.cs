using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DiceTypeTests.DieTypes.Complex
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
        public void Returns42WhenRolled()
        {
            var tensSeed = 13;
            var onesSeed = 1;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                             .Returns(tensSeed)
                             .Returns(onesSeed);

            var d66 = new D66(mockSeedGenerator.Object);
            var rollResult = d66.RollDie();

            var expectedRollResult = 42;

            Assert.AreEqual(expectedRollResult, rollResult);
        }
    }
}
