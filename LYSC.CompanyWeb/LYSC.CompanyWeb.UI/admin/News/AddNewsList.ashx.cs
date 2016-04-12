using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.news
{
    /// <summary>
    /// AddNewsList 的摘要说明
    /// </summary>
    public class AddNewsList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            BLL.HKSJ_Main mainService = new BLL.HKSJ_Main();
            context.Response.ContentType = "text/plain";

            Model.HKSJ_Main newsInfo = new Model.HKSJ_Main();

            newsInfo.title = context.Request["title"] == null ? string.Empty : context.Request["title"];
            newsInfo.content = context.Request["content"] == null ? string.Empty : context.Request["content"];
            newsInfo.Date = Convert.ToDateTime(context.Request["Date"]);

            //这里不能限制读取的值
            newsInfo.type = string.Format("{0}", "1       ");
            newsInfo.people = context.Request["people"] == null ? string.Format("{0}", "Unknow") : context.Request["people"];
            
            newsInfo.picUrl = context.Request["picUrl"] == null ? string.Empty : context.Request["picUrl"];

            if (mainService.Add(newsInfo) > 0)
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