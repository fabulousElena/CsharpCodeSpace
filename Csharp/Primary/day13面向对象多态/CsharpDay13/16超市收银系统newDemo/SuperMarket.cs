using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统newDemo
{
    class SuperMarket
    {
        Vip v = new Vip();
        Storage st = new Storage();

        public SuperMarket()
        {


        }
        /// <summary>
        /// 超市进货
        /// </summary>
        public void GetInGoods()
        {

            st.InGoods();

        }
        /// <summary>
        /// 购买时候的ui
        /// </summary>
        public void UiWhenBuy()
        {
            List<Vip> vipAccount = GetVipInfo();
           
            Console.WriteLine("Hello,欢迎来到沃尔玛。");
            //展示商品
            Console.WriteLine("想要购买什么商品呢？");

            List<GoodsFather> tempUsersBuyCar = new List<GoodsFather>();
            //定义一个购物车集合
            List<GoodsFather> usersBuyCar = new List<GoodsFather>();

            while (true)
            {

                Console.WriteLine("1：手机   2：电脑   3：Ipad   4：硬盘   5：水 ");
                //用来接收将要放进购物车里的数据的集合

                GoodsFather userGoodsWithCar = new GoodsFather();

                string WantedType = Console.ReadLine();
                tempUsersBuyCar = st.ShowGoods(WantedType);


                Console.WriteLine("您想选择哪一个呢？请输入编号:");
                string WantedNumber = Console.ReadLine();

                Console.WriteLine("请输入您要购买的数量。");
                //加入购物车
                int tempLoop = 0;
                int tempCount = Convert.ToInt32(Console.ReadLine());
                foreach (var item in tempUsersBuyCar)
                {
                    if (tempLoop < tempUsersBuyCar.Count)
                    {
                        if ((Convert.ToInt32(WantedNumber) - 1) == tempLoop)
                        {
                            userGoodsWithCar.Brand = tempUsersBuyCar[tempLoop].Brand;
                            userGoodsWithCar.Type = tempUsersBuyCar[tempLoop].Type;
                            userGoodsWithCar.Price = tempUsersBuyCar[tempLoop].Price;
                            userGoodsWithCar.Count = tempCount;
                            userGoodsWithCar.Id = tempUsersBuyCar[tempLoop].Id;
                            usersBuyCar.Add(userGoodsWithCar);
                            Console.WriteLine("该商品加入购物车成功：{0}类    商品{1}价格{2}   数量{3}", tempUsersBuyCar[tempLoop].Brand, tempUsersBuyCar[tempLoop].Type, tempUsersBuyCar[tempLoop].Price, tempCount);
                        }

                        tempLoop++;
                    }

                }
                GetTotalPrice(usersBuyCar);
                Console.WriteLine();

                Console.WriteLine("您想继续购物吗？  1=继续购物  2=收银结账  ");
                string quitOrNot = Console.ReadLine();
                if (quitOrNot.Equals("1"))
                {
                    Console.WriteLine("继续购买什么商品呢？");
                }
                else
                {
                    break;
                }

            }

            Console.WriteLine();
            Console.WriteLine("欢迎来到收银台~");
            Console.WriteLine("请问您是会员吗？ 1=是   2=不是");
            string vipZhanghao = null;
            string vipPass = null;
            string vipOrNot = Console.ReadLine();
            int status = 0;
            double tempDiscount = 0;
            string tempVipLevel = null;
            double tempScore = 0;
            while (status == 0)
            {
                if (vipOrNot.Equals("1"))
                {
                    Console.WriteLine("请输入您的vip账号,回车结束");
                    vipZhanghao = Console.ReadLine();
                    Console.WriteLine("请输入您的vip密码,回车结束");
                    vipPass = Console.ReadLine();

                    //遍历vipAccount集合
                    for (int i = 0; i < vipAccount.Count; i++)
                    {
                        if ((vipAccount[i].Name.Equals(vipZhanghao) && vipAccount[i].Password.Equals(vipPass)))
                        {
                            Console.WriteLine("登录成功！");
                            Console.WriteLine("欢迎{0}!您的vip等级为{1},积分为{2}，可以打{3}折~", vipAccount[i].Name, vipAccount[i].VipLevel, vipAccount[i].Score, vipAccount[i].DiscountNum);
                            status = -1;
                            tempDiscount = vipAccount[i].DiscountNum;
                            tempVipLevel = vipAccount[i].VipLevel;
                            tempScore = vipAccount[i].Score;
                            break;

                        }
                        else
                        {
                            status = 0;
                        }
                    }

                    if (status == 0)
                    {
                        Console.WriteLine("验证失败，请重新输入。");
                    }

                }
                else
                {
                    Console.WriteLine("是否注册vip呢？  1=是   2=否");
                    if (Console.ReadLine().Equals("1"))
                    {
                        Console.WriteLine("请输入您要注册的vip账号,回车结束");
                        vipZhanghao = Console.ReadLine();
                        Console.WriteLine("请输入您要注册的vip密码,回车结束");
                        vipPass = Console.ReadLine();
                        vipAccount.Add(new Vip(vipZhanghao, vipPass, "普通会员", 0, 0));
                        Console.WriteLine("注册成功..正在前往结账");
                        tempDiscount = 10;
                        tempVipLevel = "普通会员";
                        tempScore = 0;

                        break;
                    }
                    else
                    {
                        Console.WriteLine("取消注册程序，您将不享受折扣~正在前往结账");
                        tempDiscount = 10;
                        tempVipLevel = "不是会员";
                        tempScore = 0;
                        break;
                    }
                }
            }

            //在收银台进行价钱计算。
            Console.WriteLine("欢迎来到收银台~");
            Console.WriteLine("您的购物车里有如下商品：");
            Console.WriteLine();
            double tempTotalPrice = GetTotalPrice(usersBuyCar);
            Console.WriteLine();

            Console.WriteLine("正在计算....按回车查看总金额：");
            Console.ReadKey();
            Console.WriteLine("由于您是{0},所以总价打{1}折,原价{2}元,打折以后需付{3}元", tempVipLevel, tempDiscount, tempTotalPrice, tempTotalPrice * tempDiscount / 10);
            Console.WriteLine("确认付钱吗？ 1=确认   2=取消  （取消将关闭程序）");
            if (Console.ReadLine().Equals("1"))
            {
                Console.WriteLine("付款成功！！");

                tempScore = tempScore + tempTotalPrice;
                //判断会员  vipAccount
                if (0 <= tempScore && tempScore <= 999)
                {
                    Console.WriteLine("您现在是普通会员，还差{0}升级到下一级，下一级会员可以享受9折，加油呀！", (1000 - tempScore));
                    tempVipLevel = "普通会员";
                }
                else if (1000 <= tempScore && tempScore <= 4999)
                {
                    Console.WriteLine("您现在是黄金会员，还差{0}升级到下一级，下一级会员可以享受8折，加油呀！", (5000 - tempScore));
                    tempVipLevel = "黄金会员";
                }
                else if (5000 <= tempScore && tempScore <= 19999)
                {
                    Console.WriteLine("您现在是白金会员，还差{0}升级到下一级，下一级会员可以享受7折，加油呀！", (20000 - tempScore));
                    tempVipLevel = "白金会员";
                }
                else if (20000 <= tempScore && tempScore <= 69999)
                {
                    Console.WriteLine("您现在是钻石会员，还差{0}升级到下一级，下一级会员可以享受5折，加油呀！", (70000 - tempScore));
                    tempVipLevel = "钻石会员";
                }
                else if (70000 <= tempScore)
                {
                    Console.WriteLine("您现在是超至尊会员了！！！欢迎下次光临！！");
                    tempVipLevel = "超至尊会员";
                }

                //更新会员信息，然后写出
                for (int i = 0; i < vipAccount.Count; i++)
                {
                    if ((vipAccount[i].Name.Equals(vipZhanghao) && vipAccount[i].Password.Equals(vipPass)))
                    {
                        vipAccount[i].Name = vipZhanghao;
                        vipAccount[i].Password = vipPass;
                        vipAccount[i].VipLevel = tempVipLevel;
                        vipAccount[i].Score = tempScore;
                        vipAccount[i].DiscountNum = tempDiscount;
                    }
                }

                WriteVipInfo(vipAccount);

            }
            else
            {
                Console.WriteLine("取消付款...按任意键关闭程序。");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }
        /// <summary>
        /// 往相对路径中写入新的 会员信息。
        /// </summary>
        /// <param name="list">会员集合</param>
        public void WriteVipInfo(List<Vip> list)
        {

            using (StreamWriter sw = new StreamWriter("vip.txt", false, Encoding.Default)) {
                

                for (int i = 0; i < list.Count; i++)
                {
                    sw.WriteLine(list[i].Name + "_"+list[i].Password + "_" + list[i].VipLevel + "_" + list[i].Score + "_" + list[i].DiscountNum);
                    
                }

            }

        }


        /// <summary>
        /// 显示购物车内容以及计算总价
        /// </summary>
        /// <param name="list">传过来的购物车集合</param>
        /// <returns>返回总价</returns>
        public double GetTotalPrice(List<GoodsFather> list)
        {
            double totalPrice = 0;
            Console.WriteLine();
            Console.WriteLine("购物车：");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("商品类：" + list[i].Brand + "商品名：" + list[i].Type + "商品价格：" + list[i].Price + "商品数量：" + list[i].Count + "商品条形码：" + list[i].Id);
                totalPrice = totalPrice + list[i].Count * list[i].Price;

            }
            Console.WriteLine("购物车总金额为{0}", totalPrice);
            Console.WriteLine();
            return totalPrice;
        }

        public List<Vip> GetVipInfo()
        {

            List<Vip> vipList = new List<Vip>();
            using (StreamReader sr1 = new StreamReader("vip.txt", Encoding.Default))
            {
                string[] vipInfo = null;
                while (!sr1.EndOfStream)
                {
                    vipInfo = sr1.ReadLine().Split('_');
                    
                        vipList.Add(new Vip(vipInfo[0], vipInfo[1], vipInfo[2], Convert.ToDouble(vipInfo[3]), Convert.ToDouble(vipInfo[4])));
                    
                }

            }
            return vipList;
        }


    }
}
