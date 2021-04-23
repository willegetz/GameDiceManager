namespace DiceTypes.DieTypes
{
    public class D12
    {
        private Die _d12;

        public D12(int randomSeed)
        {
            _d12 = new Die(12, randomSeed);
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
