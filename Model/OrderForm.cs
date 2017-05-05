using System;
namespace JY.Model
{
	/// <summary>
	/// OrderForm:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderForm
	{
		public OrderForm()
		{}
		#region Model
		private long _id;
		private long? _memberid;
		private string _orderformno;
		private decimal? _producttotalprice;
		private string _purchaser;
		private string _consignee;
		private string _liveaddress;
		private string _zipcode;
		private string _phone;
		private string _remark;
		private DateTime? _creatdate;
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
		/// 会员ID
		/// </summary>
		public long? MemberId
		{
			set{ _memberid=value;}
			get{return _memberid;}
		}
		/// <summary>
		/// 订单编号
		/// </summary>
		public string OrderFormNo
		{
			set{ _orderformno=value;}
			get{return _orderformno;}
		}
		/// <summary>
		/// 产品总价格
		/// </summary>
		public decimal? ProductTotalPrice
		{
			set{ _producttotalprice=value;}
			get{return _producttotalprice;}
		}
		/// <summary>
		/// 购买人
		/// </summary>
		public string Purchaser
		{
			set{ _purchaser=value;}
			get{return _purchaser;}
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
		public string LiveAddress
		{
			set{ _liveaddress=value;}
			get{return _liveaddress;}
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
		/// 电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime? CreatDate
		{
			set{ _creatdate=value;}
			get{return _creatdate;}
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

