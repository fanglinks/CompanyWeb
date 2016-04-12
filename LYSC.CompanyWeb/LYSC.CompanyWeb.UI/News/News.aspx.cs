using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LYSC.CompanyWeb.UI.GuoUI.News
{
    public partial class News : System.Web.UI.Page
    {
        protected List<Model.HKSJ_Main> mainShowo = new List<Model.HKSJ_Main>();
        protected string NavPager { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //输出所有的信息
            BLL.HKSJ_Main mainService = new BLL.HKSJ_Main();
            //mainShowo = mainService.GetModelList(string.Empty);


            //分页每页显示13个记录
            int pageIndex = Request["pageIndex"] == null ? 1 : Convert.ToInt32(Request["pageIndex"]);
            int pageSize = Request["pageSize"] == null ? 13 : Convert.ToInt32(Request["pageSize"]);

            //获取总数totalCount
            int totalCount = mainService.GetRecordCount(string.Empty);

            DataSet ds = mainService.GetListByPage(string.Empty, "ID", pageSize * (pageIndex - 1) + 1, pageSize * pageIndex);
            mainShowo = mainService.DataTableToList(ds.Tables[0]);

            NavPager = Common.LaomaPager.ShowPageNavigate(pageSize, pageIndex, totalCount);

        }
    }
}