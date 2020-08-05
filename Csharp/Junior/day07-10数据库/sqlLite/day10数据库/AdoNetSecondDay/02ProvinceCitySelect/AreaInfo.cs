using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ProvinceCitySelect
{
    public class AreaInfo
    {

        public string AreaName { get; set; }

        public int AreaPId { get; set; }

        public int AreaId { get; set; }

        public override string ToString()
        {
            //就是为了让ComboBox显示省的名字。
            return AreaName;
            //return base.ToString();
        }
    }
}
