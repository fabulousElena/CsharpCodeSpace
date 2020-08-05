using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProOperation;

namespace ProAdd
{
    public class Add : Operation
    {
        public Add(int n1, int n2) : base(n1, n2) { }


        public override string Type
        {
            get { return "+"; }
        }

        public override int GetResult()
        {
            return this.numberOne + this.numberTwo;
        }
    }
}
