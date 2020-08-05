using DalProgram;
using ModelProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BllProgram
{
    public class MemberTypeInfoBll
    {
        MemberTypeInfoDal mtid = new MemberTypeInfoDal();

        public bool DeleteMysql(MemberTypeInfo mi)
        {
            return mtid.DeleteForMysql(mi) > 0;
        }


        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public bool ChangeMysql(MemberTypeInfo mi)
        {
            return mtid.ChangeForMysql(mi) > 0;
        }


        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public bool AddMysql(MemberTypeInfo mi)
        {
            return mtid.AddToMysql(mi) > 0;
        }


        /// <summary>
        /// 获得数据库 list 的值
        /// </summary>
        /// <returns></returns>
        public List<MemberTypeInfo> GetListValue()
        {
            return mtid.GetList();
        }
    }
}
