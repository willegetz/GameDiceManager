using System;
using System.Linq;

namespace DiceTypes
{
    public class BaseDie
    {
        // The base die should be in charge of its own seeding

        private int numberOfFaces;

        private int _randomSeed;

        private int _rangeShiftValue = 0;
        private int ExclusiveUpperBound { get { return (numberOfFaces + 1) + _rangeShiftValue; } }
        private int InclusiveLowerBound { get { return 1 + _rangeShiftValue; } }

        public BaseDie(int numberOfFaces)
        {
            this.numberOfFaces = numberOfFaces;
            _randomSeed = Guid.NewGuid().GetHashCode();
        }

        public BaseDie(int numberOfFaces, int randomSeed)
        {
            this.numberOfFaces = numberOfFaces;
            _randomSeed = randomSeed;
        }

        public string GetFaceNumbers()
        {
            var numbersOnDie = Enumerable.Range(InclusiveLowerBound, numberOfFaces);
            return string.Join(", ", numbersOnDie);
        }

        public int RollDie()
        {
            var randomizer = new Random(_randomSeed);
            var result = randomizer.Next(InclusiveLowerBound, ExclusiveUpperBound);

            return result;
        }

        public void ShiftRange(int rangeShiftValue)
        {
            _rangeShiftValue = rangeShiftValue;
        }
    }
}
