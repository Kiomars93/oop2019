using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise7
    {
        public static void answer07()
        {
            var random = new Random();

            Console.WindowHeight = 30;
            Console.WindowWidth = 120;
            //Console.SetCursorPosition(random.Next(1, 120), random.Next(1, 31));
            int fullScreen = Console.WindowWidth + Console.WindowHeight;

            //Console.SetBufferSize(120, 30);

            //Console.BackgroundColor = ConsoleColor.Red;

            //Startpunkten
            Console.SetCursorPosition(0, 0);


            for (int i = 0; i < Console.WindowWidth; i++)
            {
                //Generar olika färger vid varje loop
                var color = random.Next(1, 16);
                //Console.SetCursorPosition(random.Next(1, 120), random.Next(1, 31));

                //Den inre for-loopen skapar varje rad
                Console.BackgroundColor = (ConsoleColor)color;
                for (int j = 0; j < Console.WindowWidth; j++)
                {

                    Console.Write(" ");
                }

            }
        }
    }
}
