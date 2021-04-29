using DiceTypes.DieTypes.Basic;
using DiceTypes.Interfaces;
using System;

namespace DiceTypes.DieTypes.Complex
{
    public class PercentileDice10and0 : IDie
    {
        private D10 _tensDie;
        private D10 _onesDie;

        public PercentileDice10and0()
        {
            _tensDie = new D10();

            _onesDie = new D10();
            _onesDie.MakeOnesDie();
        }
        public PercentileDice10and0(ISeedGenerator seedGenerator)
        {
            _tensDie = new D10(seedGenerator);

            _onesDie = new D10(seedGenerator);
            _onesDie.MakeOnesDie();
        }

        public string GetDieType()
        {
            return "Percentile (2D10 with face range 1 to 10 and 0 to 9)";
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
