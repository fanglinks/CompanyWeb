using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.news
{
    /// <summary>
    /// DeleteNewsJson 的摘要说明
    /// </summary>
    public class DeleteNewsJson : IHttpHandler
    {
        BLL.HKSJ_Main mainService = new BLL.HKSJ_Main();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            int newsID = context.Request["newsID"] == null ? 0 : int.Parse(context.Request["newsID"]);

            if (mainService.Delete(newsID))
            {
                context.Response.Write("OK");
            }
            else
            {
                context.Response.Write("error");
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