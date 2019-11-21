using System;
using System.Collections.Generic;
using System.Text;

namespace Yhoop19week2
{

    class Exercise3
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
        class BoxManager
        {
            public List<Box> boxes = new List<Box>();
            public void DrawInCenter()
            {

                var heightWindow = Console.WindowHeight;
                var widthWindow = Console.WindowWidth;


                foreach (var boxElement in boxes)
                {
                    var h = boxElement.height / 2;
                    var w = boxElement.width / 2;
                    boxElement.x = (widthWindow / 2) - w;
                    boxElement.y = (heightWindow / 2) - h;
                    boxElement.Draw();
                }
            }

        }

        public static void answer03()
        {
            var manager = new BoxManager()
            {
                boxes = new List<Box>()
            };

            manager.boxes.Add(new Box()
            {
                height = 10,
                width = 20,
                color = ConsoleColor.Red,
            });

            manager.boxes.Add(new Box()
            {
                height = 6,
                width = 12,
                color = ConsoleColor.Blue,
            });

            manager.DrawInCenter();
        }

    }
}
