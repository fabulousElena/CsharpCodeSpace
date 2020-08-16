using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
   public class CodeFirstDbContext:DbContext
    {
       public CodeFirstDbContext()
           : base("name=connStr")
       {

       }
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
       }
    
       public DbSet<ClassInfo> ClassInfo { get; set; }
       public DbSet<StudentInfo> StudentInfo { get; set; }
    }
}
