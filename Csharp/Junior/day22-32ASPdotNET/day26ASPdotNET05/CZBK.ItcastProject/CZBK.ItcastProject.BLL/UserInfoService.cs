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
       /// <summary>
       /// 计算获取数据的访问，完成分页
       /// </summary>
       /// <param name="pageIndex">当前页码</param>
       /// <param name="pageSize">每页显示的记录数据</param>
       /// <returns></returns>
       public List<UserInfo> GetPageList(int pageIndex,int pageSize)
       {
           int start=(pageIndex-1)*pageSize+1;
           int end = pageIndex * pageSize;
          return UserInfoDal.GetPageList(start, end);

       }
       /// <summary>
       /// 获取总的页数
       /// </summary>
       /// <param name="pageSize">每页显示的记录数</param>
       /// <returns></returns>
       public int GetPageCount(int pageSize)
       {
           int recoredCount = UserInfoDal.GetRecordCount();//获取总的记录数.
           int pageCount =Convert.ToInt32(Math.Ceiling((double)recoredCount / pageSize));
           return pageCount;
       }
    }
}
