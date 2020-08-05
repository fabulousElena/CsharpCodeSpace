using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10键值对集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1壹 2贰 3叁 4肆 5伍 6陆 7柒 8捌 9玖 0零";
            //输入小写---->大写形式
            Dictionary<char, char> dic = new Dictionary<char, char>();

            string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //给dic集合添加数据
            for (int i = 0; i < strNew.Length; i++)
            {
                dic.Add(strNew[i][0], strNew[i][1]);
            }
            Console.WriteLine("请输入小写，我们将转换成大写");
            string input = Console.ReadLine();
            //123123  乱七八糟abc
            for (int i = 0; i < input.Length; i++)
            {
                if (dic.ContainsKey(input[i]))
                {
                    Console.Write(dic[input[i]]);
                }
                else
                {
                    Console.Write(input[i]);
                }
            }


            //案例：编写一个函数进行日期转换，将输入的中文日期转换为阿拉伯数字日期，比如：二零一二年十二月二十一日要转换为2012-12-21。(处理“十”的问题：1.*月十日；2.*月十三日；3.*月二十三日；4.*月三十日；)4中情况对“十”的不同翻译。1→10；2→1；3→不翻译；4→0【年部分不可能出现’十’，都出现在了月与日部分。】//测试数据：二零一二年十二月二十一日(2012年12月21日)、二零零九年七月九日、二零一零年十月二十四日、二零一零年十月二十日

            Console.ReadKey();

        }
    }
}
