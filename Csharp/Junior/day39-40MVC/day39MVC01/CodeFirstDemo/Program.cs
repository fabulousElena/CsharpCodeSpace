using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeFirstDbContext db = new CodeFirstDbContext();
            db.Database.CreateIfNotExists();
            ClassInfo classInfo = new ClassInfo();
            classInfo.ClassName = "0413班";
            classInfo.CreateTime = DateTime.Now;
            db.ClassInfo.Add(classInfo);
            db.SaveChanges();

        }
    }
}
