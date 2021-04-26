using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes
{
    public class D6 : IDie
    {
        private readonly BaseDie _d6;
        public D6(int randomSeed)
        {
            _d6 = new BaseDie(6);
        }

        public string GetDieType()
        {
            return "D6";
        }

        public string GetFaceNumbers()
        {
            return _d6.ListFaceNumbers();
        }

        public int RollDie()
        {
            return _d6.RollDie();
        }
    }
}
