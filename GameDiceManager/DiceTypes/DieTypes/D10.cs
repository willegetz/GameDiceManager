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
    }
}
