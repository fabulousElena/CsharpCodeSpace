using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02关键字的用法
{
    class Program
    {
        static void Main(string[] args)
        {
            //partial
        }
    }

    /// <summary>
    /// 密封类
    /// </summary>
    public sealed class Teacher:Person
    {

    }
    

    public partial class Person
    {
        private string _name;
    }

    public partial class Person
    {
        public void T()
        {
            //   _name;
        }
    }
}
