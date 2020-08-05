using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13年月日转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //案例：编写一个函数进行日期转换，将输入的中文日期转换为阿拉伯数字日期，比如：二零一二年十二月二十一日要转换为2012-12-21。(处理“十”的问题：1.*月十日；2.*月十三日；3.*月二十三日；4.*月三十日；)4中情况对“十”的不同翻译。1→10；2→1；3→不翻译；4→0【年部分不可能出现’十’，都出现在了月与日部分。】  
            //测试数据：二零一二年十二月二十一日(2012年12月21日)、二零零九年七月九日、二零一零年十月二十四日、二零一零年十月二十日

            string str = "二零一零年十月二十日";//2012-12-21
            string ziDian = "零0 一1 二2 三3 四4 五5 六6 七7 八8 九9";
            //给集合添加数据
            Dictionary<char, char> dic = new Dictionary<char, char>();
            string[] temp = ziDian.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < temp.Length; i++)
            {
                dic.Add(temp[i][0], temp[i][1]);
            }
            string result = string.Empty;
            //翻译
            for (int i = 0; i < str.Length; i++)
            {
                
                if (dic.ContainsKey(str[i]))
                {
                    result += dic[str[i]];
                }
                else
                { 
                    //不包含 十  年月日
                    //如果是年月日

                  
                    if (str[i] == '十')
                    {
                        //1.*月十日；2.*月十三日；3.*月二十三日；4.*月三十日
                        if (!dic.ContainsKey(str[i - 1]) && !dic.ContainsKey(str[i + 1]))
                        {
                            result += "10";
                        }
                        else if (!dic.ContainsKey(str[i - 1]) && dic.ContainsKey(str[i + 1]))
                        {
                            result += "1";
                        }
                        else if (dic.ContainsKey(str[i - 1]) && dic.ContainsKey(str[i + 1]))
                        {

                        }
                        else
                        {
                            result += "0";
                        }
                    }
                    else
                    { 
                        //年月日
                        result += "-"; 
                    }
                }
            }
            result = result.TrimEnd('-');
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
