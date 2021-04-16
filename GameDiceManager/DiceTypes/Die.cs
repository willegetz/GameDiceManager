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
            if (numberOfFaces == 6)
            {
                return "1, 2, 3, 4, 5, 6";
            }
            else
            {
                return "1, 2, 3, 4, 5, 6, 7, 8";
            }
        }
    }
}
