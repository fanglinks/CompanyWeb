using System;
using System.Data;
using System.Collections.Generic;

using LYSC.CompanyWeb.Model;
namespace LYSC.CompanyWeb.BLL
{
	/// <summary>
	/// HKSJ_USERS
	/// </summary>
	public partial class HKSJ_USERS
	{
		private readonly LYSC.CompanyWeb.DAL.HKSJ_USERS dal=new LYSC.CompanyWeb.DAL.HKSJ_USERS();
		public HKSJ_USERS()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string LoginName,int ID)
		{
			return dal.Exists(LoginName,ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(LYSC.CompanyWeb.Model.HKSJ_USERS model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LYSC.CompanyWeb.Model.HKSJ_USERS model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string LoginName,int ID)
		{
			
			return dal.Delete(LoginName,ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public LYSC.CompanyWeb.Model.HKSJ_USERS GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public LYSC.CompanyWeb.Model.HKSJ_USERS GetModelByCache(int ID)
		{
			
			string CacheKey = "HKSJ_USERSModel-" + ID;
			object objModel = Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ID);
					if (objModel != null)
					{
						int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
						Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LYSC.CompanyWeb.Model.HKSJ_USERS)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<LYSC.CompanyWeb.Model.HKSJ_USERS> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<LYSC.CompanyWeb.Model.HKSJ_USERS> DataTableToList(DataTable dt)
		{
			List<LYSC.CompanyWeb.Model.HKSJ_USERS> modelList = new List<LYSC.CompanyWeb.Model.HKSJ_USERS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LYSC.CompanyWeb.Model.HKSJ_USERS model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LYSC.CompanyWeb.Model.HKSJ_USERS();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["UserName"]!=null && dt.Rows[n]["UserName"].ToString()!="")
					{
					model.UserName=dt.Rows[n]["UserName"].ToString();
					}
					if(dt.Rows[n]["LoginName"]!=null && dt.Rows[n]["LoginName"].ToString()!="")
					{
					model.LoginName=dt.Rows[n]["LoginName"].ToString();
					}
					if(dt.Rows[n]["PassWord"]!=null && dt.Rows[n]["PassWord"].ToString()!="")
					{
					model.PassWord=dt.Rows[n]["PassWord"].ToString();
					}
					if(dt.Rows[n]["Plane"]!=null && dt.Rows[n]["Plane"].ToString()!="")
					{
					model.Plane=dt.Rows[n]["Plane"].ToString();
					}
					if(dt.Rows[n]["phone"]!=null && dt.Rows[n]["phone"].ToString()!="")
					{
					model.phone=dt.Rows[n]["phone"].ToString();
					}
					if(dt.Rows[n]["Mail"]!=null && dt.Rows[n]["Mail"].ToString()!="")
					{
					model.Mail=dt.Rows[n]["Mail"].ToString();
					}
					if(dt.Rows[n]["cardNo"]!=null && dt.Rows[n]["cardNo"].ToString()!="")
					{
					model.cardNo=dt.Rows[n]["cardNo"].ToString();
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

