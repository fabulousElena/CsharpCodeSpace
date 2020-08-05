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
    public partial class FormMember : Form
    {
        private FormMember()
        {
            InitializeComponent();
        }
        public static FormMember _status = null;
        public static FormMember CreateForm()
        {
            if (_status == null)
            {
                _status = new FormMember();
            }
            return _status;
        }

        MemberInfoBll mib = new MemberInfoBll();
        MemberInfo mi = new MemberInfo();

        private void FormMember_Load(object sender, EventArgs e)
        {
            LoadData();
            AddComList();
            ddlType.SelectedIndex = 1;
        }

        void LoadSerch()
        {
            dgvList.AutoGenerateColumns = false;
            List<MemberInfo> list = mib.SerchMysql(txtPhoneSearch.Text);
            list.Reverse();
            dgvList.DataSource = list;

            CurrencyManager cm = (CurrencyManager)BindingContext[dgvList.DataSource];

            for (int i = 0; i < dgvList.RowCount; i++)
            {


                if (dgvList.Rows[i].Cells[3].Value.ToString() == "1")
                {
                    //暂时挂起绑定
                    cm.SuspendBinding();
                    dgvList.Rows[i].Visible = false;
                    //重新链接绑定
                    cm.ResumeBinding();
                }
            }
        }


        /// <summary>
        /// 加载数据
        /// </summary>
        void LoadData()
        {
            dgvList.AutoGenerateColumns = false;
            List<MemberInfo> list = mib.GetMysqlList();
            list.Reverse();
            dgvList.DataSource = list;
            //货币管理器的方法
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvList.DataSource];

            for (int i = 0; i < dgvList.RowCount; i++)
            {


                if (dgvList.Rows[i].Cells[3].Value.ToString() == "1")
                {
                    //暂时挂起绑定
                    cm.SuspendBinding();
                    dgvList.Rows[i].Visible = false;
                    //重新链接绑定
                    cm.ResumeBinding();
                }
            }
        }
        /// <summary>
        /// 获得下拉列表里面的内容
        /// </summary>
        public  void AddComList()
        {
            ddlType.Items.Clear();
            ddlType.Items.AddRange(mib.GetMem().ToArray());
            ddlType.SelectedIndex = 1;
        }
        //public static bool isFlushed = false;

        /// <summary>
        /// 添加或者修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {

            mi.Miname = txtNameAdd.Text;
            mi.Miphone = txtPhoneAdd.Text;
            mi.Mimoney = Convert.ToDouble(txtMoney.Text);
            mi.Miisdelete = 0;
            //-1是空  0是下表第一个
            //mi.Mitypeid = ddlType.SelectedIndex + 1;
            //获得元素内容  然后在dal层进行查询编号
            mi.Mimembertype = ddlType.SelectedItem.ToString();

            if (btnSave.Text == "添加")
            {
                if (mib.AddToMysql(mi))
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                mi.Miid = Convert.ToInt32(txtId.Text);
                if (mib.ChangeAtMysql(mi))
                {
                    MessageBox.Show("修改成功");
                    //设置这一行选中

                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }

            ClearData();
            dgvList.Rows[dgvSelectedIndex].Selected = true;
        }
        /// <summary>
        /// 清空文本行
        /// </summary>
        void ClearData()
        {
            txtNameAdd.Text = "";
            txtPhoneAdd.Text = "";
            txtMoney.Text = "";
            ddlType.SelectedIndex = -1;
            txtPhoneSearch.Text = "";
            LoadData();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
            btnSave.Text = "添加";
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var row = dgvList.SelectedRows[0];
            mi.Miid = Convert.ToInt32(row.Cells[0].Value);
            if (mib.DeleteFromMysql(mi))
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }

            ClearData();

        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            FormMemberTypeInfo fmti = FormMemberTypeInfo.OneCreate();
            fmti.Show();
            fmti.Focus();
        }

        private void FormMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            _status = null;
        }

        private int dgvSelectedIndex = 0;
        /// <summary>
        /// 双击表格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSelectedIndex = e.RowIndex;
            DataGridViewRow row = dgvList.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtNameAdd.Text = row.Cells[1].Value.ToString();
            string sType = row.Cells[2].Value.ToString();
            txtPhoneAdd.Text = row.Cells[4].Value.ToString();
            txtMoney.Text = row.Cells[5].Value.ToString();

            ddlType.SelectedIndex = ddlType.Items.IndexOf(sType);

            btnSave.Text = "修改";

        }
        /// <summary>
        /// 搜索按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            LoadSerch();
        }
    }
}
