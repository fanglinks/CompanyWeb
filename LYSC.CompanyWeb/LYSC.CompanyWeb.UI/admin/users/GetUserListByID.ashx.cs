using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;

namespace LYSC.CompanyWeb.UI.admin.users
{
    /// <summary>
    /// GetUserListByID 的摘要说明
    /// </summary>
    public class GetUserListByID : IHttpHandler
    {
        /// <summary>
        /// 本来想写从服务端获取数据显示在前台上面的，但是没有实现功能
        /// </summary>
        /// <param name="context"></param>

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //获取ID信息
            int ID = context.Request["ID"] == null ? 0 : Convert.ToInt32(context.Request["ID"]);

            //获取为ID的实体对象
            BLL.HKSJ_USERS userServices = new BLL.HKSJ_USERS();
            var data = userServices.GetModel(ID);

            //将Json集合转换成字符串
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();

            var jsonlist = javaScriptSerializer.Serialize(data);

            context.Response.Write(jsonlist);
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