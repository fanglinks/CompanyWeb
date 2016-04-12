using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;

namespace LYSC.CompanyWeb.UI.admin.users
{
    /// <summary>
    /// UserListShowJson 的摘要说明
    /// </summary>                              
    public class UserListShowJson : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";


            //首先判断用户是否已经登陆
            if (context.Session["user"] == null)
            {
                context.Response.Write("请您正常操作");
                return;
            }

            //构造出使用easyUI显示的用户信息的Json数据

            //首先计算出User用户的集合
            BLL.HKSJ_USERS userServices = new BLL.HKSJ_USERS();
            //var list = userServices.GetModelList(string.Empty);

            //获取easyUI分页的参数page:1，rows:30
            int pageIndex = context.Request["page"] == null ? 1 : Convert.ToInt32(context.Request["page"]);
            int pageSize = context.Request["rows"] == null ? 10 : Convert.ToInt32(context.Request["rows"]);

            //计算出总的数量为了给easyUI控件实现分页
            int total = userServices.GetRecordCount(string.Empty);

            var list = userServices.GetPageSizeNav(pageIndex, pageSize, out total);
            //{                                                      
            //    "total":239,                                                      
            //    "rows":[                                                          
            //        {"code":"001","name":"Name 1","addr":"Address 11","col4":"col4 data"},  
            //    ]                                                          
            //}   
            //计算出分页的总数

            //使用匿名类来实现前台要求的Json格式，序列化为此格式
            var data = new { total = total, rows = list };

            //将data集合构造成Json字符串
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();

            string json = javaScriptSerializer.Serialize(data);
            context.Response.Write(json);
                                                   
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