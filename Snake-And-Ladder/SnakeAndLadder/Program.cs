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

        public static int NoPlay(int currentPosition) 
        {
            return currentPosition;
        }

        public static int Ladder(int currentPosition, int number)
        {
            currentPosition += number;
            return currentPosition;
        }

        public static int Snake(int currentPosition, int number)
        {
            if (currentPosition != 0)
            {
                currentPosition -= number;
            }
            if (currentPosition < 0)
            {
                currentPosition = 0;
            }
            return currentPosition;
        }

        static void Main(string[] args)
        {
            //variable
            int currentPosition = 0;
            Console.WriteLine("The  Starting Position of Player is: " + START_POSITION );
            Random Dice = new Random();
            int number = Dice.Next(1,7);
            int checkmoves = Dice.Next(1, 4);
            Console.WriteLine(number);
            Console.WriteLine(checkmoves);

            switch (checkmoves)
            {
                case 1:
                    int move = NoPlay(currentPosition);
                    currentPosition = move;
                    break;
                case 2:
                    int move1 = Ladder(currentPosition, number);
                    currentPosition = move1;
                    break;
                case 3:
                    int move2 = Snake(currentPosition, number);
                    currentPosition = move2;
                    break;
                default:
                    Console.WriteLine("No such option");
                    break;
            }

            Console.WriteLine("The Current Position of Player is: " + currentPosition);
            Console.ReadKey();
        }
    }
}
