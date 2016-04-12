using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYSC.CompanyWeb.BLL
{
    public partial class HKSJ_Main
    {
        //实现分页的功能
        public List<Model.HKSJ_Main> GetNavPageData(int pageSize, int pageIndex, out int totalCount)
        {
            return dal.GetPageSizeNav(pageSize, pageIndex, out totalCount);
        }
    }
}
