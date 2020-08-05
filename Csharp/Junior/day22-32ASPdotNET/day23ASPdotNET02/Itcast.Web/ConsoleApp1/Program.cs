using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string htmlUrl = "<input type=\"text\" value=\"{0}\"/><br />姓名<input type=\"text\" value=\"{1}\"/><br />年龄<input type=\"text\" value=\"{2}\"/><br />是猪吗<input type=\"text\" value=\"{3}\"/><br />时间<input type=\"text\" value=\"{4}\"/><br />小作文<textarea rows=\"20\" cols=\"200\">{5}</textarea>";

            Console.WriteLine(htmlUrl);
            Console.ReadKey();
        }
    }
}
