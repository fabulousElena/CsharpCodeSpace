using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace _03创建XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过代码来创建XML文档
            //1、引用命名空间
            //2、创建XML文档对象
            XmlDocument doc = new XmlDocument();
            
            //3、创建第一个行描述信息，并且添加到doc文档中
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            //4、创建根节点
            XmlElement books = doc.CreateElement("Books");
            //将根节点添加到文档中
            doc.AppendChild(books);       

            //5、给根节点Books创建子节点
            XmlElement book1 = doc.CreateElement("Book");
            //将book添加到根节点
            books.AppendChild(book1);


            //6、给Book1添加子节点
            XmlElement name1 = doc.CreateElement("Name");
            name1.InnerText = "12dsadad3";
            book1.AppendChild(name1);

            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerText = "10";
            book1.AppendChild(price1);

            XmlElement des1 = doc.CreateElement("Des");
            des1.InnerText = "好看";
            book1.AppendChild(des1);

            XmlElement book2 = doc.CreateElement("Book");
            books.AppendChild(book2);


            XmlElement name2 = doc.CreateElement("Name");
            name2.InnerText = "dddd";
            book2.AppendChild(name2);

            XmlElement price2= doc.CreateElement("Price");
            price2.InnerText = "10";
            book2.AppendChild(price2);

            XmlElement des2 = doc.CreateElement("Des");
            des2.InnerText = "好看";
            book2.AppendChild(des2);

            doc.Save("Books.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();
        }
    }
}
