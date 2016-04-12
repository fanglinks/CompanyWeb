using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYSC.CompanyWeb.UI.admin.Relationship
{
    /// <summary>
    /// AddRelationShipList 的摘要说明
    /// </summary>
    public class AddRelationShipList : IHttpHandler
    {
        //实例化客服实例管理方式
        BLL.HKSJ_Relationship relationShipServices = new BLL.HKSJ_Relationship();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            
            //实例化客户服务管理对象
            Model.HKSJ_Relationship relationShip = new Model.HKSJ_Relationship();
            //AddRess: AddRess,
            //AddZip: AddZip,
            //Plane: Plane,
            //Fax: Fax,
            //QQMSN: QQMSN,
            //DateTime: DateTime,
            //People: People
            relationShip.Address = context.Request["AddRess"];
            relationShip.Zip = context.Request["AddZip"];
            relationShip.plane = context.Request["Plane"];
            relationShip.Fax = context.Request["Fax"];
            relationShip.QQ_MSN = context.Request["QQMSN"];
            relationShip.Date = Convert.ToDateTime(context.Request["DateTime"]);
            relationShip.people = context.Request["People"];


            if (relationShipServices.Add(relationShip) > 0)
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