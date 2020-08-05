using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09石头剪刀布
{
    class Computer
    {


        /// <summary>
        /// 存储电脑出的拳头
        /// </summary>
        public string Fist
        {
            get;
            set;
        }


        public int ShowFist()
        {
            Random r = new Random();
            int rNumber = r.Next(1, 4);
            switch (rNumber)
            {
                case 1: this.Fist = "石头";
                    break;
                case 2: this.Fist = "剪刀";
                    break;
                case 3: this.Fist = "布";
                    break;
            }
            return rNumber;
        }
    }
}
