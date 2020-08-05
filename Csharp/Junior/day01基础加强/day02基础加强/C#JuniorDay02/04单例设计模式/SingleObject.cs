using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04单例设计模式
{
    class SingleObject
    {
        private SingleObject()
        { }

        private static SingleObject _single = null;

        public static SingleObject GetSingle()
        {
            if (_single == null)
            {
                _single = new SingleObject();
            }
            return _single;
        }

        public Form3 FrmThree
        {
            get;
            set;
        }

        public Form4 FrmFour
        {
            get;
            set;
        }

        public Form5 FrmFive
        {
            get;
            set;
        }
        public void CreateForm()
        { 
            
        }

       

    }
}
