using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes.Basic
{
    public class D8 : BaseDie, IDie
    {
        public D8() : base(8)
        {

        }

        public D8(int randomSeed) : base(8, randomSeed)
        {

        }

        public string GetDieType()
        {
            return "D8";
        }
    }
}
