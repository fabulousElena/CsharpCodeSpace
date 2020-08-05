using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookShop.BLL
{
    public class Articel_WordsManager
    {
        DAL.Articel_WordsService dal = new DAL.Articel_WordsService();
        public bool Insert(Model.Articel_Words model)
        {
            return dal.Insert(model)>0;
        }
        /// <summary>
        /// 判断用户的评论中是否有禁用词
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool CheckForbid(string msg)
        {
            List<string> list = dal.GetForbidWord();//获取所有的禁用词 放入缓存中。
            string regex = string.Join("|",list.ToArray());//aa|bb|cc|
            return Regex.IsMatch(msg, regex);
            //foreach (string word in list)
            //{
            //    msg.Contains(word);
            //    break;
            //}

        }
        /// <summary>
        /// 审查词过滤
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool CheckMod(string msg)
        {

            List<string> list = dal.GetModWord();//获取所有的审查词，放入缓存中。
            string regex = string.Join("|", list.ToArray());//aa|bb|cc|
            regex = regex.Replace(@"\", @"\\").Replace("{2}",@".{0,2}");
            return Regex.IsMatch(msg, regex);
        }
        /// <summary>
        /// 替换词过滤
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public string CheckReplace(string msg)
        {
            List<Model.Articel_Words> list = dal.GetReplaceWord();//放入缓存中。
            foreach (Model.Articel_Words model in list)
            {
                msg = msg.Replace(model.WordPattern, model.ReplaceWord);
            }
            return msg;
        }
    }
}
