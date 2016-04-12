
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LYSC.CompanyWeb.UI.Users
{
    public partial class Index : System.Web.UI.Page
    {
        protected List<Model.HKSJ_USERS> users = new List<Model.HKSJ_USERS>();

        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.HKSJ_USERS userService = new BLL.HKSJ_USERS();
            users = userService.GetModelList(string.Empty);

        }
    }
}