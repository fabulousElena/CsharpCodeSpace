using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08数组的5个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1
            ////练习1：从一个整数数组中取出最大的整数,最小整数,总和,平均值
            ////声明一个int类型的数组 并且随意的赋初值
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ////声明两个变量用来存储最大值和最小值
            //int max = int.MinValue;//nums[3];
            //int min = int.MaxValue;//nums[0];
            //int sum = 0;
            ////循环的让数组中的每个元素跟我的最大值、最小值进行比较

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    //关于在循环中nums[i]的理解方式
            //    //1、代表数组中当前循环到的元素
            //    //2、代表数组中的每个元素
            //    //如果数组中当前循环到的这个元素 比我的max还要大，则把当前这个元素赋值给我的max
            //    if (nums[i] > max)
            //    {
            //        max = nums[i];
            //    }

            //    if (nums[i] < min)
            //    {
            //        min = nums[i];
            //    }
            //    sum += nums[i];
            //}
            //Console.WriteLine("这个数组的最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}", max, min, sum, sum / nums.Length);
            //Console.ReadKey(); 
            #endregion



            //练习3:数组里面都是人的名字,分割成:例如:老杨|老苏|老邹…”
            //(老杨,老苏,老邹,老虎,老牛,老蒋,老王,老马)

            //string[] names = { "老杨", "老苏", "老邹", "老虎", "老牛", "老马" };
            ////老杨|老苏|老邹|老虎|老牛|老马
            ////解体思路：通过一个循环，获得字符串数组中的每一个元素。
            ////然后，将这个每一个元素都累加到一个字符串中，以|分割
            //string str=null;//""
            //for (int i = 0; i < names.Length-1; i++)
            //{
            //    str += names[i]+"|";
            //}
            //Console.WriteLine(str+names[names.Length-1]);
            //Console.ReadKey();


            #region 练习4
            //练习4：将一个整数数组的每一个元素进行如下的处理：
            //如果元素是正数则将这个位置的元素的值加1，
            //如果元素是负数则将这个位置的元素的值减1,如果元素是0,则不变。

            //int[] nums = { 1, -2, 3, -4, 5, 6, 0 };
            ////解题思路：通过一个循环，获得数组中的每一个元素。
            ////对每一个元素进行判断
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > 0)
            //    {
            //        nums[i] += 1;
            //    }
            //    else if (nums[i] < 0)
            //    {
            //        nums[i] -= 1;
            //    }
            //    else
            //    {
            //        //nums[i] = 0;
            //    }
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();

            #endregion



            //练习5：将一个字符串数组的元素的顺序进行反转。{“我”,“是”,”好人”} {“好人”,”是”,”我”}。第i个和第length-i-1个进行交换。
            string[] names = { "a", "b", "c", "d", "e", "f", "g" };
            for (int i = 0; i < names.Length / 2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = temp;
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();


            //{"好人","是","我"};
        }
    }
}
