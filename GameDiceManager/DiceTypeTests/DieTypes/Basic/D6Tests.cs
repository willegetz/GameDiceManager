using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DiceTypeTests.DieTypes.Basic
{
    [TestClass]
    public class D6Tests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var d6 = new D6();
            var dieType = d6.GetDieType();

            var expectedDieType = "D6";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var d6 = new D6();
            var faceNumbers = d6.GetFaceNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4, 5, 6";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns5WhenRolled()
        {
            var seedValue = 0;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d6 = new D6(mockSeedGenerator.Object);
            var rollResult = d6.RollDie();

            var expectedRollResult = 5;
            Assert.AreEqual(expectedRollResult, rollResult);
        }

        [TestMethod]
        public void Returns3WhenRolledWithSeed5()
        {
            var seedValue = 5;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d6 = new D6(mockSeedGenerator.Object);
            var rollResult = d6.RollDie();

            var expectedRollResult = 3;
            Assert.AreEqual(expectedRollResult, rollResult);
        }

        [TestMethod]
        public void Returns4WhenRolledWithSeed13()
        {
            var seedValue = 13;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d6 = new D6(mockSeedGenerator.Object);
            var rollResult = d6.RollDie();

            var expectedRollResult = 4;
            Assert.AreEqual(expectedRollResult, rollResult);
        }
    }
}
