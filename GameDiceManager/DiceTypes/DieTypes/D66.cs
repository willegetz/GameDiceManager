using System;

namespace DiceTypes.DieTypes
{
    public class D66
    {
        private Die _tensDie;
        private Die _onesDie;

        public D66()
        {
            _tensDie = new Die(6, 0);
            _onesDie = new Die(6, 0);
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
            return 61;
        }
    }
}
