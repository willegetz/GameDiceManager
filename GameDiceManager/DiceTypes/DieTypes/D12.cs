using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes
{
    public class D12 : BaseDie, IDie
    {
        public D12() : base(12)
        {

        }

        public D12(int randomSeed): base(12, randomSeed)
        {

        }

        public string GetDieType()
        {
            return "D12";
        }
    }
}
