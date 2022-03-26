using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    class Player
    {
        int[] snake = { 13,30,45,60,75,93,98 };  // Creating Array of All Snake Position in board
        int[] ladder = { 2,6,14,23,36,51,67,86 };  // Creating Array of All Ladder Position in board

        int id;
        public int diceNumber, currentBoardPosition, countDiceRolls;
        public Player(int id)  // creating constructor
        {
            this.id = id;
            currentBoardPosition = 0;
            countDiceRolls = 0;
        }
        public void DiceRolls()
        {
            Random random = new Random();  // Creating object of Random Class
            diceNumber = random.Next(1, 7); // Generating Random Dice Number between 1 to 6
            countDiceRolls+=1;
            Console.WriteLine($"\nAfter rolling Dice,The number display on the Dice is : {diceNumber}");
        }
        public void Move()
        {
            currentBoardPosition+=diceNumber;
            Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");
            if (Array.Exists(snake, x => x == currentBoardPosition)) // Checking that current psotion is Top of Snake or not
            {
                currentBoardPosition-=diceNumber;  // It's a snake that's why moves steps behind by dice number
                Console.WriteLine($"\nYou reached at top of Snake , So You moved {diceNumber} steps behind");
                Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");
            }
            if (Array.Exists(ladder, x => x == currentBoardPosition))  // Checking that current psotion is Bottom of Ladder or not
            {
                Console.WriteLine($"\nYou reached at bottom of Ladder , So You moved {diceNumber} steps ahead");
                currentBoardPosition+=diceNumber;  // It's a ladder that's why moves steps ahead by dice number
                Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");
                Console.WriteLine("\nYeah ! Your Turn Again"); // Turn again because it's a ladder
                DiceRolls(); // Dice rolls again
                Move(); // Again check the condition 
            }
            if (currentBoardPosition>100) // Checking that if current postion above the Total board number
            {
                Console.WriteLine("You are out of range");
                currentBoardPosition-=diceNumber; // If current postion above the Total board number then not moves ahead remain in Same Postion
                Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");
            }
            if (currentBoardPosition<0) // If current postion is below 0 then restart wit Position 0
            {
                currentBoardPosition=0;
                Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");
            }
        }
    }
}
