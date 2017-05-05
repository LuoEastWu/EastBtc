using System;
namespace JY.Model
{
	/// <summary>
	/// Advert:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Advert
	{
		public Advert()
		{}
		#region Model
		private long _id;
		private long? _adverttypeid;
		private int? _advertcategory;
		private string _advertname;
		private string _advertpic;
		private string _adverturl;
		private string _description;
		private int? _height;
		private int? _width;
		private long? _sort;
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
		/// 广告分类ID
		/// </summary>
		public long? AdvertTypeId
		{
			set{ _adverttypeid=value;}
			get{return _adverttypeid;}
		}
		/// <summary>
		/// 广告类型
		/// </summary>
		public int? AdvertCategory
		{
			set{ _advertcategory=value;}
			get{return _advertcategory;}
		}
		/// <summary>
		/// 广告名称
		/// </summary>
		public string AdvertName
		{
			set{ _advertname=value;}
			get{return _advertname;}
		}
		/// <summary>
		/// 广告图片
		/// </summary>
		public string AdvertPic
		{
			set{ _advertpic=value;}
			get{return _advertpic;}
		}
		/// <summary>
		/// 广告链接
		/// </summary>
		public string AdvertUrl
		{
			set{ _adverturl=value;}
			get{return _adverturl;}
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
		/// 高度
		/// </summary>
		public int? Height
		{
			set{ _height=value;}
			get{return _height;}
		}
		/// <summary>
		/// 宽度
		/// </summary>
		public int? Width
		{
			set{ _width=value;}
			get{return _width;}
		}
		/// <summary>
		/// 排序值
		/// </summary>
		public long? Sort
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

