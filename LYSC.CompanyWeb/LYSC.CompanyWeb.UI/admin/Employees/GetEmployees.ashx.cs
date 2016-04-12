using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.Employees
{
    /// <summary>
    /// GetEmployees 根据ID返回JSON数据；
    /// </summary>
    public class GetEmployees : IHttpHandler
    {
        BLL.HKSJ_Employees bll = new BLL.HKSJ_Employees();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            Model.HKSJ_Employees model = new Model.HKSJ_Employees();
            int id = context.Request["relationID"] == null ? 0 : int.Parse(context.Request["relationID"]);
            model=bll.GetModel(id);

            System.Web.Script.Serialization.JavaScriptSerializer ja = new System.Web.Script.Serialization.JavaScriptSerializer();

            

            context.Response.Write(ja.Serialize(model));
        
        
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