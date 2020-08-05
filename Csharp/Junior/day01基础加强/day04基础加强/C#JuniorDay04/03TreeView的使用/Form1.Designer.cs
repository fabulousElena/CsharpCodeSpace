namespace _03TreeView的使用
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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("苍老师.avi");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("b", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("a", new System.Windows.Forms.TreeNode[] {
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("重要的文件", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("windows", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("c:\\", new System.Windows.Forms.TreeNode[] {
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("我的电脑", new System.Windows.Forms.TreeNode[] {
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("网上邻居");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtParent = new System.Windows.Forms.TextBox();
            this.txtChild = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 22);
            this.treeView1.Name = "treeView1";
            treeNode17.Name = "节点7";
            treeNode17.Text = "苍老师.avi";
            treeNode18.Name = "节点6";
            treeNode18.Text = "b";
            treeNode19.Name = "节点5";
            treeNode19.Text = "a";
            treeNode20.Name = "节点4";
            treeNode20.Text = "重要的文件";
            treeNode21.Name = "节点3";
            treeNode21.Text = "windows";
            treeNode22.Name = "节点2";
            treeNode22.Text = "c:\\";
            treeNode23.Name = "节点0";
            treeNode23.Text = "我的电脑";
            treeNode24.Name = "节点1";
            treeNode24.Text = "网上邻居";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24});
            this.treeView1.Size = new System.Drawing.Size(233, 375);
            this.treeView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加根节点";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "添加子节点";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtParent
            // 
            this.txtParent.Location = new System.Drawing.Point(302, 65);
            this.txtParent.Name = "txtParent";
            this.txtParent.Size = new System.Drawing.Size(242, 21);
            this.txtParent.TabIndex = 3;
            // 
            // txtChild
            // 
            this.txtChild.Location = new System.Drawing.Point(302, 149);
            this.txtChild.Name = "txtChild";
            this.txtChild.Size = new System.Drawing.Size(242, 21);
            this.txtChild.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 462);
            this.Controls.Add(this.txtChild);
            this.Controls.Add(this.txtParent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtParent;
        private System.Windows.Forms.TextBox txtChild;
    }
}

