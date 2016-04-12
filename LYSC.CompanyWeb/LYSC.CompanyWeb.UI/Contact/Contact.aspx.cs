using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LYSC.CompanyWeb.UI.GuoUI
{
    public partial class Contact : System.Web.UI.Page
    {
        protected List<Model.HKSJ_Relationship> ContactShow = new List<Model.HKSJ_Relationship>();
        protected string NavPager;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //加载客户服务信息
                BLL.HKSJ_Relationship contact = new BLL.HKSJ_Relationship();
                //ContactShow = contact.GetModelList(string.Empty);

                //分页
                int pageIndex = Request["pageIndex"] == null ? 1 : Convert.ToInt32(Request["pageIndex"]);
                int pageSize = Request["pageSize"] == null ? 10 : Convert.ToInt32(Request["pageSize"]);
                int totalCount = contact.GetRecordCount(string.Empty);
                ContactShow = contact.DataTableToList(contact.GetListByPage(string.Empty, "id", (pageIndex - 1) * pageSize + 1, pageSize * pageIndex).Tables[0]);
                NavPager = Common.LaomaPager.ShowPageNavigate(pageSize, pageIndex, totalCount);
            }
        }
    }
}