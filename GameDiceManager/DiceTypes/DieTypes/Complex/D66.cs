using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using System;

namespace DiceTypes.DieTypes.Complex
{
    public class D66 : IDie
    {
        private D6 _tensDie;
        private D6 _onesDie;

        public D66()
        {
            _tensDie = new D6();
            _onesDie = new D6();
        }

        public D66(ISeedGenerator seedGenerator)
        {
            _tensDie = new D6(seedGenerator);
            _onesDie = new D6(seedGenerator);
        }

        public string GetDieType()
        {
            return "D66 (2D6)";
        }

        public string GetFaceNumbers()
        {
            var tensFaces = _tensDie.GetFaceNumbers();
            var onesFaces = _onesDie.GetFaceNumbers();

            return $@"Tens Die: {tensFaces}
Ones Die: {onesFaces}";
        }

        public int RollDie()
        {
            var tensResult = _tensDie.RollDie();
            var onesResult = _onesDie.RollDie();

            var result = Convert.ToInt32($"{tensResult}{onesResult}");
            return result;
        }

        public string ReportDiceRolls()
        {
            var tensResult = _tensDie.ReportRollResult();
            var onesResult = _onesDie.ReportRollResult();

            return $@"{GetDieType()} Rolls
Tens Die Roll: {_tensDie.GetDieType()} rolled {tensResult}
Ones Die Roll: {_onesDie.GetDieType()} rolled {onesResult}";
        }
    }
}
