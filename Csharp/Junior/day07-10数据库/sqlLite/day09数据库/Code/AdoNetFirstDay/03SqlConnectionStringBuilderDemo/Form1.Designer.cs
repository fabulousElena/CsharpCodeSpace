namespace _03SqlConnectionStringBuilderDemo
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
            this.btnGetString = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.propGrid4ConString = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // btnGetString
            // 
            this.btnGetString.Location = new System.Drawing.Point(12, 12);
            this.btnGetString.Name = "btnGetString";
            this.btnGetString.Size = new System.Drawing.Size(75, 23);
            this.btnGetString.TabIndex = 0;
            this.btnGetString.Text = "获取链接字符串";
            this.btnGetString.UseVisualStyleBackColor = true;
            this.btnGetString.Click += new System.EventHandler(this.btnGetString_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(12, 41);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(205, 246);
            this.txtString.TabIndex = 1;
            // 
            // propGrid4ConString
            // 
            this.propGrid4ConString.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.propGrid4ConString.Location = new System.Drawing.Point(242, 12);
            this.propGrid4ConString.Name = "propGrid4ConString";
            this.propGrid4ConString.Size = new System.Drawing.Size(276, 364);
            this.propGrid4ConString.TabIndex = 2;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 418);
            this.Controls.Add(this.propGrid4ConString);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnGetString);
            this.Name = "MainFrm";
            this.Text = "生成链接字符串";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetString;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.PropertyGrid propGrid4ConString;
    }
}

