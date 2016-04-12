using System;
using System.Data;
using System.Collections.Generic;

using LYSC.CompanyWeb.Model;
namespace LYSC.CompanyWeb.BLL
{
	/// <summary>
	/// HKSJ_Relationship
	/// </summary>
	public partial class HKSJ_Relationship
	{
		private readonly LYSC.CompanyWeb.DAL.HKSJ_Relationship dal=new LYSC.CompanyWeb.DAL.HKSJ_Relationship();
		public HKSJ_Relationship()
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
		public int  Add(LYSC.CompanyWeb.Model.HKSJ_Relationship model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(LYSC.CompanyWeb.Model.HKSJ_Relationship model)
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
		public LYSC.CompanyWeb.Model.HKSJ_Relationship GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public LYSC.CompanyWeb.Model.HKSJ_Relationship GetModelByCache(int ID)
		{
			
			string CacheKey = "HKSJ_RelationshipModel-" + ID;
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
			return (LYSC.CompanyWeb.Model.HKSJ_Relationship)objModel;
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
		public List<LYSC.CompanyWeb.Model.HKSJ_Relationship> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<LYSC.CompanyWeb.Model.HKSJ_Relationship> DataTableToList(DataTable dt)
		{
			List<LYSC.CompanyWeb.Model.HKSJ_Relationship> modelList = new List<LYSC.CompanyWeb.Model.HKSJ_Relationship>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				LYSC.CompanyWeb.Model.HKSJ_Relationship model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new LYSC.CompanyWeb.Model.HKSJ_Relationship();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["Address"]!=null && dt.Rows[n]["Address"].ToString()!="")
					{
					model.Address=dt.Rows[n]["Address"].ToString();
					}
					if(dt.Rows[n]["Zip"]!=null && dt.Rows[n]["Zip"].ToString()!="")
					{
					model.Zip=dt.Rows[n]["Zip"].ToString();
					}
					if(dt.Rows[n]["plane"]!=null && dt.Rows[n]["plane"].ToString()!="")
					{
					model.plane=dt.Rows[n]["plane"].ToString();
					}
					if(dt.Rows[n]["Fax"]!=null && dt.Rows[n]["Fax"].ToString()!="")
					{
					model.Fax=dt.Rows[n]["Fax"].ToString();
					}
					if(dt.Rows[n]["QQ_MSN"]!=null && dt.Rows[n]["QQ_MSN"].ToString()!="")
					{
					model.QQ_MSN=dt.Rows[n]["QQ_MSN"].ToString();
					}
					if(dt.Rows[n]["Date"]!=null && dt.Rows[n]["Date"].ToString()!="")
					{
						model.Date=DateTime.Parse(dt.Rows[n]["Date"].ToString());
					}
					if(dt.Rows[n]["people"]!=null && dt.Rows[n]["people"].ToString()!="")
					{
					model.people=dt.Rows[n]["people"].ToString();
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

