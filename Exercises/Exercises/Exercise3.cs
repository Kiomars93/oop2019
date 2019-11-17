using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    
    class Exercise3
    {
        public static bool IsPalindrome(string text)
        {

            string newText = text;

            bool pop = newText.Contains(text.Substring(0));



            if (text.StartsWith(newText) && text.EndsWith(newText))
            {
                Console.WriteLine("True shit");
                return true;
            }

            Console.WriteLine("False shit");
            return false;
        }
        public static void answer03()
        {
            Console.WriteLine("This program will show you if your text is palindrome or not");
            //Console.Write("Enter your first input: ");
            //string firstInput = Console.ReadLine();
            //Console.Write("Enter your second input: ");
            //string secondInput = Console.ReadLine();
            Console.WriteLine();

            //IsPalindrome("Abba"); // true
            //IsPalindrome("nurses run"); // true
            //IsPalindrome("palindrome"); // false

            string a = "abcdefgh";

            Console.WriteLine(a.Substring(0, a.Length - 1));
        }
    }
}
