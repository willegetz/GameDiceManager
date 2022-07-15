using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes.Basic
{
    public class D4 : BaseDie, IDie
    {
        public D4() : base(4)
        {

        }

        public D4(ISeedGenerator seedGenerator) : base(4, seedGenerator)
        {

        }

        public string GetDieType()
        {
            return "D4";
        }

        public string ReportRollResult()
        {
            var result = base.ReportRollValue();

            return result != null ? result.ToString() : "D4: Not Yet Rolled";
        }
    }
}
