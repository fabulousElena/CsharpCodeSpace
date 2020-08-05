using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统02
{
    class CangKu
    {
        //存储货物  功能  因为要求长度随时变化，所以用集合存储
        List<List<ProductFather>> list = new List<List<ProductFather>>();

        /// <summary>
        ///向用户展示货物
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("我们超市有：" + item[0].Name + "," + "\t" + "有" + item.Count + "个," + "\t" + "每个" + item[0].Price + "元");
            }
        }

        //list[0]存 acer
        //list[1]存三星
        //list[2]存酱油
        //list[3]存香蕉
        /// <summary>
        /// 在创建仓库对象的时候，向仓库中添加货架
        /// </summary>
        public CangKu()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
        /// <summary>
        /// 存储货物
        /// </summary>
        /// <param name="strType">货物的类型</param>
        /// <param name="count">货物的数量</param>
        public void JinPros(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        list[0].Add(new Acer(1000, "宏碁acern7000", Guid.NewGuid().ToString()));
                        break;
                    case "SamSung":
                        list[1].Add(new SamSung(9999, "盖乐世s20", Guid.NewGuid().ToString()));
                        break;
                    case "JiangYou":
                        list[2].Add(new JiangYou(50, "厨邦酱油", Guid.NewGuid().ToString()));
                        break;
                    case "Banana":
                        list[3].Add(new Banana(10, "菲律宾香蕉", Guid.NewGuid().ToString()));
                        break;
                    default:
                        break;
                }
            }

        }

        public ProductFather[] QuPros(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "SamSung":
                        pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "JiangYou":
                        pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana":
                        pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }

            return pros;
        }

    }
}
