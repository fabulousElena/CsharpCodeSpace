using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaterDal;
using CaterModel;

namespace CaterBll
{
    public partial class ManagerInfoBll
    {
        //创建数据层对象
        ManagerInfoDal miDal = new ManagerInfoDal();

        public List<ManagerInfo> GetList()
        {
            //调用查询方法
            return miDal.GetList();
        }

        public bool Add(ManagerInfo mi)
        {
            //调用dal层的insert方法，完成插入操作
            return miDal.Insert(mi) > 0;
        }

        public bool Edit(ManagerInfo mi)
        {
            return miDal.Update(mi) > 0;
        }

        public bool Remove(int id)
        {
            return miDal.Delete(id) > 0;
        }
    }
}
