using System;
namespace JY.Model
{
	/// <summary>
	/// AdvertType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AdvertType
	{
		public AdvertType()
		{}
		#region Model
		private long _id;
		private string _typename;
		private long? _fid;
		private long? _sort;
		private long? _depth;
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
		/// 类型名称
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 父类型ID
		/// </summary>
		public long? Fid
		{
			set{ _fid=value;}
			get{return _fid;}
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
		/// 深度
		/// </summary>
		public long? Depth
		{
			set{ _depth=value;}
			get{return _depth;}
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

