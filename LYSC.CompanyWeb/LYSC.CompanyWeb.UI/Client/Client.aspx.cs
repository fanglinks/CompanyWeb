using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LYSC.CompanyWeb.UI.GuoUI.Client
{
    public partial class Client : System.Web.UI.Page
    {
        protected List<Model.HKSJ_Clients> ClientsShow = new List<Model.HKSJ_Clients>();
        protected string NavPager { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //加载客户服务信息
                BLL.HKSJ_Clients clients = new BLL.HKSJ_Clients();
               // ClientsShow = clients.GetModelList(string.Empty);
                int pageIndex = Request["pageIndex"] == null ? 1 : Convert.ToInt32(Request["pageIndex"]);
                int pageSize = Request["pageSize"] == null ? 10 : Convert.ToInt32(Request["pageSize"]);
                int totalCount = clients.GetRecordCount(string.Empty);
                ClientsShow = clients.DataTableToList(clients.GetListByPage(string.Empty, "id", (pageIndex - 1) * pageSize + 1, pageSize * pageIndex).Tables[0]);
                NavPager = Common.LaomaPager.ShowPageNavigate(pageSize, pageIndex, totalCount);

            }
        }
    }
}