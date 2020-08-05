using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;
namespace CZBK.ItcastProject.WebApp._2015_5_27
{
    /// <summary>
    /// ProcessFileUp 的摘要说明
    /// </summary>
    public class ProcessFileUp : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
           HttpPostedFile file=context.Request.Files[0];//获取上传的文件.
           if (file.ContentLength>0)
           {
               //对上传的文件类型进行校验。
               string fileName =Path.GetFileName(file.FileName);//获取上传文件的名称包含扩展名。
               string fileExt = Path.GetExtension(fileName);//获取用户上传的文件扩展名。
               if (fileExt == ".jpg")
               {
                   //1.对上传文件进行重命名？
                   string newfileName = Guid.NewGuid().ToString();
                   //2:将上传的文件放在不同的目录下面?
                   string dir = "/ImageUpload/"+DateTime.Now.Year+"/"+DateTime.Now.Month+"/"+DateTime.Now.Day+"/";
                   //创建文件夹
                   if (!Directory.Exists(context.Request.MapPath(dir)))
                   {
                       Directory.CreateDirectory(context.Request.MapPath(dir));
                   }

                   string fullDir = dir + newfileName + fileExt;//文件存放的完整路径。
                  file.SaveAs(context.Request.MapPath(fullDir));

                 //  file.SaveAs(context.Request.MapPath("/ImageUpload/"+fileName));//完成文件的保存。

                   //创建图片的水印.
                  // using (Image img = Image.FromStream(file.InputStream))
                   //根据上传成功的图片创建一个Image
                  using (Image img = Image.FromFile(context.Request.MapPath(fullDir)))
                  {
                      using (Bitmap map = new Bitmap(img.Width,img.Height))//根据画布的高度与宽度创建画布。
                      {
                          //为画布创建画笔.
                          using (Graphics g = Graphics.FromImage(map))
                          {

                              //设置高质量插值法
                              g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

                              //设置高质量,低速度呈现平滑程度
                              g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                              //用画笔在画布上画图，从画布的左上角开始，将整个图片画到画布上。
                              g.DrawImage(img, 0, 0, img.Width, img.Height);
                              g.DrawString("传智播客", new Font("黑体", 14.0f, FontStyle.Bold), Brushes.Red, new PointF(map.Width-100,map.Height-25));
                              string waterImageName ="water_"+Guid.NewGuid().ToString();
                              map.Save(context.Request.MapPath("/ImageUpload/"+waterImageName+".jpg"),System.Drawing.Imaging.ImageFormat.Jpeg);
                              context.Response.Write("<html><body><img src='/ImageUpload/" + waterImageName + ".jpg'/></body></html>");
                          }
                      }
                  }


         
               }
               else
               {
                   context.Response.Write("只能上传图片文件");
               }
           }
           else
           {
               context.Response.Write("请选择上传文件");
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