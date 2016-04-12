using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace LYSC.CompanyWeb.UI.admin.users
{
    /// <summary>
    /// AddUserList 的摘要说明
    /// </summary>
    public class AddUserList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            BLL.HKSJ_USERS userServices = new BLL.HKSJ_USERS();
            context.Response.ContentType = "text/plain";

            //获取参数实现用户的添加
            Model.HKSJ_USERS users = new Model.HKSJ_USERS();

            //UserName，LoginName，Password，Plane，Phone，Email，CardNo;
            users.UserName = context.Request["UserName"];
            users.LoginName = context.Request["LoginName"];
            users.PassWord = context.Request["Password"];
            users.Plane = context.Request["Plane"];
            users.phone = context.Request["Phone"];
            users.Mail = context.Request["Email"];
            users.cardNo = context.Request["CardNo"];

            //实现给数据库中添加数据
            if (userServices.Add(users) > 0)
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