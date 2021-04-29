using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DiceTypeTests.DieTypes.Complex
{
    [TestClass]
    public class Percentile0and0DiceTests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var percentile = new PercentileDice0and0();
            var dieType = percentile.GetDieType();

            var expectedDieType = "Percentile (2D10 with face range 0 to 9 each)";

            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var percentile = new PercentileDice0and0();
            var faceNumbers = percentile.GetFaceNumbers();

            var expectedFaceNumbers = @"Tens Die: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
Ones Die: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9";

            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns90WhenRolled()
        {
            var tensSeed = 8;
            var onesSeed = 14;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                             .Returns(tensSeed)
                             .Returns(onesSeed);

            var percentile = new PercentileDice0and0(mockSeedGenerator.Object);
            var rollResult = percentile.RollDie();

            var expectedRollResult = 90;

            Assert.AreEqual(expectedRollResult, rollResult);
        }
    }
}
