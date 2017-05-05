using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using JY.Model;
namespace JY.BLL
{
	/// <summary>
	/// Product
	/// </summary>
	public partial class Product
	{
		private readonly JY.DAL.Product dal=new JY.DAL.Product();
		public Product()
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
		public long Add(JY.Model.Product model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(JY.Model.Product model)
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
		public JY.Model.Product GetModel(long ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public JY.Model.Product GetModelByCache(long ID)
		{
			
			string CacheKey = "ProductModel-" + ID;
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
			return (JY.Model.Product)objModel;
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
		public List<JY.Model.Product> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<JY.Model.Product> DataTableToList(DataTable dt)
		{
			List<JY.Model.Product> modelList = new List<JY.Model.Product>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				JY.Model.Product model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new JY.Model.Product();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=long.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["ProductTypeId"]!=null && dt.Rows[n]["ProductTypeId"].ToString()!="")
					{
						model.ProductTypeId=long.Parse(dt.Rows[n]["ProductTypeId"].ToString());
					}
					if(dt.Rows[n]["ProductNo"]!=null && dt.Rows[n]["ProductNo"].ToString()!="")
					{
					model.ProductNo=dt.Rows[n]["ProductNo"].ToString();
					}
					if(dt.Rows[n]["ProductName"]!=null && dt.Rows[n]["ProductName"].ToString()!="")
					{
					model.ProductName=dt.Rows[n]["ProductName"].ToString();
					}
					if(dt.Rows[n]["ProductPic"]!=null && dt.Rows[n]["ProductPic"].ToString()!="")
					{
					model.ProductPic=dt.Rows[n]["ProductPic"].ToString();
					}
					if(dt.Rows[n]["Description"]!=null && dt.Rows[n]["Description"].ToString()!="")
					{
					model.Description=dt.Rows[n]["Description"].ToString();
					}
					if(dt.Rows[n]["Brand"]!=null && dt.Rows[n]["Brand"].ToString()!="")
					{
						model.Brand=int.Parse(dt.Rows[n]["Brand"].ToString());
					}
					if(dt.Rows[n]["Spec"]!=null && dt.Rows[n]["Spec"].ToString()!="")
					{
					model.Spec=dt.Rows[n]["Spec"].ToString();
					}
					if(dt.Rows[n]["MarketPrice"]!=null && dt.Rows[n]["MarketPrice"].ToString()!="")
					{
						model.MarketPrice=decimal.Parse(dt.Rows[n]["MarketPrice"].ToString());
					}
					if(dt.Rows[n]["WebsitePrice"]!=null && dt.Rows[n]["WebsitePrice"].ToString()!="")
					{
						model.WebsitePrice=decimal.Parse(dt.Rows[n]["WebsitePrice"].ToString());
					}
					if(dt.Rows[n]["ProductClick"]!=null && dt.Rows[n]["ProductClick"].ToString()!="")
					{
						model.ProductClick=int.Parse(dt.Rows[n]["ProductClick"].ToString());
					}
					if(dt.Rows[n]["ProductNum"]!=null && dt.Rows[n]["ProductNum"].ToString()!="")
					{
						model.ProductNum=int.Parse(dt.Rows[n]["ProductNum"].ToString());
					}
					if(dt.Rows[n]["ProductTotal"]!=null && dt.Rows[n]["ProductTotal"].ToString()!="")
					{
						model.ProductTotal=decimal.Parse(dt.Rows[n]["ProductTotal"].ToString());
					}
					if(dt.Rows[n]["SalesVolume"]!=null && dt.Rows[n]["SalesVolume"].ToString()!="")
					{
						model.SalesVolume=int.Parse(dt.Rows[n]["SalesVolume"].ToString());
					}
					if(dt.Rows[n]["Sort"]!=null && dt.Rows[n]["Sort"].ToString()!="")
					{
						model.Sort=int.Parse(dt.Rows[n]["Sort"].ToString());
					}
					if(dt.Rows[n]["CreateDate"]!=null && dt.Rows[n]["CreateDate"].ToString()!="")
					{
						model.CreateDate=DateTime.Parse(dt.Rows[n]["CreateDate"].ToString());
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

