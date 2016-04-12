using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace LYSC.CompanyWeb.UI.admin.CompanyCulture
{
    /// <summary>
    /// DownLoadContext 的摘要说明
    /// </summary>
    public class DownLoadContext : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {

            //首先判断用户是否已经登陆
            if (context.Session["user"] == null)
            {
                context.Response.Write("请您正常操作");
                return;
            }

            context.Response.ContentType = "text/plain";
            BLL.HKSJ_Services serviceObj = new BLL.HKSJ_Services();
            List<Model.HKSJ_Services> list = new List<Model.HKSJ_Services>();
            list = serviceObj.GetModelList(string.Empty);
            var data =new {total=1,rows=list};
            //系列化
            System.Web.Script.Serialization.JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            string jsonStr = javaScriptSerializer.Serialize(data);
            context.Response.Write(jsonStr);
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