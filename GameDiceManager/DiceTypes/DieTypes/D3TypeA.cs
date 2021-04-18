using System;

namespace DiceTypes.DieTypes
{
    public class D3TypeA
    {
        public string GetDieType()
        {
            return "D3 Type A (D6 result / 2 rounded up)";
        }

        public static object GetFaceNumbers()
        {
            return "1, 2, 3, 4, 5, 6";
        }
    }
}
