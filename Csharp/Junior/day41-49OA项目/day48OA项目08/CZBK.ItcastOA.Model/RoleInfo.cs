//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CZBK.ItcastOA.Model
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class RoleInfo
    {
        public RoleInfo()
        {
            this.ActionInfo = new HashSet<ActionInfo>();
            this.UserInfo = new HashSet<UserInfo>();
        }
    
        public int ID { get; set; }
        public string RoleName { get; set; }
        public short DelFlag { get; set; }
        public System.DateTime SubTime { get; set; }
        public string Remark { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string Sort { get; set; }
    
     [JsonIgnore]
        public virtual ICollection<ActionInfo> ActionInfo { get; set; }
     [JsonIgnore]
        public virtual ICollection<UserInfo> UserInfo { get; set; }
    }
}
