using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.Client
{
    /// <summary>
    /// DeleteClientJson 的摘要说明
    /// </summary>
    public class DeleteClientJson : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            BLL.HKSJ_Clients clientService = new BLL.HKSJ_Clients();

            int clientId = context.Request["clientID"] == null ? 0 : Convert.ToInt32(context.Request["clientID"]);

            //执行计算，对获取到的数据进行删除
            if (clientService.Delete(clientId))
            {
                context.Response.Write("OK");
            }
            else
            {
                context.Response.Write("Error");
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