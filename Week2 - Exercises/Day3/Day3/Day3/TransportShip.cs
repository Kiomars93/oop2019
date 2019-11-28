using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class TransportShip : ICargoTransporter
    {
        public string Name { get;  }

        // Max antal last i skeppet
        public int Size { get;  }

        // De antal lasten i skeppet. (Värdet kan varieras)
        //Nu kan ej någon client (i main method) ändra Available värdet. Det kan endast ändras inom classen.
        public int Available { get; private set; }

        Stack<Cargo> storage;
        //public Stack<Cargo> Storage { get; set; }
       
        public TransportShip(string name, int size)
        {
            Name = name;
            Size = size;

            storage = new Stack<Cargo>();

            Available = Size;
        }



        public bool AddCargo(Cargo item)
        {
            if (item == null)
            {
                throw new ArgumentException();
            }

            if (Available > item.Size)
            {

                storage.Push(item);
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
            if (storage.Count == 0)
            {
                return null;
            }
            else
            {
                var item = storage.Pop();
                Available = Available + item.Size;
                return item;
            }

        }

        //public void ListCargo()
        //{


        //    //List what's in the storage of the ship, or "<empty>" if there is no cargo.
        //    if (storage.Count == 0)
        //    {
        //        Console.WriteLine("Cargo is empty");
        //    }
        //    else
        //    {
        //        foreach (var cargoItem in storage)
        //        {
        //            Console.WriteLine(cargoItem.Description);
        //        }
        //    }
        //}

        public void ListCargo()
        {


            //List what's in the storage of the ship, or "<empty>" if there is no cargo.
            

            if (storage.Count == 0)
            {
                Console.WriteLine("Cargo is empty");
            }
            else
            {
                foreach (var cargoItem in storage)
                {
                    Console.WriteLine(cargoItem.Description);
                }
            }
        }

        //public bool MoveCargoToOtherShip(TransportShip ship)
        //{
        //    bool movedItem = false;
        //    var item = storage.Peek();

        //    if (movedItem == false)
        //    {
        //        while (ship.Available > item.Size)
        //        {
        //            ship.AddCargo(item);
        //            //ship.Available = ship.Available - item.Size;
        //            //Console.WriteLine($"{item.Description} + {item.Size}");
        //            //storage.Peek();

        //        }

        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
