using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            var player = new TestCharacter(10, 20);
            Console.WriteLine($"Health : {player.Health}");
            Console.WriteLine($"Damage : {player.Damage}");

            player.Health = 0;

            if (player.Dead)
            {
                Console.WriteLine($"Health : {player.Health}");
                Console.WriteLine("Player is dead");
            }

        }
    }
}
