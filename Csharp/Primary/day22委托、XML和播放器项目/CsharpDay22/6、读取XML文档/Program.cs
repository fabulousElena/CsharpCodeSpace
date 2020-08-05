using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace _6_读取XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlDocument doc = new XmlDocument();
            ////加载要读取的XML
            //doc.Load("Books.xml");

            ////获得根节点
            //XmlElement books = doc.DocumentElement;

            ////获得子节点 返回节点的集合
            //XmlNodeList xnl = books.ChildNodes;

            //foreach (XmlNode item in xnl)
            //{
            //    Console.WriteLine(item.InnerText);
            //}
            //Console.ReadKey();


            //读取带属性的XML文档

            //XmlDocument doc = new XmlDocument();
            //doc.Load("Order.xml");

            //Xpath

            //XmlDocument doc = new XmlDocument();
            //doc.Load("Order.xml");
            //XmlNodeList xnl = doc.SelectNodes("/Order/Items/OrderItem");

            //foreach (XmlNode node in xnl)
            //{
            //    Console.WriteLine(node.Attributes["Name"].Value);
            //    Console.WriteLine(node.Attributes["Count"].Value);
            //}
            //Console.ReadKey();
            //改变属性的值
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Order.xml");
            //XmlNode xn = doc.SelectSingleNode("/Order/Items/OrderItem[@Name='190']");
            //xn.Attributes["Count"].Value = "200";
            //xn.Attributes["Name"].Value = "颜世伟";
            //doc.Save("Order.xml");
            //Console.WriteLine("保存成功");




            XmlDocument doc = new XmlDocument();

            doc.Load("Order.xml");

            XmlNode xn = doc.SelectSingleNode("/Order/Items");

            xn.RemoveAll();
            doc.Save("Order.xml");
            Console.WriteLine("删除成功");
            Console.ReadKey();

            ////获得文档的根节点
            //XmlElement order = doc.DocumentElement;
            //XmlNodeList xnl = order.ChildNodes;
            //foreach (XmlNode item in xnl)
            //{
            //    ////如果不是Items 就continue
            //    //if (item[])
            //    //{
            //    //    continue;
            //    //}
            //    Console.WriteLine(item.Attributes["Name"].Value);
            //    Console.WriteLine(item.Attributes["Count"].Value);
            //}
            Console.ReadKey();
        }
    }
}
