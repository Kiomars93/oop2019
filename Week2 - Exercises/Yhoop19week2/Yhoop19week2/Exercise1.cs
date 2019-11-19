using System;
using System.Collections.Generic;
using System.Text;

namespace Yhoop19week2
{
    class Exercise1
    {
        class Box
        {
            public int x;
            public int y;
            public int width;
            public int height;

            public void Draw()
            {

                var widthLine = new string('x', width);



                for (int i = 0; i < height; i++)
                {
                    Console.SetCursorPosition(x, y + i);
                    Console.WriteLine(widthLine);
                }


            }
        }
        public static void answer01()
        {
            var box1 = new Box()
            {
                x = 3,
                y = 2,
                width = 7,
                height = 4

            };
            var box2 = new Box()
            {
                x = 17,
                y = 4,
                width = 13,
                height = 8
            };

            box1.Draw();
            box2.Draw();

        }
    }
}
