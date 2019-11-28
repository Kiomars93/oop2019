using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    interface ICargoTransporter
    {
        bool AddCargo(Cargo item);
        Cargo RemoveCargo();
        void ListCargo();
    }
}
