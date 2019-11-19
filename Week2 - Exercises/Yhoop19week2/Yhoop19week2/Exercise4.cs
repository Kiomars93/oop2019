using System;
using System.Collections.Generic;
using System.Text;

namespace Yhoop19week2
{
    class Exercise4
    {
        public static void answer04()
        {
            var heightWindow = Console.WindowHeight;
            var widthWindow = Console.WindowWidth;

            var random = new Random();

            while (true)
            {

                for (int i = 0; i < heightWindow - 1; i++)
                {
                    var color = (ConsoleColor)random.Next(1, 16);
                    Console.BackgroundColor = color;
                    Console.SetCursorPosition(random.Next(1, 120), random.Next(1, 120));
                    Console.WriteLine("               ");

                }

            }
        }
    }
}
