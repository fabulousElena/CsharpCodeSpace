using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10键值对集合
{
    class Program
    {

        static void Main(string[] args)
        {
            //创建了一个键值对集合对象
            Hashtable ht = new Hashtable
            {
                { 1, "张三" },
                { 2, true },
                { 3, '男' },
                { false, "错误的" },
                { 5, "张三" }
            };
            ht[6] = "新来的";//这也是一种添加数据的方式
            ht[1] = "把张三干掉";
            ht.Add("abc", "cba");

            //abc----cba
            if (!ht.ContainsKey("abc"))
            {
                //ht.Add("abc", "哈哈哈");
                ht["abc"] = "哈哈哈";
            }
            else
            {
                Console.WriteLine("已经包含abc这个键！！！");
            }


           // ht.Clear(); //移除集合中所有的元素
            ht.Remove(3);

            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键是-----{0}==============值是{1}", item, ht[item]);
            }
            //在键值对集合中 是根据键去找值的
            //Console.WriteLine(ht[1]);
            //Console.WriteLine(ht[2]);
            //Console.WriteLine(ht[3]);
            //Console.WriteLine(ht[false]);
            //Console.WriteLine("==================================");
            //for (int i = 0; i < ht.Count; i++)
            //{
            //    Console.WriteLine(ht[i]);
            //}
            Console.ReadKey();
        }
    }
}
