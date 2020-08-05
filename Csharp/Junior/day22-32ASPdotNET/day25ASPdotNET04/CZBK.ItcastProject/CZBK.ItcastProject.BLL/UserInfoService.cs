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
        /// <summary>
        /// 根据ID删除用户的信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       public bool DeleteUserInfo(int id)
       {
           return UserInfoDal.DeleteUserInfo(id) > 0;
       }
       /// <summary>
        /// 根据用户的编号，获取用户的信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       public UserInfo GetUserInfo(int id)
       {
           return UserInfoDal.GetUserInfo(id);
       }
         /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
       public bool EditUserInfo(UserInfo userInfo)
       {
           return UserInfoDal.EditUserInfo(userInfo)>0;
       }
    }
}
