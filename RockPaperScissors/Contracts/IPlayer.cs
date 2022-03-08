using RockPaperScissors.Enums;

namespace RockPaperScissors.Contracts
{
    public interface IPlayer
    {
        Move Move { get; }

        void DetermineMove();
    }
}
