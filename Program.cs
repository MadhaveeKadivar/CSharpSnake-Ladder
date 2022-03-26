﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    internal class Program
    {
        public static int totalBoardNumber = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game\n");
            Console.WriteLine("Let's Play\n");
            //Creating Object for Player 1 and Player 2
            Player player1 = new Player(1);
            Player player2 = new Player(2);
            while(true)
            {
                Console.WriteLine("\n\nPlayer 1 turn's....");
                player1.DiceRolls(); // Calling Method of Player Class
                player1.Move();    // Calling Method of Player Class
                if (player1.currentBoardPosition==Program.totalBoardNumber)
                {
                    Console.WriteLine("Congratuation ! Player 1 Won" );
                    break;
                }
                Console.WriteLine("\n\nPlayer 2 turn's....");
                player2.DiceRolls();
                player2.Move();
                if (player2.currentBoardPosition==Program.totalBoardNumber)
                {
                    Console.WriteLine("\n\nCongratuation ! Player 2 Won");
                    break;
                }
            }
            Console.WriteLine($"\nPlayer 1 rolls dice : {player1.countDiceRolls} times");
            Console.WriteLine($"\nPlayer 2 rolls dice : {player2.countDiceRolls} times");
            Console.ReadLine();
        }
    }
}

