namespace UIProgram
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.msp = new System.Windows.Forms.MenuStrip();
            this.menuManagerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMemberInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTableInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDishInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.msp.SuspendLayout();
            this.SuspendLayout();
            // 
            // msp
            // 
            this.msp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msp.ImageScalingSize = new System.Drawing.Size(180, 180);
            this.msp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuManagerInfo,
            this.menuMemberInfo,
            this.menuTableInfo,
            this.menuDishInfo,
            this.menuOrder,
            this.menuQuit});
            this.msp.Location = new System.Drawing.Point(0, 0);
            this.msp.Name = "msp";
            this.msp.Padding = new System.Windows.Forms.Padding(0);
            this.msp.Size = new System.Drawing.Size(1578, 184);
            this.msp.TabIndex = 0;
            // 
            // menuManagerInfo
            // 
            this.menuManagerInfo.Image = global::UIProgram.Properties.Resources.menuManager;
            this.menuManagerInfo.Name = "menuManagerInfo";
            this.menuManagerInfo.Size = new System.Drawing.Size(192, 184);
            this.menuManagerInfo.ToolTipText = "员工管理";
            this.menuManagerInfo.Click += new System.EventHandler(this.menuManagerInfo_Click);
            // 
            // menuMemberInfo
            // 
            this.menuMemberInfo.Image = global::UIProgram.Properties.Resources.menuMember;
            this.menuMemberInfo.Name = "menuMemberInfo";
            this.menuMemberInfo.Size = new System.Drawing.Size(192, 184);
            this.menuMemberInfo.ToolTipText = "会员专区";
            this.menuMemberInfo.Click += new System.EventHandler(this.menuMemberInfo_Click);
            // 
            // menuTableInfo
            // 
            this.menuTableInfo.Image = global::UIProgram.Properties.Resources.menuTable;
            this.menuTableInfo.Name = "menuTableInfo";
            this.menuTableInfo.Size = new System.Drawing.Size(192, 184);
            // 
            // menuDishInfo
            // 
            this.menuDishInfo.Image = global::UIProgram.Properties.Resources.menuDish;
            this.menuDishInfo.Name = "menuDishInfo";
            this.menuDishInfo.Size = new System.Drawing.Size(192, 184);
            // 
            // menuOrder
            // 
            this.menuOrder.Image = global::UIProgram.Properties.Resources.menuOrder;
            this.menuOrder.Name = "menuOrder";
            this.menuOrder.Size = new System.Drawing.Size(192, 184);
            this.menuOrder.ToolTipText = "收银台";
            // 
            // menuQuit
            // 
            this.menuQuit.Image = global::UIProgram.Properties.Resources.menuQuit;
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(192, 184);
            this.menuQuit.ToolTipText = "退出";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 869);
            this.Controls.Add(this.msp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msp;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.msp.ResumeLayout(false);
            this.msp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msp;
        private System.Windows.Forms.ToolStripMenuItem menuManagerInfo;
        private System.Windows.Forms.ToolStripMenuItem menuMemberInfo;
        private System.Windows.Forms.ToolStripMenuItem menuTableInfo;
        private System.Windows.Forms.ToolStripMenuItem menuDishInfo;
        private System.Windows.Forms.ToolStripMenuItem menuOrder;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
    }
}