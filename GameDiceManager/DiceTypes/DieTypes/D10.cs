using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes
{
    public class D10 : BaseDie, IDie
    {

        public D10() : base(10)
        {

        }

        public D10(int randomSeed) : base(10, randomSeed)
        {

        }

        public string GetDieType()
        {
            return "D10";
        }

        public void MakeOnesDie()
        {
            var rangeShiftValue = -1;
            base.ShiftRange(rangeShiftValue);
        }
    }
}
