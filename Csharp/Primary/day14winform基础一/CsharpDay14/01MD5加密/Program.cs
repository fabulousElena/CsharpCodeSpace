using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _01MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //woaini  woaini
            //202cb962ac59075b964b07152d234b70
           // string s = GetMD5("123");
            //202cb962ac59075b964b07152d234b70
            //202cb962ac59075b964b07152d234b70
            //202cb962ac5975b964b7152d234b70
            //3244185981728979115075721453575112
            //Console.WriteLine(s);
            //Console.ReadKey();
            //double n = 123.456;
            //Console.WriteLine(n.ToString("C"));
            //Console.ReadKey();
        }

        public static string GetMD5(string str)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //开始加密
            //需要将字符处转换成字节数组
            byte[] buffer = Encoding.GetEncoding("GBK").GetBytes(str);
            //返回一个加密好的字节数组
            byte[] MD5Buffer = md5.ComputeHash(buffer);

            //将字节数组转换成字符串
            //字节数组--->字符串
            //1将字节数组中每个元素按照指定的编码格式解析成字符串   //return Encoding.GetEncoding("GBK").GetString(MD5Buffer);
            //2直接将数组ToString();
            //3将字节数组中的每个元素ToString()


            // 189 273 345 我爱你
            // 189 273 345
            string strNew = "";
            for (int i = 0; i < MD5Buffer.Length; i++)
            {
                //                               把十进制转换为16进制
                strNew += MD5Buffer[i].ToString("x2");
            }
            return strNew;
        }
    }
}
