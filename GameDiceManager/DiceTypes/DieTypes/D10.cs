namespace DiceTypes.DieTypes
{
    public class D10
    {
        private readonly Die _d10;

        public D10(int randomSeed)
        {
            _d10 = new Die(10, randomSeed);
        }

        public string GetDieType()
        {
            return "D10";
        }

        public string GetFaceNumbers()
        {
            return _d10.ListFaceNumbers();
        }

        public int RollDie()
        {
            return _d10.RollDie();
        }

        public void MakeOnesDie()
        {
            var rangeShiftValue = -1;
            _d10.ShiftRange(rangeShiftValue);
        }
    }
}
