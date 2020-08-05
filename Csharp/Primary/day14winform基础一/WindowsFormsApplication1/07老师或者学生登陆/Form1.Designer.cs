namespace _07老师或者学生登陆
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.rdoTeacher = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 21);
            this.txtName.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(140, 127);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(211, 21);
            this.txtPwd.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "登陆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Location = new System.Drawing.Point(140, 185);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(47, 16);
            this.rdoStudent.TabIndex = 5;
            this.rdoStudent.TabStop = true;
            this.rdoStudent.Text = "学生";
            this.rdoStudent.UseVisualStyleBackColor = true;
            // 
            // rdoTeacher
            // 
            this.rdoTeacher.AutoSize = true;
            this.rdoTeacher.Location = new System.Drawing.Point(289, 184);
            this.rdoTeacher.Name = "rdoTeacher";
            this.rdoTeacher.Size = new System.Drawing.Size(47, 16);
            this.rdoTeacher.TabIndex = 6;
            this.rdoTeacher.TabStop = true;
            this.rdoTeacher.Text = "老师";
            this.rdoTeacher.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 384);
            this.Controls.Add(this.rdoTeacher);
            this.Controls.Add(this.rdoStudent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdoStudent;
        private System.Windows.Forms.RadioButton rdoTeacher;
    }
}

