using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.Web.AdminManager
{
    public partial class AddCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string msg=Request["txtMsg"];
                msg = msg.Trim();
                string[]words=msg.Split(new char[]{'\r','\n'},StringSplitOptions.RemoveEmptyEntries);
                BLL.Articel_WordsManager bll = new BLL.Articel_WordsManager();
                foreach (string word in words)
                {
                    string[]w=word.Split('=');
                    Model.Articel_Words model = new Model.Articel_Words();
                    model.WordPattern = w[0];
                    if (w[1] == "{BANNED}")
                    {
                        model.IsForbid = true;
                    }
                    else if (w[1] == "{MOD}")
                    {
                        model.IsMod = true;
                    }
                    else
                    {
                        model.ReplaceWord = w[1];
                    }
                    bll.Insert(model);
                }
            }
        }
    }
}