using System;
using System.Linq;

namespace DiceTypes.DieTypes
{
    public class D66
    {
        private D6 _tensDie;
        private D6 _onesDie;

        public D66(int tensSeed, int onesSeed)
        {
            _tensDie = new D6(tensSeed);
            _onesDie = new D6(onesSeed);
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
    }
}
