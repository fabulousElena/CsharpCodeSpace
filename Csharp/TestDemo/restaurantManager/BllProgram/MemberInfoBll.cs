using DalProgram;
using ModelProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BllProgram
{
    
    public partial class MemberInfoBll
    {
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public bool ChangeAtMysql(MemberInfo mi) {

            return mid.ChangeMysql(mi) >0;
        }

        /// <summary>
        /// 查询操作
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public List<MemberInfo> SerchMysql(string s) {
           return mid.SerchFromMysql(s);
        }


        /// <summary>
        /// 获得下拉菜单栏的内容  list集合
        /// </summary>
        /// <returns></returns>
        public List<string> GetMem() {
           return mid.GetMemberString();
        }



        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public bool AddToMysql(MemberInfo mi) {
           return mid.AddMysql(mi)>0;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public bool DeleteFromMysql(MemberInfo mi)
        {
            return mid.DeleteMysql(mi) > 0;
        }

        MemberInfoDal mid = new MemberInfoDal();
        /// <summary>
        /// 返回给ui数据
        /// </summary>
        /// <returns></returns>
        public List<MemberInfo> GetMysqlList()
        {
            return mid.GetList();
        }
    }
}
