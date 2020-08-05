using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统newDemo
{
    class Storage
    {
        //仓库 是个List集合  list里面存储 商品List集合

        List<List<GoodsFather>> huoJia = new List<List<GoodsFather>>();
        
        /// <summary>
        /// 创建仓库的时候，会自动添加货架
        /// </summary>
        public Storage(){
            huoJia.Add(new List<GoodsFather>());
            huoJia.Add(new List<GoodsFather>());
            huoJia.Add(new List<GoodsFather>());
            huoJia.Add(new List<GoodsFather>());
            huoJia.Add(new List<GoodsFather>());
        }

        /// <summary>
        /// 进货  从进货单里读取  然后存储到类中
        /// </summary>
        public void InGoods()
        {
            //读取进货单
            using (StreamReader sr = new StreamReader("进货单.txt", Encoding.Default))
            {
                string tempString = null;
                string[] tempArray = null;
                //循环读取  每次循环添加一种商品
                while (!sr.EndOfStream) {
                    //当读到每一行的时候，进行判断。  tempArray[1], tempArray[2], tempArray[3],Guid.NewGuid().ToByteArray()

                    tempString = sr.ReadLine();
                    tempArray = tempString.Split('_');

                    if (tempArray[0].Length < 10)
                    {
                        tempArray[1] = tempArray[1] + "      ";
                    }


                    switch (tempArray[0])
                    {
                        case "CellPhone":
                            huoJia[0].Add(new CellPhon("CellPhone", tempArray[1], Convert.ToDouble(tempArray[2]), Convert.ToInt32(tempArray[3]), Guid.NewGuid().ToString()));
                            break;
                        case "Computer":
                            huoJia[1].Add(new Computer("Computer", tempArray[1], Convert.ToDouble(tempArray[2]), Convert.ToInt32(tempArray[3]), Guid.NewGuid().ToString()));
                            break;
                        case "Ipad":
                            huoJia[2].Add(new Ipad("Ipad", tempArray[1], Convert.ToDouble(tempArray[2]), Convert.ToInt32(tempArray[3]), Guid.NewGuid().ToString()));
                            break;
                        case "Disk":
                            huoJia[3].Add(new Disk("Disk", tempArray[1], Convert.ToDouble(tempArray[2]), Convert.ToInt32(tempArray[3]), Guid.NewGuid().ToString()));
                            break;
                        case "Water":
                            huoJia[4].Add(new Water("Water", tempArray[1], Convert.ToDouble(tempArray[2]), Convert.ToInt32(tempArray[3]), Guid.NewGuid().ToString()));
                            break;

                    }
                }

            }

        }
        /// <summary>
        /// 展示用户选择的商品类型
        /// </summary>
        /// <param name="type">用户选择的类型</param>
        /// <returns>返回当前选择的类型集合  比如cellphone集合</returns>
        public List<GoodsFather> ShowGoods(string type)
        {
            
            List<GoodsFather> userList = new List<GoodsFather>();
            
            int tempIndex = 0;
            switch (type)
            {
                case "1":
                    foreach (var item in huoJia[0])
                    {
                        
                        tempIndex++;
                        Console.WriteLine("编号:" + tempIndex + "\t" + "类型：" + item.Type + "\t" + "价格：" + item.Price + "\t" + "数量" + item.Count + "\t");
                        GoodsFather allUserBought = new GoodsFather(item.Brand,item.Type,item.Price,item.Count,item.Id);
                        userList.Add(allUserBought);
                        
                    }
                    break;
                case "2":
                    foreach (var item in huoJia[1])
                    {
                        tempIndex++;
                        Console.WriteLine("编号:" + tempIndex + "\t" + "类型：" + item.Type + "\t" + "价格：" + item.Price + "\t" + "数量" + item.Count + "\t");
                        GoodsFather allUserBought = new GoodsFather(item.Brand, item.Type, item.Price, item.Count, item.Id);
                        userList.Add(allUserBought);
                    }
                    break;
                case "3":
                    foreach (var item in huoJia[2])
                    {
                        tempIndex++;
                        Console.WriteLine("编号:" + tempIndex + "\t" + "类型：" + item.Type + "\t" + "价格：" + item.Price + "\t" + "数量" + item.Count + "\t");
                        GoodsFather allUserBought = new GoodsFather(item.Brand, item.Type, item.Price, item.Count, item.Id);
                        userList.Add(allUserBought);
                    }
                    break;
                case "4":
                    foreach (var item in huoJia[3])
                    {
                        tempIndex++;
                        Console.WriteLine("编号:" + tempIndex + "\t" + "类型：" + item.Type + "\t" + "价格：" + item.Price + "\t" + "数量" + item.Count + "\t");
                        GoodsFather allUserBought = new GoodsFather(item.Brand, item.Type, item.Price, item.Count, item.Id);
                        userList.Add(allUserBought);
                    }
                    break;
                case "5":
                    foreach (var item in huoJia[4])
                    {
                        tempIndex++;
                        Console.WriteLine("编号:" + tempIndex + "\t" + "类型：" + item.Type + "\t" + "价格：" + item.Price + "\t" + "数量" + item.Count + "\t");
                        GoodsFather allUserBought = new GoodsFather(item.Brand, item.Type, item.Price, item.Count, item.Id);
                        userList.Add(allUserBought);
                    }
                    break;
                default:
                    break;
            }


            return userList;
        }
        
    }
}
