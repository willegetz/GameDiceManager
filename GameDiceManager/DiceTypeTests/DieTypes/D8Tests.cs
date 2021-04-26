using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceTypeTests.DieTypes
{
    [TestClass]
    public class D8Tests
    {
        [TestMethod]
        public void ReportItsType()
        {
            var d8 = new D8(0);
            var dieType = d8.GetDieType();

            var expectedDieType = "D8";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void ReportItsFaceNumbers()
        {
            var d8 = new D8(0);
            var faceNumbers = d8.GetFaceNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4, 5, 6, 7, 8";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }
    }
}
