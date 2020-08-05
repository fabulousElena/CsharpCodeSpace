using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace _05文档对象模型
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { ID = 1, Name = "yhb", Gender = '男', Age = 30 });
            list.Add(new Student() { ID = 2, Name = "wl", Gender = '女', Age = 20 });
            list.Add(new Student() { ID = 3, Name = "刘德华", Gender = '男', Age = 50 });
            list.Add(new Student() { ID = 4, Name = "张学友", Gender = '男', Age = 60 });
            list.Add(new Student() { ID = 5, Name = "哥哥", Gender = '男', Age = -10 });


            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);

            doc.AppendChild(dec);


            XmlElement person = doc.CreateElement("Person");
            doc.AppendChild(person);

            //通过循环List集合，获得所有对象 以节点的形式添加到XML文档中
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement student = doc.CreateElement("Student");
                student.SetAttribute("studentID", list[i].ID.ToString());
                XmlElement name = doc.CreateElement("Name");
                name.InnerXml = list[i].Name;
                XmlElement age = doc.CreateElement("Age");
                age.InnerXml = list[i].Age.ToString();
                XmlElement gender = doc.CreateElement("Gender");
                gender.InnerXml = list[i].Gender.ToString();
                //添加
                person.AppendChild(student);
                student.AppendChild(name);
                student.AppendChild(age);
                student.AppendChild(gender);


            }

            doc.Save("Student.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();

        }
    }

    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public char Gender { get; set; }
    }
}
