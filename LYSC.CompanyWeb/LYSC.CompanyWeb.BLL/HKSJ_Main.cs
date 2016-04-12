using System;
using System.Data;
using System.Collections.Generic;

using LYSC.CompanyWeb.Model;
namespace LYSC.CompanyWeb.BLL
{
	/// <summary>
	/// HKSJ_Main
	/// </summary>
	public partial class HKSJ_Main
	{
		private readonly LYSC.CompanyWeb.DAL.HKSJ_Main dal=new LYSC.CompanyWeb.DAL.HKSJ_Main();
		public HKSJ_Main()
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
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(LYSC.CompanyWeb.Model.HKSJ_Main model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LYSC.CompanyWeb.Model.HKSJ_Main model)
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
		public LYSC.CompanyWeb.Model.HKSJ_Main GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public LYSC.CompanyWeb.Model.HKSJ_Main GetModelByCache(int ID)
		{
			
			string CacheKey = "HKSJ_MainModel-" + ID;
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
			return (LYSC.CompanyWeb.Model.HKSJ_Main)objModel;
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
		public List<LYSC.CompanyWeb.Model.HKSJ_Main> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<LYSC.CompanyWeb.Model.HKSJ_Main> DataTableToList(DataTable dt)
		{
			List<LYSC.CompanyWeb.Model.HKSJ_Main> modelList = new List<LYSC.CompanyWeb.Model.HKSJ_Main>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LYSC.CompanyWeb.Model.HKSJ_Main model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LYSC.CompanyWeb.Model.HKSJ_Main();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["title"]!=null && dt.Rows[n]["title"].ToString()!="")
					{
					model.title=dt.Rows[n]["title"].ToString();
					}
					if(dt.Rows[n]["content"]!=null && dt.Rows[n]["content"].ToString()!="")
					{
					model.content=dt.Rows[n]["content"].ToString();
					}
					if(dt.Rows[n]["type"]!=null && dt.Rows[n]["type"].ToString()!="")
					{
					model.type=dt.Rows[n]["type"].ToString();
					}
					if(dt.Rows[n]["Date"]!=null && dt.Rows[n]["Date"].ToString()!="")
					{
						model.Date=DateTime.Parse(dt.Rows[n]["Date"].ToString());
					}
					if(dt.Rows[n]["people"]!=null && dt.Rows[n]["people"].ToString()!="")
					{
					model.people=dt.Rows[n]["people"].ToString();
					}
					if(dt.Rows[n]["picUrl"]!=null && dt.Rows[n]["picUrl"].ToString()!="")
					{
					model.picUrl=dt.Rows[n]["picUrl"].ToString();
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

