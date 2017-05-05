using System;
namespace JY.Model
{
	/// <summary>
	/// UserType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserType
	{
		public UserType()
		{}
		#region Model
		private long _id;
		private string _usertypename;
		private string _remark;
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
		/// 用户类型名称
		/// </summary>
		public string UserTypeName
		{
			set{ _usertypename=value;}
			get{return _usertypename;}
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

