namespace _02ProvinceCitySelect
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
            this.cbxProvince = new System.Windows.Forms.ComboBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.btbExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxProvince
            // 
            this.cbxProvince.FormattingEnabled = true;
            this.cbxProvince.Location = new System.Drawing.Point(67, 56);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(121, 20);
            this.cbxProvince.TabIndex = 0;
            this.cbxProvince.SelectedIndexChanged += new System.EventHandler(this.cbxProvince_SelectedIndexChanged);
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(250, 56);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(121, 20);
            this.cbxCity.TabIndex = 0;
            // 
            // btbExport
            // 
            this.btbExport.Location = new System.Drawing.Point(76, 110);
            this.btbExport.Name = "btbExport";
            this.btbExport.Size = new System.Drawing.Size(75, 23);
            this.btbExport.TabIndex = 1;
            this.btbExport.Text = "导出数据";
            this.btbExport.UseVisualStyleBackColor = true;
            this.btbExport.Click += new System.EventHandler(this.btbExport_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 356);
            this.Controls.Add(this.btbExport);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.cbxProvince);
            this.Name = "MainFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxProvince;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.Button btbExport;
    }
}

