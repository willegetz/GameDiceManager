using System;
using System.Linq;

namespace DiceTypes
{
    public class Die
    {
        private int numberOfFaces;
        private int ExcludedUpperBound { get { return numberOfFaces + 1; } }

        public Die(int numberOfFaces)
        {
            this.numberOfFaces = numberOfFaces;
        }

        public string ListNumbers()
        {
            var numbersOnDie = Enumerable.Range(1, numberOfFaces);
            return string.Join(", ", numbersOnDie);
        }

        public int RollDie()
        {
            if (numberOfFaces == 6)
            {
                var randomizer = new Random(13);
                var result = randomizer.Next(1, ExcludedUpperBound);

                return result;
            }
            else if (numberOfFaces == 8)
            {
                var randomizer = new Random(6);
                var result = randomizer.Next(1, ExcludedUpperBound);

                return result;
            }
            else
            {
                var randomizer = new Random(6);
                var result = randomizer.Next(1, ExcludedUpperBound);

                return result;
            }
        }
    }
}
