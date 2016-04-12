using System;
namespace LYSC.CompanyWeb.Model
{
	/// <summary>
	/// HKSJ_USERS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class HKSJ_USERS
	{
		public HKSJ_USERS()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _loginname;
		private string _password;
		private string _plane;
		private string _phone;
		private string _mail;
		private string _cardno;
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
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LoginName
		{
			set{ _loginname=value;}
			get{return _loginname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PassWord
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Plane
		{
			set{ _plane=value;}
			get{return _plane;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mail
		{
			set{ _mail=value;}
			get{return _mail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cardNo
		{
			set{ _cardno=value;}
			get{return _cardno;}
		}
		#endregion Model

	}
}

