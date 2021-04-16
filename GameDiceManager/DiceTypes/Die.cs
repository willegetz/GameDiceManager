namespace DiceTypes
{
    public class Die
    {
        private int numberOfFaces;

        public Die(int numberOfFaces)
        {
            this.numberOfFaces = numberOfFaces;
        }

        public string ListNumbers()
        {
            return "1, 2, 3, 4, 5, 6";
        }
    }
}
