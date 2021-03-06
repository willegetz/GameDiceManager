using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes.Basic
{
    public class D8 : BaseDie, IDie
    {
        public D8() : base(8)
        {

        }

        public D8(ISeedGenerator seedGenerator) : base(8, seedGenerator)
        {

        }

        public string GetDieType()
        {
            return "D8";
        }

        public string ReportRollResult()
        {
            var result = base.ReportRollValue();

            return result != null ? result.ToString() : $"{GetDieType()}: Not Yet Rolled";
        }
    }
}
