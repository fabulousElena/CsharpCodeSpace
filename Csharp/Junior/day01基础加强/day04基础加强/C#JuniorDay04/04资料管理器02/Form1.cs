using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04资料管理器02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string pathName = @"D:\SoftWare";
            loadDirectoryAndFile(pathName, treeView1.Nodes);
        }

        void loadDirectoryAndFile(string s, TreeNodeCollection tnc)
        {
            //获得该路径下面所有的文件夹路径
            string[] dirs = Directory.GetDirectories(s);
            //遍历数组  取得每个文件夹的名字和路径
            for (int i = 0; i < dirs.Length; i++)
            {
                //获得文件夹名字
                string dirName = Path.GetFileNameWithoutExtension(dirs[i]);
                //把名字作为tree的一个节点
                tnc.Add(dirName);
                //获得该文件夹所有的文件名称
                string[] fileNames = Directory.GetFiles(dirs[i]);
                //遍历节点下面的文件夹  进行递归  如果没有就往下走  也就是吧数据加入节点内
                loadDirectoryAndFile(dirs[i], tnc[i].Nodes);
                //遍历数组  操作所有的文件
                foreach (var item in fileNames)
                {
                    //获得所有文件名
                    string ss = Path.GetFileName(item);
                    //在节点上添加所有的文件名
                    tnc[i].Nodes.Add(ss);
                }
            }



        }
    }
}
