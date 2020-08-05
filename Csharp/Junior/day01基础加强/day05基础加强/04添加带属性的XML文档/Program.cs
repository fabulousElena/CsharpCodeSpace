using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace _04添加带属性的XML文档
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);

            XmlElement order = doc.CreateElement("Order");
            doc.AppendChild(order);

            XmlElement customerName = doc.CreateElement("CustomerName");
            customerName.InnerXml = "刘洋";
            order.AppendChild(customerName);

            XmlElement orderNumber = doc.CreateElement("OrderNumber");
            orderNumber.InnerXml = "10000";
            order.AppendChild(orderNumber);


            XmlElement items = doc.CreateElement("Items");
            order.AppendChild(items);


            XmlElement orderItem1 = doc.CreateElement("OrderItem");
            orderItem1.SetAttribute("Name", "码表");
            orderItem1.SetAttribute("Count", "100001");
            items.AppendChild(orderItem1);

            XmlElement orderItem2 = doc.CreateElement("OrderItem");
            orderItem2.SetAttribute("Name", "雨衣");
            orderItem2.SetAttribute("Count", "1");
            items.AppendChild(orderItem2);



            doc.Save("Order.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();
        }
    }
}
