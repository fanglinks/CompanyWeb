using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LYSC.CompanyWeb.UI.Product
{
    public partial class Product : System.Web.UI.Page
    {
        protected List<Model.HKSJ_Main> mainShow = new List<Model.HKSJ_Main>();

        //实现分页显示图片数据
        protected string NavPager { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //获取网站Main表中的数据
            BLL.HKSJ_Main mainServices = new BLL.HKSJ_Main();
            // mainShow = mainServices.GetModelList(string.Empty);

            //首先获取分页参数
            int pageSize = Request["pageSize"] == null ? 10 : Convert.ToInt32(Request["pageSize"]);
            int pageIndex = Request["pageIndex"] == null ? 1 : Convert.ToInt32(Request["pageIndex"]);

            //获取到totalCount的数据
            int totalCount = mainServices.GetRecordCount(string.Empty);

            //计算在页面上面显示的分页的数量
            DataSet ds = mainServices.GetListByPage(string.Empty, "ID", pageSize * (pageIndex - 1) + 1, pageIndex * pageSize);

            mainShow = mainServices.DataTableToList(ds.Tables[0]);

            NavPager = Common.LaomaPager.ShowPageNavigate(pageSize, pageIndex, totalCount);
        }
    }
}