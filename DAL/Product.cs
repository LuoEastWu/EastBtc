using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace JY.DAL
{
	/// <summary>
	/// 数据访问类:Product
	/// </summary>
	public partial class Product
	{
		public Product()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long ID)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ID;

			int result= DbHelperSQL.RunProcedure("Product_Exists",parameters,out rowsAffected);
			if(result==1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		///  增加一条数据
		/// </summary>
		public long Add(JY.Model.Product model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt,8),
					new SqlParameter("@ProductTypeId", SqlDbType.BigInt,8),
					new SqlParameter("@ProductNo", SqlDbType.NVarChar,50),
					new SqlParameter("@ProductName", SqlDbType.NVarChar,50),
					new SqlParameter("@ProductPic", SqlDbType.NVarChar,50),
					new SqlParameter("@Description", SqlDbType.NText),
					new SqlParameter("@Brand", SqlDbType.Int,4),
					new SqlParameter("@Spec", SqlDbType.NVarChar,50),
					new SqlParameter("@MarketPrice", SqlDbType.Decimal,9),
					new SqlParameter("@WebsitePrice", SqlDbType.Decimal,9),
					new SqlParameter("@ProductClick", SqlDbType.Int,4),
					new SqlParameter("@ProductNum", SqlDbType.Int,4),
					new SqlParameter("@ProductTotal", SqlDbType.Decimal,9),
					new SqlParameter("@SalesVolume", SqlDbType.Int,4),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.ProductTypeId;
			parameters[2].Value = model.ProductNo;
			parameters[3].Value = model.ProductName;
			parameters[4].Value = model.ProductPic;
			parameters[5].Value = model.Description;
			parameters[6].Value = model.Brand;
			parameters[7].Value = model.Spec;
			parameters[8].Value = model.MarketPrice;
			parameters[9].Value = model.WebsitePrice;
			parameters[10].Value = model.ProductClick;
			parameters[11].Value = model.ProductNum;
			parameters[12].Value = model.ProductTotal;
			parameters[13].Value = model.SalesVolume;
			parameters[14].Value = model.Sort;
			parameters[15].Value = model.CreateDate;
			parameters[16].Value = model.IsDelete;

			DbHelperSQL.RunProcedure("Product_ADD",parameters,out rowsAffected);
			return (long)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(JY.Model.Product model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt,8),
					new SqlParameter("@ProductTypeId", SqlDbType.BigInt,8),
					new SqlParameter("@ProductNo", SqlDbType.NVarChar,50),
					new SqlParameter("@ProductName", SqlDbType.NVarChar,50),
					new SqlParameter("@ProductPic", SqlDbType.NVarChar,50),
					new SqlParameter("@Description", SqlDbType.NText),
					new SqlParameter("@Brand", SqlDbType.Int,4),
					new SqlParameter("@Spec", SqlDbType.NVarChar,50),
					new SqlParameter("@MarketPrice", SqlDbType.Decimal,9),
					new SqlParameter("@WebsitePrice", SqlDbType.Decimal,9),
					new SqlParameter("@ProductClick", SqlDbType.Int,4),
					new SqlParameter("@ProductNum", SqlDbType.Int,4),
					new SqlParameter("@ProductTotal", SqlDbType.Decimal,9),
					new SqlParameter("@SalesVolume", SqlDbType.Int,4),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.ProductTypeId;
			parameters[2].Value = model.ProductNo;
			parameters[3].Value = model.ProductName;
			parameters[4].Value = model.ProductPic;
			parameters[5].Value = model.Description;
			parameters[6].Value = model.Brand;
			parameters[7].Value = model.Spec;
			parameters[8].Value = model.MarketPrice;
			parameters[9].Value = model.WebsitePrice;
			parameters[10].Value = model.ProductClick;
			parameters[11].Value = model.ProductNum;
			parameters[12].Value = model.ProductTotal;
			parameters[13].Value = model.SalesVolume;
			parameters[14].Value = model.Sort;
			parameters[15].Value = model.CreateDate;
			parameters[16].Value = model.IsDelete;

			DbHelperSQL.RunProcedure("Product_Update",parameters,out rowsAffected);
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long ID)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ID;

			DbHelperSQL.RunProcedure("Product_Delete",parameters,out rowsAffected);
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Product ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public JY.Model.Product GetModel(long ID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ID;

			JY.Model.Product model=new JY.Model.Product();
			DataSet ds= DbHelperSQL.RunProcedure("Product_GetModel",parameters,"ds");
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=long.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductTypeId"]!=null && ds.Tables[0].Rows[0]["ProductTypeId"].ToString()!="")
				{
					model.ProductTypeId=long.Parse(ds.Tables[0].Rows[0]["ProductTypeId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductNo"]!=null && ds.Tables[0].Rows[0]["ProductNo"].ToString()!="")
				{
					model.ProductNo=ds.Tables[0].Rows[0]["ProductNo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ProductName"]!=null && ds.Tables[0].Rows[0]["ProductName"].ToString()!="")
				{
					model.ProductName=ds.Tables[0].Rows[0]["ProductName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ProductPic"]!=null && ds.Tables[0].Rows[0]["ProductPic"].ToString()!="")
				{
					model.ProductPic=ds.Tables[0].Rows[0]["ProductPic"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Description"]!=null && ds.Tables[0].Rows[0]["Description"].ToString()!="")
				{
					model.Description=ds.Tables[0].Rows[0]["Description"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Brand"]!=null && ds.Tables[0].Rows[0]["Brand"].ToString()!="")
				{
					model.Brand=int.Parse(ds.Tables[0].Rows[0]["Brand"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Spec"]!=null && ds.Tables[0].Rows[0]["Spec"].ToString()!="")
				{
					model.Spec=ds.Tables[0].Rows[0]["Spec"].ToString();
				}
				if(ds.Tables[0].Rows[0]["MarketPrice"]!=null && ds.Tables[0].Rows[0]["MarketPrice"].ToString()!="")
				{
					model.MarketPrice=decimal.Parse(ds.Tables[0].Rows[0]["MarketPrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["WebsitePrice"]!=null && ds.Tables[0].Rows[0]["WebsitePrice"].ToString()!="")
				{
					model.WebsitePrice=decimal.Parse(ds.Tables[0].Rows[0]["WebsitePrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductClick"]!=null && ds.Tables[0].Rows[0]["ProductClick"].ToString()!="")
				{
					model.ProductClick=int.Parse(ds.Tables[0].Rows[0]["ProductClick"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductNum"]!=null && ds.Tables[0].Rows[0]["ProductNum"].ToString()!="")
				{
					model.ProductNum=int.Parse(ds.Tables[0].Rows[0]["ProductNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductTotal"]!=null && ds.Tables[0].Rows[0]["ProductTotal"].ToString()!="")
				{
					model.ProductTotal=decimal.Parse(ds.Tables[0].Rows[0]["ProductTotal"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SalesVolume"]!=null && ds.Tables[0].Rows[0]["SalesVolume"].ToString()!="")
				{
					model.SalesVolume=int.Parse(ds.Tables[0].Rows[0]["SalesVolume"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Sort"]!=null && ds.Tables[0].Rows[0]["Sort"].ToString()!="")
				{
					model.Sort=int.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreateDate"]!=null && ds.Tables[0].Rows[0]["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(ds.Tables[0].Rows[0]["CreateDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsDelete"]!=null && ds.Tables[0].Rows[0]["IsDelete"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsDelete"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsDelete"].ToString().ToLower()=="true"))
					{
						model.IsDelete=true;
					}
					else
					{
						model.IsDelete=false;
					}
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,ProductTypeId,ProductNo,ProductName,ProductPic,Description,Brand,Spec,MarketPrice,WebsitePrice,ProductClick,ProductNum,ProductTotal,SalesVolume,Sort,CreateDate,IsDelete ");
			strSql.Append(" FROM Product ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,ProductTypeId,ProductNo,ProductName,ProductPic,Description,Brand,Spec,MarketPrice,WebsitePrice,ProductClick,ProductNum,ProductTotal,SalesVolume,Sort,CreateDate,IsDelete ");
			strSql.Append(" FROM Product ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Product ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from Product T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Product";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

