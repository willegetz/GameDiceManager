using System;

namespace DiceTypes.DieTypes
{
    public class D3TypeA
    {
        public string GetDieType()
        {
            return "D3 Type A (D6 result / 2 rounded up)";
        }

        public string GetFaceNumbers()
        {
            return "1, 2, 3, 4, 5, 6";
        }

        public int RollDie()
        {
            return 3;
        }
    }
}
