using System;
using System.Data;
using System.Collections.Generic;

using LYSC.CompanyWeb.Model;
namespace LYSC.CompanyWeb.BLL
{
	/// <summary>
	/// HKSJ_First
	/// </summary>
	public partial class HKSJ_First
	{
		private readonly LYSC.CompanyWeb.DAL.HKSJ_First dal=new LYSC.CompanyWeb.DAL.HKSJ_First();
		public HKSJ_First()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Name)
		{
			return dal.Exists(Name);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(LYSC.CompanyWeb.Model.HKSJ_First model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LYSC.CompanyWeb.Model.HKSJ_First model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string Name)
		{
			
			return dal.Delete(Name);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Namelist )
		{
			return dal.DeleteList(Namelist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public LYSC.CompanyWeb.Model.HKSJ_First GetModel(string Name)
		{
			
			return dal.GetModel(Name);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public LYSC.CompanyWeb.Model.HKSJ_First GetModelByCache(string Name)
		{
			
			string CacheKey = "HKSJ_FirstModel-" + Name;
			object objModel =LYSC.CompanyWeb.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Name);
					if (objModel != null)
					{
						int ModelCache =Common.ConfigHelper.GetConfigInt("ModelCache");
						Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (LYSC.CompanyWeb.Model.HKSJ_First)objModel;
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
		public List<LYSC.CompanyWeb.Model.HKSJ_First> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<LYSC.CompanyWeb.Model.HKSJ_First> DataTableToList(DataTable dt)
		{
			List<LYSC.CompanyWeb.Model.HKSJ_First> modelList = new List<LYSC.CompanyWeb.Model.HKSJ_First>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LYSC.CompanyWeb.Model.HKSJ_First model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LYSC.CompanyWeb.Model.HKSJ_First();
					if(dt.Rows[n]["Name"]!=null && dt.Rows[n]["Name"].ToString()!="")
					{
					model.Name=dt.Rows[n]["Name"].ToString();
					}
					if(dt.Rows[n]["Matter"]!=null && dt.Rows[n]["Matter"].ToString()!="")
					{
					model.Matter=dt.Rows[n]["Matter"].ToString();
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

