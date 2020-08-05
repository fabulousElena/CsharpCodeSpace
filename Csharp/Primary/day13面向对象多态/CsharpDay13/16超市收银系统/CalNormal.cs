using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统
{

    /// <summary>
    /// 不打折 该多少钱就多少钱
    /// </summary>
    class CalNormal:CalFather
    {
        public override double GetTotalMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
