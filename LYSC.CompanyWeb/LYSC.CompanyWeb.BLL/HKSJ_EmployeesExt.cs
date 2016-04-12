using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYSC.CompanyWeb.BLL
{
    
    public partial class HKSJ_Employees
    {
        public List<Model.HKSJ_Employees> GetPageNavEmployees(int pageIndex, int pageSize, out int totalCount)
        {
            return dal.GetPageNavEmployees(pageIndex,pageSize,out totalCount);
        }
    }
}
