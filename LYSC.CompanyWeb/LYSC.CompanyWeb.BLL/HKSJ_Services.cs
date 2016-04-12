using System;
using System.Data;
using System.Collections.Generic;
using LYSC.CompanyWeb.Common;
using LYSC.CompanyWeb.Model;
namespace LYSC.CompanyWeb.BLL
{
	/// <summary>
	/// HKSJ_Services
	/// </summary>
	public partial class HKSJ_Services
	{
		private readonly LYSC.CompanyWeb.DAL.HKSJ_Services dal=new LYSC.CompanyWeb.DAL.HKSJ_Services();
		public HKSJ_Services()
		{}
		#region  Method

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(LYSC.CompanyWeb.Model.HKSJ_Services model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LYSC.CompanyWeb.Model.HKSJ_Services model)
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
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public LYSC.CompanyWeb.Model.HKSJ_Services GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public LYSC.CompanyWeb.Model.HKSJ_Services GetModelByCache(int ID)
		{
			
			string CacheKey = "HKSJ_ServicesModel-" + ID;
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
			return (LYSC.CompanyWeb.Model.HKSJ_Services)objModel;
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
		public List<LYSC.CompanyWeb.Model.HKSJ_Services> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<LYSC.CompanyWeb.Model.HKSJ_Services> DataTableToList(DataTable dt)
		{
			List<LYSC.CompanyWeb.Model.HKSJ_Services> modelList = new List<LYSC.CompanyWeb.Model.HKSJ_Services>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LYSC.CompanyWeb.Model.HKSJ_Services model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LYSC.CompanyWeb.Model.HKSJ_Services();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["Name"]!=null && dt.Rows[n]["Name"].ToString()!="")
					{
					model.Name=dt.Rows[n]["Name"].ToString();
					}
					if(dt.Rows[n]["Context"]!=null && dt.Rows[n]["Context"].ToString()!="")
					{
					model.Context=dt.Rows[n]["Context"].ToString();
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

