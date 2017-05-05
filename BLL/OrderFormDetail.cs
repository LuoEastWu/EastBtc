using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using JY.Model;
namespace JY.BLL
{
	/// <summary>
	/// OrderFormDetail
	/// </summary>
	public partial class OrderFormDetail
	{
		private readonly JY.DAL.OrderFormDetail dal=new JY.DAL.OrderFormDetail();
		public OrderFormDetail()
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
		public long Add(JY.Model.OrderFormDetail model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(JY.Model.OrderFormDetail model)
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
		public JY.Model.OrderFormDetail GetModel(long ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public JY.Model.OrderFormDetail GetModelByCache(long ID)
		{
			
			string CacheKey = "OrderFormDetailModel-" + ID;
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
			return (JY.Model.OrderFormDetail)objModel;
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
		public List<JY.Model.OrderFormDetail> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<JY.Model.OrderFormDetail> DataTableToList(DataTable dt)
		{
			List<JY.Model.OrderFormDetail> modelList = new List<JY.Model.OrderFormDetail>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				JY.Model.OrderFormDetail model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new JY.Model.OrderFormDetail();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=long.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["OrderFormID"]!=null && dt.Rows[n]["OrderFormID"].ToString()!="")
					{
						model.OrderFormID=long.Parse(dt.Rows[n]["OrderFormID"].ToString());
					}
					if(dt.Rows[n]["OrderFormNo"]!=null && dt.Rows[n]["OrderFormNo"].ToString()!="")
					{
					model.OrderFormNo=dt.Rows[n]["OrderFormNo"].ToString();
					}
					if(dt.Rows[n]["ProductID"]!=null && dt.Rows[n]["ProductID"].ToString()!="")
					{
						model.ProductID=int.Parse(dt.Rows[n]["ProductID"].ToString());
					}
					if(dt.Rows[n]["ProductNo"]!=null && dt.Rows[n]["ProductNo"].ToString()!="")
					{
					model.ProductNo=dt.Rows[n]["ProductNo"].ToString();
					}
					if(dt.Rows[n]["ProductName"]!=null && dt.Rows[n]["ProductName"].ToString()!="")
					{
					model.ProductName=dt.Rows[n]["ProductName"].ToString();
					}
					if(dt.Rows[n]["Spec"]!=null && dt.Rows[n]["Spec"].ToString()!="")
					{
					model.Spec=dt.Rows[n]["Spec"].ToString();
					}
					if(dt.Rows[n]["Price"]!=null && dt.Rows[n]["Price"].ToString()!="")
					{
						model.Price=decimal.Parse(dt.Rows[n]["Price"].ToString());
					}
					if(dt.Rows[n]["Number"]!=null && dt.Rows[n]["Number"].ToString()!="")
					{
						model.Number=int.Parse(dt.Rows[n]["Number"].ToString());
					}
					if(dt.Rows[n]["WebsitePrice"]!=null && dt.Rows[n]["WebsitePrice"].ToString()!="")
					{
						model.WebsitePrice=decimal.Parse(dt.Rows[n]["WebsitePrice"].ToString());
					}
					if(dt.Rows[n]["TotalPrice"]!=null && dt.Rows[n]["TotalPrice"].ToString()!="")
					{
						model.TotalPrice=decimal.Parse(dt.Rows[n]["TotalPrice"].ToString());
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

