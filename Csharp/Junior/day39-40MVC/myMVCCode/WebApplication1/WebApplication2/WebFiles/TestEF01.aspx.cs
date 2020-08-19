using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.Models;

namespace WebApplication2.WebFiles
{
    public partial class TestEF01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var mb = new MemberInfo();
            mb.mitypeid = 7;
            mb.miname = "EF我叫EF";
            mb.miphone = "这是phone";
            mb.mimoney = 333333;
            mb.miisdelete = false;

            //找到 Model1.Context.tt 里的类名，也就是数据表名加上Entities
            //通过它向数据库添加操作
            var mtd = new myTestDatabaseEntities();
            //将数据添加到EF并添加了添加标记。
            mtd.MemberInfo.Add(mb);
            //把数据保存到数据库  自动生成语句添加到数据库。
            //返回受影响的行数  int
            var lines = mtd.SaveChanges();
            //获得刚插入的id
            Response.Write(mb.miid);
        }

        //当查询按钮点击时
        protected void Button2_Click(object sender, EventArgs e)
        {
            //new 一个数据库操作类
            myTestDatabaseEntities db = new myTestDatabaseEntities();
            //使用 Linq 表达式
            IQueryable<MemberInfo> memberList = from mem in db.MemberInfo where mem.miid == 28 select mem;
            //遍历得到的数据 
            //延迟加载机制 --当数据使用到的时候，才会进行查询 例子中当语句走到  in 的时候，才开始进行数据库查询
            foreach (MemberInfo mebInfo in memberList)
            {
                Response.Write(mebInfo.miphone);
            }
        }

        //当删除按钮点击的时候
        protected void Button3_Click(object sender, EventArgs e)
        {
            var db = new myTestDatabaseEntities();
            //var memberList = from mem in db.MemberInfo
            //                 where mem.miid == 28
            //                 select mem;
            ////返回第一个元素或者null(没有元素的时候)  FirstOrDefault();
            //MemberInfo mbi = memberList.FirstOrDefault();
            //if (mbi != null)
            //{
            //    //删除查出来的数据
            //    //db.MemberInfo.Remove(mbi);
            //    //通过枚举标记数据的状态  标记为删除状态
            //    db.Entry<MemberInfo>(mbi).State = System.Data.Entity.EntityState.Deleted;
            //    //更新到数据库中
            //    db.SaveChanges();
            //}
            //else
            //{
            //    Response.Write("删除的数据不存在");
            //}

            //方法2  常用
            MemberInfo mbi = new MemberInfo() { miid = 29 };
            db.Entry<MemberInfo>(mbi).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }

        //更新按钮点击的时候
        protected void Button4_Click(object sender, EventArgs e)
        {
            var db = new myTestDatabaseEntities();
            var memberList = from mem in db.MemberInfo where mem.miid == 31 select mem;
            var mbi = memberList.FirstOrDefault();
            mbi.miphone = "新的phone新的phone";
            //把状态标记为更新
            db.Entry<MemberInfo>(mbi).State = EntityState.Modified;
            db.SaveChanges();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            var uu = new uuPussy();
            uu.uage = 18;
            uu.uprice=2000;
            uu.uisfirst = true;

            Model2Container1 db = new Model2Container1();
            db.uuPussySet.Add(uu);
            db.SaveChanges();//默认开启了事务
        }
    }
}