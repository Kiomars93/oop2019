using System;

namespace Day3Exercise3
{
    class Program
    {
        public class Time
        {
            public int Hour { get; set; }
            public int Minute { get; set; }
            public int Second { get; set; }
        }
        static void Main(string[] args)
        {

            var travel = new DateTime();

            int hour = travel.Hour;

            for (int i = 0; i < hour; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
