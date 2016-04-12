using LYSC.CompanyWeb.DBUtitly;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LYSC.CompanyWeb.DAL
{
    public partial class HKSJ_Relationship
    {
        //使用存储过程进行分页,p_GetPageRelationShip
        public List<Model.HKSJ_Relationship> GetPagerNavRelation(int pageIndex, int pageSize, out int totalCount)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                using (SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString))
                {
                    //创建并且执行数据源
                    adapter.SelectCommand = conn.CreateCommand();

                    //执行存储过程代码
                    adapter.SelectCommand.CommandText = "p_GetPageRelationShip";
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    //设置输入参数
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@pageIndex", pageIndex));
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@pageSize", pageSize));

                    //设置输出参数
                    SqlParameter parameterout = new SqlParameter("@totalCount", SqlDbType.Int);
                    parameterout.Direction = ParameterDirection.Output;
                    adapter.SelectCommand.Parameters.Add(parameterout);

                    //将数据源填充到表中
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //获取输入总数
                    totalCount = Convert.ToInt32(parameterout.Value);

                    //循环遍历输出所有的RelationShip信息
                    List<Model.HKSJ_Relationship> relationShipList = new List<Model.HKSJ_Relationship>();

                    foreach (DataRow row in dt.Rows)
                    {
                        Model.HKSJ_Relationship relationship = new Model.HKSJ_Relationship();

                        //获取所有的输出参数
                        relationship.ID = Convert.ToInt32(row["ID"].ToString());
                        relationship.Address = row["Address"] == DBNull.Value ? "" : row["Address"].ToString();
                        relationship.Zip = row["Zip"] == DBNull.Value ? "" : row["Zip"].ToString();
                        relationship.plane = row["plane"] == DBNull.Value ? "" : row["plane"].ToString();
                        relationship.Fax = row["Fax"] == DBNull.Value ? "" : row["Fax"].ToString();
                        relationship.QQ_MSN = row["QQ_MSN"] == DBNull.Value ? "" : row["QQ_MSN"].ToString();
                        relationship.Date = row["Date"] == DBNull.Value ? Convert.ToDateTime("2012-11-09") : Convert.ToDateTime(row["Date"].ToString());
                        relationship.people = row["people"] == DBNull.Value ? "" : row["people"].ToString();

                        relationShipList.Add(relationship);
                    }
                    return relationShipList;
                }
            }
        }
    }
}
