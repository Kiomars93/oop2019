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
            bool numberInput = false;

            while (numberInput == false)
            {
                Console.Write(input01);
                
                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    return a.ToString();
                }
                catch (Exception)
                {
                    Console.WriteLine("That's not a number, try again");
                } 
            }
            return null;
        }

        public static void answer01() {


            int x = Convert.ToInt32(ReadInt("Type a number: "));
            int y = Convert.ToInt32(ReadInt("Type another number: "));
            Console.WriteLine();
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
    }
}
