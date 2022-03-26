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
            int diceNumber;
            Random random = new Random(); // Creating object of Random Class
            diceNumber = random.Next(1, 7); // Generation random number between 1 to 6
            Console.WriteLine($"After rolling Dice,The number display on the Dice is : {diceNumber}");
            Console.ReadLine();

        }
    }
}
