using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.Employees
{
    /// <summary>
    /// DeleteEmployees 的摘要说明
    /// </summary>
    public class DeleteEmployees : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            int id = context.Request["relationShipID"] == null ? 0 : int.Parse(context.Request["relationShipID"]);
            BLL.HKSJ_Employees bll = new BLL.HKSJ_Employees();
            Model.HKSJ_Employees model = new Model.HKSJ_Employees();

            if (bll.Delete(id))
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