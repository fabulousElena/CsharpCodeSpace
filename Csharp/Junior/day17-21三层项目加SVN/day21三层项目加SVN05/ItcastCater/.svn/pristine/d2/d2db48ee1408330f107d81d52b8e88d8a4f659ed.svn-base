using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaterUI.test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private DialogResult result = DialogResult.Cancel;

        //希望将方法赋值给一个变量，这个变量要求是委托类型
        //类-》实例化-》对象
        //委托-》实例化-》委托对象
        //一般将委托实例化采用直接赋值的方式，而不用构造方法
        //委托对象-》事件（本质是委托对象）
        //Action<T>:无返回值的委托
        //Func<T>：有返回值的委托

        //事件：event,关键：让变量不能在外部被调用，但是可以被访问；只能进行+=、-=操作，而不能进行=操作
        public event Action myDelegate;
        public Func<int> myDelegate2;//无参数，返回int类型的值

        //public Delegate a1;

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            
        }

        private int SetBtn()
        {
            
            button1.Text = "欢迎";
            return 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myDelegate2 += SetBtn;//当对象没有初始化时，第一次调用必须是=
            //当进行了多次加等之后，再进行赋值时，依然可以使用=运算符，会将之前的赋值清除

            //调用事件，就可以执行事件中的方法
            //myDelegate();


        }
    }
}
