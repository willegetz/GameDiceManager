using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes
{
    public class D4 : BaseDie, IDie
    {
        public D4(): base(4)
        {

        }

        public D4(int randomSeed): base(4, randomSeed)
        {

        }

        public string GetDieType()
        {
            return "D4";
        }
    }
}
