using System;
namespace LYSC.CompanyWeb.Model
{
	/// <summary>
	/// HKSJ_Services:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HKSJ_Services
	{
		public HKSJ_Services()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _context;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Context
		{
			set{ _context=value;}
			get{return _context;}
		}
		#endregion Model

	}
}

