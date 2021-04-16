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
    }
}
