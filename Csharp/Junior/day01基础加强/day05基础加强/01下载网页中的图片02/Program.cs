using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _01下载网页中的图片02
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient web = new WebClient();
            //string s =  web.DownloadString("https://www.pixiv.net/ranking.php?mode=daily&content=illust&date=20200723");
            web.DownloadFile("https://huazhi-1301084657.cos.ap-guangzhou.myqcloud.com/wp-content/uploads/2020/07/Snipaste_2020-07-12_20-31-39.png", @"D:\asd.png");
            Console.ReadKey();
        }
    }
}
