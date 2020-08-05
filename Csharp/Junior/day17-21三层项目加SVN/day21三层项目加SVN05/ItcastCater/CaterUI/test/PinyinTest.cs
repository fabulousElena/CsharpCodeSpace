using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaterCommon;
using Microsoft.International.Converters.PinYinConverter;

namespace CaterUI.test
{
    public partial class PinyinTest : Form
    {
        public PinyinTest()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            #region 拼音基础
            ////构造拼音对象
            //ChineseChar cc = new ChineseChar(textBox1.Text[0]);
            ////调用获取拼音的属性
            //var pinyin = cc.Pinyins;//返回一个字符串集合
            ////一个字的拼音结果，就是（拼音+声调）
            ////是集合的原因：中文存在多音字
            ////输出集合中的元素
            //foreach (string s in pinyin)
            //{
            //    textBox2.Text += s + " ";
            //}
            #endregion

            #region 获取中文首字母

            //string txt = textBox1.Text;
            ////字符串可以被看作是字符数组
            //foreach (char c in txt)
            //{
            //    ChineseChar cc=new ChineseChar(c);
            //    string py1 = cc.Pinyins[0];//多音字中的第一个拼音
            //    char c1 = py1[0]; //获取首字母
            //    textBox2.Text += c1;
            //}

            #endregion

            #region 调用封装帮助类

            textBox2.Text = PinyinHelper.GetPinyin(textBox1.Text);

            #endregion
        }
    }
}
