using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DiceTypeTests.DieTypes.Complex
{
    // From World Builder's Guidebook
    // In orrder to generate a d16, roll a d6 and a d8 simultaneously.
    // If the d6 comes up 1-3, read the d8 without modification.
    // If the d6 comes up 4-6, read the d8 as d8+8.
    // This gernerates a random number between 1 and 16.

    [TestClass]
    public class D16Tests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var d16 = new D16();
            var dieType = d16.GetDieType();

            var expectedDieType = "D16";

            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var d16 = new D16();
            var faceNumbers = d16.GetFaceNumbers();

            var expectedFaceNumbers = @"D8: 1, 2, 3, 4, 5, 6, 7, 8
D6: 1, 2, 3, 4, 5, 6";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void ReturnsDieLogicDescription()
        {
            var d16 = new D16();
            string logicDescription = d16.GetDieLogicDescription();

            var expectedLogicDescription = @"The result of the D16 is calculated thusly:
Step 1) Roll a D8
Step 2) Roll a D6 and consult the result. If the result is 1, 2, or 3 add 0 to the D8 result, otherwise add 8 to the D8 result
Step 3) The calculated total from Step 2 is the final result";

            Assert.AreEqual(expectedLogicDescription, logicDescription);
        }

        [TestMethod]
        public void Returns8WhenRolled()
        {
            var d8Seed = 8;
            var d6Seed = 5;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                             .Returns(d8Seed)
                             .Returns(d6Seed);

            var d16 = new D16(mockSeedGenerator.Object);
            var rollResult = d16.RollDie();

            var expectedRollResult = 8;

            Assert.AreEqual(expectedRollResult, rollResult);
        }

        [TestMethod]
        public void Returns13WhenRolled()
        {
            var d8Seed = 13;
            var d6Seed = 13;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                             .Returns(d8Seed)
                             .Returns(d6Seed);

            var d16 = new D16(mockSeedGenerator.Object);
            var rollResult = d16.RollDie();

            var expectedRollResult = 13;

            Assert.AreEqual(expectedRollResult, rollResult);
        }

        [TestMethod]
        public void ReportDiceRolls()
        {
            var d8Seed = 13;
            var d6Seed = 13;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.SetupSequence(x => x.GetRandomSeed())
                             .Returns(d8Seed)
                             .Returns(d6Seed);

            var d16 = new D16(mockSeedGenerator.Object);
            var rollResult = d16.RollDie();
            var reportedDiceRolls = d16.ReportDiceRolls();

            var expectedRollResult = 13;
            var expectedDiceRollReport = @"D16 Rolls
Decision Die Roll: D6 rolled 4
Value Die Roll: D8 rolled 5";

            Assert.AreEqual(expectedRollResult, rollResult);
            Assert.AreEqual(expectedDiceRollReport, reportedDiceRolls);
        }
    }
}
