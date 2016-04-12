using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LYSC.CompanyWeb.DBUtitly;

namespace LYSC.CompanyWeb.DAL
{
  public partial  class HKSJ_Employees
    {
      //使用存储过程进行分页,
      public List<Model.HKSJ_Employees> GetPageNavEmployees(int pageIndex, int pageSize, out int totalCount)
      {
          using (SqlDataAdapter adapter=new SqlDataAdapter())
          {
              using (SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString))
              { 
                //创建并且执行数据源；
                  adapter.SelectCommand = conn.CreateCommand();
                  //执行存储过程代码；
                  adapter.SelectCommand.CommandText = "p_GetPageEmployees";
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

                  //循环遍历；
                  List<Model.HKSJ_Employees> modelist = new List<Model.HKSJ_Employees>();
                  foreach (DataRow row in dt.Rows)
                  {
                      //ID, title, content, people, date, status, MainPeople
                      Model.HKSJ_Employees model = new Model.HKSJ_Employees();
                      model.ID = int.Parse(row["ID"].ToString());
                      model.title = row["title"] == DBNull.Value ? "" : row["title"].ToString();
                      model.content = row["content"] == DBNull.Value ? "" : row["content"].ToString();
                      model.people = row["people"] == DBNull.Value ? "" : row["people"].ToString();
                      model.status = int.Parse(row["status"].ToString());
                      model.date = row["date"] == DBNull.Value ? Convert.ToDateTime("2012-11-09") : Convert.ToDateTime(row["date"].ToString());
                      model.MainPeople= row["MainPeople"] == DBNull.Value ? "" : row["MainPeople"].ToString();
                      modelist.Add(model);

                  }
                  return modelist;
              }
          }
      }
    }
}
