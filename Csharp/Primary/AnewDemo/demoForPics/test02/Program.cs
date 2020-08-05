using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test02
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "[00:36.073]";
            string[] s2 = s.Split(new char[] { '[', ']' });
            string[] s3 = s2[1].Split(':');

            double nb = double.Parse(s3[0]) * 60 + double.Parse(s3[1]); 
            Console.WriteLine(nb);
            Console.ReadKey();
        }
    }
}
