using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LYSC.CompanyWeb.UI.GuoUI.Employment
{
    public partial class Employment : System.Web.UI.Page
    {
        protected List<Model.HKSJ_Employees> Empoyees = new List<Model.HKSJ_Employees>();
        protected string NavPager;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //加载信息       
                BLL.HKSJ_Employees employees = new BLL.HKSJ_Employees();
                //Empoyees = employees.GetModelList(string.Empty);
                //分页
                int pageIndex = Request["pageIndex"] == null ? 1 : Convert.ToInt32(Request["pageIndex"]);
                int pageSize = Request["pageSize"] == null ? 10 : Convert.ToInt32(Request["pageSize"]);
                int totalCount = employees.GetRecordCount(string.Empty);
                Empoyees = employees.DataTableToList(employees.GetListByPage(string.Empty, "id", (pageIndex - 1) * pageSize + 1, pageSize * pageIndex).Tables[0]);
                NavPager = Common.LaomaPager.ShowPageNavigate(pageSize, pageIndex, totalCount);
            }
        }
    }
}