using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace LYSC.CompanyWeb.UI.admin.Employees
{
    /// <summary>
    /// EmployeeShowJson 的摘要说明
    /// </summary>
    public class EmployeeShowJson1 : IHttpHandler
    {
        //实例化一个对象Employee
        BLL.HKSJ_Employees employeesService = new BLL.HKSJ_Employees();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //得到实例化的所有的信息
            List<Model.HKSJ_Employees> employees = employeesService.GetModelList(string.Empty);

            //得到总的数量
            int total = employeesService.GetRecordCount(string.Empty);

            //{                                                      
            //    "total":239,                                                      
            //    "rows":[                                                          
            //        {"code":"001","name":"Name 1","addr":"Address 11","col4":"col4 data"},  
            //    ]                                                          
            //}   

            //实例化成前台需要的Json
            var date = new { total = total, rows = employees };

            //将此实例化集合进行转换成Json对象，
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            string data = javaScriptSerializer.Serialize(date);

            //输出所有的信息
            context.Response.Write(data);
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