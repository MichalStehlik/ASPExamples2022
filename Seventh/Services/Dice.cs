using Microsoft.Extensions.Options;

namespace Seventh.Services
{
    public class Dice
    {
        public int Value { get; set; } = 0;
        private Random _random = new Random();
        private IConfiguration _conf;
        private DiceOptions _options;
        public int Range { get; private set; }

        public Dice(
            /*DiceOptions options*/ 
            /*IConfiguration config*/ 
            IOptions<DiceOptions> options
            )
        {
            // Range = options.Range;
            // _conf = config;
            //string rangeString = _conf["Dice:Range"];
            //Range = int.Parse(rangeString);
            _options = options.Value;
            Range = _options.Range;
            Value = _random.Next(Range);
            Console.WriteLine("Startuji s hodnotou:" + Value);
        }
    }
}
