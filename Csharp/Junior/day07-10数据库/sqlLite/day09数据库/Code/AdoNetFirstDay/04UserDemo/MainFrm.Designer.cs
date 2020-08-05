namespace _04UserDemo
{
    partial class MainFrm
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
            this.btnOpenUserRegistFrm = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnOpenLoginFrm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenUserRegistFrm
            // 
            this.btnOpenUserRegistFrm.Location = new System.Drawing.Point(32, 25);
            this.btnOpenUserRegistFrm.Name = "btnOpenUserRegistFrm";
            this.btnOpenUserRegistFrm.Size = new System.Drawing.Size(75, 23);
            this.btnOpenUserRegistFrm.TabIndex = 0;
            this.btnOpenUserRegistFrm.Text = "用户注册";
            this.btnOpenUserRegistFrm.UseVisualStyleBackColor = true;
            this.btnOpenUserRegistFrm.Click += new System.EventHandler(this.btnOpenUserRegistFrm_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(32, 80);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "用户Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnOpenLoginFrm2
            // 
            this.btnOpenLoginFrm2.Location = new System.Drawing.Point(32, 134);
            this.btnOpenLoginFrm2.Name = "btnOpenLoginFrm2";
            this.btnOpenLoginFrm2.Size = new System.Drawing.Size(75, 23);
            this.btnOpenLoginFrm2.TabIndex = 0;
            this.btnOpenLoginFrm2.Text = "2用户Login";
            this.btnOpenLoginFrm2.UseVisualStyleBackColor = true;
            this.btnOpenLoginFrm2.Click += new System.EventHandler(this.btnOpenLoginFrm2_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 357);
            this.Controls.Add(this.btnOpenLoginFrm2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnOpenUserRegistFrm);
            this.Name = "MainFrm";
            this.Text = "用户管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenUserRegistFrm;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnOpenLoginFrm2;
    }
}

