using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=0;
            for (int i = 0; i < 600000000;i++ )
            {
                a = i;
            }
            MessageBox.Show(a.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(StartCaul);
            Thread myThread = new Thread(threadStart);
        //    myThread.Priority = ThreadPriority.Normal;//建议操作系统将创建的线程优先级设置为最高。
           // myThread.Name = "";
           // myThread.Abort();
            myThread.IsBackground = true;//设置为后台线程。
            myThread.Start();
           // myThread.Join(1000);//阻塞主线程。
           
        }
        //bool isStop = false;
        private void StartCaul()
        {
            int a = 0;
            for (int i = 0; i < 600000000; i++)
            {
               // if (!isStop)
               // {
                    a = i;
               // }
               // else
               // {
                  
               // }
            }
            //MessageBox.Show(a.ToString());
            this.textBox1.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>() {1,2,3,4,5 };
            ParameterizedThreadStart parThreadStart = new
             ParameterizedThreadStart(Show);
            Thread thread1 = new Thread(parThreadStart);
            thread1.IsBackground = true;
            thread1.Start(list);
        }
        private void Show(object obj)
        {
            List<int> list = obj as List<int>;
            foreach (int i in list)
            {
                MessageBox.Show(i.ToString());
            }
        }
        /// <summary>
        /// 跨线程访问
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(ShowResult);
            thread1.IsBackground = true;
            thread1.Start();
        }
        private void ShowResult()
        {
            int a = 0;
            for (int i = 0; i < 600000000; i++)
            {
               
                a = i;
              
            }
            //MessageBox.Show(a.ToString());
            if (this.textBox1.InvokeRequired)//是否要对文本框进行跨线程访问。
            {
                //Invoke：去找创建TextBox的线程（主线程（UI线程）），有主线程完成委托方法的调用。
                this.textBox1.Invoke(new Action<TextBox, string>(ShowTextBoxValue), this.textBox1, a.ToString());//
            }
            else
            {
                this.textBox1.Text = a.ToString();
            }
        }

        private void ShowTextBoxValue(TextBox txt,string value)
        {
            txt.Text = value;

        }

        private void button5_Click(object sender, EventArgs e)
        {
          //  this.textBox1.Text = "safasdfd";
            Thread thread1 = new Thread(AddSum);
            thread1.IsBackground = true;
            thread1.Start();

            Thread thread2 = new Thread(AddSum);
            thread2.IsBackground = true;
            thread2.Start();
        }



        private static readonly object obj = new object();

        private void AddSum()
        {
            lock (obj)  
            {

                for (int i = 0; i < 2000; i++)
                {
                    int a = Convert.ToInt32(this.textBox1.Text);
                    a++;
                    this.textBox1.Text = a.ToString();
                }
            }
           
        }
    }
}
