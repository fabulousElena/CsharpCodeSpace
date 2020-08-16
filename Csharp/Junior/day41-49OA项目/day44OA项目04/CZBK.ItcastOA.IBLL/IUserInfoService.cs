using CZBK.ItcastOA.Model;
using CZBK.ItcastOA.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.ItcastOA.IBLL
{
   public interface IUserInfoService:IBaseService<UserInfo>
    {
       bool DeleteEntities(List<int>list);
       IQueryable<UserInfo> LoadSearchEntities(UserInfoSearch userInfoSearch, short delFlag);
    }
}
