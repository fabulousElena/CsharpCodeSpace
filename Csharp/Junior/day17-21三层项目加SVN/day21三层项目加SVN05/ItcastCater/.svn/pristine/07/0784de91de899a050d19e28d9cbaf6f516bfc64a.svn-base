using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaterBll;

namespace CaterUI.test
{
    public partial class ListViewTest : Form
    {
        public ListViewTest()
        {
            InitializeComponent();
        }

        private void ListViewTest_Load(object sender, EventArgs e)
        {
            //获取餐桌信息
            TableInfoBll tiBll=new TableInfoBll();
            var list = tiBll.GetList(new Dictionary<string, string>());
            //遍历集合，添加餐桌
            foreach (var ti in list)
            {
                lvTableInfo.Items.Add(ti.TTitle, 0);
            }
        }
    }
}
