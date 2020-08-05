namespace _09使用XML实现增删改查
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.rdoWoman = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdoUpdateWoman = new System.Windows.Forms.RadioButton();
            this.rdoUpdateMan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdatePwd = new System.Windows.Forms.TextBox();
            this.txtUpdateAge = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(85, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(502, 157);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Age";
            this.Column3.HeaderText = "年龄";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Gender";
            this.Column4.HeaderText = "性别";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Password";
            this.Column5.HeaderText = "密码";
            this.Column5.Name = "Column5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.rdoWoman);
            this.groupBox1.Controls.Add(this.rdoMan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(85, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.a);
            this.groupBox2.Controls.Add(this.rdoUpdateWoman);
            this.groupBox2.Controls.Add(this.rdoUpdateMan);
            this.groupBox2.Controls.Add(this.txtUpdateID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtUpdateName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUpdateAge);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtUpdatePwd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(85, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(7, 32);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(17, 12);
            this.a.TabIndex = 1;
            this.a.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(49, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(396, 12);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 21);
            this.txtAge.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(222, 61);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 21);
            this.txtPwd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "年龄";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "性别";
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Checked = true;
            this.rdoMan.Location = new System.Drawing.Point(49, 63);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(35, 16);
            this.rdoMan.TabIndex = 9;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "男";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // rdoWoman
            // 
            this.rdoWoman.AutoSize = true;
            this.rdoWoman.Location = new System.Drawing.Point(49, 85);
            this.rdoWoman.Name = "rdoWoman";
            this.rdoWoman.Size = new System.Drawing.Size(35, 16);
            this.rdoWoman.TabIndex = 10;
            this.rdoWoman.TabStop = true;
            this.rdoWoman.Text = "女";
            this.rdoWoman.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(396, 64);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "注册";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoUpdateWoman
            // 
            this.rdoUpdateWoman.AutoSize = true;
            this.rdoUpdateWoman.Location = new System.Drawing.Point(49, 77);
            this.rdoUpdateWoman.Name = "rdoUpdateWoman";
            this.rdoUpdateWoman.Size = new System.Drawing.Size(35, 16);
            this.rdoUpdateWoman.TabIndex = 21;
            this.rdoUpdateWoman.TabStop = true;
            this.rdoUpdateWoman.Text = "女";
            this.rdoUpdateWoman.UseVisualStyleBackColor = true;
            // 
            // rdoUpdateMan
            // 
            this.rdoUpdateMan.AutoSize = true;
            this.rdoUpdateMan.Checked = true;
            this.rdoUpdateMan.Location = new System.Drawing.Point(49, 55);
            this.rdoUpdateMan.Name = "rdoUpdateMan";
            this.rdoUpdateMan.Size = new System.Drawing.Size(35, 16);
            this.rdoUpdateMan.TabIndex = 20;
            this.rdoUpdateMan.TabStop = true;
            this.rdoUpdateMan.Text = "男";
            this.rdoUpdateMan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "性别";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "密码";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "年龄";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "姓名";
            // 
            // txtUpdatePwd
            // 
            this.txtUpdatePwd.Location = new System.Drawing.Point(222, 53);
            this.txtUpdatePwd.Name = "txtUpdatePwd";
            this.txtUpdatePwd.Size = new System.Drawing.Size(100, 21);
            this.txtUpdatePwd.TabIndex = 15;
            // 
            // txtUpdateAge
            // 
            this.txtUpdateAge.Location = new System.Drawing.Point(396, 4);
            this.txtUpdateAge.Name = "txtUpdateAge";
            this.txtUpdateAge.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateAge.TabIndex = 14;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(223, 4);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateName.TabIndex = 13;
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(49, 20);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(100, 21);
            this.txtUpdateID.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoWoman;
        private System.Windows.Forms.RadioButton rdoMan;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdoUpdateWoman;
        private System.Windows.Forms.RadioButton rdoUpdateMan;
        private System.Windows.Forms.TextBox txtUpdateID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdatePwd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}

