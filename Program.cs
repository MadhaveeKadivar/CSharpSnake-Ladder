﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game\n");
            Console.WriteLine("Let's Play\n");
            Console.WriteLine("Currently you are at 0 Position\n");

            int totalBoardNumber = 100, diceNumber, currentBoardPosition = 0;
            int[] snake = {1,3,5,67,87,92,95,98};  // Creating Array of All Snake Position in board
            int[] ladder = {4,6,21,28,36,51,71,80};  // Creating Array of All Ladder Position in board

            Random random = new Random(); // Creating object of Random Class
            diceNumber = random.Next(1, 7); // Generating Random Dice Number between 1 to 6
            Console.WriteLine($"\nAfter rolling Dice,The number display on the Dice is : {diceNumber}");
           
            currentBoardPosition+=diceNumber;
            Console.WriteLine($"You are now at position : {currentBoardPosition}");

            if(Array.Exists(snake, x => x == currentBoardPosition)) // Checking that current psotion is Top of Snake or not
            {
                currentBoardPosition-=diceNumber; // It's a snake that's why moves steps behind by dice number
                Console.WriteLine($"\nYou reached at top of Snake , So You moved {diceNumber} steps behind\n");
            }
            if(Array.Exists(ladder, x => x == currentBoardPosition))  // Checking that current psotion is Bottom of Ladder or not
            {
                Console.WriteLine($"You reached at bottom of Ladder , So You moved {diceNumber} steps ahead\n");
                currentBoardPosition+=diceNumber; // It's a ladder that's why moves steps ahead by dice number
            }         
            Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");
            Console.ReadLine();
        }
    }
}

