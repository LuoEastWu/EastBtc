﻿using System;
namespace JY.Model
{
	/// <summary>
	/// MemberRank:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MemberRank
	{
		public MemberRank()
		{}
		#region Model
		private long _id;
		private string _memberrankname;
		private int? _fid;
		private int? _sort;
		private int? _depth;
		private string _remark;
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
		/// 会员等级
		/// </summary>
		public string MemberRankName
		{
			set{ _memberrankname=value;}
			get{return _memberrankname;}
		}
		/// <summary>
		/// 父类型
		/// </summary>
		public int? Fid
		{
			set{ _fid=value;}
			get{return _fid;}
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
		/// 深度
		/// </summary>
		public int? Depth
		{
			set{ _depth=value;}
			get{return _depth;}
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

