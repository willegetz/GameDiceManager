using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceTypeTests.DieTypes
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
        public void Returns5WhenRolled()
        {
            var randomSeed = 4;

            var d20 = new D20(randomSeed);
            var rollResult = d20.RollDie();

            var expectedRollResult = 17;
            Assert.AreEqual(expectedRollResult, rollResult);
        }
    }
}
