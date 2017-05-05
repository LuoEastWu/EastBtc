using System;
namespace JY.Model
{
	/// <summary>
	/// Information:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Information
	{
		public Information()
		{}
		#region Model
		private long _id;
		private int? _informationtypeid;
		private string _informationname;
		private string _informationcontent;
		private string _informationpic;
		private string _description;
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
		/// 资讯分类ID
		/// </summary>
		public int? InformationTypeId
		{
			set{ _informationtypeid=value;}
			get{return _informationtypeid;}
		}
		/// <summary>
		/// 资讯标题
		/// </summary>
		public string InformationName
		{
			set{ _informationname=value;}
			get{return _informationname;}
		}
		/// <summary>
		/// 资讯内容
		/// </summary>
		public string InformationContent
		{
			set{ _informationcontent=value;}
			get{return _informationcontent;}
		}
		/// <summary>
		/// 图片
		/// </summary>
		public string InformationPic
		{
			set{ _informationpic=value;}
			get{return _informationpic;}
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

