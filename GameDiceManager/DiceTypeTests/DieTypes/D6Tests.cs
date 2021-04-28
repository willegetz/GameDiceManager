using DiceTypes.DieTypes;
using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DiceTypeTests.DieTypes
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
            var randomSeed = 0;

            var d6 = new D6(randomSeed);
            var rollResult = d6.RollDie();

            var expectedRollResult = 5;
            Assert.AreEqual(expectedRollResult, rollResult);
        }

        [TestMethod]
        [Ignore("This is an exploration of mocking")]
        public void Spike_MockDieRollResult()
        {
            var dieMock = new Mock<IDie>();
            dieMock.Setup(x => x.RollDie()).Returns(7);

            var d6 = new D6();
            var result = d6.RollDie();

            Assert.AreEqual(2, result);
        }
    }
}
