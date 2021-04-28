namespace DiceTypes
{
    public class SeedGenerator
    {
        public int GetRandomSeed()
        {
            return Guid.NewGuid().GetHashCode();
        }
    }
}
