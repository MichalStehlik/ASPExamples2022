namespace Sixth.Services
{
    public class SimpleDice : IRoller
    {
        private Random _rand = new Random();

        public int Roll()
        {
            return _rand.Next(6) + 1;
        }
    }
}
