using System;
namespace LYSC.CompanyWeb.Model
{
	/// <summary>
	/// HKSJ_Main:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HKSJ_Main
	{
		public HKSJ_Main()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _content;
		private string _type;
		private DateTime _date;
		private string _people;
		private string _picurl;
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
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string type
		{
			set{ _type=value;}
			get{return _type;}
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
		/// <summary>
		/// 
		/// </summary>
		public string picUrl
		{
			set{ _picurl=value;}
			get{return _picurl;}
		}
		#endregion Model

	}
}

