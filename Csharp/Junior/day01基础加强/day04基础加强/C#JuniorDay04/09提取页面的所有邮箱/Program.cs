using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace _09提取页面的所有邮箱
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient web = new WebClient();
            //UTF-8
            //string html = web.DownloadString(@"C:\Users\SpringRain\Desktop\大家留下email交友吧_email_天涯部落.html");

            byte[] buffer = web.DownloadData(@"C:\Users\SpringRain\Desktop\大家留下email交友吧_email_天涯部落.html");

            string html = Encoding.UTF8.GetString(buffer);


            MatchCollection mc = Regex.Matches(html, @"[0-9a-zA-Z]+@\w+(\.[a-zA-Z]+){1,2}");

            foreach (Match item in mc)
            {
                if (item.Success)
                {
                    Console.WriteLine(item.Value);
                }
            }

            //Console.WriteLine(html);
            Console.ReadKey();

            // <a href="http://bj.58.com/zpguanggao/21441295472910x.shtml" target="_blank" class="t" _t="jingpin">诚招婚礼策划师</a>	  

            //                                                                                                                                <a href="http://bj.58.com/zpguanggao/21187154058888x.shtml" target="_blank" class="t" _t="jingpin">修片师</a>

            // <a href="http://qy.58.com/3085395953671/" target="_blank" class="fl" title="京宇轩健康科技有限公司">京宇轩健康科技有限公司</a>
        }
    }
}
