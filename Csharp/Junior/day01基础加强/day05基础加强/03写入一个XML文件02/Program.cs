using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03写入一个XML文件02
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.1", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement book = doc.CreateElement("BOOKS");
            doc.AppendChild(book);

            XmlElement b1 = doc.CreateElement("芜湖起飞");
            book.AppendChild(b1);

            XmlElement b1Auther = doc.CreateElement("Auther");
            b1Auther.InnerText = "伍兹不行";
            b1.AppendChild(b1Auther);

            XmlElement b1year = doc.CreateElement("Year");
            b1year.InnerText = "2020-07-20";
            b1.AppendChild(b1year);

            XmlElement b1Detail = doc.CreateElement("Detail");
            b1Detail.SetAttribute("Cap1", "少妇白洁");
            b1Detail.SetAttribute("Cap2", "少年阿宾");
            b1Detail.SetAttribute("Cap3", "阿斌爱上了白洁");
            b1.AppendChild(b1Detail);

            doc.Save("tt.xml");
        }
    }
}
