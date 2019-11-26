using System;
using System.Collections.Generic;

namespace Day3
{
    //Fields: är vanligtvis private och ändras inom classen. (Skrivs i camelcase).
    //Props: är vanligtvis public och kan ändras från båda hållen. 
    //Man kan göra det private med som t.ex. private set. (Skrivs i pascalcase).
    class Program
    {
        static void Main(string[] args)
        {
            var ship = new TransportShip();

            var express = new TransportShip("Planet Express", 10);
            

            var nostromo = new TransportShip("Nostromo", 50);



            //while (true)
            //{
            //    var cargo = new Cargo("Bottles of Slurm");

            //    if (!ship.AddCargo(cargo))
            //    {
            //        break;
            //    }

            //}

            while (true)
            {
                var cargo = new Cargo("Crate with strange eggs", 4);

                if (!nostromo.AddCargo(cargo))
                    break;
            }

            //Console.WriteLine($"{ship.Name}, space available: {ship.Available}");
            //ship.ListCargo();

            //ship.RemoveCargo();

            //Console.WriteLine($"{ship.Name}, space available: {ship.Available}");
            //ship.ListCargo();

            Console.WriteLine($"{nostromo.Name}, space available: {nostromo.Available}");
            Console.WriteLine("- Moving some cargo to Planet Express...");

            nostromo.MoveCargoToOtherShip(express);

            Console.WriteLine($"{nostromo.Name}, space available: {nostromo.Available}");
            Console.WriteLine($"{express.Name}, space available: {express.Available}");

            express.ListCargo();


        }
    }
}
