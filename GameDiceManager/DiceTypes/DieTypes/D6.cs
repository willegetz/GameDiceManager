using System;

namespace DiceTypes.DieTypes
{
    public class D6 : Die
    {
        public D6(int randomSeed) : base(6, randomSeed)
        {

        }

        public string GetDieType()
        {
            return "D6";
        }

        public string GetFaceNumbers()
        {
            return base.ListNumbers();
        }
    }
}
