using DiceTypes.Interfaces;

namespace DiceTypes.DieTypes
{
    public class D12 : IDie
    {
        private BaseDie _d12;

        public D12(int randomSeed)
        {
            _d12 = new BaseDie(12, randomSeed);
        }

        public string GetDieType()
        {
            return "D12";
        }

        public string GetFaceNumbers()
        {
            return _d12.ListFaceNumbers();
        }

        public int RollDie()
        {
            return _d12.RollDie();
        }
    }
}
