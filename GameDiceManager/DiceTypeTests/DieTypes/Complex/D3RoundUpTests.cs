using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceTypeTests.DieTypes.Complex
{
    [TestClass]
    public class D3RoundUpTests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var d3TypeA = new D3RoundUp();
            var dieType = d3TypeA.GetDieType();

            var expectedDieType = "D3 Round Up (D6 result / 2 rounded up)";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportsItsFaces()
        {
            var d3TypeA = new D3RoundUp();
            var faceNumbers = d3TypeA.GetFaceNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4, 5, 6";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns2WhenRolled()
        {
            var randomSeed = 5;

            var d3 = new D3RoundUp(randomSeed);
            var rollResult = d3.RollDie();
            

            var expectedRollResult = 2;

            Assert.AreEqual(expectedRollResult, rollResult);
        }
    }
}
