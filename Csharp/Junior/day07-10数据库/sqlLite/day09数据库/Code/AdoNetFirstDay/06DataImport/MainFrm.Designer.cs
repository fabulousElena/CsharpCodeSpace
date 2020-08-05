namespace _06DataImport
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
            this.btnSelectDataFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectDataFile
            // 
            this.btnSelectDataFile.Location = new System.Drawing.Point(430, 11);
            this.btnSelectDataFile.Name = "btnSelectDataFile";
            this.btnSelectDataFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDataFile.TabIndex = 0;
            this.btnSelectDataFile.Text = "打开";
            this.btnSelectDataFile.UseVisualStyleBackColor = true;
            this.btnSelectDataFile.Click += new System.EventHandler(this.btnSelectDataFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(13, 13);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(411, 21);
            this.txtFilePath.TabIndex = 1;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 436);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSelectDataFile);
            this.Name = "MainFrm";
            this.Text = "文件导入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectDataFile;
        private System.Windows.Forms.TextBox txtFilePath;
    }
}

