using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceTypeTests.DieTypes
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
        public void Returns3WhenRolled()
        {
            var randomSeed = 0;

            var d4 = new D4(randomSeed);
            var rollResult = d4.RollDie();

            var expectedRollResult = 3;
            Assert.AreEqual(expectedRollResult, rollResult);
        }
    }
}
