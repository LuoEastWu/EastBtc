using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace JY.DAL
{
	/// <summary>
	/// 数据访问类:Advert
	/// </summary>
	public partial class Advert
	{
		public Advert()
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

			int result= DbHelperSQL.RunProcedure("Advert_Exists",parameters,out rowsAffected);
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
		public long Add(JY.Model.Advert model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt,8),
					new SqlParameter("@AdvertTypeId", SqlDbType.BigInt,8),
					new SqlParameter("@AdvertCategory", SqlDbType.Int,4),
					new SqlParameter("@AdvertName", SqlDbType.NVarChar,50),
					new SqlParameter("@AdvertPic", SqlDbType.NVarChar,50),
					new SqlParameter("@AdvertUrl", SqlDbType.NText),
					new SqlParameter("@Description", SqlDbType.NText),
					new SqlParameter("@Height", SqlDbType.Int,4),
					new SqlParameter("@Width", SqlDbType.Int,4),
					new SqlParameter("@Sort", SqlDbType.BigInt,8),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.AdvertTypeId;
			parameters[2].Value = model.AdvertCategory;
			parameters[3].Value = model.AdvertName;
			parameters[4].Value = model.AdvertPic;
			parameters[5].Value = model.AdvertUrl;
			parameters[6].Value = model.Description;
			parameters[7].Value = model.Height;
			parameters[8].Value = model.Width;
			parameters[9].Value = model.Sort;
			parameters[10].Value = model.CreateDate;
			parameters[11].Value = model.IsDelete;

			DbHelperSQL.RunProcedure("Advert_ADD",parameters,out rowsAffected);
			return (long)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(JY.Model.Advert model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt,8),
					new SqlParameter("@AdvertTypeId", SqlDbType.BigInt,8),
					new SqlParameter("@AdvertCategory", SqlDbType.Int,4),
					new SqlParameter("@AdvertName", SqlDbType.NVarChar,50),
					new SqlParameter("@AdvertPic", SqlDbType.NVarChar,50),
					new SqlParameter("@AdvertUrl", SqlDbType.NText),
					new SqlParameter("@Description", SqlDbType.NText),
					new SqlParameter("@Height", SqlDbType.Int,4),
					new SqlParameter("@Width", SqlDbType.Int,4),
					new SqlParameter("@Sort", SqlDbType.BigInt,8),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.AdvertTypeId;
			parameters[2].Value = model.AdvertCategory;
			parameters[3].Value = model.AdvertName;
			parameters[4].Value = model.AdvertPic;
			parameters[5].Value = model.AdvertUrl;
			parameters[6].Value = model.Description;
			parameters[7].Value = model.Height;
			parameters[8].Value = model.Width;
			parameters[9].Value = model.Sort;
			parameters[10].Value = model.CreateDate;
			parameters[11].Value = model.IsDelete;

			DbHelperSQL.RunProcedure("Advert_Update",parameters,out rowsAffected);
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

			DbHelperSQL.RunProcedure("Advert_Delete",parameters,out rowsAffected);
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
			strSql.Append("delete from Advert ");
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
		public JY.Model.Advert GetModel(long ID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ID;

			JY.Model.Advert model=new JY.Model.Advert();
			DataSet ds= DbHelperSQL.RunProcedure("Advert_GetModel",parameters,"ds");
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=long.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AdvertTypeId"]!=null && ds.Tables[0].Rows[0]["AdvertTypeId"].ToString()!="")
				{
					model.AdvertTypeId=long.Parse(ds.Tables[0].Rows[0]["AdvertTypeId"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AdvertCategory"]!=null && ds.Tables[0].Rows[0]["AdvertCategory"].ToString()!="")
				{
					model.AdvertCategory=int.Parse(ds.Tables[0].Rows[0]["AdvertCategory"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AdvertName"]!=null && ds.Tables[0].Rows[0]["AdvertName"].ToString()!="")
				{
					model.AdvertName=ds.Tables[0].Rows[0]["AdvertName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["AdvertPic"]!=null && ds.Tables[0].Rows[0]["AdvertPic"].ToString()!="")
				{
					model.AdvertPic=ds.Tables[0].Rows[0]["AdvertPic"].ToString();
				}
				if(ds.Tables[0].Rows[0]["AdvertUrl"]!=null && ds.Tables[0].Rows[0]["AdvertUrl"].ToString()!="")
				{
					model.AdvertUrl=ds.Tables[0].Rows[0]["AdvertUrl"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Description"]!=null && ds.Tables[0].Rows[0]["Description"].ToString()!="")
				{
					model.Description=ds.Tables[0].Rows[0]["Description"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Height"]!=null && ds.Tables[0].Rows[0]["Height"].ToString()!="")
				{
					model.Height=int.Parse(ds.Tables[0].Rows[0]["Height"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Width"]!=null && ds.Tables[0].Rows[0]["Width"].ToString()!="")
				{
					model.Width=int.Parse(ds.Tables[0].Rows[0]["Width"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Sort"]!=null && ds.Tables[0].Rows[0]["Sort"].ToString()!="")
				{
					model.Sort=long.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
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
			strSql.Append("select ID,AdvertTypeId,AdvertCategory,AdvertName,AdvertPic,AdvertUrl,Description,Height,Width,Sort,CreateDate,IsDelete ");
			strSql.Append(" FROM Advert ");
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
			strSql.Append(" ID,AdvertTypeId,AdvertCategory,AdvertName,AdvertPic,AdvertUrl,Description,Height,Width,Sort,CreateDate,IsDelete ");
			strSql.Append(" FROM Advert ");
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
			strSql.Append("select count(1) FROM Advert ");
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
			strSql.Append(")AS Row, T.*  from Advert T ");
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
			parameters[0].Value = "Advert";
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

