﻿/**  版本信息模板在安装目录下，可自行修改。
* C_Mileage.cs
*
* 功 能： N/A
* 类 名： C_Mileage
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/2/24 11:30:15   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;

using yny_005.Model;
namespace yny_005.BLL
{
	/// <summary>
	/// C_Mileage
	/// </summary>
	public partial class C_Mileage
	{
		private readonly yny_005.DAL.C_Mileage dal=new yny_005.DAL.C_Mileage();
		public C_Mileage()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public static int GetMaxId()
		{
			return DAL.C_Mileage.GetMaxId();
		}

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public static bool Exists(int ID)
		{
			return DAL.C_Mileage.Exists(ID);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static int  Add(yny_005.Model.C_Mileage model)
		{
			return DAL.C_Mileage.Add(model);
		}

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(yny_005.Model.C_Mileage model)
		{
			return DAL.C_Mileage.Update(model);
		}

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool Delete(int ID)
		{
			
			return DAL.C_Mileage.Delete(ID);
		}
       
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static yny_005.Model.C_Mileage GetModel(int ID)
		{
			
			return DAL.C_Mileage.GetModel(ID);
		}

       

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetList(string strWhere)
		{
			return DAL.C_Mileage.GetList(strWhere);
		}
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public static DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return DAL.C_Mileage.GetList(Top,strWhere,filedOrder);
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static List<yny_005.Model.C_Mileage> GetModelList(string strWhere)
		{
			DataSet ds = DAL.C_Mileage.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static List<yny_005.Model.C_Mileage> DataTableToList(DataTable dt)
		{
			List<yny_005.Model.C_Mileage> modelList = new List<yny_005.Model.C_Mileage>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				yny_005.Model.C_Mileage model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = DAL.C_Mileage.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetAllList()
		{
			return GetList("");
		}

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public static int GetRecordCount(string strWhere)
		{
			return DAL.C_Mileage.GetRecordCount(strWhere);
		}
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public static DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return DAL.C_Mileage.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}

		public static Model.C_Mileage GetModelBywhere(string where)
		{
			return DAL.C_Mileage.GetModelBywhere(where);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
		//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

