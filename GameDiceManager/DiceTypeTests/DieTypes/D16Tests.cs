using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceTypeTests.DieTypes
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
    }
}
