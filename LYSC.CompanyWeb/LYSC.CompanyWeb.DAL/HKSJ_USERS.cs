using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LYSC.CompanyWeb.DBUtitly;

namespace LYSC.CompanyWeb.DAL
{
	/// <summary>
	/// 数据访问类:HKSJ_USERS
	/// </summary>
	public partial class HKSJ_USERS
	{
		public HKSJ_USERS()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "HKSJ_USERS"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string LoginName,int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from HKSJ_USERS");
			strSql.Append(" where LoginName=@LoginName and ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@LoginName", SqlDbType.VarChar,20),
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = LoginName;
			parameters[1].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LYSC.CompanyWeb.Model.HKSJ_USERS model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HKSJ_USERS(");
			strSql.Append("UserName,LoginName,PassWord,Plane,phone,Mail,cardNo)");
			strSql.Append(" values (");
			strSql.Append("@UserName,@LoginName,@PassWord,@Plane,@phone,@Mail,@cardNo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,20),
					new SqlParameter("@LoginName", SqlDbType.VarChar,20),
					new SqlParameter("@PassWord", SqlDbType.VarChar,30),
					new SqlParameter("@Plane", SqlDbType.VarChar,14),
					new SqlParameter("@phone", SqlDbType.VarChar,14),
					new SqlParameter("@Mail", SqlDbType.VarChar,30),
					new SqlParameter("@cardNo", SqlDbType.VarChar,18)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.LoginName;
			parameters[2].Value = model.PassWord;
			parameters[3].Value = model.Plane;
			parameters[4].Value = model.phone;
			parameters[5].Value = model.Mail;
			parameters[6].Value = model.cardNo;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public bool Update(LYSC.CompanyWeb.Model.HKSJ_USERS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update HKSJ_USERS set ");
            strSql.Append("UserName=@UserName,");
            strSql.Append("PassWord=@PassWord,");
            strSql.Append("Plane=@Plane,");
            strSql.Append("phone=@phone,");
            strSql.Append("Mail=@Mail,");
            strSql.Append("LoginName=@LoginName,");
            strSql.Append("cardNo=@cardNo");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.VarChar,20),
					new SqlParameter("@PassWord", SqlDbType.VarChar,30),
					new SqlParameter("@Plane", SqlDbType.VarChar,14),
					new SqlParameter("@phone", SqlDbType.VarChar,14),
					new SqlParameter("@Mail", SqlDbType.VarChar,30),
					new SqlParameter("@cardNo", SqlDbType.VarChar,18),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@LoginName", SqlDbType.VarChar,20)};
            parameters[0].Value = model.UserName;
            parameters[1].Value = model.PassWord;
            parameters[2].Value = model.Plane;
            parameters[3].Value = model.phone;
            parameters[4].Value = model.Mail;
            parameters[5].Value = model.cardNo;
            parameters[6].Value = model.ID;
            parameters[7].Value = model.LoginName;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HKSJ_USERS ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string LoginName,int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HKSJ_USERS ");
			strSql.Append(" where LoginName=@LoginName and ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@LoginName", SqlDbType.VarChar,20),
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = LoginName;
			parameters[1].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HKSJ_USERS ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public LYSC.CompanyWeb.Model.HKSJ_USERS GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,UserName,LoginName,PassWord,Plane,phone,Mail,cardNo from HKSJ_USERS ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			LYSC.CompanyWeb.Model.HKSJ_USERS model=new LYSC.CompanyWeb.Model.HKSJ_USERS();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserName"]!=null && ds.Tables[0].Rows[0]["UserName"].ToString()!="")
				{
					model.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LoginName"]!=null && ds.Tables[0].Rows[0]["LoginName"].ToString()!="")
				{
					model.LoginName=ds.Tables[0].Rows[0]["LoginName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PassWord"]!=null && ds.Tables[0].Rows[0]["PassWord"].ToString()!="")
				{
					model.PassWord=ds.Tables[0].Rows[0]["PassWord"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Plane"]!=null && ds.Tables[0].Rows[0]["Plane"].ToString()!="")
				{
					model.Plane=ds.Tables[0].Rows[0]["Plane"].ToString();
				}
				if(ds.Tables[0].Rows[0]["phone"]!=null && ds.Tables[0].Rows[0]["phone"].ToString()!="")
				{
					model.phone=ds.Tables[0].Rows[0]["phone"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Mail"]!=null && ds.Tables[0].Rows[0]["Mail"].ToString()!="")
				{
					model.Mail=ds.Tables[0].Rows[0]["Mail"].ToString();
				}
				if(ds.Tables[0].Rows[0]["cardNo"]!=null && ds.Tables[0].Rows[0]["cardNo"].ToString()!="")
				{
					model.cardNo=ds.Tables[0].Rows[0]["cardNo"].ToString();
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,UserName,LoginName,PassWord,Plane,phone,Mail,cardNo ");
			strSql.Append(" FROM HKSJ_USERS ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,UserName,LoginName,PassWord,Plane,phone,Mail,cardNo ");
			strSql.Append(" FROM HKSJ_USERS ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM HKSJ_USERS ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from HKSJ_USERS T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "HKSJ_USERS";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

