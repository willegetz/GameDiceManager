using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DiceTypeTests.DieTypes.Basic
{
    [TestClass]
    public class D20Tests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var d20 = new D20();
            var dieType = d20.GetDieType();

            var expectedDieType = "D20";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var d20 = new D20();
            var faceNumbers = d20.GetFaceNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns5WhenRolledWithSeed4()
        {
            var seedValue = 4;
            
            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d20 = new D20(mockSeedGenerator.Object);
            var rollResult = d20.RollDie();

            var expectedRollResult = 17;
            Assert.AreEqual(expectedRollResult, rollResult);
        }

        [TestMethod]
        public void ReportsRollResultOf17AfterDieRollResultsIn17()
        {
            var seedValue = 4;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d20 = new D20(mockSeedGenerator.Object);
            var rollResult = d20.RollDie();
            var reportedResult = d20.ReportRollValue();

            var expectedRollResult = 17;
            Assert.AreEqual(expectedRollResult, rollResult);
            Assert.AreEqual(expectedRollResult, reportedResult);
        }

        [TestMethod]
        public void ReportsNoValueIfNotRolled()
        {
            var seedValue = 0;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d20 = new D20(mockSeedGenerator.Object);
            var reportedResult = d20.ReportRollResult();

            var expectedRollResult = "D20: Not Yet Rolled";

            Assert.AreEqual(expectedRollResult, reportedResult);
        }
    }
}
