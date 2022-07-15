using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes.Basic
{
    public class D6 : BaseDie, IDie
    {
        public D6() : base(6)
        {
        }


        public D6(ISeedGenerator seedGenerator) : base(6, seedGenerator)
        {

        }

        public string GetDieType()
        {
            return "D6";
        }

        public string ReportRollResult()
        {
            var result = base.ReportRollValue();

            return result != null ? result.ToString() : $"{GetDieType()}: Not Yet Rolled";
        }
    }
}
