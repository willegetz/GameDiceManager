using System;
using System.Linq;

namespace DiceTypes
{
    public class Die
    {
        private int numberOfFaces;
        private int randomSeed;

        private int _rangeShiftValue = 0;
        private int ExclusiveUpperBound { get { return (numberOfFaces + 1) + _rangeShiftValue; } }
        private int InclusiveLowerBound { get { return 1 + _rangeShiftValue; } }

        public Die(int numberOfFaces, int randomSeed)
        {
            this.numberOfFaces = numberOfFaces;
            this.randomSeed = randomSeed;
        }

        public string ListFaceNumbers()
        {
            var numbersOnDie = Enumerable.Range(InclusiveLowerBound, numberOfFaces);
            return string.Join(", ", numbersOnDie);
        }

        public int RollDie()
        {
            var randomizer = new Random(randomSeed);
            var result = randomizer.Next(InclusiveLowerBound, ExclusiveUpperBound);

            return result;
        }

        public void ShiftRange(int rangeShiftValue)
        {
            _rangeShiftValue = rangeShiftValue;
        }
    }
}
