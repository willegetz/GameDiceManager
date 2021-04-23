namespace DiceTypes.DieTypes
{
    public class D8
    {
        private readonly Die _d8;

        public D8(int randomSeed)
        {
            _d8 = new Die(8, randomSeed);
        }

        public string GetDieType()
        {
            return "D8";
        }

        public string GetFaceNumbers()
        {
            return _d8.ListFaceNumbers();
        }

        public int RollDie()
        {
            return _d8.RollDie();
        }
    }
}
