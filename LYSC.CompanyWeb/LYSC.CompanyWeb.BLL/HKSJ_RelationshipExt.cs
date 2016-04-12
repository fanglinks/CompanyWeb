using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYSC.CompanyWeb.BLL
{
    public partial class HKSJ_Relationship
    {
        //使用存储过程进行分页,p_GetPageRelationShip
        public List<Model.HKSJ_Relationship> GetPagerNavRelation(int pageIndex, int pageSize, out int totalCount)
        {
            return dal.GetPagerNavRelation(pageIndex, pageSize, out totalCount);
        }
    }
}
