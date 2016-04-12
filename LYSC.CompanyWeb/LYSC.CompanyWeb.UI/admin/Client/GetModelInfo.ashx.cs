using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.Client
{
    /// <summary>
    /// GetModelInfo 的摘要说明
    /// </summary>
    public class GetModelInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int clientId = context.Request["id"] == null ? 0 : int.Parse(context.Request["id"]);
            BLL.HKSJ_Clients clientService = new BLL.HKSJ_Clients();
            Model.HKSJ_Clients client = new Model.HKSJ_Clients();
            client = clientService.GetModel(clientId);               
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            context.Response.Write(serializer.Serialize(client));
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