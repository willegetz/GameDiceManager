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

        public D16(int randomSeed)
        {
            _d8 = new Die(8, randomSeed);
            _d6 = new Die(6, randomSeed);
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
            return d8Result;
        }
    }
}
