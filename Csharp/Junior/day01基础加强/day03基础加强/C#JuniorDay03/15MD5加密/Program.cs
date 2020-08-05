using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace _15MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //张三abc  abc123  明文保存

            string str = "123";
            //202cb962ac59075b964b07152d234b70
            //202cb962ac59075b964b07152d234b70
            //202cb962ac5975b964b7152d234b70
            //3244185981728979115075721453575112
            string md5Str = GetMd5(str);
            Console.WriteLine(md5Str);
            Console.ReadKey();
        }

        static string GetMd5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.Default.GetBytes(str);
            //开始加密 返回加密好的字节数组
            byte[] bufferMd5 = md5.ComputeHash(buffer);
            //转成字符串
            //string result = Encoding.Default.GetString(bufferMd5);
            //return result;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < bufferMd5.Length; i++)
            {
                sb.Append(bufferMd5[i].ToString("x2"));//x:表示将十进制转换为16进制
            }
            return sb.ToString();
        }
    }
}
