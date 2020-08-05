using BllProgram;
using ModelProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIProgram
{
    public partial class FormManagerInfo : Form
    {
        private FormManagerInfo()
        {
            InitializeComponent();
        }
        public static FormManagerInfo _status;
      
        /// <summary>
        /// 单例
        /// </summary>
        /// <returns></returns>
        public static FormManagerInfo OneCreate() {
            if (_status == null)
            {
                _status = new FormManagerInfo();

            }
            return _status;
        }

        private void FormManagerInfo_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        /// <summary>
        /// 加载列表
        /// </summary>
        void LoadList()
        {
            dgList.AutoGenerateColumns = false;
            //创建业务逻辑层对象
            List<ManagerInfo> list = mib.GetListValue();
            list.Reverse();
            dgList.DataSource = list;
        }
        ManagerInfoBll mib = new ManagerInfoBll();
        /// <summary>
        /// 添加或者修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //接受用户输入

            //如果按钮的文本是 修改  就修改
            if (btnSave.Text == "修改")
            {
                ManagerInfo mi = new ManagerInfo();

                mi.userid = Convert.ToInt32(txtId.Text);
                if (Convert.ToInt32(txtId.Text) == -1)
                {
                    MessageBox.Show("请在编号处输入数字");
                    return;
                }
                mi.username = txtName.Text;
                if (rb1.Checked)
                {
                    mi.usertype = "经理";
                }
                else
                {
                    mi.usertype = "生化人";
                }
                //判断是否更改了密码  更改了就是true  反之false
                if (txtPwd.Text.Length != 0)
                {
                    mi.userpass = txtPwd.Text;
                    if (mib.UpdateToMysql(mi, true))
                    {
                        MessageBox.Show("修改成功");
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
                else
                {
                    if (mib.UpdateToMysql(mi, false))
                    {
                        MessageBox.Show("修改成功");
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }

                }
                txtId.ReadOnly = true;
                txtId.Text = "添加时无编号";
                txtPwd.Text = "";
                txtName.Text = "";
            }
            //如果按钮的文本是 添加  添加
            else
            {
                ManagerInfo mi = new ManagerInfo();
                mi.username = txtName.Text;
                mi.userpass = txtPwd.Text;
                if (rb1.Checked)
                {
                    mi.usertype = "经理";
                }
                else
                {
                    mi.usertype = "生化人";
                }
                bool b = mib.AddToMySql(mi);

                if (b)
                {
                    MessageBox.Show("添加成功~");

                }
                else
                {
                    MessageBox.Show("操作失败");
                }
                txtPwd.Text = "";
                txtName.Text = "";
            }
            LoadList();
            btnSave.Text = "添加";
        }
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPwd.Text = "";
            txtName.Text = "";
        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            if (i != -1)
            {
                DataGridViewRow row = dgList.Rows[i];
               
                ManagerInfo mi = new ManagerInfo();
                mi.userid = Convert.ToInt32(row.Cells[0].Value.ToString());
                bool bb = mib.DeleteToMysql(mi);
                if (bb)
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
                
            }
            else
            {
                MessageBox.Show("请选中要删除的行");
            }


            LoadList();
            i = -1;
        }
        /// <summary>
        /// 当表格双击的时候  获取 赋值到文本框中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgList.Rows[e.RowIndex];
            //获取id赋值到文本框中
            txtId.Text = row.Cells[0].Value.ToString();
            
            txtName.Text = row.Cells[1].Value.ToString();
            if (row.Cells[2].Value.ToString() == "经理")
            {
                rb1.Checked = true;
            }
            else
            {
                rb2.Checked = true;
            }


            btnSave.Text = "修改";
        }
        int i;
        /// <summary>
        /// 获得单机表格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }

        /// <summary>
        /// 将字段指向null  然后就可以再次创建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormManagerInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            _status = null;
        }
    }
}
