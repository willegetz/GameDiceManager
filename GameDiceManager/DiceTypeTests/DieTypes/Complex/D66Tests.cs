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
        public void ReturnsDieLogicDescription()
        {
            var d66 = new D66();
            var logicDescription = d66.GetDieLogicDescription();

            var expectedLogicDescription = @"The result of the D66 is calculated thusly:
Step 1) Roll a D6 and use the result for the tens value
Step 2) Roll a D6 and use the result for the ones value
Step 3) The combined values are the final result";

            Assert.AreEqual(expectedLogicDescription, logicDescription);
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

        [TestMethod]
        public void ReportDiceRolls()
        {
            var tensSeed = 13;
            var onesSeed = 1;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                             .Returns(tensSeed)
                             .Returns(onesSeed);

            var d66 = new D66(mockSeedGenerator.Object);
            var rollResult = d66.RollDie();
            var reportedDiceRolls = d66.ReportDiceRolls();

            var expectedRollResult = 42;
            var expectedDiceRollReport = @"D66 (2D6) Rolls
Tens Die Roll: D6 rolled 4
Ones Die Roll: D6 rolled 2";

            Assert.AreEqual(expectedRollResult, rollResult);
            Assert.AreEqual(expectedDiceRollReport, reportedDiceRolls);
        }
    }
}
