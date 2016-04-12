using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;

namespace LYSC.CompanyWeb.UI.admin.Employees
{
    /// <summary>
    /// EmployeeShowJson 的摘要说明
    /// </summary>
    public class EmployeeShowJson : IHttpHandler,IRequiresSessionState
    {
        //实例化一个对象Employee
        BLL.HKSJ_Employees bll = new BLL.HKSJ_Employees();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";


            //判断用户是否登录
            if (context.Session["user"] == null)
            {
                context.Response.Write("请您正常操作");
                return;
            }

            //得到实例化的所有的信息
            //List<Model.HKSJ_Employees> employees = bll.GetModelList(string.Empty);

            //将信息构造成前台分页的信息
            //page:1，rows:20

            int pageIndex = context.Request["page"] == null ? 1 : Convert.ToInt32(context.Request["page"]);
            int pageSize = context.Request["rows"] == null ? 10 : Convert.ToInt32(context.Request["rows"]);                   
            

            //得到表中de总的数量
            int total = bll.GetRecordCount(string.Empty);
            List<Model.HKSJ_Employees> list = bll.GetPageNavEmployees(pageIndex,pageSize,out total);

            //{                                                      
            //    "total":239,                                                      
            //    "rows":[                                                          
            //        {"code":"001","name":"Name 1","addr":"Address 11","col4":"col4 data"},  
            //    ]                                                          
            //}   

            //实例化成前台需要的Json
            var date = new { total = total, rows = list };

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