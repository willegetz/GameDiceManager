using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes.Complex
{
    public class D16 : IDie
    {
        private D8 _d8;
        private D6 _d6;

        public D16()
        {
            _d8 = new D8();
            _d6 = new D6();
        }

        public D16(ISeedGenerator seedGenerator)
        {
            _d8 = new D8(seedGenerator);
            _d6 = new D6(seedGenerator);
        }

        public string GetDieType()
        {
            return "D16";
        }

        public string GetFaceNumbers()
        {
            return $@"D8: {_d8.GetFaceNumbers()}
D6: {_d6.GetFaceNumbers()}";
        }

        public int RollDie()
        {
            var d8Result = _d8.RollDie();
            var d6Result = _d6.RollDie();

            int d16Result;

            if (d6Result <= 3)
            {
                d16Result = d8Result;
            }
            else
            {
                d16Result = d8Result + 8;
            }

            return d16Result;
        }

        public string ReportDiceRolls()
        {
            var decisionDie = _d6.ReportRollResult();
            var valueDie = _d8.ReportRollResult();

            return $@"{GetDieType()} Rolls
Decision Die Roll: {_d6.GetDieType()} rolled {decisionDie}
Value Die Roll: {_d8.GetDieType()} rolled {valueDie}";
        }

        public string GetDieLogicDescription()
        {
            var logicDescription = @"The result of the D16 is calculated thusly:
Step 1) Roll a D8
Step 2) Roll a D6 and consult the result. If the result is 1, 2, or 3 add 0 to the D8 result, otherwise add 8 to the D8 result
Step 3) The calculated total from Step 2 is the final result";

            return logicDescription;
        }
    }
}
