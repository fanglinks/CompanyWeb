using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LYSC.CompanyWeb.UI.GuoUI.Service
{
    public partial class Service : System.Web.UI.Page
    {
        protected List<Model.HKSJ_Services> ServicesShow = new List<Model.HKSJ_Services>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //加载客户服务信息
                BLL.HKSJ_Services services = new BLL.HKSJ_Services();
                ServicesShow = services.GetModelList(string.Empty);
            }
        }
    }
}