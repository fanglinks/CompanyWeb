using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.news
{
    /// <summary>
    /// UpdateNewsList 的摘要说明
    /// </summary>
    public class UpdateNewsList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            BLL.HKSJ_Main mainService = new BLL.HKSJ_Main();

            context.Response.ContentType = "text/plain";

            Model.HKSJ_Main newsInfo = new Model.HKSJ_Main();

            newsInfo.ID = context.Request["ID"] == null ? 0 : Convert.ToInt32(context.Request["ID"]);
            newsInfo.title = context.Request["title"];
            newsInfo.content = context.Request["content"];
            newsInfo.Date = Convert.ToDateTime(context.Request["Date"]);
            newsInfo.type = context.Request["type"];
            newsInfo.people = context.Request["people"];
            newsInfo.picUrl = context.Request["picUrl"];

            if (mainService.Update(newsInfo))
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