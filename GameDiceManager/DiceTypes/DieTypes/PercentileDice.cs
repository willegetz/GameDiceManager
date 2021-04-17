using System;

namespace DiceTypes.DieTypes
{
    public class PercentileDice
    {
        public string GetDieType()
        {
            return "Percentile (2D10)";
        }

        public string GetFaceNumbers()
        {
            return @"Tens Die: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
Ones Die: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9";
        }
    }
}
