using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    class Program
    {
        //CONSTANT
        public const int START_POSITION = 0;
        public const int END_POSITION = 100;

        public static int NoPlay(int currentPosition) 
        {
            return currentPosition;
        }

        public static int Ladder(int currentPosition, int number)
        {
            int temporaryNumber = currentPosition;
            currentPosition += number;
            if (currentPosition > 100)
                currentPosition = temporaryNumber;
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
            int currentPosition1 = 0;
            int currentPosition2 = 0;
            int timesDieRolledPlayer1 = 0;
            int timesDieRolledPlayer2 = 0;
            Console.WriteLine("The Starting Position of Both Players is: " + START_POSITION );
            Console.WriteLine("\n");
            Random Dice = new Random();
            while (currentPosition1 != 100 && currentPosition2 != 100)
            {
                timesDieRolledPlayer1++;
                int number = Dice.Next(1, 7);
                int checkmoves = Dice.Next(1, 4);
                switch (checkmoves)
                {
                    case 1:
                        int move = NoPlay(currentPosition1);
                        currentPosition1 = move;
                        break;
                    case 2:
                        int move1 = Ladder(currentPosition1, number);
                        currentPosition1 = move1;
                        break;
                    case 3:
                        int move2 = Snake(currentPosition1, number);
                        currentPosition1 = move2;
                        break;
                    default:
                        Console.WriteLine("No such option");
                        break;
                }

                Console.WriteLine("The Current Position of Player1 is: " + currentPosition1);

                if (currentPosition1 == 100)
                    break;

                timesDieRolledPlayer2++;
                number = Dice.Next(1, 7);
                checkmoves = Dice.Next(1, 4);
                switch (checkmoves)
                {
                    case 1:
                        int move = NoPlay(currentPosition2);
                        currentPosition2 = move;
                        break;
                    case 2:
                        int move1 = Ladder(currentPosition2, number);
                        currentPosition2 = move1;
                        break;
                    case 3:
                        int move2 = Snake(currentPosition2, number);
                        currentPosition2 = move2;
                        break;
                    default:
                        Console.WriteLine("No such option");
                        break;
                }

                Console.WriteLine("The Current Position of Player2 is: " + currentPosition2);
                Console.WriteLine("\n");

            }
            Console.WriteLine("Number of times Die Rolled is for Player1 is " + timesDieRolledPlayer1);
            Console.WriteLine("Number of times Die Rolled is for Player2 is " + timesDieRolledPlayer2);
            if (currentPosition1 == 100)
            {
                Console.WriteLine("Player1 Wins");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Thus Player2 Wins");
                Console.ReadKey();
            }
        }
    }
}
