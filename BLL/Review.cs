using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using JY.Model;
namespace JY.BLL
{
	/// <summary>
	/// Review
	/// </summary>
	public partial class Review
	{
		private readonly JY.DAL.Review dal=new JY.DAL.Review();
		public Review()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(JY.Model.Review model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(JY.Model.Review model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public JY.Model.Review GetModel(long ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public JY.Model.Review GetModelByCache(long ID)
		{
			
			string CacheKey = "ReviewModel-" + ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (JY.Model.Review)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<JY.Model.Review> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<JY.Model.Review> DataTableToList(DataTable dt)
		{
			List<JY.Model.Review> modelList = new List<JY.Model.Review>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				JY.Model.Review model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new JY.Model.Review();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=long.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["MemberId"]!=null && dt.Rows[n]["MemberId"].ToString()!="")
					{
						model.MemberId=long.Parse(dt.Rows[n]["MemberId"].ToString());
					}
					if(dt.Rows[n]["ProductId"]!=null && dt.Rows[n]["ProductId"].ToString()!="")
					{
						model.ProductId=int.Parse(dt.Rows[n]["ProductId"].ToString());
					}
					if(dt.Rows[n]["ProductName"]!=null && dt.Rows[n]["ProductName"].ToString()!="")
					{
					model.ProductName=dt.Rows[n]["ProductName"].ToString();
					}
					if(dt.Rows[n]["ReviewContent"]!=null && dt.Rows[n]["ReviewContent"].ToString()!="")
					{
					model.ReviewContent=dt.Rows[n]["ReviewContent"].ToString();
					}
					if(dt.Rows[n]["ReplyContent"]!=null && dt.Rows[n]["ReplyContent"].ToString()!="")
					{
					model.ReplyContent=dt.Rows[n]["ReplyContent"].ToString();
					}
					if(dt.Rows[n]["ReviewName"]!=null && dt.Rows[n]["ReviewName"].ToString()!="")
					{
					model.ReviewName=dt.Rows[n]["ReviewName"].ToString();
					}
					if(dt.Rows[n]["ReviewDate"]!=null && dt.Rows[n]["ReviewDate"].ToString()!="")
					{
						model.ReviewDate=DateTime.Parse(dt.Rows[n]["ReviewDate"].ToString());
					}
					if(dt.Rows[n]["Sort"]!=null && dt.Rows[n]["Sort"].ToString()!="")
					{
						model.Sort=int.Parse(dt.Rows[n]["Sort"].ToString());
					}
					if(dt.Rows[n]["IsDelete"]!=null && dt.Rows[n]["IsDelete"].ToString()!="")
					{
						if((dt.Rows[n]["IsDelete"].ToString()=="1")||(dt.Rows[n]["IsDelete"].ToString().ToLower()=="true"))
						{
						model.IsDelete=true;
						}
						else
						{
							model.IsDelete=false;
						}
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

