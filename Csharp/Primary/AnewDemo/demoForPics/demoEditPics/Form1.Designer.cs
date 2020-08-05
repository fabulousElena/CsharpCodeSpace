namespace demoEditPics
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Mplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1891, 966);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.TabStop = false;
            this.tabControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyUp);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1883, 926);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图片操作";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(428, 822);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "导入图片";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(854, 775);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 27);
            this.label10.TabIndex = 10;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(1059, 775);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 27);
            this.label9.TabIndex = 9;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(555, 775);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 27);
            this.label8.TabIndex = 8;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(560, 805);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 72);
            this.panel1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(660, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "删除:R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(562, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "to腿腿:D";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(467, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "to肉肉:S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(370, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "to女女:A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(267, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "to风景:W";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(129, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "下一张:→";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "上一张:←";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1883, 766);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.Mplayer);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1883, 926);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "音乐播放";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(1182, 609);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(689, 64);
            this.label21.TabIndex = 15;
            this.label21.Text = "歌词";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(1182, 552);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(689, 57);
            this.label20.TabIndex = 13;
            this.label20.Text = "歌词";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(1182, 489);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(689, 63);
            this.label19.TabIndex = 12;
            this.label19.Text = "歌词";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(1182, 422);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(689, 67);
            this.label18.TabIndex = 11;
            this.label18.Text = "歌词";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label17.Location = new System.Drawing.Point(1182, 354);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(689, 68);
            this.label17.TabIndex = 10;
            this.label17.Text = "歌词";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(1182, 289);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(689, 65);
            this.label16.TabIndex = 9;
            this.label16.Text = "歌词";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(1182, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(689, 68);
            this.label15.TabIndex = 8;
            this.label15.Text = "歌词";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(1182, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(689, 61);
            this.label14.TabIndex = 7;
            this.label14.Text = "歌词";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(1182, 96);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(689, 64);
            this.label13.TabIndex = 6;
            this.label13.Text = "歌词";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(1135, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 37);
            this.label12.TabIndex = 5;
            this.label12.Text = "歌词";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(495, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 37);
            this.label11.TabIndex = 4;
            this.label11.Text = "专辑封面";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(500, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(422, 422);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "打开文件夹";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.ColumnWidth = 20;
            this.listBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(6, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(403, 708);
            this.listBox1.TabIndex = 1;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // Mplayer
            // 
            this.Mplayer.Enabled = true;
            this.Mplayer.Location = new System.Drawing.Point(6, 802);
            this.Mplayer.Name = "Mplayer";
            this.Mplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Mplayer.OcxState")));
            this.Mplayer.Size = new System.Drawing.Size(1871, 112);
            this.Mplayer.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1884, 961);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixiv图片操作";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mplayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer Mplayer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Timer timer1;
    }
}

