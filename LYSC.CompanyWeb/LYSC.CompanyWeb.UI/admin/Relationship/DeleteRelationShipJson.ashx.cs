using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.Relationship
{
    /// <summary>
    /// DeleteRelationShipJson 的摘要说明
    /// </summary>
    public class DeleteRelationShipJson : IHttpHandler
    {
        //实例化一个客服联系方式的对象
        BLL.HKSJ_Relationship relationShipSrevices = new BLL.HKSJ_Relationship();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //relationShipID
            //获取到要删除的ID
            int relationShipID = context.Request["relationShipID"] == null ? 0 : Convert.ToInt32(context.Request["relationShipID"]);

            //实现删除
            if (relationShipSrevices.Delete(relationShipID))
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