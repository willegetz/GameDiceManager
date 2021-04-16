using System;
using System.Linq;

namespace DiceTypes
{
    public class Die
    {
        private int numberOfFaces;

        public Die(int numberOfFaces)
        {
            this.numberOfFaces = numberOfFaces;
        }

        public string ListNumbers()
        {
            var numbersOnDie = Enumerable.Range(1, numberOfFaces);
            return string.Join(", ", numbersOnDie);
        }

        public object RollDie()
        {
            return 4;
        }
    }
}
