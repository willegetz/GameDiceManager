using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using System;

namespace DiceTypes.DieTypes.Complex
{
    public class PercentileDice0and0 : IDie
    {
        private D10 _tensDie;
        private D10 _onesDie;

        public PercentileDice0and0(int tensSeed, int onesSeed)
        {
            _tensDie = new D10(tensSeed);
            _tensDie.MakeOnesDie();

            _onesDie = new D10(onesSeed);
            _onesDie.MakeOnesDie();
        }

        public string GetDieType()
        {
            return "Percentile (2D10 with face range 0 to 9 each)";
        }

        public string GetFaceNumbers()
        {
            var tensFaceNumbers = $"Tens Die: {_tensDie.GetFaceNumbers()}";
            var onesFaceNumbers = $"Ones Die: {_onesDie.GetFaceNumbers()}";

            return $@"{tensFaceNumbers}
{onesFaceNumbers}";
        }

        public int RollDie()
        {
            var tensResult = _tensDie.RollDie();
            var onesResult = _onesDie.RollDie();

            var result = Convert.ToInt32($"{tensResult}{onesResult}");

            return result;
        }
    }
}
