using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02打开文件练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要打开的文件所在的路径");
            string filePath = Console.ReadLine();
            Console.WriteLine("请输入要打开的文件的名字");
            string fileName = Console.ReadLine();

            //通过简单工厂设计模式返回父类

            BaseFile bf = GetFile(filePath, fileName);
            if (bf != null)
            {
                bf.OpenFile();
            }
            Console.ReadKey();
        }

        static BaseFile GetFile(string filePath,string fileName)
        {
            BaseFile bf = null;
            string strExtension = Path.GetExtension(fileName);//3.txt
            switch (strExtension)
            { 
                case ".txt":
                    bf = new TxtFile(filePath, fileName);
                    break;
                case ".avi":
                    bf = new AviFile(filePath, fileName);
                    break;
                case ".mp4":
                    bf = new MP4File(filePath, fileName);
                    break;
            }
            return bf;
        }

    }

    class BaseFile
    { 
        //字段、属性、构造函数、函数、索引器
        private string _filePath;
        public string FilePath//ctrl+R+E
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        //自动属性 prop+两下tab
        public string FileName { get; set; }

        public BaseFile(string filePath, string fileName)
        {
            this.FilePath = filePath;
            this.FileName = fileName;
        }

      
        //设计一个函数  用来打开指定的文件
        public void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.FilePath + "\\" + this.FileName);
            Process pro = new Process();
            pro.StartInfo = psi;
            pro.Start();
        }
    }

    class TxtFile : BaseFile
    { 
        //因为子类会默认调用父类无参数的构造函数

        public TxtFile(string filePath, string fileName)
            : base(filePath, fileName)
        { }
    }


    class MP4File : BaseFile
    {
        public MP4File(string filePath, string fileName)
            : base(filePath, fileName)
        { }
    }

    class AviFile : BaseFile
    {
        public AviFile(string filePath, string fileName)
            : base(filePath, fileName)
        { }
    }
}
