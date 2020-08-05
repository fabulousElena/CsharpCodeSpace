using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02模拟磁盘打开文件
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                   Console.WriteLine("请选择要进入的磁盘");
            string path = Console.ReadLine();//D:\
            Console.WriteLine("请选择要打开的文件");
            string fileName = Console.ReadLine();//1.txt
            //文件的全路径：path+fileName

            FileFather ff = GetFile(fileName, path + fileName);
            ff.OpenFile();
            Console.ReadKey();
            }
         
        }


        public static FileFather GetFile(string fileName, string fullPath)
        {
            string extension = Path.GetExtension(fileName);
            FileFather ff = null;
            switch (extension)
            {
                case ".txt": ff = new TxtPath(fullPath);
                    break;
                case ".jpg": ff = new JpgPath(fullPath);
                    break;
                case ".wmv": ff = new WmvPath(fullPath);
                    break;
            }
            return ff;
        }
    }

    public abstract class FileFather
    {
        public string fullPath
        {
            get;
            set;
        }
        public FileFather(string fullPath)
        {
            this.fullPath = fullPath;
        }
        public abstract void OpenFile();
    }
     

    public class TxtPath : FileFather
    {
        public TxtPath(string fullPath)
            : base(fullPath)
        {

        }

        public override void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.fullPath);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }

    public class JpgPath : FileFather
    {
        public JpgPath(string fullPath)
            : base(fullPath)
        {

        }


        public override void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.fullPath);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }

    public class WmvPath : FileFather
    {
        public WmvPath(string fullPath)
            : base(fullPath)
        {

        }

        public override void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.fullPath);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }


}
