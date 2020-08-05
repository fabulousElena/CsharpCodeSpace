using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01方法的练习02
{
    class Program
    {

        // 用方法实现： 计算一个整数数组的平均值，保留两位小数
        static void Main(string[] args)
        {
            int[] arr = { 1,1,1,1,1,5};
            GetAvg(arr);
            Console.ReadKey();
        }

        public static void GetAvg(int[] arr)
        {
            double sum = 0;
            double[] dou = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                dou[i] = arr[i];
                sum = sum + dou[i];
            }

            double avg = sum / arr.Length;
            Console.Write(arr + "数组的平均值" );
            Console.WriteLine("是{0:0.00}",avg);
        }
    }
}
