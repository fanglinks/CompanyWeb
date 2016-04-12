using System;
namespace LYSC.CompanyWeb.Model
{
	/// <summary>
	/// HKSJ_First:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HKSJ_First
	{
		public HKSJ_First()
		{}
		#region Model
		private string _name;
		private string _matter;
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
		public string Matter
		{
			set{ _matter=value;}
			get{return _matter;}
		}
		#endregion Model

	}
}

