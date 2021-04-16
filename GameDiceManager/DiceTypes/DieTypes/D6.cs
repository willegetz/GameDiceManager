using System;

namespace DiceTypes.DieTypes
{
    public class D6
    {
        private readonly Die _d6;
        public D6(int randomSeed)
        {
            _d6 = new Die(6, randomSeed);
        }

        public string GetDieType()
        {
            return "D6";
        }

        public string GetFaceNumbers()
        {
            return _d6.ListFaceNumbers();
        }
    }
}
