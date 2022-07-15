using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DiceTypeTests.DieTypes.Basic
{
    [TestClass]
    public class D4Tests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var d4 = new D4();
            var dieType = d4.GetDieType();

            var expectedDieType = "D4";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var d4 = new D4();
            var faceNumbers = d4.GetFaceNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns3WhenRolledWithSeed0()
        {
            var seedValue = 0;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d4 = new D4(mockSeedGenerator.Object);
            var rollResult = d4.RollDie();

            var expectedRollResult = 3;
            Assert.AreEqual(expectedRollResult, rollResult);
        }

        [TestMethod]
        public void ReportsRollResultOf3AfterDieRollResultsIn3()
        {
            var seedValue = 0;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d4 = new D4(mockSeedGenerator.Object);
            var rollResult = d4.RollDie();
            var reportedResult = d4.ReportRollValue();

            var expectedRollResult = 3;
            Assert.AreEqual(expectedRollResult, rollResult);
            Assert.AreEqual(expectedRollResult, reportedResult);
        }

        [TestMethod]
        public void ReportsNoValueIfNotRolled()
        {
            var seedValue = 0;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d4 = new D4(mockSeedGenerator.Object);
            var reportedResult = d4.ReportRollResult();

            var expectedRollResult = "D4: Not Yet Rolled";
            
            Assert.AreEqual(expectedRollResult, reportedResult);
        }
    }
}
