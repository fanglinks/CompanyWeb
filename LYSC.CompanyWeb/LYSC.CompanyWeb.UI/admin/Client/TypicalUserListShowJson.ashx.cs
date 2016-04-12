using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Script.Serialization;
using System.Web.SessionState;

namespace LYSC.CompanyWeb.UI.admin.Client
{
    /// <summary>
    /// TypicalUserListShowJson 的摘要说明
    /// 用来获取典型客户的信息
    /// </summary>
    public class TypicalUserListShowJson : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            //判断用户是否登录
            //首先判断用户是否已经登陆
            if (context.Session["user"] == null)
            {
                context.Response.Write("请您正常操作");
                return;
            }


            context.Response.ContentType = "text/plain";
            //page:2
            //rows:10
            //sort:ID
            //order:asc
            List<Model.HKSJ_Clients> list = new List<Model.HKSJ_Clients>();
            BLL.HKSJ_Clients clientService = new BLL.HKSJ_Clients();
            int pageIndex = context.Request["page"] == null ? 1 : int.Parse(context.Request["page"]);
            int pageSize = context.Request["rows"] == null ? 5 : int.Parse(context.Request["rows"]);

            DataSet ds = clientService.GetListByPage("", "id", (pageIndex - 1) * pageSize + 1, pageSize * pageIndex);

            list = clientService.DataTableToList(ds.Tables[0]);

            int total = clientService.GetRecordCount(string.Empty);

            var data = new { total = total, rows = list };

            JavaScriptSerializer TypicalClientJSon = new JavaScriptSerializer();

            string json = TypicalClientJSon.Serialize(data);
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