namespace _03TextBox
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
            this.txtWords = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(34, 43);
            this.txtWords.Multiline = true;
            this.txtWords.Name = "txtWords";
            this.txtWords.PasswordChar = '猪';
            this.txtWords.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWords.Size = new System.Drawing.Size(429, 92);
            this.txtWords.TabIndex = 0;
            this.txtWords.WordWrap = false;
            this.txtWords.TextChanged += new System.EventHandler(this.txtWords_TextChanged);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(227, 138);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(41, 12);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "label1";
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 429);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtWords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.Label lblText;
    }
}

