using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Program
    {
        public const int START_POSITION = 0;
        public const int END_POSITION = 100;
        static void Main(string[] args)
        {
            //variable
            int currentPosition = 0;
            Console.WriteLine("The  Starting Position of Player is: " + START_POSITION );
            Random Dice = new Random();
            int number = Dice.Next(1,7);
            currentPosition += number;
            Console.WriteLine("The Current Position of Player is: " + currentPosition);
            Console.ReadKey();
        }
    }
}
