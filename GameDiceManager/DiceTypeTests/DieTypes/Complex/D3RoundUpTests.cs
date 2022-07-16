using DiceTypes.DieTypes.Complex;
using DiceTypes.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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
        public void ReturnsDieLogicDescription()
        {
            var d3TypeA = new D3RoundUp();
            var logicDescription = d3TypeA.GetDieLogicDescription();

            var expectedLogicDescription = @"The of the D3 Rounded Up is calculated thusly:
Step 1) Roll a D6
Step 2) Divide the result by 2 and round up
Step 3) The calculated value from step 2 is the final result";

            Assert.AreEqual(expectedLogicDescription, logicDescription);
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
        public void Returns2WhenRolledWithSeed5()
        {
            var randomSeed = 5;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed())
                             .Returns(randomSeed);

            var d3 = new D3RoundUp(mockSeedGenerator.Object);
            var rollResult = d3.RollDie();

            var expectedRollResult = 2;

            Assert.AreEqual(expectedRollResult, rollResult);
        }

        [TestMethod]
        public void D6ResultIs3BeforeCalculatingResultOf2()
        {
            var randomSeed = 5;

            var mockSeedGenerator = new Mock<ISeedGenerator>();
            mockSeedGenerator.Setup(x => x.GetRandomSeed())
                             .Returns(randomSeed);

            var d3 = new D3RoundUp(mockSeedGenerator.Object);
            var rollResult = d3.RollDie();
            var dieRollHistory = d3.GetRollHistory();

            var expectedRollResult = 2;
            var expectedDieRollHistory = "D6: 3";

            Assert.AreEqual(expectedRollResult, rollResult);
            Assert.AreEqual(expectedDieRollHistory, dieRollHistory);
        }
    }
}
