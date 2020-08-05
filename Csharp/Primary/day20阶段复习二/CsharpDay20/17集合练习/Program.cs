using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 集合练习1
            //案例：把分拣奇偶数的程序用泛型实现。int[] nums={1,2,3,4,5,6,7,8,9};奇数在左边 偶数在右边
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> listJi = new List<int>();
            //List<int> listOu = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        listOu.Add(nums[i]);
            //    }
            //    else
            //    {
            //        listJi.Add(nums[i]);
            //    }
            //}

            //listJi.AddRange(listOu);
            //foreach (var item in listJi)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey(); 
            #endregion




            #region 集合练习2
            //练习1：将int数组中的奇数放到一个新的int数组中返回。
            //将数组中的奇数取出来放到一个集合中，最终将集合转换成数组 。
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //List<int> listJi = new List<int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 != 0)
            //    {
            //        listJi.Add(nums[i]);
            //    }
            //}
            ////集合转换成数组
            //int[] numsNew = listJi.ToArray();
            //foreach (var item in numsNew)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            #endregion




            #region 集合练习3
            //练习2：从一个整数的List<int>中取出最大数（找最大值）。
            //集合初始化器
            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int max = list[0];
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] > max)
            //    {
            //        max = list[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.ReadKey();
            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //Console.ReadKey(); 
            //  list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //Person p = new Person("李四", 16, '女') { Name = "张三", Age = 19, Gender = '男' };
            //p.SayHello();
            //Console.ReadKey();
            #endregion




           
            #region 集合练习4
            //练习：把123转换为：壹贰叁。Dictionary<char,char>
            //"1一 2二 3三 4四 5五 6六 7七 8八 9九"
            //string str = "1一 2二 3三 4四 5五 6六 7七 8八 9九";
            ////123  一二三
            //Dictionary<char, char> dic = new Dictionary<char, char>();
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < strNew.Length; i++)
            //{
            //    //1一 strNew[i][0]  strNew[i][1]
            //    dic.Add(strNew[i][0], strNew[i][1]);
            //}

            //Console.WriteLine("请输入阿拉伯数字");
            //string input = Console.ReadLine();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (dic.ContainsKey(input[i]))
            //    {
            //        Console.Write(dic[input[i]]);
            //    }
            //    else
            //    {
            //        Console.Write(input[i]);
            //    }
            //}
            //Console.ReadKey(); 
            #endregion



            #region 集合练习5
            ////练习：计算字符串中每种字符出现的次数（面试题）。 “Welcome to Chinaworld”，不区分大小写，打印“W2”“e 2”“o 3”…… 

            //string s = "Welcome to Chinaworld";

            //Dictionary<char, int> dic = new Dictionary<char, int>();
            ////遍历 s  
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == ' ')
            //    {
            //        continue;
            //    }
            //    if (dic.ContainsKey(s[i]))
            //    {
            //        dic[s[i]]++;
            //    }
            //    else
            //    {
            //        dic[s[i]] = 1;
            //    }
            //}


            //foreach (KeyValuePair<char,int> kv in dic)
            //{
            //    Console.WriteLine("字母{0}出现了{1}次",kv.Key,kv.Value);
            //}
            //Console.ReadKey(); 
            #endregion


         
            #region 集合练习5
            //案例：两个（List）集合{ “a”,“b”,“c”,“d”,“e”}和{ “d”, “e”, “f”, “g”, “h” }，把这两个集合去除重复项合并成一个。
            //List<string> listOne = new List<string>() { "a", "b", "c", "d", "e" };
            //List<string> listTwo = new List<string>() { "d", "e", "f", "g", "h" };
            //for (int i = 0; i < listTwo.Count; i++)
            //{
            //    if (!listOne.Contains(listTwo[i]))
            //    {
            //        listOne.Add(listTwo[i]);
            //    }
            //}


            //foreach (var item in listOne)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey(); 
            #endregion
             
        }
    }

    public class Person
    {
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }

        public void SayHello()
        {
            Console.WriteLine("{0}---{1}---{2}", this.Name, this.Age, this.Gender);
        }
    }
}
