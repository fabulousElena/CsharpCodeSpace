using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
   public class ClassInfo
    {
       [Key]
       public int Id { get; set; }
       [StringLength(32)]
       [Required]
       public string ClassName { get; set; }
       [Required]
       public DateTime CreateTime { get; set; }
       public virtual ICollection<StudentInfo> StudentInfo { get; set; }
    }
}
