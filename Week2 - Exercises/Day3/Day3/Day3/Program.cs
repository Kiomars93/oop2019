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

            //var express = new TransportShip("Planet Express", 10);

            ////var nostromo = new TransportShip("Nostromo", 50);

            //express.AddCargo(new Cargo("Item A", 1));
            //express.AddCargo(new Cargo("Item B", 1));

            //Cargo cargo;

            //while ((cargo = express.RemoveCargo()) != null)
            //{
            //    Console.WriteLine($"Removed cargo {cargo.Description}");
            //}

            //while (true)
            //{
            //    var cargo = new Cargo("Bottles of Slurm");

            //    if (!ship.AddCargo(cargo))
            //    {
            //        break;
            //    }

            //}

            //Console.WriteLine($"{ship.Name}, space available: {ship.Available}");
            //ship.ListCargo();

            //ship.RemoveCargo();

            //Console.WriteLine($"{ship.Name}, space available: {ship.Available}");
            //ship.ListCargo();

            //while (true)
            //{
            //    var cargo = new Cargo("Crate with strange eggs", 4);

            //    if (!nostromo.AddCargo(cargo))
            //        break;
            //}



            //Console.WriteLine($"{nostromo.Name}, space available: {nostromo.Available}");
            //Console.WriteLine("- Moving some cargo to Planet Express...");

            //nostromo.MoveCargoToOtherShip(express);

            //Console.WriteLine($"{nostromo.Name}, space available: {nostromo.Available}");
            //Console.WriteLine($"{express.Name}, space available: {express.Available}");

            //express.ListCargo();

            var express = new TransportShip("Planet Express", 10);
            var nostromo = new TransportShip("Nostromo", 50);
            var station = new SpaceStation("Solaris");

            express.AddCargo(new Cargo("Item A from Planet Express", 1));
            express.AddCargo(new Cargo("Item B from Planet Express", 1));

            // Planet Express dropping off its cargo to the station
            station.DropOff("secret password key", express);

            // Nostromo picking it up, using the same key
            station.PickUp("secret password key", nostromo);

            Console.WriteLine("-- Planet Express --");
            express.ListCargo();

            Console.WriteLine("--Nostromo--");
            nostromo.ListCargo();

        }
    }
}
