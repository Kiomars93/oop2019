using System;
using System.Collections.Generic;
using System.Text;

namespace Yhoop19week2
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

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Blue;

            var widthLine = new string('x', width);

            Console.ForegroundColor = color;

            for (int i = 0; i <= height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.WriteLine(widthLine);
            }


        }
    }
    class Exercise2
    {
        public static void answer02()
        {
            var box1 = new Box()
            {
                x = 3,
                y = 2,
                width = 7,
                height = 4,
                color = ConsoleColor.Red

            };
            var box2 = new Box()
            {
                x = 17,
                y = 4,
                width = 13,
                height = 8,
                color = ConsoleColor.Blue
            };

            box1.Draw();
            box2.Draw();

        }
    }
}
