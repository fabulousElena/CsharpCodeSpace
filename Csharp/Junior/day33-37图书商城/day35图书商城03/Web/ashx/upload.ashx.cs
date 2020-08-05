using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace BookShop.Web.ashx
{
    /// <summary>
    /// upload 的摘要说明
    /// </summary>
    public class upload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string action = context.Request["action"];
            if (action == "upload")//上传图片
            {
                ProcessFileUpload(context);
            }
            else if (action =="cut")//截取图片
            {
                ProcessCutPhoto(context);
            }
            else
            {
                context.Response.Write("参数错误!!");
            }
        }
        /// <summary>
        /// 文件上传
        /// </summary>
        /// <param name="context"></param>
        private void ProcessFileUpload(HttpContext context)
        {
            HttpPostedFile file = context.Request.Files["Filedata"];
            if (file != null)
            {
                string fileName = Path.GetFileName(file.FileName);
                string fileExt = Path.GetExtension(fileName);
                if (fileExt == ".jpg")
                {
                    string dir = "/ImageUpload/" + DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day + "/";
                    if (!Directory.Exists(context.Request.MapPath(dir)))
                    {
                        Directory.CreateDirectory(context.Request.MapPath(dir));
                    }
                    string newfileName = Guid.NewGuid().ToString();
                    string fullDir = dir + newfileName + fileExt;
                    file.SaveAs(context.Request.MapPath(fullDir));
                    using (Image img = Image.FromFile(context.Request.MapPath(fullDir)))
                    {
                        context.Response.Write(fullDir + ":" + img.Width + ":" + img.Height);
                    }

                    //file.SaveAs(context.Request.MapPath("/ImageUpload/"+fileName));
                    //context.Response.Write("/ImageUpload/" + fileName);
                }
            }
        }

        /// <summary>
        /// 图片的截取
        /// </summary>
        /// <param name="context"></param>
        private void ProcessCutPhoto(HttpContext context)
        {
            int x = Convert.ToInt32(context.Request["x"]);
            int y = Convert.ToInt32(context.Request["y"]);
            int width = Convert.ToInt32(context.Request["width"]);
            int height = Convert.ToInt32(context.Request["height"]);
            string imgSrc = context.Request["imgSrc"];//获取上传成功的图片的路径
            using (Bitmap map = new Bitmap(width, height))
            {
                using (Graphics g = Graphics.FromImage(map))
                {
                    using (Image img = Image.FromFile(context.Request.MapPath(imgSrc)))
                    {
                        //第一个参数：表示画哪张图片.
                        //二：画多么大。
                        //三：画原图的哪块区域
                        g.DrawImage(img, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);
                        string newfileName = Guid.NewGuid().ToString();
                        string fullDir = "/ImageUpload/" + newfileName + ".jpg";
                        map.Save(context.Request.MapPath(fullDir),System.Drawing.Imaging.ImageFormat.Jpeg);
                        context.Response.Write(fullDir);

                    }
                   
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}