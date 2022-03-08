using RockPaperScissors.Contracts;
using RockPaperScissors.Enums;

namespace RockPaperScissors.Models
{
    public abstract class AbstractPlayer : IPlayer
    {
        public Move Move { get; protected set; }

        public abstract void DetermineMove();
    }
}
