namespace _05简单记事本儿应用程序
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
            this.btnWordWrap = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWordWrap
            // 
            this.btnWordWrap.Location = new System.Drawing.Point(13, 13);
            this.btnWordWrap.Name = "btnWordWrap";
            this.btnWordWrap.Size = new System.Drawing.Size(224, 23);
            this.btnWordWrap.TabIndex = 0;
            this.btnWordWrap.Text = "自动换行";
            this.btnWordWrap.UseVisualStyleBackColor = true;
            this.btnWordWrap.Click += new System.EventHandler(this.btnWordWrap_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(325, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(12, 55);
            this.txtWords.Multiline = true;
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(677, 387);
            this.txtWords.TabIndex = 2;
            this.txtWords.TextChanged += new System.EventHandler(this.txtWords_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密码：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(164, 145);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 21);
            this.txtName.TabIndex = 5;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(164, 191);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(219, 21);
            this.txtPwd.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(164, 259);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "登陆";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(308, 259);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(75, 23);
            this.btnRest.TabIndex = 8;
            this.btnRest.Text = "重置";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 434);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWords);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnWordWrap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWordWrap;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRest;
    }
}

