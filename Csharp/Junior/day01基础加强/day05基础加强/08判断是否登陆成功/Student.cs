using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08判断是否登陆成功
{
    class Student
    {
        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public char Gender
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public override bool Equals(object obj)
        {
            Student s = obj as Student;
            if (this.Name == s.Name && this.Age == s.Age && this.Gender == s.Gender && this.ID == s.ID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
