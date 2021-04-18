using System;

namespace DiceTypes.DieTypes
{
    public class D66
    {
        private Die _tensDie;

        public D66()
        {
            _tensDie = new Die(6, 0);
        }

        public string GetDieType()
        {
            return "D66 (2D6)";
        }

        public string GetFaceNumbers()
        {
            var tensFaces = _tensDie.ListFaceNumbers();

            return $@"Tens Die: {tensFaces}
Ones Die: 1, 2, 3, 4, 5, 6";
        }

        public int RollDie()
        {
            return 61;
        }
    }
}
