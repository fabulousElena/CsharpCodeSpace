using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CZBK.ItcastProject.DAL;
namespace CZBK.ItcastProject.BLL
{
   public class UserInfoService
    {
      UserInfoDal UserInfoDal = new UserInfoDal();
       /// <summary>
       /// 返回数据列表
       /// </summary>
       /// <returns></returns>
       public List<UserInfo> GetList()
       {
           return UserInfoDal.GetList();

       }
       /// <summary>
       /// 添加数据
       /// </summary>
       /// <param name="userInfo"></param>
       /// <returns></returns>
       public bool AddUserInfo(UserInfo userInfo)
       {
           return UserInfoDal.AddUserInfo(userInfo)>0;
       }
    }
}
