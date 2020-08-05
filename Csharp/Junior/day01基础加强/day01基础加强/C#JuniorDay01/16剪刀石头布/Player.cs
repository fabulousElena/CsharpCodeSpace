using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16剪刀石头布
{
    class Player
    {
        public int ChuQuan(string fist)//石头 剪刀 布
        {
            int res = 0;
            switch (fist)
            { 
                case "石头":
                    res = 1;
                    break;
                case "剪刀":
                    res = 2;
                    break;
                case "布":
                    res = 3;
                    break;
            }
            return res;
        }
    }
}
