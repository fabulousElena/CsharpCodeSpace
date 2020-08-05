using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaterModel;

namespace CaterDal
{
    public class HallInfoDal
    {
        public List<HallInfo> GetList()
        {
            string sql = "select * from hallInfo where hIsDelete=0";
            DataTable dt = SqliteHelper.GetDataTable(sql);

            List<HallInfo> list=new List<HallInfo>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new HallInfo()
                {
                    HId = Convert.ToInt32(row["hid"]),
                    HTitle = row["htitle"].ToString()
                });
            }

            return list;
        }

        public int Insert(HallInfo hi)
        {
            string sql = "insert into hallinfo(htitle,hisDelete) values(@title,0)";
            SQLiteParameter p=new SQLiteParameter("@title",hi.HTitle);

            return SqliteHelper.ExecuteNonQuery(sql, p);
        }

        public int Update(HallInfo hi)
        {
            string sql = "update hallinfo set htitle=@title where hid=@id";
            SQLiteParameter[] ps =
            {
                new SQLiteParameter("@title",hi.HTitle), 
                new SQLiteParameter("@id",hi.HId)
            };

            return SqliteHelper.ExecuteNonQuery(sql, ps);
        }

        public int Delete(int id)
        {
            string sql = "update hallinfo set hIsDelete=1 where hid=@id";
            SQLiteParameter p=new SQLiteParameter("@id",id);
            return SqliteHelper.ExecuteNonQuery(sql, p);
        }
    }
}
