using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModelProgram
{
   public class MemberTypeInfo
    {
        private  int _memid;
        private  string _memtitle;
        private  double _memdiscount;
        private  int _memisdelete;

        public  int Memid { get => _memid; set => _memid = value; }
        public  string Memtitle { get => _memtitle; set => _memtitle = value; }
        public  double Memdiscount { get => _memdiscount; set => _memdiscount = value; }
        public  int Memisdelete { get => _memisdelete; set => _memisdelete = value; }
    }
}
