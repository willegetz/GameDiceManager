using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes.Basic
{
    public class D20 : BaseDie, IDie
    {
        public D20() : base(20)
        {
        }

        public D20(int randomSeed) : base(20, randomSeed)
        {
        }

        public string GetDieType()
        {
            return "D20";
        }
    }
}
