using System;
using System.Collections;
using System.Collections.Generic;

namespace Day2Exercises
{
    class Program
    {
        class TransportShip
        {
            public string Name { get; set; }
            
            // Max antal last i skeppet
            public int Size { get; set; }

            // De antal lasten i skeppet. (Värdet kan varieras)
            public int Available { get; set; }

            
            public Stack<Cargo> Storage { get; set; }
            public TransportShip(string name, int size)
            {
                Name = name;
                Size = size;
                // Det här en tomt storage annars är defaultvärdet null
                Storage = new Stack<Cargo>();

                Available = Size;
            }
            public bool AddCargo(Cargo item)
            {

                

                if (Available > item.Size) 
                { 
                    Storage.Push(item);
                    Available = Available - item.Size;
                    return true;
                }
                //Måste göra nåt med storage propsen i cargoklassen
                //If there is enough available storage space left, the cargo is added to the ship and the method returns true
                //If there is not enough space for the item, the cargo is not added and the method returns false
                //On successful cargo load, modify how much cargo space is available on the ship

                return false;
            }
                

                public Cargo RemoveCargo()
            {
                //If the storage is empty, the method should return null
                //On successful unload, modify how much cargo space is available on the ship
                if(Storage.Count == 0) { 
                return null;
                }
                else
                {
                    var item = Storage.Pop();
                    Available = Available + item.Size;
                    return item;
                }
                
            }

            public void ListCargo()
            {
              

                //List what's in the storage of the ship, or "<empty>" if there is no cargo.
                if (Storage.Count == 0)
                {
                    Console.WriteLine("Cargo is empty");
                }    else 
                {
                    foreach (var cargoItem in Storage)
                    {
                        Console.WriteLine(cargoItem.Description);
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            var ship = new TransportShip("Planet Express", 10);

            while (true)
            {
                var cargo = new Cargo("Bottles of Slurm", 3);

                if (!ship.AddCargo(cargo))
                {
                    break;
                }

            }

            Console.WriteLine($"{ship.Name}, space available: {ship.Available}");
            ship.ListCargo();

            ship.RemoveCargo();

            Console.WriteLine($"{ship.Name}, space available: {ship.Available}");
            ship.ListCargo();
        }
    }
}
