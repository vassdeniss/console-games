using RockPaperScissors.Enums;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Players
{
    public class AI : AbstractPlayer
    {
        public override void DetermineMove()
        {
            Random random = new Random();
            Move = (Move)random.Next(3);
        }
    }
}
