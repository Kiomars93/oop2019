using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise2
    {
        public static string ReadInt(string input01)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            return a.ToString();

        }
        public static void answer02()
        {

            Console.WriteLine("-- Amazing Leap Year Calculator 2019 --");
            Console.Write("First year: ");

            int x = Convert.ToInt32(ReadInt("Type a number: "));

            if (x > 0 && x <= 9999)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Year must be between 0 and 9999.");
            }

            Console.WriteLine();

            Console.Write("Second year: ");

            int y = Convert.ToInt32(ReadInt("Type a number: "));

            if (y > x)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine($"Year must be between {x} and 9999.");
            }

            Console.WriteLine();


            for (int i = x; i <= y; i++)
            {

                //if (x % 4 == 0) {
                if (DateTime.IsLeapYear(x))
                {
                    Console.WriteLine(x++ + "*");
                }
                else
                {
                    Console.WriteLine(x++);
                }
            }
        }
    }
}
