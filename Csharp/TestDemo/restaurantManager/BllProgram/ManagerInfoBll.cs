using CommonProgram;
using DalProgram;
using ModelProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BllProgram
{
    public partial class ManagerInfoBll
    {
        ManagerInfo mi;
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="sname">用户名</param>
        /// <param name="spass">密码</param>
        /// <returns></returns>
        public bool CheckLogin(string sname, string spass)
        {
            mi = mid.UserLogin(sname);
            if (mi.userpass == Md5Helper.GetMd(spass))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// 返回登录的用户类型
        /// </summary>
        /// <returns></returns>
        public string ReturnType()
        {
            return mi.usertype;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public bool DeleteToMysql(ManagerInfo mi)
        {
            return mid.DeleteManager(mi) > 0;
        }


        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="mi">是操作的数据对象 封装起来的</param>
        /// <param name="b">是否更改了密码</param>
        /// <returns></returns>
        public bool UpdateToMysql(ManagerInfo mi, bool b)
        {
            return mid.UpdateManager(mi, b) > 0;
        }



        ManagerInfoDal mid = new ManagerInfoDal();
        //创建数据层对象
        public List<ManagerInfo> GetListValue()
        {
            return mid.GetList();
        }
        /// <summary>
        /// 判断执行的行数   大于0则成功
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public bool AddToMySql(ManagerInfo mi)
        {
            return mid.InsertInto(mi) > 0;
        }
    }
}
