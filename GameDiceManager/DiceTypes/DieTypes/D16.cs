using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceTypes.DieTypes
{
    public class D16
    {
        private Die _d8;
        private Die _d6;

        public D16(int d8RandomSeed, int d6RandomSeed)
        {
            _d8 = new Die(8, d8RandomSeed);
            _d6 = new Die(6, d6RandomSeed);
        }

        public string GetDieType()
        {
            return "D16";
        }

        public string GetFaceNumbers()
        {
            return $@"D8: {_d8.ListFaceNumbers()}
D6: {_d6.ListFaceNumbers()}";
        }

        public int RollDie()
        {
            var d8Result = _d8.RollDie();
            var d6Result = _d6.RollDie();

            int d16Result;

            if (d6Result >= 3)
            {
                d16Result = d8Result;
            }
            else
            {
                d16Result = d8Result + 8;
            }

            return d16Result;
        }
    }
}
