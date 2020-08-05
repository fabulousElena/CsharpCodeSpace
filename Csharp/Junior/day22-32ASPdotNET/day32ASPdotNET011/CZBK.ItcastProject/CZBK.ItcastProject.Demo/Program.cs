using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.ItcastProject.Demo
{
   // public delegate  int SumAdd(int a,int b);
    class Program
    {
        static void Main(string[] args)
        {
            //Func<>
            //Action<>

           // Program p = new Program();
           // SumAdd sumAdd = new SumAdd(p.AddSum);
           //int sum=sumAdd(6, 3);
           //Console.WriteLine(sum);
           //Console.ReadKey();
            //Process[] ps=Process.GetProcesses();
            //foreach (Process p in ps)
            //{
            //    Console.WriteLine(p.ProcessName);
            //   // p.Kill();
            //}

         // Process p=  Process.GetCurrentProcess();
          //Console.WriteLine(p.ProcessName);
            
            Process.Start("notepad.exe");
            Console.ReadKey();
        }
        public int AddSum(int a, int b)
        {
            return a + b;
        }
    }
  
}
