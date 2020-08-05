using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _11英汉翻译
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> dic = new Dictionary<string, string>();
        private void Form1_Load(object sender, EventArgs e)
        {

            string[] contents = File.ReadAllLines("english.txt", Encoding.Default);
            for (int i = 0; i < contents.Length; i++)
            {
                //abandon   v.抛弃 放弃
                int index = contents[i].IndexOf(" ");
                string english = contents[i].Substring(0, index);
                string chinese = contents[i].Substring(index + 1).Trim();

                //dic.Add(english, chinese);
                if (!dic.ContainsKey(english))
                {
                    dic.Add(english, chinese);
                }
                else
                {
                    //有重复的   累加给英文单词所对应的中文解释
                    dic[english] += chinese;
                } 


                #region 麻烦的
                //    string[] temp = contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //string chinese = string.Empty;
                //for (int j = 1; j < temp.Length; j++)
                //{
                //    chinese += temp[j];
                //}

                ////有重复的数据，添加之前做一个判断
                //if (!dic.ContainsKey(temp[0]))
                //{
                //    dic.Add(temp[0], chinese);
                //}
                //else
                //{ 
                //  //有重复的   累加给英文单词所对应的中文解释
                //    dic[temp[0]] += chinese;
                //} 
                #endregion
            }
            Console.WriteLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string english = textBox1.Text.Trim();
            if (dic.ContainsKey(english))
            {
                textBox2.Text = dic[english];
            }
            else
            {
                textBox2.Text = "请下载最新版本的英文词典！！！";
            }
        }
    }
}
