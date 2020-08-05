using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _03TreeView的使用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  
        {
            //TreeNodeCollection:当前树状菜单节点的集合 所有的数据都要添加到这个集合下
            treeView1.Nodes.Add(txtParent.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //获得要添加子节点的根节点
            //获得当前选中的节点
            TreeNode tn = treeView1.SelectedNode;
            //每一个节点都可以看做是一个节点集合 因为可以无限的向下添加子节点
            tn.Nodes.Add(txtChild.Text);
        }
    }
}
