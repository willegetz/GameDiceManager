using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceTypeTests.DieTypes
{
    [TestClass]
    public class D12Tests
    {
        [TestMethod]
        public void ReportItsType()
        {
            var d12 = new D12();
            var dieType = d12.GetDieType();

            var expectedDieType = "D12";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var d12 = new D12();
            var faceNumbers = d12.GetFaceNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns11WhenRolled()
        {
            var randomSeed = 6;

            var d12 = new D12(randomSeed);
            var rollResult = d12.RollDie();

            var expectedRollResult = 11;

            Assert.AreEqual(expectedRollResult, rollResult);
        }
    }
}
