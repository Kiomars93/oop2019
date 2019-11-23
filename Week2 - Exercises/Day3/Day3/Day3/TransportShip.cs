using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class TransportShip
    {
        public string Name { get; set; }

        // Max antal last i skeppet
        public int Size { get; set; }

        // De antal lasten i skeppet. (Värdet kan varieras)
        //Nu kan ej någon client (i main method) ändra Available värdet. Det kan endast ändras inom classen.
        public int Available { get; private set; }

        Stack<Cargo> storage;
        //public Stack<Cargo> Storage { get; set; }
        public TransportShip()
        {
            Name = "Planet Express";
            Size = 10;

            storage = new Stack<Cargo>();

            Available = Size;
        }

        public TransportShip(string name, int size)
        {
            Name = name;
            Size = size;

            storage = new Stack<Cargo>();

            Available = Size;
        }



        public bool AddCargo(Cargo item)
        {

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

        public bool MoveCargoToOtherShip(TransportShip ship)
        {

            return true;
        }

    }
}
