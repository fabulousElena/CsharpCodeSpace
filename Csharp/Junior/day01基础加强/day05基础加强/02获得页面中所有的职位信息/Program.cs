using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace _02获得页面中所有的职位信息
{
    class Program
    {
        static void Main(string[] args)
        {
            //<a.+?_t=.+?>.+?</a>

            WebClient web = new WebClient();

            byte[] buffer = web.DownloadData(@"C:\Users\SpringRain\Desktop\北京婚礼策划招聘_北京婚礼策划师招聘_北京招聘婚礼策划师助理-北京58同城.html");


            string html = Encoding.UTF8.GetString(buffer);

            MatchCollection mc = Regex.Matches(html, "<a.+?_t=.+?>(?<work>.+?)</a>");
            int i = 0;
            foreach (Match item in mc)
            {
                if (item.Success)
                {
                    i++;
                    Console.WriteLine(item.Groups["work"].Value);
                }
            }
            Console.WriteLine(i);
            Console.ReadKey();
            

        }
    }
}
