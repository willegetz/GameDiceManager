using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes
{
    public class D6: BaseDie
    {
        public D6() : base(6)
        {
        }

        public D6(int randomSeed) : base(6, randomSeed)
        {

        }

        public string GetDieType()
        {
            return "D6";
        }
    }
}
