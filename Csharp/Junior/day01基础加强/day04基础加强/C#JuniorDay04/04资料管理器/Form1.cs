using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _04资料管理器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\SpringRain\Desktop\demo";
            LoadDirectoryAndFile(path, treeView1.Nodes);
        }

        //将找到的文件和文件夹加载到节点上
        private void LoadDirectoryAndFile(string path, TreeNodeCollection tc)
        {
            //获得当前这一目录下所有文件夹的路径
            string[] dics = Directory.GetDirectories(path);
            for (int i = 0; i < dics.Length; i++)
            {
                //从文件夹的全路径中截取出文件夹的名字
                string dicName = Path.GetFileNameWithoutExtension(dics[i]);
                //将文件夹的名字加载到节点集合下
                //获得节点
                TreeNode tn = tc.Add(dicName);
                //获得当前文件夹下所有文件的全路径
                LoadDirectoryAndFile(dics[i], tn.Nodes);
            }

            ////string[] fileNames = Directory.GetFiles(path);
            ////for (int i = 0; i < fileNames.Length; i++)
            ////{
            ////    TreeNode tn= tc.Add(Path.GetFileNameWithoutExtension(fileNames[i]));
            ////    tn.Tag = fileNames[i];
            ////}

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //获得选中的节点
            string filePath = treeView1.SelectedNode.Tag.ToString();
            textBox1.Text = File.ReadAllText(filePath, Encoding.Default);
        }
    }
}
