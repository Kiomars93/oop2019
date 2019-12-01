using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GameEngine();
            var human = new Human();
            var monster = new Monster();
            //var dragon = new Dragon();
            //var slime = new Slime();











            //Uppgift 4
            //while (true)
            //{
            //    var initative = game.RollForInitiative(dragon, slime);

            //    Console.WriteLine($"{initative.First.Name} would attack {initative.Second.Name} first");
            //}

            //Uppgift 3
            //Console.WriteLine("Human attacks Monster!");

            //var damage = game.attack(human, monster);

            //Console.WriteLine($"{damage} points of damage, Monster has {monster.Health} health left!");


            //Uppgift 2
            //if (monster.WeakAgainst(human))
            //{
            //    Console.WriteLine("Monster has weak defense against Human");
            //}

            //if (human.StrongAgainst(monster))
            //{
            //    Console.WriteLine("Human has strong attack against Monster");
            //}

            //if (dragon.StrongAgainst(human) && dragon.StrongAgainst(monster))
            //{
            //    Console.WriteLine("Dragon is pretty bad ass...");
            //}
        }
    }
}
