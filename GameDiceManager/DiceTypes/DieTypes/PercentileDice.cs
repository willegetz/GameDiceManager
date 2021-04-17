using System;

namespace DiceTypes.DieTypes
{
    public class PercentileDice
    {
        private Die _tensDie;
        private Die _onesDie;

        public PercentileDice(int tensSeed, int onesSeed)
        {
            _tensDie = new Die(10, tensSeed);
            _onesDie = new Die(10, onesSeed);
            _onesDie.ShiftRange(-1);
        }

        public string GetDieType()
        {
            return "Percentile (2D10)";
        }

        public string GetFaceNumbers()
        {
            var tensFaceNumbers = $"Tens Die: {_tensDie.ListFaceNumbers()}";
            var onesFaceNumbers = $"Ones Die: {_onesDie.ListFaceNumbers()}";
            return $@"{tensFaceNumbers}
{onesFaceNumbers}";
        }

        public int RollDice()
        {
            var tensResult = _tensDie.RollDie();
            var onesResult = _onesDie.RollDie();

            var result = Convert.ToInt32($"{tensResult}{onesResult}");

            return result;
        }
    }
}
