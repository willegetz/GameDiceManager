using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceTypes.DieTypes
{
    public class D16
    {
        public D16(int randomSeed)
        {

        }

        public string GetDieType()
        {
            return "D16";
        }

        public string GetFaceNumbers()
        {
            return @"D8: 1, 2, 3, 4, 5, 6, 7, 9
D6: 1, 2, 3, 4, 5, 6";
        }

        public int RollDie()
        {
            return 4;
        }
    }
}
