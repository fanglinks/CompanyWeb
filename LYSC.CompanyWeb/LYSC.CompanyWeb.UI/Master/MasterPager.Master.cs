using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LYSC.CompanyWeb.UI.Master
{
    public partial class MasterPager : System.Web.UI.MasterPage
    {
        public string _tabtitle = "";
        public string TabTitle
        {
            get
            {
                return _tabtitle;
            }
            set
            {
                _tabtitle = value;
            }
        }
        //查询出软件产品显示出来

        protected List<LYSC.CompanyWeb.Model.HKSJ_Main> mainShow = new List<LYSC.CompanyWeb.Model.HKSJ_Main>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //得到最新的产品显示出10条来
            LYSC.CompanyWeb.BLL.HKSJ_Main mainService = new LYSC.CompanyWeb.BLL.HKSJ_Main();
            DataSet ds = mainService.GetList(10, string.Empty, "ID desc");
            mainShow = mainService.DataTableToList(ds.Tables[0]);
        }
    }
}