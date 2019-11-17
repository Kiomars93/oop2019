using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise6
    {
        public static void answer06()
        {
            var random = new Random();
            var number = random.Next(1, 100);

            Console.WriteLine("Human vs super advanced AI computer. FIGHT!");
            Console.WriteLine("Start game, press 1");
            Console.WriteLine("End game, press 2");
            int button = Convert.ToInt32(Console.ReadLine());
            
            

            bool endGame = false;

            while (endGame == false)
            {
                switch (button)
                {

                    case 1:
                        {
                            Console.WriteLine("Human guess");
                            int human = Convert.ToInt32(Console.ReadLine());
                            var ai = random.Next(1, 100);
                            
                                if (human < number)

                                {
                                    Console.WriteLine("too low");
                                }
                                else if (human > number)
                                {
                                    Console.WriteLine("too high");
                                }

                                else if (human == number)
                                {
                                    Console.WriteLine($"{human} is correct, human is the winner");
                                    endGame = true;
                                } 

                             if (ai < number)
                        {
                            Console.WriteLine($"Computer guesses the number is {ai}");
                                Console.WriteLine("Computer guess is too low");
                                ai = ai + ai;
                        }
                            else if (ai > number)
                        {
                            Console.WriteLine($"Computer guesses the number is {ai}");
                            Console.WriteLine("Computer guess is too high");
                            ai = ai - ai;
                        }
                            else if (ai == number)
                        {
                            Console.WriteLine($"{ai} is correct, computer is the winner");
                            endGame = true;
                        }
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("You have inserted the wrong button. Try again!");
                            break;
                        }
                }
                
        }
            //{
            //    if (human < number)
            //    {
            //        Console.WriteLine("too high");
            //    }
            //    else if (ai < number)
            //    {
            //        Console.WriteLine("too high");
            //    }
            //}
        }
    }
}
