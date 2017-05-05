using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using JY.Model;

namespace JY.BLL
{
	/// <summary>
	/// ComDataList
	/// </summary>
	public partial class ComDataList
	{
        private readonly JY.DAL.ComDataList dal = new JY.DAL.ComDataList();

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
                return dal.GetComList(top, fields, tables, where, fieldorder);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

		#endregion  Method
	}
}

