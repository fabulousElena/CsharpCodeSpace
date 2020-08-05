using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace _5_追击XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //追加XML文档
            XmlDocument doc = new XmlDocument();
            XmlElement books;
            if (File.Exists("Books.xml"))
            {
                //如果文件存在 加载XML
                doc.Load("Books.xml");
                //获得文件的根节点
                books = doc.DocumentElement;
            }
            else
            {
                //如果文件不存在
                //创建第一行
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                //创建根节点
                books = doc.CreateElement("Books");
                doc.AppendChild(books);
                
            }
            //5、给根节点Books创建子节点
            XmlElement book1 = doc.CreateElement("Book");
            //将book添加到根节点
            books.AppendChild(book1);


            //6、给Book1添加子节点
            XmlElement name1 = doc.CreateElement("Name");
            name1.InnerText = "c#开发大全";
            book1.AppendChild(name1);

            XmlElement price1 = doc.CreateElement("Price");
            price1.InnerText = "110";
            book1.AppendChild(price1);
              
            XmlElement des1 = doc.CreateElement("Des");
            des1.InnerText = "看不懂";
            book1.AppendChild(des1);


            doc.Save("Books.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();

        }
    }
}
