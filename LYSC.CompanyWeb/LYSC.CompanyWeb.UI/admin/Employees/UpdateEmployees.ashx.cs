using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.Employees
{
    /// <summary>
    /// UpdateEmployees 的摘要说明
    /// </summary>
    public class UpdateEmployees : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");

            BLL.HKSJ_Employees bll = new BLL.HKSJ_Employees();
            Model.HKSJ_Employees model = new Model.HKSJ_Employees();

            //ID, title, content, people, date, status, MainPeople
             //构造修改的参数
             //var updateEmployeesDate = {
                    //ID: RowUpdateEmployeesID[0].ID,
                    //title: $("#txtUpdatePosition").val(),
                    //content: $("#txtUpdatePositionContent").val(),
                    //people: $("#txtUpdateDemand").val(),
                    //status: $("#txtUpdateState").val(),
                   
                    //Date: $('#txtUpdateDate').datebox('getValue'),
                    //MainPeople: $("#txtUpdatePeople").val(),
            model.ID =int.Parse( context.Request["ID"]);
            model.title = context.Request["title"];
            model.content = context.Request["content"];
            model.people=context.Request["people"];
            model.status = int.Parse(context.Request["status"]);
            model.MainPeople = context.Request["MainPeople"];
            model.date = Convert.ToDateTime(context.Request["Date"]);


            if (bll.Update(model))
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