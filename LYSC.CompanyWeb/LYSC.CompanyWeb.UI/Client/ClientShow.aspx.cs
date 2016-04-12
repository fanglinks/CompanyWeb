using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LYSC.CompanyWeb.UI.Client
{
    public partial class ClientShow : System.Web.UI.Page
    {
        protected Model.HKSJ_Clients ClientsShow = new Model.HKSJ_Clients();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //加载客户服务信息
                BLL.HKSJ_Clients clients = new BLL.HKSJ_Clients();
                ClientsShow = clients.GetModel(int.Parse(Request["id"]));
            }
        }
    }
}