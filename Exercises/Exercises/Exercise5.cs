using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise5
    {
        public static void answer05()
        {
            var random = new Random();
            var number = random.Next(1, 100);

            Console.WriteLine("Hello, you have two choices!");
            Console.WriteLine("Start game, press 1");
            Console.WriteLine("End game, press 2");


            int gameChoice = Convert.ToInt32(Console.ReadLine());

            bool endGame = false;

            while (endGame == false)
            {

                switch (gameChoice)
                {
                    case 1:
                        {
                            Console.Write("Guess a number: ");
                            int userInput = Convert.ToInt32(Console.ReadLine());
                            if (userInput < number)
                            {
                                Console.WriteLine("too low");
                            }
                            else if (userInput > number)
                            {
                                Console.WriteLine("too high");
                            }
                            else if (userInput == number)
                            {
                                Console.WriteLine("that is correct");
                                endGame = true;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("You chose to end the game");
                            endGame = true;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("You have inserted the wrong number. Try again!");
                            endGame = true;
                        }
                        break;
                }
            }

        }
    }
}
