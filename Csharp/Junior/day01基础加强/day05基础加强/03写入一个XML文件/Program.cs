using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace _03写入一个XML文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //1、创建一个XML文档对象
            XmlDocument doc = new XmlDocument();
            //2、创建第一行描述信息
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            
            //3、将创建的第一行数据添加到文档中
            doc.AppendChild(dec);
            //4、给文档添加根节点
            XmlElement books = doc.CreateElement("Books");
            //5、将根节点添加给文档对象
            doc.AppendChild(books);

            //6、给根节点添加子节点
            XmlElement book1 = doc.CreateElement("Book");
            //将子节点book1添加到根节点下
            books.AppendChild(book1);
            

            //7、给book1添加子节点
            XmlElement bookName1 = doc.CreateElement("BookName");
            //8、设置标签中显示的文本
            bookName1.InnerText = "水浒传";
            book1.AppendChild(bookName1);

            

            XmlElement author1 = doc.CreateElement("Author");
            author1.InnerText = "<authorName>匿名</authorName>";
            book1.AppendChild(author1);

            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerXml = "<authorName>匿名</authorName>";
            book1.AppendChild(price1);

            XmlElement des1 = doc.CreateElement("Des");
            des1.InnerXml = "好看，顶！~！！！！";
            book1.AppendChild(des1);


            Console.WriteLine("保存成功");
            doc.Save("Book.xml");
            Console.ReadKey();
        }
    }
}
