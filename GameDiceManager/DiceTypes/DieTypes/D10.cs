using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes
{
    public class D10 : BaseDie
    {
        private readonly BaseDie _d10;

        public D10() : base(10)
        {

        }

        public D10(int randomSeed) : base(10)
        {
            _d10 = new BaseDie(10);
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
