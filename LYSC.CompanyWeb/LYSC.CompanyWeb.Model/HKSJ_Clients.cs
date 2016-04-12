using System;
namespace LYSC.CompanyWeb.Model
{
	/// <summary>
	/// HKSJ_Clients:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HKSJ_Clients
	{
		public HKSJ_Clients()
		{}
		#region Model
		private int _id;
		private string _title;
		private string _softname;
		private string _content;
		private string _liaisonphone;
		private string _liaisonpeple;
		private DateTime _date;
		private string _peple;
		/// <summary>
		/// 
		/// </summary>
		public int id
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
		public string softName
		{
			set{ _softname=value;}
			get{return _softname;}
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
		public string liaisonPhone
		{
			set{ _liaisonphone=value;}
			get{return _liaisonphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string liaisonPeple
		{
			set{ _liaisonpeple=value;}
			get{return _liaisonpeple;}
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
		public string peple
		{
			set{ _peple=value;}
			get{return _peple;}
		}
		#endregion Model

	}
}

