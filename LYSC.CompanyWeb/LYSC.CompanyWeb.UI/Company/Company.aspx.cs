using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LYSC.CompanyWeb.UI.GuoUI.Company
{
    public partial class Company : System.Web.UI.Page
    {
        
        protected List<Model.HKSJ_Services> ServicesShow = new List<Model.HKSJ_Services>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //输出信息显示在前台
            BLL.HKSJ_Services server = new BLL.HKSJ_Services();
            ServicesShow = server.GetModelList(string.Empty);
        }
    }
}