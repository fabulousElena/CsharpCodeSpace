using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统
{
    /// <summary>
    /// 按折扣率打折
    /// </summary>
    class CalRate:CalFather
    {

        /// <summary>
        /// 折扣率
        /// </summary>
        public double Rate
        {
            get;
            set;
        }

        public CalRate(double rate)
        {
            this.Rate = rate;
        }
        public override double GetTotalMoney(double realMoney)
        {
            return realMoney * this.Rate;
        }
    }
}
