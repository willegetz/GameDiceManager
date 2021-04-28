using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes.Basic
{
    public class D4 : BaseDie, IDie
    {
        public D4() : base(4)
        {

        }

        public D4(int randomSeed) : base(4, randomSeed)
        {

        }

        public D4(ISeedGenerator seedGenerator) : base(4, seedGenerator)
        {

        }

        public string GetDieType()
        {
            return "D4";
        }
    }
}
