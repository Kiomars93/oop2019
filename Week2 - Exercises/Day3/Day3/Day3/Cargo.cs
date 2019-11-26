using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class Cargo
    {
        public string Description { get; private set; }
        public int Size { get; private set; }
        public Cargo(string description)
        {
            Description = description;
            Size = 3;

            SetAccountBalance(Size);
        }

        public Cargo(string description, int size)
        {
            Description = description;
            Size = size;

            SetAccountBalance(Size);
        }
        void SetAccountBalance(int value)
        {
            if (value <= 0)
                throw new ArgumentException("Can't set account to a negative balance", "value");

        }
    }
}