using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02枚举
{
    //
        //    [public] enum 枚举名
        //{
        //    值1,
        //    值2,
        //    值3,
        //    ........
        //}


    //声明了一个枚举 Gender
    public enum Gender
    {
        男,
        女
    }

    class Program
    {

        static void Main(string[] args)
        {
            //变量类型 变量名=值;
            int n = 10;
            Gender gender = Gender.男;

            //为什么会有枚举这个东东？
            //xx大学管理系统
            //姓名 性别 年龄 系别 年级  
            //性别
            //char gender = '男';
            //string s1 = "female";
            //string ss1 = "爷们";
        }
    }
}
