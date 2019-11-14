using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercise1
    {
        public static string ReadInt(string input01)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            return a.ToString();

        }

        public static void answer01() {

            try
            {
                Console.Write("Type a number: ");
                int x = Convert.ToInt32(ReadInt("Type a number: "));
                Console.Write("Type another number: ");
                int y = Convert.ToInt32(ReadInt("Type a number: "));
                Console.WriteLine();
                Console.WriteLine($"{x} + {y} = {x + y}");
            }
            catch (Exception)
            {

                Console.WriteLine("That's not a number, try again");
            }
        }
    }
}
