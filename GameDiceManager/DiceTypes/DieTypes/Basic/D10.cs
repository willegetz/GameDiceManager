using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes.Basic
{
    public class D10 : BaseDie, IDie
    {

        public D10() : base(10)
        {

        }

        public D10(ISeedGenerator seedGenerator) : base(10, seedGenerator)
        {
        }

        public string GetDieType()
        {
            return "D10";
        }

        public void MakeOnesDie()
        {
            var rangeShiftValue = -1;
            ShiftRange(rangeShiftValue);
        }

        public string ReportRollResult()
        {
            var result = base.ReportRollValue();

            return result != null ? result.ToString() : $"{GetDieType()}: Not Yet Rolled";
        }
    }
}
