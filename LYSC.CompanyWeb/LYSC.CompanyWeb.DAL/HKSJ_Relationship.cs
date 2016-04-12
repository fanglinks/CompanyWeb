using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using LYSC.CompanyWeb.DBUtitly;

namespace LYSC.CompanyWeb.DAL
{
	/// <summary>
	/// 数据访问类:HKSJ_Relationship
	/// </summary>
	public partial class HKSJ_Relationship
	{
		public HKSJ_Relationship()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "HKSJ_Relationship"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from HKSJ_Relationship");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(LYSC.CompanyWeb.Model.HKSJ_Relationship model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HKSJ_Relationship(");
			strSql.Append("Address,Zip,plane,Fax,QQ_MSN,Date,people)");
			strSql.Append(" values (");
			strSql.Append("@Address,@Zip,@plane,@Fax,@QQ_MSN,@Date,@people)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Address", SqlDbType.VarChar,50),
					new SqlParameter("@Zip", SqlDbType.VarChar,20),
					new SqlParameter("@plane", SqlDbType.VarChar,20),
					new SqlParameter("@Fax", SqlDbType.VarChar,20),
					new SqlParameter("@QQ_MSN", SqlDbType.VarChar,30),
					new SqlParameter("@Date", SqlDbType.DateTime),
					new SqlParameter("@people", SqlDbType.VarChar,20)};
			parameters[0].Value = model.Address;
			parameters[1].Value = model.Zip;
			parameters[2].Value = model.plane;
			parameters[3].Value = model.Fax;
			parameters[4].Value = model.QQ_MSN;
			parameters[5].Value = model.Date;
			parameters[6].Value = model.people;

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
		public bool Update(LYSC.CompanyWeb.Model.HKSJ_Relationship model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HKSJ_Relationship set ");
			strSql.Append("Address=@Address,");
			strSql.Append("Zip=@Zip,");
			strSql.Append("plane=@plane,");
			strSql.Append("Fax=@Fax,");
			strSql.Append("QQ_MSN=@QQ_MSN,");
			strSql.Append("Date=@Date,");
			strSql.Append("people=@people");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Address", SqlDbType.VarChar,50),
					new SqlParameter("@Zip", SqlDbType.VarChar,20),
					new SqlParameter("@plane", SqlDbType.VarChar,20),
					new SqlParameter("@Fax", SqlDbType.VarChar,20),
					new SqlParameter("@QQ_MSN", SqlDbType.VarChar,30),
					new SqlParameter("@Date", SqlDbType.DateTime),
					new SqlParameter("@people", SqlDbType.VarChar,20),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Address;
			parameters[1].Value = model.Zip;
			parameters[2].Value = model.plane;
			parameters[3].Value = model.Fax;
			parameters[4].Value = model.QQ_MSN;
			parameters[5].Value = model.Date;
			parameters[6].Value = model.people;
			parameters[7].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HKSJ_Relationship ");
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from HKSJ_Relationship ");
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
		public LYSC.CompanyWeb.Model.HKSJ_Relationship GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Address,Zip,plane,Fax,QQ_MSN,Date,people from HKSJ_Relationship ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			LYSC.CompanyWeb.Model.HKSJ_Relationship model=new LYSC.CompanyWeb.Model.HKSJ_Relationship();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Address"]!=null && ds.Tables[0].Rows[0]["Address"].ToString()!="")
				{
					model.Address=ds.Tables[0].Rows[0]["Address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Zip"]!=null && ds.Tables[0].Rows[0]["Zip"].ToString()!="")
				{
					model.Zip=ds.Tables[0].Rows[0]["Zip"].ToString();
				}
				if(ds.Tables[0].Rows[0]["plane"]!=null && ds.Tables[0].Rows[0]["plane"].ToString()!="")
				{
					model.plane=ds.Tables[0].Rows[0]["plane"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Fax"]!=null && ds.Tables[0].Rows[0]["Fax"].ToString()!="")
				{
					model.Fax=ds.Tables[0].Rows[0]["Fax"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QQ_MSN"]!=null && ds.Tables[0].Rows[0]["QQ_MSN"].ToString()!="")
				{
					model.QQ_MSN=ds.Tables[0].Rows[0]["QQ_MSN"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Date"]!=null && ds.Tables[0].Rows[0]["Date"].ToString()!="")
				{
					model.Date=DateTime.Parse(ds.Tables[0].Rows[0]["Date"].ToString());
				}
				if(ds.Tables[0].Rows[0]["people"]!=null && ds.Tables[0].Rows[0]["people"].ToString()!="")
				{
					model.people=ds.Tables[0].Rows[0]["people"].ToString();
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
			strSql.Append("select ID,Address,Zip,plane,Fax,QQ_MSN,Date,people ");
			strSql.Append(" FROM HKSJ_Relationship ");
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
			strSql.Append(" ID,Address,Zip,plane,Fax,QQ_MSN,Date,people ");
			strSql.Append(" FROM HKSJ_Relationship ");
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
			strSql.Append("select count(1) FROM HKSJ_Relationship ");
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
			strSql.Append(")AS Row, T.*  from HKSJ_Relationship T ");
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
			parameters[0].Value = "HKSJ_Relationship";
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

