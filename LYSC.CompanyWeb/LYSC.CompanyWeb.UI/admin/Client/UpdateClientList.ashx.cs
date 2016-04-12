using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.Client
{
    /// <summary>
    /// UpdateClientList 的摘要说明
    /// </summary>
    public class UpdateClientList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            BLL.HKSJ_Clients clientService = new BLL.HKSJ_Clients();
            Model.HKSJ_Clients client = new Model.HKSJ_Clients();
            context.Response.ContentType = "text/plain";
            //id: RowUpdat
            //title: $("#t
            //softName: $(
            //liaisonPhone
            //liaisonPeple
            //date: $("#tx
            // peple: $("#t
            client.id = context.Request["id"] == null ? 0 : int.Parse(context.Request["id"]);
            client.title = context.Request["title"];
            client.softName = context.Request["softName"];
            client.liaisonPhone = context.Request["liaisonPhone"];
            client.liaisonPeple = context.Request["liaisonPeple"];
            client.date = context.Request["date"] == null ? DateTime.Now : Convert.ToDateTime(context.Request["date"]);
            client.peple = context.Request["peple"];
            client.content = context.Request["content"];

            if (client.title != "" && client.softName != "" && client.liaisonPhone != "" && client.liaisonPeple != "" && client.peple != "" && client.content != "")
            {
                //实现给数据库中添加数据
                if (clientService.Update(client))
                {
                    context.Response.Write("OK");
                }
                else
                {
                    context.Response.Write("error");
                }
            }
            else
            {
                context.Response.Write("LackOfRequeryItem");
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