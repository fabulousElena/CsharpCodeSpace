using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.ItcastProject.Model
{
   public class UserInfo
    {
       public int Id { get; set; }
       public string UserName { get; set; }
       public string UserPass { get; set; }
       public DateTime RegTime { get; set; }
       public string Email { get; set; }
    }
}
