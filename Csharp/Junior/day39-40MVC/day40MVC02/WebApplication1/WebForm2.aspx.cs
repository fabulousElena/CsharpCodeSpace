using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Model2Container db = new Model2Container();
            Customer customer = new Customer() {CustomerName="zhangsan",CustomerPwd="123", SubTime=DateTime.Now };
            OrderInfo orderInfo1 = new OrderInfo() { ID = Guid.NewGuid(), OrderNum = "10001", CreateDateTime = DateTime.Now,Customer=customer };
            OrderInfo orderInfo2 = new OrderInfo() { ID = Guid.NewGuid(), OrderNum = "10002", CreateDateTime = DateTime.Now, Customer = customer };
            db.Customer.Add(customer);
            db.OrderInfo.Add(orderInfo1);
            db.OrderInfo.Add(orderInfo2);
            db.SaveChanges();//默认的已经开启了事务。 工作单元模式。（UnitOfwork）
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Model2Container db = new Model2Container();
            var customerList = from c in db.Customer
                               select c;
            foreach (var customer in customerList)
            {
                Response.Write(customer.CustomerName+":");


                foreach (var orderInfo in customer.OrderInfo)//延迟加载。
                {
                    Response.Write(orderInfo.OrderNum);
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Model2Container db = new Model2Container();
            //var customerInfoList = from c in db.Customer
            //                   where c.ID == 1
            //                   select c;
            //var customerInfo = customerInfoList.FirstOrDefault();
            //foreach (var orderInfo in customerInfo.OrderInfo)
            //{
            //    Response.Write(orderInfo.OrderNum);
            //}

            var orderInfoList = from o in db.OrderInfo
                               where o.CustomerID == 1
                               select o;
            foreach (var orderInfo in orderInfoList)
            {
                Response.Write(orderInfo.OrderNum);
            }
                           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
             Model2Container db = new Model2Container();
             var orderInfoList = from o in db.OrderInfo
                                 where o.OrderNum == "10001"
                                 select o;
             var orderInfo = orderInfoList.FirstOrDefault();
             Customer customer = orderInfo.Customer;
             Response.Write(customer.CustomerName);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Model2Container db = new Model2Container();
            //var customer = (from c in db.Customer
            //                where c.ID == 1
            //                select c).FirstOrDefault();
            //var orderInfoList = customer.OrderInfo;
            //while (orderInfoList.Count > 0)
            //{
            //    var orderInfo = orderInfoList.FirstOrDefault();
            //    db.Entry<OrderInfo>(orderInfo).State = System.Data.EntityState.Deleted;
            //}
            //db.SaveChanges();

            var orderList = from o in db.OrderInfo
                            where o.CustomerID == 2
                            select o;

        }

    }
}