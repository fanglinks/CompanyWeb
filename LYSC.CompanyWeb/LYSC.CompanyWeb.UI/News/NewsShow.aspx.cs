using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LYSC.CompanyWeb.UI.GuoUI.News
{
    public partial class NewsShow : System.Web.UI.Page
    {
        protected Model.HKSJ_Main mainShowInfo;

        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Request["ID"] == null ? 0 : Convert.ToInt32(Request["ID"]);

            //获取ID的新闻显示在页面上面
            BLL.HKSJ_Main mainServices = new BLL.HKSJ_Main();
            mainShowInfo = mainServices.GetModel(ID);

        }
    }
}