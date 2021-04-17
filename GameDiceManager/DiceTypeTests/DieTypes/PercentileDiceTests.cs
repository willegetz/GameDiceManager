using DiceTypes.DieTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DiceTypeTests.DieTypes
{
    [TestClass]
    public class PercentileDiceTests
    {
        // The percentile dice are two D10s
        //  The faces on the first D10 (the tens) number 1 to 10
        //  The faces on the second D10 (the ones) number 0 to 9
        // The percentage result is the concatination of the first and second D10 and
        //  not a random number between 1 and 100.
        // The face numbers are reported as above explicitly stating which die each set
        //  belongs to

        // To make testing easier for the time being, two random seeds will be used in order
        //  to ensure the appropriate roll results.

        [TestMethod]
        public void ReportsItsType()
        {
            var percentile = new PercentileDice();
            string dieType = percentile.GetDieType();

            var expectedDieType = "Percentile (2D10)";

            Assert.AreEqual(expectedDieType, dieType);
        }
    }
}
