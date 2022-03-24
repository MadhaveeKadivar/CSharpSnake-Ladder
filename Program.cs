using System;
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
            int[] snake = {1,3,5,67,87,92,95,98};
            int[] ladder = {4,6,21,28,36,51,71,80};

            Random random = new Random();
            diceNumber = random.Next(1, 7);
            Console.WriteLine($"\nAfter rolling Dice,The number display on the Dice is : {diceNumber}");
           

            currentBoardPosition+=diceNumber;

            Console.WriteLine($"You are now at position : {currentBoardPosition}");

            if(Array.Exists(snake, x => x == currentBoardPosition))
            {
                currentBoardPosition-=diceNumber;
                Console.WriteLine($"\nYou reached at top of Snake , So You moved {diceNumber} steps behind\n");
            }
            if(Array.Exists(ladder, x => x == currentBoardPosition))
            {
                Console.WriteLine($"You reached at bottom of Ladder , So You moved {diceNumber} steps ahead\n");
                currentBoardPosition+=diceNumber;
            }
            

            Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");

            Console.ReadLine();

        }
    }
}

