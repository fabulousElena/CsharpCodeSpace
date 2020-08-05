namespace _01下载网页中的图片03
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.bt1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(255, 102);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(1026, 554);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(676, 50);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(177, 46);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "显示";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 829);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Button bt1;
    }
}

