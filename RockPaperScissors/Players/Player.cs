using RockPaperScissors.Enums;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Players
{
    public class Player : AbstractPlayer
    {
        public override void DetermineMove()
        {
            string choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "rock":
                case "r":
                    Move = Move.ROCK;
                    break;
                case "paper":
                case "p":
                    Move = Move.PAPER;
                    break;
                case "scissors":
                case "s":
                    Move = Move.SCISSOR;
                    break;
                default:
                    throw new ArgumentException("Error: Invalid choice!");
            }
        }
    }
}
