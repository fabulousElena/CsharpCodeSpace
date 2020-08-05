using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
namespace _06对xml文档实现增删改查
{
    class Program
    {
        static void Main(string[] args)
        {
            //XMLDocument
            #region 对xml文档实现追加的需求
            //XmlDocument doc = new XmlDocument();
            ////首先判断xml文档是否存在 如果存在 则追加  否则创建一个
            //if (File.Exists("Student.xml"))
            //{
            //    //加载进来
            //    doc.Load("Student.xml");
            //    //追加
            //    //获得根节点 给根节点添加子节点
            //    XmlElement person = doc.DocumentElement;

            //    XmlElement student = doc.CreateElement("Student");
            //    student.SetAttribute("studentID", "10");
            //    person.AppendChild(student);

            //    XmlElement name = doc.CreateElement("Name");
            //    name.InnerXml = "我是新来哒";
            //    student.AppendChild(name);

            //    XmlElement age = doc.CreateElement("Age");
            //    age.InnerXml = "18";
            //    student.AppendChild(age);

            //    XmlElement gender = doc.CreateElement("Gender");
            //    gender.InnerXml = "女";
            //    student.AppendChild(gender);

            //}
            //else
            //{
            //    //不存在

            //    XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            //    doc.AppendChild(dec);

            //    XmlElement person = doc.CreateElement("Person");
            //    doc.AppendChild(person);


            //    XmlElement student = doc.CreateElement("Student");
            //    student.SetAttribute("studentID", "110");
            //    person.AppendChild(student);

            //    XmlElement name = doc.CreateElement("Name");
            //    name.InnerXml = "张三三李思思";
            //    student.AppendChild(name);

            //    XmlElement age = doc.CreateElement("Age");
            //    age.InnerXml = "28";
            //    student.AppendChild(age);

            //    XmlElement gender = doc.CreateElement("Gender");
            //    gender.InnerXml = "男";
            //    student.AppendChild(gender);
            //}

            //doc.Save("Student.xml");
            //Console.WriteLine("保存成功"); 
            #endregion


            #region 读取XML文档
            //XmlDocument doc = new XmlDocument();

            //doc.Load("OrDER.xml");

            ////还是 先获得根节点
            //XmlElement order = doc.DocumentElement;
            ////获得根节点下面的所有子节点
            //XmlNodeList xnl = order.ChildNodes;

            //foreach (XmlNode item in xnl)
            //{
            //    Console.WriteLine(item.InnerText);
            //}
            //XmlElement items = order["Items"];
            //XmlNodeList xnl2 = items.ChildNodes;
            //foreach (XmlNode item in xnl2)
            //{
            //    Console.WriteLine(item.Attributes["Name"].Value);
            //    Console.WriteLine(item.Attributes["Count"].Value);

            //    if (item.Attributes["Name"].Value == "手套")
            //    {
            //        item.Attributes["Count"].Value = "新来哒";
            //    }
            //}

            //doc.Save("OrDER.xml"); 
            #endregion



            #region 使用XPath的方式来读取XML文件


            //XmlDocument doc = new XmlDocument();
            //doc.Load("order.xml");
            ////获得根节点
            //XmlElement order = doc.DocumentElement;
            //XmlNode xn = order.SelectSingleNode("/Order/Items/OrderItem[@Name='雨衣']");

            ////Console.WriteLine(xn.Attributes["Name"].Value);

            //xn.Attributes["Count"].Value = "woshi new";


            //doc.Save("order.xml");
            //Console.WriteLine("保存成功");
            #endregion



            XmlDocument doc = new XmlDocument();

            doc.Load("order.xml");


            //doc.RemoveAll();不行 根节点不允许删除

            XmlElement order = doc.DocumentElement;

            //order.RemoveAll();移除根节点下的所有子节点

           // XmlNode xn = order.SelectSingleNode("/Order/Items/OrderItem[@Name='雨衣']");


           // //让orderItem去删除属性
           // XmlNode orderItem = order.SelectSingleNode("/Order/Items/OrderItem");

           // //获得Items节点

           // //XmlNode items = order["Items"];//order.SelectSingleNode("/Order/Items");

            
           //// items.RemoveChild(xn);移除当前节点
            
           // //orderItem.RemoveAttributeNode(xn.Attributes["Count"]);

           // xn.Attributes.RemoveNamedItem("Count");

           // doc.Save("order.xml");
           // Console.WriteLine("删除成功");
           // Console.ReadKey();


            //XPath
        }
    }
}
