using System;
namespace JY.Model
{
	/// <summary>
	/// Review:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Review
	{
		public Review()
		{}
		#region Model
		private long _id;
		private long? _memberid;
		private int? _productid;
		private string _productname;
		private string _reviewcontent;
		private string _replycontent;
		private string _reviewname;
		private DateTime? _reviewdate;
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
		/// 产品ID
		/// </summary>
		public int? ProductId
		{
			set{ _productid=value;}
			get{return _productid;}
		}
		/// <summary>
		/// 商品名称
		/// </summary>
		public string ProductName
		{
			set{ _productname=value;}
			get{return _productname;}
		}
		/// <summary>
		/// 评论内容
		/// </summary>
		public string ReviewContent
		{
			set{ _reviewcontent=value;}
			get{return _reviewcontent;}
		}
		/// <summary>
		/// 回复内容
		/// </summary>
		public string ReplyContent
		{
			set{ _replycontent=value;}
			get{return _replycontent;}
		}
		/// <summary>
		/// 评论人
		/// </summary>
		public string ReviewName
		{
			set{ _reviewname=value;}
			get{return _reviewname;}
		}
		/// <summary>
		/// 评论时间
		/// </summary>
		public DateTime? ReviewDate
		{
			set{ _reviewdate=value;}
			get{return _reviewdate;}
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

