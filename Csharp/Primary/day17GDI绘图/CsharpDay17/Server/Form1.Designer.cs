namespace Server
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnZD = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 116;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnZD
            // 
            this.btnZD.Location = new System.Drawing.Point(413, 385);
            this.btnZD.Name = "btnZD";
            this.btnZD.Size = new System.Drawing.Size(75, 23);
            this.btnZD.TabIndex = 115;
            this.btnZD.Text = "震动";
            this.btnZD.UseVisualStyleBackColor = true;
            this.btnZD.Click += new System.EventHandler(this.btnZD_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(448, 349);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 114;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(393, 349);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(49, 23);
            this.btnSelect.TabIndex = 113;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cboUsers
            // 
            this.cboUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(323, 43);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(165, 20);
            this.cboUsers.TabIndex = 112;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(314, 385);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 111;
            this.btnSend.Text = "发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(40, 212);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(480, 108);
            this.txtMsg.TabIndex = 110;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(38, 72);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(482, 123);
            this.txtLog.TabIndex = 109;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(240, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 108;
            this.btnStart.Text = "开始监听";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(163, 43);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(38, 21);
            this.txtPort.TabIndex = 105;
            this.txtPort.Text = "50000";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(40, 349);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(335, 21);
            this.txtPath.TabIndex = 106;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(40, 43);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(117, 21);
            this.txtServer.TabIndex = 107;
            this.txtServer.Text = "192.168.11.87";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnZD);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnZD;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtServer;
    }
}

