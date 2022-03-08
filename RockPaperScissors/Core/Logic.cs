using RockPaperScissors.Contracts;
using RockPaperScissors.Enums;
using RockPaperScissors.Players;

namespace RockPaperScissors.Core
{
    public class Logic : IRockPaperScissorLogic
    {
        private int wins;
        private int loses;
        private int draws;

        private readonly Player player;
        private readonly AI ai;

        public Logic()
        {
            player = new Player();
            ai = new AI();
        }

        public Player Player => player;

        public AI AI => ai;

        public string DetermineWinner()
        {
            switch (player.Move, ai.Move)
            {
                case (Move.ROCK, Move.PAPER):
                case (Move.PAPER, Move.SCISSOR):
                case (Move.SCISSOR, Move.ROCK):
                    return $"The Ai Won! You Lost! :(\nWins: {wins}\nLoses: {++loses}\nDraws: {draws}";
                case (Move.ROCK, Move.SCISSOR):
                case (Move.PAPER, Move.ROCK):
                case (Move.SCISSOR, Move.PAPER):
                    return $"You Won! The AI Was Beaten! :>\nWins: {++wins}\nLoses: {loses}\nDraws: {draws}";
                default:
                    return $"It is a Draw!!\nWins: {wins}\nLoses: {loses}\nDraws: {++draws}";
            }
        }

        public void DetermineAIMove()
        {
            try
            {
                ai.DetermineMove();
            }
            catch
            {
                throw;
            }
        }

        public void DeterminePlayerMove()
        {
            try
            {
                player.DetermineMove();
            }
            catch
            {
                throw;
            }
        }
    }
}
