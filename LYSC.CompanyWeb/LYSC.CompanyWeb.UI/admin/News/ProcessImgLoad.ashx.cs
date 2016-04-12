using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.News
{
    /// <summary>
    /// ProcessImgLoad 的摘要说明
    /// </summary>
    public class ProcessImgLoad : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //保存上传图片
            HttpPostedFile img = context.Request.Files[0];
            img.SaveAs(context.Server.MapPath("images/" + img.FileName));
            //返回图片地址
            context.Response.Write(img.FileName);
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