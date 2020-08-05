using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BllProgram;
using ModelProgram;

namespace UIProgram
{
    public partial class FormMemberTypeInfo : Form
    {
        private FormMemberTypeInfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 单例
        /// </summary>
        public static FormMemberTypeInfo _status;
        public static FormMemberTypeInfo OneCreate()
        {
            if (_status == null)
            {
                _status = new FormMemberTypeInfo();

            }
            return _status;
        }
        MemberTypeInfoBll mtib = new MemberTypeInfoBll();
        private void FormMemberTypeInfo_Load(object sender, EventArgs e)
        {
            load();
        }
        /// <summary>
        /// 刷新
        /// </summary>
        public void load()
        {
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = mtib.GetListValue();
           int rCount = dgvList.RowCount;
            for (int i = 0; i < rCount; i++)
            {
                ;
                if (dgvList.Rows[i].Cells[3].Value.ToString() == "1")
                {
                    dgvList.Rows[i].Visible = false;
                }
            }
        }

        MemberTypeInfo mi = new MemberTypeInfo();

        /// <summary>
        /// 保存 或者修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "添加")
            {
                mi.Memtitle = txtTitle.Text;
                mi.Memdiscount = Convert.ToDouble(txtDiscount.Text);
                mi.Memisdelete = 0;
                if (mtib.AddMysql(mi))
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
                mi.Memid = Convert.ToInt32(txtId.Text);
                mi.Memtitle = txtTitle.Text;
                mi.Memdiscount = Convert.ToDouble(txtDiscount.Text);
                mi.Memisdelete = 0;
                if (mtib.ChangeMysql(mi))
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            ClearBox();
            
            //mi = null;
        }

        void ClearBox()
        {
            txtId.Text = "添加时无编号";
            txtTitle.Text = "";
            txtDiscount.Text = "";
            btnSave.Text = "添加";
            load();
        }

        /// <summary>
        /// 双击修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Text = "修改";
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvList.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtTitle.Text = row.Cells[1].Value.ToString();
            txtDiscount.Text = row.Cells[2].Value.ToString();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearBox();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var row = dgvList.SelectedRows[0];
            mi.Memid = Convert.ToInt32(row.Cells[0].Value);

            if (mtib.DeleteMysql(mi))
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }


            ClearBox();
        }

        private void FormMemberTypeInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMember fm = FormMember.CreateForm();
            fm.AddComList();
            _status = null;
        }
    }
}
