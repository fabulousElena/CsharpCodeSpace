using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _11字符串的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //课上练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba“.
            //string str = "abcdef";//fedcba
            ////将str转换成char数组
            //char[] chs = str.ToCharArray();
            ////翻转char数组
            //for (int i = 0; i < chs.Length / 2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length - 1 - i];
            //    chs[chs.Length - 1 - i] = temp;
            //}
            ////将改变后的char数组重新变回字符串
            //str = new string(chs);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //课上练习2：接收用户输入的一句英文，将其中的单词以反序输出。      “I love you"→“I evol uoy"
            //string str = "Chinese food is best food";
            ////获得要翻转的单词 按照空格分割
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strNew.Length; i++)
            //{
            //    char[] chs = strNew[i].ToCharArray();
            //    for (int j = 0; j < chs.Length / 2; j++)
            //    {
            //        char temp = chs[j];
            //        chs[j] = chs[chs.Length - 1 - j];
            //        chs[chs.Length - 1 - j] = temp;
            //    }

            //    strNew[i] = new string(chs);
            //}
            ////把空格安插到字符串数组中每个元素的后面
            //str = string.Join(" ", strNew);
            //Console.WriteLine(str);
            //Console.ReadKey();


            //课上练习3：”2012年12月21日”从日期字符串中把年月日分别取出来，打印到控制台

            // string date = "2012年12月21日";

            //string[] newDate = date.Split(new char[] { '年', '月', '日' }, StringSplitOptions.RemoveEmptyEntries);

            //Console.WriteLine("{0}年{1}月{2}日",newDate[0],newDate[1],newDate[2]);
            //Console.ReadKey();

            //课上练习4：把csv文件中的联系人姓名和电话显示出来。简单模拟csv文件，csv文件就是使用,分割数据的文本,输出：


            //string[] lines = File.ReadAllLines(@"C:\Users\SpringRain\Desktop\电话.txt", Encoding.Default);
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    //将双引号替换成""
            //    lines[i] = lines[i].Replace("\"", "");
            //    //将逗号和分号去掉
            //    string[] linesNew = lines[i].Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            //    Console.WriteLine("姓名：" + linesNew[0] + linesNew[1] + " 电话:" + linesNew[2]);
            //}




            //练习5：123-456---7---89-----123----2把类似的字符串中重复符号”-”去掉，既得到123-456-7-89-123-2. split()、

            //string str = "123-456---7---89-----123----2";

            //string[] strNew = str.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

            //Console.WriteLine(string.Join("-", strNew));
            //Console.ReadKey();

            //c:\aewqq\beqewq.txt

            //string str = @"c:\aewqq\beqewq.txt";
            //int index = str.LastIndexOf("\\");

            //string fileName = str.Substring(index + 1);
            //Console.WriteLine(fileName);



            //练习7：“192.168.10.5[port=21,type=ftp]”，这个字符串表示IP地址为192.168.10.5的服务器的21端口提供的是ftp服务，其中如果“,type=ftp”部分被省略，则默认为http服务。请用程序解析此字符串，然后打印出“IP地址为***的服务器的***端口提供的服务为***” line.Contains(“type=”)。192.168.10.5[port=21]
            string str = "192.168.10.5[port=23341,type=http]";//192.168.10.5[port=21]
            string ip = string.Empty;
            string port = string.Empty;
            string type = string.Empty;
            if (str.Contains("type"))
            {
                //获得第一次[出现的位置 截取IP地址
                int index1 = str.IndexOf("[");
                ip = str.Substring(0, index1);
                //获得=号第一次出现的位置
                int index2 = str.IndexOf("=");
                //获得逗号出现的位置
                int index3 = str.IndexOf(",");
                port = str.Substring(index2 + 1, index3 - index2 - 1);
                //获得最后一次=号出现的位置
                int index4 = str.LastIndexOf("=");
                //获得]出现的位置
                int index5 = str.IndexOf("]");
                type = str.Substring(index4 + 1, index5 - index4 - 1);
                Console.WriteLine(type);
            }
            else
            {

            }

            Console.ReadKey();

        }
    }
}
