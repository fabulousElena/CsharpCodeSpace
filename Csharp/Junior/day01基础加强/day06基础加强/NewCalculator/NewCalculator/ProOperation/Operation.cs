using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProOperation
{
    public abstract class Operation    {        public int numberOne { get; set; }        public int numberTwo { get; set; }        public Operation(int n1, int n2)
        {            this.numberOne = n1;            this.numberTwo = n2;        }
        /// <summary>        /// 计算子类的计算类型  +— */        /// </summary>        public abstract string Type { get; }
        /// <summary>        /// 获得计算结果        /// </summary>        /// <returns></returns>        public abstract int GetResult();    }

}
