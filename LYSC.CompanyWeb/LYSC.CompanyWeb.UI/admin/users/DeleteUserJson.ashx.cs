using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace LYSC.CompanyWeb.UI.admin.users
{
    /// <summary>
    /// DeleteUserJson 的摘要说明
    /// </summary>
    public class DeleteUserJson : IHttpHandler
    {
        //定义用户业务逻辑成对象
        BLL.HKSJ_USERS userService = new BLL.HKSJ_USERS();

        public void ProcessRequest(HttpContext context)
        {

            context.Response.ContentType = "text/plain";
            //获取到要删除用户的ID
            int userID = context.Request["userID"] == null ? 0 : Convert.ToInt32(context.Request["userID"]);

            //执行计算，对获取到的数据进行删除
            if (userService.Delete(userID))
            {
                context.Response.Write("OK");
            }
            else
            {
                context.Response.Write("Error");
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