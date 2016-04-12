using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.CompanyCulture
{
    /// <summary>
    /// UpdateContext 的摘要说明
    /// </summary>
    public class UpdateContext : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //取出所有传过来的参数
            string CulContext = context.Request["contentCulture"];
            string name=context.Request["name"];
            int id = context.Request["id"] == null ? 1 : int.Parse(context.Request["id"]);
            //新建对象
            BLL.HKSJ_Services serviceObj = new BLL.HKSJ_Services();
            Model.HKSJ_Services service = serviceObj.GetModel(id);
            //赋值
            service.Context = CulContext;
            service.Name = name;
            //更新
            if (serviceObj.Update(service))
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