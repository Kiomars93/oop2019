using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class SpaceStation
    {
        Dictionary<string, List<Cargo>> Storage = new Dictionary<string, List<Cargo>>();
        string Name;

        public SpaceStation(string name)
        {
            this.Name = name;
        }

        public void DropOff(string key, ICargoTransporter transporter)
        {
            Cargo cargo;
            List<Cargo> listOfCargo = new List<Cargo>();
            
            while ((cargo = transporter.RemoveCargo()) != null)
            {
                listOfCargo.Add(cargo); 
            }

            Storage[key] = listOfCargo;
        }

        public void PickUp(string key, ICargoTransporter transporter)
        {
            List<Cargo> listOfCargo = Storage[key];

            foreach (Cargo cargo in listOfCargo)
            {
                transporter.AddCargo(cargo);
            }

        }
    }
}
