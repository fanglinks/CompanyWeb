using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin
{
    /// <summary>
    /// AddClient 的摘要说明
    /// </summary>
    public class AddClient : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            BLL.HKSJ_Clients clientServices = new BLL.HKSJ_Clients();
            context.Response.ContentType = "text/plain";

            //获取参数实现用户的添加
            Model.HKSJ_Clients client = new Model.HKSJ_Clients();


            //var title = $("#
            //var softName = $
            //var liaisonPhone
            //var liaisonPeple
            //var date = $("#t
            //peple
            client.title = context.Request["title"];
            client.softName = context.Request["softName"];
            client.liaisonPhone = context.Request["liaisonPhone"];
            client.liaisonPeple = context.Request["liaisonPeple"];
            string str = context.Request["date"];
            client.date = DateTime.Now;
            client.peple = context.Request["peple"];
            client.content = context.Request["content"];


            if (client.title != "" && client.softName != "" && client.liaisonPhone != "" && client.liaisonPeple != "" && str != "" && client.peple != "" && client.content != "")
            {
                //实现给数据库中添加数据
                if (clientServices.Add(client) > 0)
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