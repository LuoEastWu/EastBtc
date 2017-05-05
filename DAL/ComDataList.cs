using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;

namespace JY.DAL
{
	/// <summary>
	/// 数据访问类:ComDataList
	/// </summary>
	public partial class ComDataList
	{
		public ComDataList()
		{}
		#region  Method

        /// <summary>
        /// 获得通用数据
        /// </summary>
        public DataTable GetComList(int top, string fields, string tables, string where, string fieldorder)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (top > 0)
                {
                    strSql.Append(" top " + top.ToString());
                }
                if (fields.Trim() != "")
                {
                    strSql.Append(" " + fields + " ");
                }
                else
                {
                    return null;
                }
                if (tables.Trim() != "")
                {
                    strSql.Append(" from " + tables + " ");
                }
                else
                {
                    return null;
                }
                if (where.Trim() != "")
                {
                    strSql.Append(" where " + where);
                }
                if (fieldorder.Trim() != "")
                {
                    strSql.Append(" order by " + fieldorder);
                }
                return DbHelperSQL.Query(strSql.ToString()).Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		#endregion  Method
	}
}

