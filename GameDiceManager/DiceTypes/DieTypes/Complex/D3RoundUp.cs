using DiceTypes.Interfaces;
using System;

namespace DiceTypes.DieTypes.Complex
{
    public class D3RoundUp : BaseDie, IDie
    {
        public D3RoundUp() : base(6)
        {

        }

        public D3RoundUp(ISeedGenerator seedGenerator) : base(6, seedGenerator)
        {
        }

        public string GetDieType()
        {
            return "D3 Round Up (D6 result / 2 rounded up)";
        }

        public string GetRollHistory()
        {
            var rollResult = base.ReportRollValue();

            return $"D6: {rollResult}";
        }

        public override int RollDie()
        {
            var d6Result = base.RollDie();
            var d3Result = d6Result / 2.0;

            var result = Math.Ceiling(d3Result);

            return Convert.ToInt32(result);
        }

        public string GetDieLogicDescription()
        {
            var logicDescription = @"The of the D3 Rounded Up is calculated thusly:
Step 1) Roll a D6
Step 2) Divide the result by 2 and round up
Step 3) The calculated value from step 2 is the final result";

            return logicDescription;
        }
    }
}
