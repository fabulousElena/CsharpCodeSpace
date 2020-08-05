using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
namespace _09使用XML实现增删改查
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        //加载数据
        void LoadData()
        {

            dataGridView1.RowHeadersVisible = false;//取消显示第一列
            //将选项模式改为选中一整行
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //取消选中第一行


            //存储对象的集合
            List<User> listUser = new List<User>();

            //开始读取数据 赋值给集合中的对象

            XmlDocument doc = new XmlDocument();
            doc.Load("haodongxi.xml");

            //获得根节点
            XmlElement users = doc.DocumentElement;

            //获得根节点下面的所有子节点

            XmlNodeList xnl = users.ChildNodes;

            foreach (XmlNode item in xnl)
            {
                //将从XML文档中读取到的数据赋值给集合中对象的属性
                listUser.Add(new User() { ID = Convert.ToInt32(item.Attributes["id"].Value), Name = item["name"].InnerText, Age = Convert.ToInt32(item["age"].InnerText), Gender = Convert.ToChar(item["gender"].InnerText), Password = item["password"].InnerText });
            }

            //将数据赋值给DataGridView
            dataGridView1.DataSource = listUser;

            //取消选中行
            dataGridView1.ClearSelection();
        }


        //注册
        private void btnOk_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("haodongxi.xml");

            //获得根节点
            XmlElement users = doc.DocumentElement;
            //新添加的子节点
            XmlElement user = doc.CreateElement("user");
            user.SetAttribute("id", txtID.Text.Trim());
            users.AppendChild(user);

            XmlElement name = doc.CreateElement("name");
            name.InnerText = txtName.Text.Trim();
            user.AppendChild(name);

            XmlElement age = doc.CreateElement("age");
            age.InnerText = txtAge.Text.Trim();
            user.AppendChild(age);

            XmlElement gender = doc.CreateElement("gender");
            gender.InnerText = rdoMan.Checked ? "男" : "女";
            user.AppendChild(gender);

            XmlElement password = doc.CreateElement("password");
            password.InnerText = txtPwd.Text;
            user.AppendChild(password);

            doc.Save("haodongxi.xml");
            //进入到DataGridView中
            LoadData();
            MessageBox.Show("注册成功");
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //删除指定的行数据
            //获得到当前选中行的ID
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            //根据id进行删除
            XmlDocument doc = new XmlDocument();
            doc.Load("haodongxi.xml");
            XmlElement users = doc.DocumentElement;
            //获得要删除的节点
            XmlNode xn = users.SelectSingleNode("/Users/user[@id='" + id + "']");

            users.RemoveChild(xn);//移除子节点，包括子节点下面的子节点
            // xn.RemoveAll();//删除子节点 但是自己还在
            doc.Save("haodongxi.xml");

            LoadData();

            MessageBox.Show("删除成功");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //将选中行的数据赋值给文本框等......
            txtUpdateID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtUpdateName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtUpdateAge.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtUpdatePwd.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            string gender = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            if (gender == "男")
            {
                rdoUpdateMan.Checked = true;
            }
            else
            {
                rdoUpdateWoman.Checked = true;
            }
        }


        //修改
        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("haodongxi.xml");

            XmlElement users = doc.DocumentElement;

            string id = txtUpdateID.Text;

            XmlNode xn = users.SelectSingleNode("/Users/user[@id='" + id + "']");

            xn["name"].InnerText = txtUpdateName.Text;
            xn["age"].InnerText = txtUpdateAge.Text;
            xn["password"].InnerText = txtUpdatePwd.Text;
            string gender = rdoUpdateMan.Checked ? "男" : "女";
            xn["gender"].InnerText = gender;
            
            MessageBox.Show("修改成功");
            doc.Save("haodongxi.xml");
            LoadData();

        }
    }
}
