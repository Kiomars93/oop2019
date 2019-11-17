using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise8
    {
        public static void answer08()
        {
            char x = 'x';

            Console.Write("Please input size of tree: ");

            //Console.SetCursorPosition(20, 3);

            int userInput = Convert.ToInt32(Console.ReadLine());
            var repeated = new string('x', userInput);

            //Console.WriteLine(repeated);

            for (int i = 0; i < repeated.Length; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < repeated.Length; j++)
                {

                    j = j + i;
                    Console.WriteLine(j);
                    //if (j % 3 == 0)
                    //{
                    //    Console.WriteLine("*"); 
                    //}
                }
                
            }

           
            

        }
    }
}
