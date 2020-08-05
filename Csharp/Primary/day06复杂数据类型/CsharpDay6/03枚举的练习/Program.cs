using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03枚举的练习
{
    public enum Sesons
    { 
        春,
        夏,
        秋,
        冬
    }

    public enum QQState
    { 
        OnLine,
        OffLine,
        Leave,
        Busy,
        QMe
    }


    class Program
    {
        static void Main(string[] args)
        {
            Sesons s = Sesons.春;
            QQState state = QQState.OnLine;

        }
    }
}
