﻿namespace _02Do_you_Love_Me
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
            this.btnLove = new System.Windows.Forms.Button();
            this.btnUnLove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLove
            // 
            this.btnLove.Location = new System.Drawing.Point(119, 89);
            this.btnLove.Name = "btnLove";
            this.btnLove.Size = new System.Drawing.Size(75, 23);
            this.btnLove.TabIndex = 0;
            this.btnLove.Text = "爱";
            this.btnLove.UseVisualStyleBackColor = true;
            this.btnLove.Click += new System.EventHandler(this.btnLove_Click);
            // 
            // btnUnLove
            // 
            this.btnUnLove.Location = new System.Drawing.Point(356, 89);
            this.btnUnLove.Name = "btnUnLove";
            this.btnUnLove.Size = new System.Drawing.Size(75, 23);
            this.btnUnLove.TabIndex = 1;
            this.btnUnLove.Text = "不爱";
            this.btnUnLove.UseVisualStyleBackColor = true;
            this.btnUnLove.Click += new System.EventHandler(this.btnUnLove_Click);
            this.btnUnLove.MouseEnter += new System.EventHandler(this.btnUnLove_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 413);
            this.Controls.Add(this.btnUnLove);
            this.Controls.Add(this.btnLove);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLove;
        private System.Windows.Forms.Button btnUnLove;
    }
}

