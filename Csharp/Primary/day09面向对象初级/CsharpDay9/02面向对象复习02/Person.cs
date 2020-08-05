using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02面向对象复习02
{
    class Person
    {
        private string _name;
        public string Name
        {
            get { return this._name; }
            set
            {
                if (value.Length > 20)
                {
                    Console.WriteLine("您输入的字符串超出长度");
                    this._name = "超出长度";
                }
                this._name = value;
            }
        }
        private int _age;
        public int Age
        {
            get
            {
                if (this._age < 0 || this._age > 100)
                {
                    this.Age = 0;
                    return this._age;
                }
                return this._age;
            }
            set { this._age = value; }
        }
        private char _gender;
        public char Gender
        {
            get
            {
                if (this._gender != '男' && this._gender != '女')
                {
                    this._gender = '男';
                    return this._gender;
                }

                return this._gender;
            }
            set { this._gender = value; }
        }
    }
}
