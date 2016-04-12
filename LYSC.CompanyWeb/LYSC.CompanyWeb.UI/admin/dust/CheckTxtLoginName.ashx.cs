using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.dust
{
    /// <summary>
    /// CheckTxtLoginName 的摘要说明
    /// </summary>
    public class CheckTxtLoginName : IHttpHandler
    {
        //实例化一个查询用户的信息
        BLL.HKSJ_USERS usersService = new BLL.HKSJ_USERS();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //得到前台传递过来的值
            string LoginName = context.Request["LoginName"] == null ? null : context.Request["LoginName"].ToString();

            //判断用户是否存在
            if (usersService.ExistsLoginName(LoginName))
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