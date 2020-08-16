using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
   public class StudentInfo
    {
       [Key]
       public int Id { get; set; }
       [StringLength(32)]
       [Required]
       public string StuName { get; set; }
        [Required]
       public DateTime SubTime { get; set; }
       public virtual ClassInfo ClassInfo { get; set; }
    }
}
