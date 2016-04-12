using System;
namespace LYSC.CompanyWeb.Model
{
	/// <summary>
	/// HKSJ_Employees:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HKSJ_Employees
	{
		public HKSJ_Employees()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _content;
		private string _people;
		private DateTime _date;
		private int _status;
		private string _mainpeople;
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
		public string people
		{
			set{ _people=value;}
			get{return _people;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime date
		{
			set{ _date=value;}
			get{return _date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MainPeople
		{
			set{ _mainpeople=value;}
			get{return _mainpeople;}
		}
		#endregion Model

	}
}

