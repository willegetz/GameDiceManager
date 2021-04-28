using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes.Complex
{
    public class D16 : IDie
    {
        private D8 _d8;
        private D6 _d6;

        public D16()
        {
            _d8 = new D8();
            _d6 = new D6();
        }

        public D16(int d8RandomSeed, int d6RandomSeed)
        {
            _d8 = new D8(d8RandomSeed);
            _d6 = new D6(d6RandomSeed);
        }

        public D16(ISeedGenerator seedGenerator)
        {
            _d8 = new D8(seedGenerator);
            _d6 = new D6(seedGenerator);
        }

        public string GetDieType()
        {
            return "D16";
        }

        public string GetFaceNumbers()
        {
            return $@"D8: {_d8.GetFaceNumbers()}
D6: {_d6.GetFaceNumbers()}";
        }

        public int RollDie()
        {
            var d8Result = _d8.RollDie();
            var d6Result = _d6.RollDie();

            int d16Result;

            if (d6Result <= 3)
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
