using System;
namespace JY.Model
{
	/// <summary>
	/// Product:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Product
	{
		public Product()
		{}
		#region Model
		private long _id;
		private long? _producttypeid;
		private string _productno;
		private string _productname;
		private string _productpic;
		private string _description;
		private int? _brand;
		private string _spec;
		private decimal? _marketprice;
		private decimal? _websiteprice;
		private int? _productclick;
		private int? _productnum;
		private decimal? _producttotal;
		private int? _salesvolume;
		private int? _sort;
		private DateTime? _createdate;
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
		/// 产品分类ID
		/// </summary>
		public long? ProductTypeId
		{
			set{ _producttypeid=value;}
			get{return _producttypeid;}
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
		/// 产品图片
		/// </summary>
		public string ProductPic
		{
			set{ _productpic=value;}
			get{return _productpic;}
		}
		/// <summary>
		/// 描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 品牌
		/// </summary>
		public int? Brand
		{
			set{ _brand=value;}
			get{return _brand;}
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
		/// 市场价格
		/// </summary>
		public decimal? MarketPrice
		{
			set{ _marketprice=value;}
			get{return _marketprice;}
		}
		/// <summary>
		/// 本网站价格
		/// </summary>
		public decimal? WebsitePrice
		{
			set{ _websiteprice=value;}
			get{return _websiteprice;}
		}
		/// <summary>
		/// 产品点击量
		/// </summary>
		public int? ProductClick
		{
			set{ _productclick=value;}
			get{return _productclick;}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public int? ProductNum
		{
			set{ _productnum=value;}
			get{return _productnum;}
		}
		/// <summary>
		/// 产品总价
		/// </summary>
		public decimal? ProductTotal
		{
			set{ _producttotal=value;}
			get{return _producttotal;}
		}
		/// <summary>
		/// 销售量
		/// </summary>
		public int? SalesVolume
		{
			set{ _salesvolume=value;}
			get{return _salesvolume;}
		}
		/// <summary>
		/// 排序值
		/// </summary>
		public int? Sort
		{
			set{ _sort=value;}
			get{return _sort;}
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

