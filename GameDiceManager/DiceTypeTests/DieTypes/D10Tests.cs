using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceTypeTests.DieTypes
{
    [TestClass]
    public class D10Tests
    {
        [TestMethod]
        public void ReportsItsType()
        {
            var d10 = new D10(0);
            var dieType = d10.GetDieType();

            var expectedDieType = "D10";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var d10 = new D10(0);
            string faceNumbers = d10.GetFaceNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }

        [TestMethod]
        public void Returns9WhenRolled()
        {
            var randomSeed = 4;

            var d10 = new D10(randomSeed);
            int rollResult = d10.RollDie();

            var expectedResult = 9;

            Assert.AreEqual(expectedResult, rollResult);
        }
    }
}
