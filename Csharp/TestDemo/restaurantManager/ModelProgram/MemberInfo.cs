using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProgram
{
   public partial class MemberInfo
    {
        private int _miid;
        private int _mitypeid;
        private string _miname;
        private string _miphone;
        private double _mimoney;
        private int _miisdelete;
        private string _mimembertype;

        public int Miid { get => _miid; set => _miid = value; }
        public int Mitypeid { get => _mitypeid; set => _mitypeid = value; }
        public string Miname { get => _miname; set => _miname = value; }
        public string Miphone { get => _miphone; set => _miphone = value; }
        public double Mimoney { get => _mimoney; set => _mimoney = value; }
        public int Miisdelete { get => _miisdelete; set => _miisdelete = value; }
        public string Mimembertype { get => _mimembertype; set => _mimembertype = value; }
    }
}
