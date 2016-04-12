using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.Relationship
{
    /// <summary>
    /// UpdateRelationShip 的摘要说明
    /// </summary>
    public class UpdateRelationShip : IHttpHandler
    {
        //实例化BLL层
        BLL.HKSJ_Relationship relationShipServices = new BLL.HKSJ_Relationship();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //ID: RowUpdateRelationShipID[0].ID,
            //Address: $("#txtUpdateAddress").val(),
            //Zip: $("#txtUpdateZip").val(),
            //Plane: $("#txtUpdateLoginPlane").val(),
            //Fax: $("#txtUpdateFax").val(),
            //QQMSN: $("#txtUpdateQQMSN").val(),
            //Date: $("#txtUpdateDate").val(),
            //people: $("#txtUpdatePeople").val(),


            //实例化Model对象。
            Model.HKSJ_Relationship relationship = new Model.HKSJ_Relationship();
            relationship.ID = context.Request["ID"] == null ? 0 : Convert.ToInt32(context.Request["ID"]);
            relationship.Address = context.Request["Address"];
            relationship.Zip = context.Request["Zip"];
            relationship.plane = context.Request["Plane"];
            relationship.Fax = context.Request["Fax"];
            relationship.QQ_MSN = context.Request["QQMSN"];
            relationship.Date = Convert.ToDateTime(context.Request["Date"]);
            relationship.people = context.Request["people"];

            //使用数据库实现修改信息
            if (relationShipServices.Update(relationship))
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