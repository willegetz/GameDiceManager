using System;
using System.Linq;

namespace DiceTypes.DieTypes
{
    public class D66
    {
        private Die _tensDie;
        private Die _onesDie;

        public D66(int tensSeed)
        {
            _tensDie = new Die(6, tensSeed);
            _onesDie = new Die(6, 14);
        }

        public string GetDieType()
        {
            return "D66 (2D6)";
        }

        public string GetFaceNumbers()
        {
            var tensFaces = _tensDie.ListFaceNumbers();
            var onesFaces = _onesDie.ListFaceNumbers();

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
    }
}
