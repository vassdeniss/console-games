using RockPaperScissors.Contracts;
using RockPaperScissors.Enums;
using RockPaperScissors.Models;
using RockPaperScissors.Players;
using System;
using System.Threading;

namespace RockPaperScissors.Core
{
    public class Engine : IRunnable
    {
        private readonly Logic logic;

        public Engine()
        {
            logic = new Logic();
        }

        public void Run()
        {
            while (true)
            {
                PrintTitle();
                PlayerMove();
                AiMove();
                Result();
            }
        }

        private void Result()
        {
            PrintTitle();
            Console.Write($"The AI chose:... ");
            Thread.Sleep(2000);
            Console.Write($"{logic.AI.Move}\n");
            Thread.Sleep(1000);
            Console.WriteLine(logic.DetermineWinner());
            Thread.Sleep(7000);
        }

        private void AiMove()
        {
            PrintTitle();
            Console.WriteLine("AI Player is choosing...");
            Thread.Sleep(5000);
            logic.DetermineAIMove();
        }

        private void PlayerMove()
        {
            PrintTitle();
            Console.WriteLine("Choose between <r>ock, <p>aper, <s>cissiors");
            Console.Write("My choice is: ");

            try
            {
                logic.DeterminePlayerMove();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(2000);
                PlayerMove();
            }
        }

        private void PrintTitle()
        {
            Console.Clear();
            Console.WriteLine("Console Rock Paper Scissors by vass");
        }
    }
}
