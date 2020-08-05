using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProOperation
{
    public abstract class Operation
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }
        public Operation(int n1, int n2)
        {
            this.NumberOne = n1;
            this.NumberTwo = n2;
        }
        public abstract int GetResult();
    }
}
