using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch  sw =new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000; i++)
            {
               new Thread(() =>
                 {
                      int i2 = 1 + 1;
                     
                    }).Start();
           }
           sw.Stop();
           Console.WriteLine(sw.Elapsed.TotalMilliseconds);


		  sw.Reset();
           sw.Restart();
           for (int i = 0; i < 1000; i++)
          {
              ThreadPool.QueueUserWorkItem(new WaitCallback(PoolCallBack), "sssss"+i);
               //ThreadPool.GetMaxThreads
           }
           sw.Stop();
           Console.WriteLine(sw.Elapsed.TotalMilliseconds);

           Console.ReadKey();
		  
        }
        private static void PoolCallBack(object state)
        {
            int i = 1 + 1;

        }
    }
}
