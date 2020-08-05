using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
namespace _08判断是否登陆成功
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        //存储XML文档中读取出来的对象
        List<Student> list = new List<Student>();
        private void Form1_Load(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();

            doc.Load("person.xml");

            //获得根节点
            XmlElement person = doc.DocumentElement;
            //获得根节点下面的所有子节点
            XmlNodeList xnl = person.ChildNodes;

            //遍历xnl这个节点集合 将xml中的数据读取出来 赋值给List泛型集合
            foreach (XmlNode item in xnl)
            {
                int id = Convert.ToInt32(item.Attributes["studentID"].Value);
                string name = item["Name"].InnerText;
                int age = Convert.ToInt32(item["Age"].InnerText);
                char gender = Convert.ToChar(item["Gender"].InnerText);

                Student student = new Student();

                student.Name = name;
                student.Age = age;
                student.ID = id;
                student.Gender = gender;
                //把对象添加给泛型集合
                list.Add(student);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            int age = Convert.ToInt32(txtAge.Text.Trim());
            int id = Convert.ToInt32(txtID.Text.Trim());
            //获得选中的单选按钮的文本
            char gender = rdoMan.Checked ? '男' : '女';
            //创建登陆的学员对象
            Student loginStudent = new Student();
            loginStudent.Name = name;
            loginStudent.Age = age;
            loginStudent.Gender = gender;
            loginStudent.ID = id;
            bool isLogin = false;

            //拿登陆对象去跟集合中的每一个对象进行比较
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(loginStudent))
                {
                    MessageBox.Show("登陆成功");
                    isLogin = true;
                }
            }

            if (isLogin == false)
            {
                MessageBox.Show("登陆失败");
            }

        }
    }
}
