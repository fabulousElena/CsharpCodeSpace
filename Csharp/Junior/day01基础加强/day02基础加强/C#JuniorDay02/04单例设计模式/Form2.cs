using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _04单例设计模式
{
    public partial class Form2 : Form
    {
        //第一步：构造函数私有化
        private Form2()
        {
            InitializeComponent();
        }

        //第二部：声明一个静态的字段用来存储全局唯一的窗体对象
        private static Form2 _single = null;
        //第三步：通过一个静态函数返回一个全局唯一的对象

        public static Form2 GetSingle()
        {
            if (_single == null)
            {
                _single = new Form2();
            }
            return _single;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当你关闭窗体的时候 让窗体2的资源不被释放
            _single = new Form2();
        }
    }
}
