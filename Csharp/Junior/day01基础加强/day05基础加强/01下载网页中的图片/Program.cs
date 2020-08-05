using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace _01下载网页中的图片
{
    class Program
    {
        static void Main(string[] args)
        {
            //WebClient web = new WebClient();
            //string html = web.DownloadString("http://car.autohome.com.cn/photolist/series/3589/15/p1/?pvareaid=101197");

            //MatchCollection mc = Regex.Matches(html, @"<img.+?(?<picSrc>http://car\d\..+?\.jpg).+?>");
            //int i=0;
            //foreach (Match item in mc)
            //{
            //    if (item.Success)
            //    {
            //        i++;
            //        //Console.WriteLine(item.Value);
            //        Console.WriteLine(item.Groups["picSrc"].Value);
            //        //获得原路径
            //        string src=item.Groups["picSrc"].Value;
            //        //下载到电脑上的路径
            //        string target=@"C:\Users\SpringRain\Desktop"+"\\"+i+".jpg";
            //        //开始下载
            //        web.DownloadFile(src, target);
            //    }
            //}
            //Console.WriteLine("下载成功！！！！");
            Console.ReadKey();

        }
    }
}
