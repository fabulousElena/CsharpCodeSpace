using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02面向对象复习
{
    public class Person
    {
        //字段、属性、方法
        string _name;
        public string Name
        {
            get
            {
                if (_name != "孙全")
                {
                    return _name = "孙全";
                }
                return _name;
            }
            set { _name = value; }
        }
        int _age;
        public int Age
        {
            get { return _age; }
            set {

                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value; }
        }
        char _gender;
        public char Gender
        {
            get {
                if (_gender != '男' && _gender != '女')
                {
                    return _gender = '男';
                }
                
                return _gender; }
            set { _gender = value; }
        }


        public void SayHello()
        {
            Console.WriteLine("我叫{0},我今年{1}岁了,我是{2}生", this.Name, this.Age,this.Gender);
        }



    }
}
