using DiceTypes;
using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DiceTypeTests
{
    [TestClass]
    public class BaseDieTests
    {
        [TestMethod]
        public void D6_ListsItsNumbers()
        {
            var numberOfFaces = 6;

            var d6 = new BaseDie(numberOfFaces);
            var numbersOnD6 = d6.GetFaceNumbers();

            var expectedNumbers = "1, 2, 3, 4, 5, 6";

            Assert.AreEqual(expectedNumbers, numbersOnD6);
        }

        [TestMethod]
        public void D8_ListsItsNumbers()
        {
            var numberOfFaces = 8;

            var d8 = new BaseDie(numberOfFaces);
            var numbersOnD8 = d8.GetFaceNumbers();

            var expectedNumbersOnD8 = "1, 2, 3, 4, 5, 6, 7, 8";

            Assert.AreEqual(expectedNumbersOnD8, numbersOnD8);
        }

        [TestMethod]
        public void D12_ListsItsNumbers()
        {
            var numberOfFaces = 12;

            var d12 = new BaseDie(numberOfFaces);
            var numbersOnD12 = d12.GetFaceNumbers();

            var expectedNumbersOnD12 = "1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12";

            Assert.AreEqual(expectedNumbersOnD12, numbersOnD12);
        }

        [TestMethod]
        public void D6_ShiftsRangeUpByOneWhenRangeShiftValueIs1()
        {
            var numberOfFaces = 6;
            var rangeShiftValue = 1;

            var shiftedD6 = new BaseDie(numberOfFaces);
            shiftedD6.ShiftRange(rangeShiftValue);

            var numbersOnShiftedD6 = shiftedD6.GetFaceNumbers();

            var expectedNumbersOnShiftedD6 = "2, 3, 4, 5, 6, 7";

            Assert.AreEqual(expectedNumbersOnShiftedD6, numbersOnShiftedD6);
        }

        [TestMethod]
        public void D6_ShiftsRangeDownByOneWhenRangeShiftValueIsNegative1()
        {
            var numberOfFaces = 6;
            var rangeShiftValue = -1;

            var shiftedD6 = new BaseDie(numberOfFaces);
            shiftedD6.ShiftRange(rangeShiftValue);

            var numbersOnShiftedD6 = shiftedD6.GetFaceNumbers();

            var expectedNumbersOnShiftedD6 = "0, 1, 2, 3, 4, 5";

            Assert.AreEqual(expectedNumbersOnShiftedD6, numbersOnShiftedD6);
        }

        [TestMethod]
        public void D6_Returns4WhenRolled()
        {
            var numberOfFaces = 6;
            var seedValue = 13;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d6 = new BaseDie(numberOfFaces, mockSeedGenerator.Object);
            var rollResult = d6.RollDie();

            var expectedResult = 4;

            Assert.AreEqual(expectedResult, rollResult);
        }

        [TestMethod]
        public void D8_Returns7WhenRolled()
        {
            var numberOfFaces = 8;
            var seedValue = 6;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d8 = new BaseDie(numberOfFaces, mockSeedGenerator.Object);
            var rollResult = d8.RollDie();

            var expectedResult = 7;

            Assert.AreEqual(expectedResult, rollResult);
        }

        [TestMethod]
        public void D12_Returns11WhenRolled()
        {
            var numberOfFaces = 12;
            var seedValue = 6;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d12 = new BaseDie(numberOfFaces, mockSeedGenerator.Object);
            var rollResult = d12.RollDie();

            var expectedResult = 11;

            Assert.AreEqual(expectedResult, rollResult);
        }

        [TestMethod]
        public void D20_Returns13WhenRolled()
        {
            var numberOfFaces = 20;
            var seedValue = 17;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);


            var d20 = new BaseDie(numberOfFaces, mockSeedGenerator.Object);
            var rollResult = d20.RollDie();

            var expectedRollResult = 13;

            Assert.AreEqual(expectedRollResult, rollResult);
        }

        [TestMethod]
        public void D6_ReportsValueRolledWhenAsked()
        {
            var numberOfFaces = 6;
            var seedValue = 13;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed()).Returns(seedValue);

            var d6 = new BaseDie(numberOfFaces, mockSeedGenerator.Object);
            var rollResult = d6.RollDie();
            var reportedResult = d6.ReportRollValue();

            var expectedResult = 4;

            Assert.AreEqual(expectedResult, rollResult);
            Assert.AreEqual(expectedResult, reportedResult);
        }
    }
}
