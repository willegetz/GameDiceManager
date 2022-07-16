using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes.Basic
{
    public class D12 : BaseDie, IDie
    {
        public D12() : base(12)
        {

        }

        public D12(ISeedGenerator seedGenerator) : base(12, seedGenerator)
        {

        }

        public string GetDieType()
        {
            return "D12";
        }

        public string ReportRollResult()
        {
            var result = base.ReportRollValue();

            return result != null ? result.ToString() : $"{GetDieType()}: Not Yet Rolled";
        }
    }
}
