using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace JY.DAL
{
	/// <summary>
	/// 数据访问类:Review
	/// </summary>
	public partial class Review
	{
		public Review()
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

			int result= DbHelperSQL.RunProcedure("Review_Exists",parameters,out rowsAffected);
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
		public long Add(JY.Model.Review model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt,8),
					new SqlParameter("@MemberId", SqlDbType.BigInt,8),
					new SqlParameter("@ProductId", SqlDbType.Int,4),
					new SqlParameter("@ProductName", SqlDbType.NVarChar,50),
					new SqlParameter("@ReviewContent", SqlDbType.NText),
					new SqlParameter("@ReplyContent", SqlDbType.NText),
					new SqlParameter("@ReviewName", SqlDbType.NVarChar,50),
					new SqlParameter("@ReviewDate", SqlDbType.DateTime),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.MemberId;
			parameters[2].Value = model.ProductId;
			parameters[3].Value = model.ProductName;
			parameters[4].Value = model.ReviewContent;
			parameters[5].Value = model.ReplyContent;
			parameters[6].Value = model.ReviewName;
			parameters[7].Value = model.ReviewDate;
			parameters[8].Value = model.Sort;
			parameters[9].Value = model.IsDelete;

			DbHelperSQL.RunProcedure("Review_ADD",parameters,out rowsAffected);
			return (long)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(JY.Model.Review model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt,8),
					new SqlParameter("@MemberId", SqlDbType.BigInt,8),
					new SqlParameter("@ProductId", SqlDbType.Int,4),
					new SqlParameter("@ProductName", SqlDbType.NVarChar,50),
					new SqlParameter("@ReviewContent", SqlDbType.NText),
					new SqlParameter("@ReplyContent", SqlDbType.NText),
					new SqlParameter("@ReviewName", SqlDbType.NVarChar,50),
					new SqlParameter("@ReviewDate", SqlDbType.DateTime),
					new SqlParameter("@Sort", SqlDbType.Int,4),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MemberId;
			parameters[2].Value = model.ProductId;
			parameters[3].Value = model.ProductName;
			parameters[4].Value = model.ReviewContent;
			parameters[5].Value = model.ReplyContent;
			parameters[6].Value = model.ReviewName;
			parameters[7].Value = model.ReviewDate;
			parameters[8].Value = model.Sort;
			parameters[9].Value = model.IsDelete;

			DbHelperSQL.RunProcedure("Review_Update",parameters,out rowsAffected);
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

			DbHelperSQL.RunProcedure("Review_Delete",parameters,out rowsAffected);
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
			strSql.Append("delete from Review ");
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
		public JY.Model.Review GetModel(long ID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ID;

			JY.Model.Review model=new JY.Model.Review();
			DataSet ds= DbHelperSQL.RunProcedure("Review_GetModel",parameters,"ds");
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
				if(ds.Tables[0].Rows[0]["ProductId"]!=null && ds.Tables[0].Rows[0]["ProductId"].ToString()!="")
				{
					model.ProductId=int.Parse(ds.Tables[0].Rows[0]["ProductId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ProductName"]!=null && ds.Tables[0].Rows[0]["ProductName"].ToString()!="")
				{
					model.ProductName=ds.Tables[0].Rows[0]["ProductName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ReviewContent"]!=null && ds.Tables[0].Rows[0]["ReviewContent"].ToString()!="")
				{
					model.ReviewContent=ds.Tables[0].Rows[0]["ReviewContent"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ReplyContent"]!=null && ds.Tables[0].Rows[0]["ReplyContent"].ToString()!="")
				{
					model.ReplyContent=ds.Tables[0].Rows[0]["ReplyContent"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ReviewName"]!=null && ds.Tables[0].Rows[0]["ReviewName"].ToString()!="")
				{
					model.ReviewName=ds.Tables[0].Rows[0]["ReviewName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ReviewDate"]!=null && ds.Tables[0].Rows[0]["ReviewDate"].ToString()!="")
				{
					model.ReviewDate=DateTime.Parse(ds.Tables[0].Rows[0]["ReviewDate"].ToString());
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
			strSql.Append("select ID,MemberId,ProductId,ProductName,ReviewContent,ReplyContent,ReviewName,ReviewDate,Sort,IsDelete ");
			strSql.Append(" FROM Review ");
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
			strSql.Append(" ID,MemberId,ProductId,ProductName,ReviewContent,ReplyContent,ReviewName,ReviewDate,Sort,IsDelete ");
			strSql.Append(" FROM Review ");
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
			strSql.Append("select count(1) FROM Review ");
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
			strSql.Append(")AS Row, T.*  from Review T ");
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
			parameters[0].Value = "Review";
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

