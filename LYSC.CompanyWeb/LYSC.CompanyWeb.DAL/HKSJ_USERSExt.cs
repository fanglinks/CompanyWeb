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
    public partial class HKSJ_USERS
    {

        #region ----使用存储过程进行分页-----
        public List<Model.HKSJ_USERS> GetPageSizeNav(int pageIndex, int pageSize, out int totalCount)
        {
            //new一个SqlDataAdapter对象
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {
                //构造链接字符串
                using (SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString))
                {
                    //创建并执行数据源参数
                    adapter.SelectCommand = conn.CreateCommand();
                    //定义使用存储过程
                    adapter.SelectCommand.CommandText = "p_GetPageUSERS";
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //设置输入参数
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@pageIndex", pageIndex));
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@pageSize", pageSize));

                    //设置输出参数
                    SqlParameter parameterout = new SqlParameter("@totalCount", SqlDbType.Int);
                    parameterout.Direction = ParameterDirection.Output;
                    adapter.SelectCommand.Parameters.Add(parameterout);

                    //将数据源对象填充到表中
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //获取输出参数
                    totalCount = Convert.ToInt32(parameterout.Value);

                    //循环遍历表中的数据源对象
                    List<Model.HKSJ_USERS> userproject = new List<Model.HKSJ_USERS>();

                    foreach (DataRow row in dt.Rows)
                    {
                        Model.HKSJ_USERS user = new Model.HKSJ_USERS();

                        //获取表中的所有对象显示输出
                        user.ID = Convert.ToInt32(row["ID"].ToString());
                        user.UserName = row["UserName"] == DBNull.Value ? "" : row["UserName"].ToString();
                        user.LoginName = row["LoginName"] == DBNull.Value ? "" : row["LoginName"].ToString();
                        user.PassWord = row["PassWord"] == DBNull.Value ? "" : row["PassWord"].ToString();
                        user.Plane = row["Plane"] == DBNull.Value ? "" : row["Plane"].ToString();
                        user.phone = row["phone"] == DBNull.Value ? "" : row["phone"].ToString();
                        user.Mail = row["Mail"] == DBNull.Value ? "" : row["Mail"].ToString();
                        user.cardNo = row["cardNo"] == DBNull.Value ? "" : row["cardNo"].ToString();

                        userproject.Add(user);
                    }

                    return userproject;
                }
            }
        }
        
        #endregion

        #region ----只判断用户名，如果用户名存在则返回所有的信息----
        public Model.HKSJ_USERS GetLoginUser(string loginName)
        {
            //ID, UserName, LoginName, PassWord, Plane, phone, Mail, cardNo
            Model.HKSJ_USERS user = new Model.HKSJ_USERS();
            string sql = "select ID, UserName, LoginName, PassWord, Plane, phone, Mail, cardNo from HKSJ_USERS where LoginName=@LoginName";
            using (SqlDataReader reader = DbHelperSQL.ExecuteReader(sql, new SqlParameter("@LoginName", loginName)))
            {
                if (reader.Read())
                {
                    user.ID = int.Parse(reader["ID"].ToString());
                    user.LoginName = reader["LoginName"] == DBNull.Value ? string.Empty : reader["LoginName"].ToString();
                    user.UserName = reader["UserName"] == DBNull.Value ? string.Empty : reader["UserName"].ToString();
                    user.cardNo = reader["cardNo"] == DBNull.Value ? string.Empty : reader["cardNo"].ToString();
                    user.Mail = reader["Mail"] == DBNull.Value ? string.Empty : reader["Mail"].ToString();
                    user.PassWord = reader["PassWord"] == DBNull.Value ? string.Empty : reader["PassWord"].ToString();
                    user.phone = reader["phone"] == DBNull.Value ? string.Empty : reader["phone"].ToString();
                    user.Plane = reader["Plane"] == DBNull.Value ? string.Empty : reader["Plane"].ToString();
                }
            }
            return user;
        }
        #endregion

        #region ----同时判断用户名和密码----

        public Model.HKSJ_USERS GetLoginUser(string loginName, string userPwd)
        {
            //ID, UserName, LoginName, PassWord, Plane, phone, Mail, cardNo
            Model.HKSJ_USERS user = new Model.HKSJ_USERS();
            string sql = "select ID, UserName, LoginName, PassWord, Plane, phone, Mail, cardNo from HKSJ_USERS where LoginName=@LoginName and PassWord=@PassWord";
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@LoginName",loginName),
            new SqlParameter("@PassWord",userPwd)
          };
            using (SqlDataReader reader = DbHelperSQL.ExecuteReader(sql, paras))
            {
                if (reader.Read())
                {
                    user.ID = int.Parse(reader["ID"].ToString());
                    user.LoginName = reader["LoginName"] == DBNull.Value ? string.Empty : reader["LoginName"].ToString();
                    user.UserName = reader["UserName"] == DBNull.Value ? string.Empty : reader["UserName"].ToString();
                    user.cardNo = reader["cardNo"] == DBNull.Value ? string.Empty : reader["cardNo"].ToString();
                    user.Mail = reader["Mail"] == DBNull.Value ? string.Empty : reader["Mail"].ToString();
                    user.PassWord = reader["PassWord"] == DBNull.Value ? string.Empty : reader["PassWord"].ToString();
                    user.phone = reader["phone"] == DBNull.Value ? string.Empty : reader["phone"].ToString();
                    user.Plane = reader["Plane"] == DBNull.Value ? string.Empty : reader["Plane"].ToString();
                }
            }
            return user;
        }
        #endregion

        #region ---自己写的方法判断但添加用户的时候是否存在同名用户----
        public bool ExistsLoginName(string LoginName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select count(1) from HKSJ_USERS where LoginName=@LoginName");
            SqlParameter[] parameter = new SqlParameter[] {
            new SqlParameter("@LoginName",LoginName),
            };
            return DbHelperSQL.Exists(sb.ToString(), parameter);

        }
        #endregion

    }
}
