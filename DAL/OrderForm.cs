using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace JY.DAL
{
	/// <summary>
	/// 数据访问类:OrderForm
	/// </summary>
	public partial class OrderForm
	{
		public OrderForm()
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

			int result= DbHelperSQL.RunProcedure("OrderForm_Exists",parameters,out rowsAffected);
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
		public long Add(JY.Model.OrderForm model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt,8),
					new SqlParameter("@MemberId", SqlDbType.BigInt,8),
					new SqlParameter("@OrderFormNo", SqlDbType.NVarChar,50),
					new SqlParameter("@ProductTotalPrice", SqlDbType.Decimal,9),
					new SqlParameter("@Purchaser", SqlDbType.NVarChar,50),
					new SqlParameter("@Consignee", SqlDbType.NVarChar,50),
					new SqlParameter("@LiveAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@CreatDate", SqlDbType.DateTime),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.MemberId;
			parameters[2].Value = model.OrderFormNo;
			parameters[3].Value = model.ProductTotalPrice;
			parameters[4].Value = model.Purchaser;
			parameters[5].Value = model.Consignee;
			parameters[6].Value = model.LiveAddress;
			parameters[7].Value = model.ZipCode;
			parameters[8].Value = model.Phone;
			parameters[9].Value = model.Remark;
			parameters[10].Value = model.CreatDate;
			parameters[11].Value = model.Sort;
			parameters[12].Value = model.IsDelete;

			DbHelperSQL.RunProcedure("OrderForm_ADD",parameters,out rowsAffected);
			return (long)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(JY.Model.OrderForm model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt,8),
					new SqlParameter("@MemberId", SqlDbType.BigInt,8),
					new SqlParameter("@OrderFormNo", SqlDbType.NVarChar,50),
					new SqlParameter("@ProductTotalPrice", SqlDbType.Decimal,9),
					new SqlParameter("@Purchaser", SqlDbType.NVarChar,50),
					new SqlParameter("@Consignee", SqlDbType.NVarChar,50),
					new SqlParameter("@LiveAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@ZipCode", SqlDbType.NVarChar,50),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@CreatDate", SqlDbType.DateTime),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MemberId;
			parameters[2].Value = model.OrderFormNo;
			parameters[3].Value = model.ProductTotalPrice;
			parameters[4].Value = model.Purchaser;
			parameters[5].Value = model.Consignee;
			parameters[6].Value = model.LiveAddress;
			parameters[7].Value = model.ZipCode;
			parameters[8].Value = model.Phone;
			parameters[9].Value = model.Remark;
			parameters[10].Value = model.CreatDate;
			parameters[11].Value = model.Sort;
			parameters[12].Value = model.IsDelete;

			DbHelperSQL.RunProcedure("OrderForm_Update",parameters,out rowsAffected);
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

			DbHelperSQL.RunProcedure("OrderForm_Delete",parameters,out rowsAffected);
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
			strSql.Append("delete from OrderForm ");
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
		public JY.Model.OrderForm GetModel(long ID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ID;

			JY.Model.OrderForm model=new JY.Model.OrderForm();
			DataSet ds= DbHelperSQL.RunProcedure("OrderForm_GetModel",parameters,"ds");
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=long.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MemberId"]!=null && ds.Tables[0].Rows[0]["MemberId"].ToString()!="")
				{
					model.MemberId=long.Parse(ds.Tables[0].Rows[0]["MemberId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OrderFormNo"]!=null && ds.Tables[0].Rows[0]["OrderFormNo"].ToString()!="")
				{
					model.OrderFormNo=ds.Tables[0].Rows[0]["OrderFormNo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ProductTotalPrice"]!=null && ds.Tables[0].Rows[0]["ProductTotalPrice"].ToString()!="")
				{
					model.ProductTotalPrice=decimal.Parse(ds.Tables[0].Rows[0]["ProductTotalPrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Purchaser"]!=null && ds.Tables[0].Rows[0]["Purchaser"].ToString()!="")
				{
					model.Purchaser=ds.Tables[0].Rows[0]["Purchaser"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Consignee"]!=null && ds.Tables[0].Rows[0]["Consignee"].ToString()!="")
				{
					model.Consignee=ds.Tables[0].Rows[0]["Consignee"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LiveAddress"]!=null && ds.Tables[0].Rows[0]["LiveAddress"].ToString()!="")
				{
					model.LiveAddress=ds.Tables[0].Rows[0]["LiveAddress"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ZipCode"]!=null && ds.Tables[0].Rows[0]["ZipCode"].ToString()!="")
				{
					model.ZipCode=ds.Tables[0].Rows[0]["ZipCode"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Phone"]!=null && ds.Tables[0].Rows[0]["Phone"].ToString()!="")
				{
					model.Phone=ds.Tables[0].Rows[0]["Phone"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null && ds.Tables[0].Rows[0]["Remark"].ToString()!="")
				{
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CreatDate"]!=null && ds.Tables[0].Rows[0]["CreatDate"].ToString()!="")
				{
					model.CreatDate=DateTime.Parse(ds.Tables[0].Rows[0]["CreatDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Sort"]!=null && ds.Tables[0].Rows[0]["Sort"].ToString()!="")
				{
					model.Sort=int.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
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
			strSql.Append("select ID,MemberId,OrderFormNo,ProductTotalPrice,Purchaser,Consignee,LiveAddress,ZipCode,Phone,Remark,CreatDate,Sort,IsDelete ");
			strSql.Append(" FROM OrderForm ");
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
			strSql.Append(" ID,MemberId,OrderFormNo,ProductTotalPrice,Purchaser,Consignee,LiveAddress,ZipCode,Phone,Remark,CreatDate,Sort,IsDelete ");
			strSql.Append(" FROM OrderForm ");
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
			strSql.Append("select count(1) FROM OrderForm ");
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
			strSql.Append(")AS Row, T.*  from OrderForm T ");
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
			parameters[0].Value = "OrderForm";
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

