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
    public partial class HKSJ_Main
    {
        //使用存储过程进行分页,
        public List<Model.HKSJ_Main> GetPageSizeNav(int pageSize, int pageIndex, out int totalCount)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                using (SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString))
                {
                    adapter.SelectCommand = conn.CreateCommand();

                    adapter.SelectCommand.CommandText = "Pro_GetPageProject";
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;//设置执行一个存储过程


                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@pageIndex", pageIndex));
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@pageSize", pageSize));

                    //设置一个输出参数
                    SqlParameter parameterTotalCount = new SqlParameter("@totalCount", SqlDbType.Int);
                    parameterTotalCount.Direction = ParameterDirection.Output;//代表输出参数

                    adapter.SelectCommand.Parameters.Add(parameterTotalCount);



                    DataSet ds = new DataSet();

                    adapter.Fill(ds);//自动打开连接，自动读取数据放到表里去，另外自动释放Reader..

                    //获取一共有多少条[第一种方式获取返回值的参数]
                    totalCount = int.Parse(ds.Tables[1].Rows[0][0].ToString());

                    //第二种获取返回值参数的方式：直接从输出参数获取值
                    totalCount = (int)parameterTotalCount.Value;//如果使用的是SqlDataReader读取数据的话，必须等待
                    //Reader释放之后才能拿到 输出参数的值。


                    List<Model.HKSJ_Main> projects = new List<Model.HKSJ_Main>();
                    //获取数据分页数据
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        Model.HKSJ_Main projectInfo = new Model.HKSJ_Main();
                        projectInfo.ID = int.Parse(row["ID"].ToString());
                        projectInfo.content = row["content"] == DBNull.Value ? string.Empty : row["content"].ToString();
                        projectInfo.title = row["title"] == DBNull.Value ? string.Empty : row["title"].ToString();
                        projectInfo.type = row["type"] == DBNull.Value ? string.Empty : row["type"].ToString();
                        projectInfo.picUrl = row["picUrl"] == DBNull.Value ? string.Empty : row["picUrl"].ToString();
                        projectInfo.Date = row["Date"] == DBNull.Value ? DateTime.Now : (DateTime)row["Date"];
                        projectInfo.people = row["people"] == DBNull.Value ? string.Empty : row["people"].ToString();


                        projects.Add(projectInfo);
                    }

                    return projects;
                }
            }
        }
    }
}