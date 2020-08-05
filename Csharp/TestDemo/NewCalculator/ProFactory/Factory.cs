using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProOperation;
using System.Reflection;
using System.IO;

namespace ProFactory
{
    public class Factory
    {
        /// <summary>
        /// 工厂  返回父类  但其实父类中装的是子类对象
        /// </summary>
        /// <param name="type"></param>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static Operation GetOperation(string type, int n1, int n2)
        {
            Operation oper = null;
            //动态的获得程序集
            string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugin");
            //获得dllPath路径下所有程序集文件的全路径
            string[] filePath = Directory.GetFiles(dllPath);
            //遍历filePath  加载所有的程序集文件
            foreach (string item in filePath)
            {
                Assembly ass = Assembly.LoadFile(item);
                //获得程序集中所有的公开数据类型
                Type[] types = ass.GetExportedTypes();
                foreach (Type tt in types)
                {
                    //判断当前数据类型是不是自己需要的
                    if (tt.IsSubclassOf(typeof(Operation)) && !tt.IsAbstract)
                    {
                        //创建子类对象，赋值给oper
                        object o = Activator.CreateInstance(tt, n1, n2);
                        oper = (Operation)o;
                        //判断传进来的类型 如果是的话 就返回
                        if (type == oper.Type)
                        {
                            break;
                        }
                        else
                        {
                            oper = null;
                        }
                    }
                }

                
            }
            return oper;
        }
    }
}
