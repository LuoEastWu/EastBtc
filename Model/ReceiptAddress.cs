using System;
namespace JY.Model
{
	/// <summary>
	/// ReceiptAddress:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ReceiptAddress
	{
		public ReceiptAddress()
		{}
		#region Model
		private long _id;
		private int? _memberid;
		private string _consignee;
		private string _liveadderss;
		private string _phone;
		private string _zipcode;
		private DateTime? _createdate;
		private int? _sort;
		private bool _isdelete;
		/// <summary>
		/// ID
		/// </summary>
		public long ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 会员Id
		/// </summary>
		public int? MemberId
		{
			set{ _memberid=value;}
			get{return _memberid;}
		}
		/// <summary>
		/// 收货人
		/// </summary>
		public string Consignee
		{
			set{ _consignee=value;}
			get{return _consignee;}
		}
		/// <summary>
		/// 收货地址
		/// </summary>
		public string LiveAdderss
		{
			set{ _liveadderss=value;}
			get{return _liveadderss;}
		}
		/// <summary>
		/// 手机
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 邮编
		/// </summary>
		public string ZipCode
		{
			set{ _zipcode=value;}
			get{return _zipcode;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int? Sort
		{
			set{ _sort=value;}
			get{return _sort;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public bool IsDelete
		{
			set{ _isdelete=value;}
			get{return _isdelete;}
		}
		#endregion Model

	}
}

