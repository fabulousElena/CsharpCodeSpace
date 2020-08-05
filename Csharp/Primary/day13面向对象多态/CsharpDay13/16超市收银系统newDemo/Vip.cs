using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统newDemo
{
    class Vip
    {
        private string _name;
        private string _password;
        private string _vipLevel;
        private double _score;
        private double _discountNum;

        public Vip(){}

        

        public string Name { get => _name; set => _name = value; }
        public string VipLevel { get => _vipLevel; set => _vipLevel = value; }
        public double Score { get => _score; set => _score = value; }
        public double DiscountNum { get => _discountNum; set => _discountNum = value; }
        public string Password { get => _password; set => _password = value; }

        public Vip(string name,string password, string viplevel,double score,double discountnum) {
            this.Name = name;
            this.Password = password;
            this.VipLevel = viplevel;
            this.Score = score;
            this.DiscountNum = discountnum;
        }

        
}
}
