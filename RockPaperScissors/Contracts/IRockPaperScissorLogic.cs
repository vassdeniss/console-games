using RockPaperScissors.Players;

namespace RockPaperScissors.Contracts
{
    public interface IRockPaperScissorLogic
    {
        Player Player { get; }

        AI AI { get; }

        void DeterminePlayerMove();

        void DetermineAIMove();

        string DetermineWinner();
    }
}
