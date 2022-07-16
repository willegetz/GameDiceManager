using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes.Basic
{
    public class D20 : BaseDie, IDie
    {
        public D20() : base(20)
        {
        }

        public D20(ISeedGenerator seedGenerator) : base(20, seedGenerator)
        {

        }

        public string GetDieType()
        {
            return "D20";
        }

        public string ReportRollResult()
        {
            var result = base.ReportRollValue();

            return result != null ? result.ToString() : $"{GetDieType()}: Not Yet Rolled";
        }
    }
}
