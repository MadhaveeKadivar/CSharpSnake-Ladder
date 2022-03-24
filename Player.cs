using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    class Player
    {
        int[] snake = { 13,30,45,60,75,93,98 };
        int[] ladder = { 2,6,14,23,36,51,67,86 };

        int id;
        public int diceNumber, currentBoardPosition, countDiceRolls;
        public Player(int id)
        {
            this.id = id;
            currentBoardPosition = 0;
            countDiceRolls = 0;
        }
        public void DiceRolls()
        {
            Random random = new Random();
            diceNumber = random.Next(1, 7);
            countDiceRolls+=1;
            Console.WriteLine($"\nAfter rolling Dice,The number display on the Dice is : {diceNumber}");
        }
        public void Move()
        {
            currentBoardPosition+=diceNumber;

            Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");

            if (Array.Exists(snake, x => x == currentBoardPosition))
            {
                currentBoardPosition-=diceNumber;
                Console.WriteLine($"\nYou reached at top of Snake , So You moved {diceNumber} steps behind");
                Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");
            }
            if (Array.Exists(ladder, x => x == currentBoardPosition))
            {
                Console.WriteLine($"\nYou reached at bottom of Ladder , So You moved {diceNumber} steps ahead");
                currentBoardPosition+=diceNumber;
                Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");
                Console.WriteLine("\nYeah ! Your Turn Again");
                DiceRolls();
                Move();
            }
            if (currentBoardPosition>100)
            {
                Console.WriteLine("You are out of range");
                currentBoardPosition-=diceNumber;
                Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");
            }
            if (currentBoardPosition<0)
            {
                currentBoardPosition=0;
                Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");
            }

        }
    }
}