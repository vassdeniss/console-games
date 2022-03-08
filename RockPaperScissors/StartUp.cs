using RockPaperScissors.Contracts;
using RockPaperScissors.Core;

namespace RockPaperScissors
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IRunnable engine = new Engine();
            engine.Run();
        }
    }
}
