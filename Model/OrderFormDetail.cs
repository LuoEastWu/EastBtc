using System;
namespace JY.Model
{
	/// <summary>
	/// OrderFormDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderFormDetail
	{
		public OrderFormDetail()
		{}
		#region Model
		private long _id;
		private long? _orderformid;
		private string _orderformno;
		private int? _productid;
		private string _productno;
		private string _productname;
		private string _spec;
		private decimal? _price;
		private int? _number;
		private decimal? _websiteprice;
		private decimal? _totalprice;
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
		/// 订单ID
		/// </summary>
		public long? OrderFormID
		{
			set{ _orderformid=value;}
			get{return _orderformid;}
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
		/// 产品ID
		/// </summary>
		public int? ProductID
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 产品编号
		/// </summary>
		public string ProductNo
		{
			set{ _productno=value;}
			get{return _productno;}
		}
		/// <summary>
		/// 产品名称
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 规格
		/// </summary>
		public string Spec
		{
			set{ _spec=value;}
			get{return _spec;}
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public int? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 本网站价
		/// </summary>
		public decimal? WebsitePrice
		{
			set{ _websiteprice=value;}
			get{return _websiteprice;}
		}
		/// <summary>
		/// 总金额
		/// </summary>
		public decimal? TotalPrice
		{
			set{ _totalprice=value;}
			get{return _totalprice;}
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

