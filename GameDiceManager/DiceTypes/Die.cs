using System;
using System.Linq;

namespace DiceTypes
{
    public class Die
    {
        private int numberOfFaces;
        private int randomSeed;
        private int ExcludedUpperBound { get { return numberOfFaces + 1; } }

        public Die(int numberOfFaces, int randomSeed)
        {
            this.numberOfFaces = numberOfFaces;
            this.randomSeed = randomSeed;
        }

        public string ListNumbers()
        {
            var numbersOnDie = Enumerable.Range(1, numberOfFaces);
            return string.Join(", ", numbersOnDie);
        }

        public int RollDie()
        {
            var randomizer = new Random(randomSeed);
            var result = randomizer.Next(1, ExcludedUpperBound);

            return result;
        }
    }
}
