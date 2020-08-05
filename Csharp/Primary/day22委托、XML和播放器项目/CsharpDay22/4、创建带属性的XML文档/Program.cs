using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace _4_创建带属性的XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8","yes");
            doc.AppendChild(dec);

            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);

            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerXml = "<p>我是一个p标签</p>";
            order.AppendChild(customerName);

            XmlElement customerNumber = doc.CreateElement("CustomerNumber");
            customerNumber.InnerText = "<p>我是一个p标签</p>";
            order.AppendChild(customerNumber);
              

            XmlElement items = doc.CreateElement("Items");
            order.AppendChild(items);

            XmlElement orderItem1 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem1.SetAttribute("Name", "充气娃娃");
            orderItem1.SetAttribute("Count", "10");
            items.AppendChild(orderItem1);

            XmlElement orderItem2 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem2.SetAttribute("Name", "充气娃娃");
            orderItem2.SetAttribute("Count", "10");
            items.AppendChild(orderItem2);

            XmlElement orderItem3 = doc.CreateElement("OrderItem");
            //给节点添加属性
            orderItem3.SetAttribute("Name", "充气娃娃");
            orderItem3.SetAttribute("Count", "10");
            items.AppendChild(orderItem3);

            doc.Save("Order.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();

            
        }
    }
}
