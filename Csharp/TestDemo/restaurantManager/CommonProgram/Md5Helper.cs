using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CommonProgram
{
    public partial class Md5Helper
    {
        public static string GetMd(string str)
        {
            //utf-8 x2加密  十六进制 两倍存储空间
            //创建对象的方法  直接new  直接点 也就是静态方法
            MD5 md5 = MD5.Create();
            byte[] byteOld = Encoding.UTF8.GetBytes(str);
            byte[] byteNew = md5.ComputeHash(byteOld);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteNew)
            {
                //字节转换为16进制表现的两倍字符串
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
