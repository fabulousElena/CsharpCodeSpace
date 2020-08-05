namespace UIProgram
{
    partial class FormLoginIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginIn));
            this.tname = new System.Windows.Forms.TextBox();
            this.tpass = new System.Windows.Forms.TextBox();
            this.blogin = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tname
            // 
            this.tname.BackColor = System.Drawing.Color.Pink;
            this.tname.Location = new System.Drawing.Point(547, 158);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(315, 30);
            this.tname.TabIndex = 0;
            // 
            // tpass
            // 
            this.tpass.BackColor = System.Drawing.Color.Pink;
            this.tpass.Location = new System.Drawing.Point(547, 266);
            this.tpass.Name = "tpass";
            this.tpass.PasswordChar = '*';
            this.tpass.Size = new System.Drawing.Size(315, 30);
            this.tpass.TabIndex = 1;
            // 
            // blogin
            // 
            this.blogin.Location = new System.Drawing.Point(631, 357);
            this.blogin.Name = "blogin";
            this.blogin.Size = new System.Drawing.Size(143, 38);
            this.blogin.TabIndex = 2;
            this.blogin.Text = "登录";
            this.blogin.UseVisualStyleBackColor = true;
            this.blogin.Click += new System.EventHandler(this.blogin_Click);
            // 
            // bexit
            // 
            this.bexit.Location = new System.Drawing.Point(631, 424);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(143, 38);
            this.bexit.TabIndex = 3;
            this.bexit.Text = "退出";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // FormLoginIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::UIProgram.Properties.Resources.Snipaste_2020_07_29_23_36_56;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(993, 553);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.blogin);
            this.Controls.Add(this.tpass);
            this.Controls.Add(this.tname);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoginIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLoginIn_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tpass;
        private System.Windows.Forms.Button blogin;
        private System.Windows.Forms.Button bexit;
    }
}