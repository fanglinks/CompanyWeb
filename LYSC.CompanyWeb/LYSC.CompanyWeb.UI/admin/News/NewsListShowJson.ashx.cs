using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;

namespace LYSC.CompanyWeb.UI.admin.news
{
    /// <summary>
    /// NewsListShowJson 的摘要说明
    /// </summary>
    public class NewsListShowJson : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //判断用户是否登录
            if (context.Session["user"] == null)
            {
                context.Response.Write("请您正常操作");
                return;
            }

            //取出新闻列表
            BLL.HKSJ_Main mainService = new BLL.HKSJ_Main();

            //获取分页的参数
            int pageIndex = context.Request["page"] == null ? 1 : int.Parse(context.Request["page"]);

            int pageSize = context.Request["rows"] == null ? 10 : int.Parse(context.Request["rows"]);

            //计算出总数量
            int totalCount = mainService.GetRecordCount(string.Empty);

            var newsList = mainService.GetNavPageData(pageSize, pageIndex, out totalCount);

            //将得到的数据转换成json格式字符串
            var data = new { total= totalCount, rows = newsList };

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();

            string json = javaScriptSerializer.Serialize(data);
            context.Response.Write(json);
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