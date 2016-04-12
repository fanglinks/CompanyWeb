using System;
namespace LYSC.CompanyWeb.Model
{
	/// <summary>
	/// HKSJ_Relationship:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HKSJ_Relationship
	{
		public HKSJ_Relationship()
		{}
		#region Model
		private int _id;
		private string _address;
		private string _zip;
		private string _plane;
		private string _fax;
		private string _qq_msn;
		private DateTime _date;
		private string _people;
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
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Zip
		{
			set{ _zip=value;}
			get{return _zip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string plane
		{
			set{ _plane=value;}
			get{return _plane;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Fax
		{
			set{ _fax=value;}
			get{return _fax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ_MSN
		{
			set{ _qq_msn=value;}
			get{return _qq_msn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime Date
		{
			set{ _date=value;}
			get{return _date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string people
		{
			set{ _people=value;}
			get{return _people;}
		}
		#endregion Model

	}
}

