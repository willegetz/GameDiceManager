using System;

namespace DiceTypes.DieTypes
{
    public class D3TypeA
    {
        private Die _d6;

        public D3TypeA()
        {
            _d6 = new Die(6, 0);
        }
        public string GetDieType()
        {
            return "D3 Type A (D6 result / 2 rounded up)";
        }

        public string GetFaceNumbers()
        {
            return _d6.ListFaceNumbers();
        }

        public int RollDie()
        {
            return 3;
        }
    }
}
