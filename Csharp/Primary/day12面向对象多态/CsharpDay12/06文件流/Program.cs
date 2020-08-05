using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06文件流
{
    class Program
    {
        static void Main(string[] args)
        {

            ////使用FileStream来读取数据              路径        文件模式：打开或创建    处理数据：读取
            //FileStream fsRead = new FileStream(@"D:\a.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 5];
            ////3.8M  5M
            ////返回本次实际读取到的有效字节数  r
            ////                 字节数组  从哪儿读   最多读的长度  
            //int r = fsRead.Read(buffer,    0,     buffer.Length);
            ////将字节数组中每一个元素按照指定的编码格式解码成字符串
            ////                                      解码这个   从0开始  解码R个
            //string s = Encoding.Default.GetString(buffer,      0,       r );
            ////关闭流
            //fsRead.Close();
            ////释放流所占用的资源
            //fsRead.Dispose();
            //Console.WriteLine(s);
            //Console.WriteLine(r);
            //Console.ReadKey();



            //使用FileStream来写入数据
            using (FileStream fsWrite = new FileStream(@"D:\a.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = "看我游牧又把你覆盖掉";
                byte[] buffer = Encoding.Default.GetBytes(str);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            Console.WriteLine("写入OK");
            Console.ReadKey();
        }
    }
}
