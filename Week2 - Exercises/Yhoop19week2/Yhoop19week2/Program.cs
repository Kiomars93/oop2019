using System;
using System.Collections.Generic;
//Exercise1.answer01();
//Exercise2.answer02();
//Exercise3.answer03();
//Exercise4.answer04();
namespace Yhoop19week2
{
    class Program
    {
        static void Main(string[] args)
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
