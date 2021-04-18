using System;

namespace DiceTypes.DieTypes
{
    public class D66
    {
        public string GetDieType()
        {
            return "D66 (2D6)";
        }

        public string GetFaceNumbers()
        {
            return @"Tens Die: 1, 2, 3, 4, 5, 6
Ones Die: 1, 2, 3, 4, 5, 6";
        }
    }
}
