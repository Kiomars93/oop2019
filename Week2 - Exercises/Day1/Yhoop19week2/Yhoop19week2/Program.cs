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
        class Box
        {
            public int x;
            public int y;
            public int width;
            public int height;
            public ConsoleColor color;
            
            public void Draw()
            {
                var heightWindow = Console.WindowHeight;
                var widthWindow = Console.WindowWidth;
                var random = new Random();
                var widthLine = new string(' ', width);
                var heightLine = new string('y', height);
                var color = (ConsoleColor)random.Next(1, 16);
                Console.BackgroundColor = color;
                //Console.ForegroundColor = color;

                for (int i = 0; i <= heightWindow; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.WriteLine(widthLine);
                }
            }
        }
        static void Main(string[] args)
        {


            var random = new Random();

            while (true)
            {
                var color = (ConsoleColor)random.Next(1, 16);
                var heightWindow = Console.WindowHeight;
                var widthWindow = Console.WindowWidth;

                var x = random.Next(0, widthWindow);
                var y = random.Next(0, heightWindow);

                var width = random.Next(0, widthWindow - x);
                var height = random.Next(0, heightWindow - y);



                var box = new Box()
                {
                    x = x,
                    y = y,
                    width = width,
                    height = height,
                    color = color
                };
                box.Draw();
            }

            

            //while (true)
            //{

            //    for (int i = 0; i < heightWindow - 1; i++)
            //    {
            //        var color = (ConsoleColor)random.Next(1, 16);
            //        Console.BackgroundColor = color;
            //        Console.SetCursorPosition(random.Next(1, 120), random.Next(1, 120));
            //        Console.WriteLine("               ");

            //    }

            //}

        }
    }
}
