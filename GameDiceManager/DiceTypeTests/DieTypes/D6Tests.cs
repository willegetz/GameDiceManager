using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DiceTypeTests.DieTypes
{
    [TestClass]
    public class D6Tests
    {
        // x The D6 type can tell you it is a D6.
        // The D6 has all the functionality of a die with the same number of faces
        // The D6 is random when it is "picked up"
        // Can the D6 inform us on other things?

        [TestMethod]
        public void D6ReportsItsType()
        {
            var d6 = new D6(13);
            var dieType = d6.GetDieType();

            var expectedDieType = "D6";
            Assert.AreEqual(expectedDieType, dieType);
        }

        [TestMethod]
        public void D6ReportItsFaceNumbers()
        {
            var d6 = new D6(13);
            var faceNumbers = d6.ListNumbers();

            var expectedFaceNumbers = "1, 2, 3, 4, 5, 6";
            Assert.AreEqual(expectedFaceNumbers, faceNumbers);
        }
    }
}
