using System;
using System.Collections.Generic;

namespace LastShipExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var travel = new DateTime();

            int hour = travel.Hour;

            hour = 24;

            int extraLine = 8;
            
           
            for (int i = 0; i < extraLine; i++)
            {
                Console.WriteLine(".");
                for (int j = 0; j < hour; j++)
                {
                    Console.Write(".");
                }

            }
        }
    }
}
