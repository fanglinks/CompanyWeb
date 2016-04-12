using System;
using System.Data;
using System.Collections.Generic;

using LYSC.CompanyWeb.Model;
namespace LYSC.CompanyWeb.BLL
{
	/// <summary>
	/// HKSJ_Clients
	/// </summary>
	public partial class HKSJ_Clients
	{
		private readonly LYSC.CompanyWeb.DAL.HKSJ_Clients dal=new LYSC.CompanyWeb.DAL.HKSJ_Clients();
		public HKSJ_Clients()
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
		public bool Exists(int id)
		{
			return dal.Exists(id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(LYSC.CompanyWeb.Model.HKSJ_Clients model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LYSC.CompanyWeb.Model.HKSJ_Clients model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return dal.Delete(id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return dal.DeleteList(idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public LYSC.CompanyWeb.Model.HKSJ_Clients GetModel(int id)
		{
			
			return dal.GetModel(id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public LYSC.CompanyWeb.Model.HKSJ_Clients GetModelByCache(int id)
		{
			
			string CacheKey = "HKSJ_ClientsModel-" + id;
			object objModel = Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(id);
					if (objModel != null)
					{
						int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
						Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LYSC.CompanyWeb.Model.HKSJ_Clients)objModel;
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
		public List<LYSC.CompanyWeb.Model.HKSJ_Clients> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<LYSC.CompanyWeb.Model.HKSJ_Clients> DataTableToList(DataTable dt)
		{
			List<LYSC.CompanyWeb.Model.HKSJ_Clients> modelList = new List<LYSC.CompanyWeb.Model.HKSJ_Clients>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LYSC.CompanyWeb.Model.HKSJ_Clients model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LYSC.CompanyWeb.Model.HKSJ_Clients();
					if(dt.Rows[n]["id"]!=null && dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					if(dt.Rows[n]["title"]!=null && dt.Rows[n]["title"].ToString()!="")
					{
					model.title=dt.Rows[n]["title"].ToString();
					}
					if(dt.Rows[n]["softName"]!=null && dt.Rows[n]["softName"].ToString()!="")
					{
					model.softName=dt.Rows[n]["softName"].ToString();
					}
					if(dt.Rows[n]["content"]!=null && dt.Rows[n]["content"].ToString()!="")
					{
					model.content=dt.Rows[n]["content"].ToString();
					}
					if(dt.Rows[n]["liaisonPhone"]!=null && dt.Rows[n]["liaisonPhone"].ToString()!="")
					{
					model.liaisonPhone=dt.Rows[n]["liaisonPhone"].ToString();
					}
					if(dt.Rows[n]["liaisonPeple"]!=null && dt.Rows[n]["liaisonPeple"].ToString()!="")
					{
					model.liaisonPeple=dt.Rows[n]["liaisonPeple"].ToString();
					}
					if(dt.Rows[n]["date"]!=null && dt.Rows[n]["date"].ToString()!="")
					{
						model.date=DateTime.Parse(dt.Rows[n]["date"].ToString());
					}
					if(dt.Rows[n]["peple"]!=null && dt.Rows[n]["peple"].ToString()!="")
					{
					model.peple=dt.Rows[n]["peple"].ToString();
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

