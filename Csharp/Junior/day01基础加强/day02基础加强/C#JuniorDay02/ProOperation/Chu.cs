using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProOperation
{
    public class Chu:Operation
    {
        public Chu(int n1, int n2)
            : base(n1, n2)
        { }

        public override int GetResult()
        {
            return this.NumberOne / this.NumberTwo;
        }
    }
}
