using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace LYSC.CompanyWeb.UI.admin.Relationship
{
    /// <summary>
    /// GetRelationShip 的摘要说明
    /// </summary>
    public class GetRelationShip : IHttpHandler
    {
        //实例化一个客户服务联系的对象
        BLL.HKSJ_Relationship relationShipServices = new BLL.HKSJ_Relationship();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //获取要显示详细信息的ID
            int relationID = context.Request["relationID"] == null ? 0 : Convert.ToInt32(context.Request["relationID"]);

            //获取实体对象
            var date = relationShipServices.GetModel(relationID);

            //转换成Json格式
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            var list = javaScriptSerializer.Serialize(date);

            context.Response.Write(list);

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