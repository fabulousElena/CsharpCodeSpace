using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16剪刀石头布
{
    class Computer
    {
        Random r = new Random();
        private string _fist;//存储拳头的字段
        public string Fist
        {
            get { return _fist; }
            set { _fist = value; }
        }
        public int ChuQuan()
        {
            int rNumber = r.Next(1, 4);
            switch (rNumber)
            { 
                case 1:
                    this.Fist = "石头";
                    break;
                case 2:
                    this.Fist = "剪刀";
                    break;
                case 3:
                    this.Fist = "布";
                    break;
            }
            return rNumber;
        }
    }
}
