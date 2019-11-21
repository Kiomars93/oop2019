using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class Cargo
    {
        public string Description { get; set; }
        public int Size { get; set; }

        public Cargo(string description, int size)
        {
            Description = description;
            Size = size;
        }
    }
}
