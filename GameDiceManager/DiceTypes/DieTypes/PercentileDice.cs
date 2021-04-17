using System;

namespace DiceTypes.DieTypes
{
    public class PercentileDice
    {
        private Die _tensDie;

        public PercentileDice()
        {
            _tensDie = new Die(10, 5);
        }

        public string GetDieType()
        {
            return "Percentile (2D10)";
        }

        public string GetFaceNumbers()
        {
            var tensFaceNumbers = $"Tens Die: {_tensDie.ListFaceNumbers()}";
            return $@"{tensFaceNumbers}
Ones Die: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9";
        }

        public int RollDice()
        {
            var tensResult = _tensDie.RollDie();
            var result = Convert.ToInt32($"{tensResult}8");

            return result;
        }
    }
}
