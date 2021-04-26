using System;
using System.Linq;

namespace DiceTypes
{
    public class BaseDie
    {
        // The base die should be in charge of its own seeding

        private int numberOfFaces;

        public int RandomSeed { get; set; }

        private int _rangeShiftValue = 0;
        private int ExclusiveUpperBound { get { return (numberOfFaces + 1) + _rangeShiftValue; } }
        private int InclusiveLowerBound { get { return 1 + _rangeShiftValue; } }

        public BaseDie(int numberOfFaces)
        {
            this.numberOfFaces = numberOfFaces;
            RandomSeed = Guid.NewGuid().GetHashCode();
        }

        public string ListFaceNumbers()
        {
            var numbersOnDie = Enumerable.Range(InclusiveLowerBound, numberOfFaces);
            return string.Join(", ", numbersOnDie);
        }

        public int RollDie()
        {
            var randomizer = new Random(RandomSeed);
            var result = randomizer.Next(InclusiveLowerBound, ExclusiveUpperBound);

            return result;
        }

        public void ShiftRange(int rangeShiftValue)
        {
            _rangeShiftValue = rangeShiftValue;
        }
    }
}
