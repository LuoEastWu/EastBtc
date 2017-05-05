using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using JY.Model;
namespace JY.BLL
{
	/// <summary>
	/// Advert
	/// </summary>
	public partial class Advert
	{
		private readonly JY.DAL.Advert dal=new JY.DAL.Advert();
		public Advert()
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
		public long Add(JY.Model.Advert model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(JY.Model.Advert model)
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
		public JY.Model.Advert GetModel(long ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public JY.Model.Advert GetModelByCache(long ID)
		{
			
			string CacheKey = "AdvertModel-" + ID;
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
			return (JY.Model.Advert)objModel;
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
		public List<JY.Model.Advert> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<JY.Model.Advert> DataTableToList(DataTable dt)
		{
			List<JY.Model.Advert> modelList = new List<JY.Model.Advert>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				JY.Model.Advert model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new JY.Model.Advert();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=long.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["AdvertTypeId"]!=null && dt.Rows[n]["AdvertTypeId"].ToString()!="")
					{
						model.AdvertTypeId=long.Parse(dt.Rows[n]["AdvertTypeId"].ToString());
					}
					if(dt.Rows[n]["AdvertCategory"]!=null && dt.Rows[n]["AdvertCategory"].ToString()!="")
					{
						model.AdvertCategory=int.Parse(dt.Rows[n]["AdvertCategory"].ToString());
					}
					if(dt.Rows[n]["AdvertName"]!=null && dt.Rows[n]["AdvertName"].ToString()!="")
					{
					model.AdvertName=dt.Rows[n]["AdvertName"].ToString();
					}
					if(dt.Rows[n]["AdvertPic"]!=null && dt.Rows[n]["AdvertPic"].ToString()!="")
					{
					model.AdvertPic=dt.Rows[n]["AdvertPic"].ToString();
					}
					if(dt.Rows[n]["AdvertUrl"]!=null && dt.Rows[n]["AdvertUrl"].ToString()!="")
					{
					model.AdvertUrl=dt.Rows[n]["AdvertUrl"].ToString();
					}
					if(dt.Rows[n]["Description"]!=null && dt.Rows[n]["Description"].ToString()!="")
					{
					model.Description=dt.Rows[n]["Description"].ToString();
					}
					if(dt.Rows[n]["Height"]!=null && dt.Rows[n]["Height"].ToString()!="")
					{
						model.Height=int.Parse(dt.Rows[n]["Height"].ToString());
					}
					if(dt.Rows[n]["Width"]!=null && dt.Rows[n]["Width"].ToString()!="")
					{
						model.Width=int.Parse(dt.Rows[n]["Width"].ToString());
					}
					if(dt.Rows[n]["Sort"]!=null && dt.Rows[n]["Sort"].ToString()!="")
					{
						model.Sort=long.Parse(dt.Rows[n]["Sort"].ToString());
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

