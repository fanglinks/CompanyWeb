using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.Employees
{
    /// <summary>
    /// AddEmployeesList 的摘要说明
    /// </summary>
    public class AddEmployeesList : IHttpHandler
    {
        BLL.HKSJ_Employees bll = new BLL.HKSJ_Employees();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");

            Model.HKSJ_Employees model = new Model.HKSJ_Employees();
             //Position: Position,
             //Content: Content,
             //Demand: Demand,
             //State: State,
             //DateTime: DateTime,
             //People: People
            model.content = context.Request["Content"];
            model.title = context.Request["Position"];
            model.status = int.Parse(context.Request["State"]);
            model.MainPeople = context.Request["People"];
            model.people = context.Request["Demand"];
            model.date = Convert.ToDateTime(context.Request["DateTime"]);

            if (bll.Add(model) > 0)
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