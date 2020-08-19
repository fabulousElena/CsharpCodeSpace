using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UsersInfoValidate
    {
        public int uid { get; set; }
        [Required(ErrorMessage = "用户名不能为空")]
        public string uaccount { get; set; }
        public string upassword { get; set; }
        public string uphone { get; set; }
        public string uemail { get; set; }
        public string udatetime { get; set; }
    }

    [MetadataType(typeof(UsersInfoValidate))]
    public  partial class usersinfo
    {
        
    }


}