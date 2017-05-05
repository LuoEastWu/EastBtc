using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using JY.Model;
namespace JY.BLL
{
	/// <summary>
	/// OrderForm
	/// </summary>
	public partial class OrderForm
	{
		private readonly JY.DAL.OrderForm dal=new JY.DAL.OrderForm();
		public OrderForm()
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
		public long Add(JY.Model.OrderForm model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(JY.Model.OrderForm model)
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
		public JY.Model.OrderForm GetModel(long ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public JY.Model.OrderForm GetModelByCache(long ID)
		{
			
			string CacheKey = "OrderFormModel-" + ID;
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
			return (JY.Model.OrderForm)objModel;
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
		public List<JY.Model.OrderForm> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<JY.Model.OrderForm> DataTableToList(DataTable dt)
		{
			List<JY.Model.OrderForm> modelList = new List<JY.Model.OrderForm>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				JY.Model.OrderForm model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new JY.Model.OrderForm();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=long.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["MemberId"]!=null && dt.Rows[n]["MemberId"].ToString()!="")
					{
						model.MemberId=long.Parse(dt.Rows[n]["MemberId"].ToString());
					}
					if(dt.Rows[n]["OrderFormNo"]!=null && dt.Rows[n]["OrderFormNo"].ToString()!="")
					{
					model.OrderFormNo=dt.Rows[n]["OrderFormNo"].ToString();
					}
					if(dt.Rows[n]["ProductTotalPrice"]!=null && dt.Rows[n]["ProductTotalPrice"].ToString()!="")
					{
						model.ProductTotalPrice=decimal.Parse(dt.Rows[n]["ProductTotalPrice"].ToString());
					}
					if(dt.Rows[n]["Purchaser"]!=null && dt.Rows[n]["Purchaser"].ToString()!="")
					{
					model.Purchaser=dt.Rows[n]["Purchaser"].ToString();
					}
					if(dt.Rows[n]["Consignee"]!=null && dt.Rows[n]["Consignee"].ToString()!="")
					{
					model.Consignee=dt.Rows[n]["Consignee"].ToString();
					}
					if(dt.Rows[n]["LiveAddress"]!=null && dt.Rows[n]["LiveAddress"].ToString()!="")
					{
					model.LiveAddress=dt.Rows[n]["LiveAddress"].ToString();
					}
					if(dt.Rows[n]["ZipCode"]!=null && dt.Rows[n]["ZipCode"].ToString()!="")
					{
					model.ZipCode=dt.Rows[n]["ZipCode"].ToString();
					}
					if(dt.Rows[n]["Phone"]!=null && dt.Rows[n]["Phone"].ToString()!="")
					{
					model.Phone=dt.Rows[n]["Phone"].ToString();
					}
					if(dt.Rows[n]["Remark"]!=null && dt.Rows[n]["Remark"].ToString()!="")
					{
					model.Remark=dt.Rows[n]["Remark"].ToString();
					}
					if(dt.Rows[n]["CreatDate"]!=null && dt.Rows[n]["CreatDate"].ToString()!="")
					{
						model.CreatDate=DateTime.Parse(dt.Rows[n]["CreatDate"].ToString());
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

