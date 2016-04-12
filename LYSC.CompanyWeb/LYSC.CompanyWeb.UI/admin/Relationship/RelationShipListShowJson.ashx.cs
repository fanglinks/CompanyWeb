using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;

namespace LYSC.CompanyWeb.UI.admin.Relationship
{
    /// <summary>
    /// RelationShipListShowJson 的摘要说明
    /// </summary>
    public class RelationShipListShowJson : IHttpHandler,IRequiresSessionState
    {
        //实例化客服的对象
        BLL.HKSJ_Relationship RelationShipServices = new BLL.HKSJ_Relationship();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //判断用户是否登录
            if (context.Session["user"] == null)
            {
                context.Response.Write("请您正常操作");
                return;
            }


            //查询出所有的信息显示在客服联系方式的的界面上面，
            //var data = RelationShipServices.GetModelList(string.Empty);

            //将信息构造成前台分页的信息
            //page:1，rows:20
            int pageIndex = context.Request["page"] == null ? 1 : Convert.ToInt32(context.Request["page"]);
            int pageSize = context.Request["rows"] == null ? 10 : Convert.ToInt32(context.Request["rows"]);

            //得出表中的总数
            int total = RelationShipServices.GetRecordCount(string.Empty);

            var list = RelationShipServices.GetPagerNavRelation(pageIndex, pageSize, out total);

            //获取到Json格式的字符串
            var date = new { total = total, rows = list };

            //将List转换成Json的格式
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            var relationshipJson = javaScriptSerializer.Serialize(date);

            context.Response.Write(relationshipJson);
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