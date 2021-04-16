using DiceTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiceTypeTests
{
    [TestClass]
    public class DieTests
    {
        [TestMethod]
        public void D6_ListsItsNumbers()
        {
            // A six sided die contains numbers from 1 to 6
            // A person can pick up the die and see all the numbers
            //  by rotating it in their hand

            // Assume the die can contain any number of faces.
            // When creating the die we need to specify the number of faces akin to when
            //  we look for a specific die.

            var numberOfFaces = 6;

            var d6 = new Die(numberOfFaces);
            var numbersOnD6 = d6.ListNumbers();

            var expectedNumbers = "1, 2, 3, 4, 5, 6";

            Assert.AreEqual(expectedNumbers, numbersOnD6);
        }

        [TestMethod]
        public void D8_ListsItsNumbers()
        {
            var numberOfFaces = 8;

            var d8 = new Die(numberOfFaces);
            var numbersOnD8 = d8.ListNumbers();

            var expectedNumbersOnD8 = "1, 2, 3, 4, 5, 6, 7, 8";

            Assert.AreEqual(expectedNumbersOnD8, numbersOnD8);
        }

        [TestMethod]
        public void D12_ListsItsNumbers()
        {
            var numberOfFaces = 12;

            var d12 = new Die(numberOfFaces);
            var numbersOnD12 = d12.ListNumbers();

            var expectedNumbersOnD12 = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12";

            Assert.AreEqual(expectedNumbersOnD12, numbersOnD12);
        }

        [TestMethod]
        public void D6_Returns4WhenRolled()
        {
            var numberOfFaces = 6;

            var d6 = new Die(numberOfFaces);
            var rollResult = d6.RollDie();

            var expectedResult = 4;

            Assert.AreEqual(expectedResult, rollResult);
        }
    }
}
