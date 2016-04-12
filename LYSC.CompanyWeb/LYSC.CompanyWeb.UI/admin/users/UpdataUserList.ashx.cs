using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace LYSC.CompanyWeb.UI.admin.users
{
    /// <summary>
    /// UpdataUserList 的摘要说明
    /// </summary>
    public class UpdataUserList : IHttpHandler
    {
        //实例化数据访问层
        BLL.HKSJ_USERS userService = new BLL.HKSJ_USERS();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //实例化一个对象
            Model.HKSJ_USERS users = new Model.HKSJ_USERS();

            //获取ID信息
            //ID: RowUpdateUserID[0].ID,
            //UserName: $("#txtUpdateUserName").val(),
            //LoginName: $("#txtUpdateLoginName").val(),
            //Password: $("#txtUpdatePassword").val(),
            //Plane: $("#txtUpdatePlane").val(),
            //Phone: $("#txtUpdatePhone").val(),
            //Email: $("#txtUpdateEmail").val(),
            //CardNo: $("#txtUpdateCardNo").val()
            users.ID = context.Request["ID"] == null ? 0 : Convert.ToInt32(context.Request["ID"]);
            users.UserName = context.Request["UserName"];
            users.LoginName = context.Request["LoginName"];
            users.PassWord = context.Request["Password"];
            users.Plane = context.Request["Plane"];
            users.phone = context.Request["Phone"];
            users.Mail = context.Request["Email"];
            users.cardNo = context.Request["CardNo"];

            //进行修改实现功能
            if (userService.Update(users))
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