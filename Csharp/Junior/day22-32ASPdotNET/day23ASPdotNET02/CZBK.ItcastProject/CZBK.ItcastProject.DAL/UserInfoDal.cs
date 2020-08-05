using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CZBK.ItcastProject.DAL
{
    public class UserInfoDal
    {

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetList()
        {
            string sql = "select * from UserInfo";
            DataTable da = SqlHelper.GetDataTable(sql, CommandType.Text);
            List<UserInfo> list = null;
            if (da.Rows.Count > 0)
            {
                list = new List<UserInfo>();
                UserInfo userInfo = null;
                foreach (DataRow row in da.Rows)
                {
                    userInfo = new UserInfo();
                    LoadEntity(userInfo, row);
                    list.Add(userInfo);
                }
            }
            return list;
        }
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public int AddUserInfo(UserInfo userInfo)
        {
            string sql = "insert into UserInfo(UserName,UserPass,RegTime,Email) values(@UserName,@UserPass,@RegTime,@Email)";
            SqlParameter[] pars = { 
                                new SqlParameter("@UserName",SqlDbType.NVarChar,32),
                                  new SqlParameter("@UserPass",SqlDbType.NVarChar,32),
                                         new SqlParameter("@RegTime",SqlDbType.DateTime),
                                    new SqlParameter("@Email",SqlDbType.NVarChar,32)
                               
                                
                                };
            pars[0].Value = userInfo.UserName;
            pars[1].Value = userInfo.UserPass;
            pars[2].Value = userInfo.RegTime;
            pars[3].Value = userInfo.Email;
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pars);

        }


        private void LoadEntity(UserInfo userInfo, DataRow row)
        {
            userInfo.UserName = row["UserName"] != DBNull.Value ? row["UserName"].ToString() : string.Empty;

            userInfo.UserPass = row["UserPass"] != DBNull.Value ? row["UserPass"].ToString() : string.Empty;
            userInfo.Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : string.Empty;
            userInfo.Id = Convert.ToInt32(row["ID"]);
            userInfo.RegTime = Convert.ToDateTime(row["RegTime"]);
        }

    }
}
