namespace _09石头剪刀布
{
    partial class lblComputer
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
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnStone = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "玩家出：";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(125, 45);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(41, 12);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "电脑出：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "裁判";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(305, 202);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(41, 12);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "label6";
            // 
            // btnStone
            // 
            this.btnStone.Location = new System.Drawing.Point(122, 283);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(75, 23);
            this.btnStone.TabIndex = 6;
            this.btnStone.Text = "石头";
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(263, 283);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(75, 23);
            this.btnCut.TabIndex = 7;
            this.btnCut.Text = "剪刀";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(392, 283);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 8;
            this.btnNo.Text = "布";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 435);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnStone);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label1);
            this.Name = "lblComputer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnNo;
    }
}

