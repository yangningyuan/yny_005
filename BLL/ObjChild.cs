/**  版本信息模板在安装目录下，可自行修改。
* ObjChild.cs
*
* 功 能： N/A
* 类 名： ObjChild
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/10/29 21:42:42   N/A    初版
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
using System.Collections;

namespace yny_005.BLL
{
	/// <summary>
	/// ObjChild
	/// </summary>
	public static partial class ObjChild
	{
		
		#region  BasicMethod

	

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public static bool Exists(int ID)
		{
			return DAL.ObjChild.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public static int  Add(yny_005.Model.ObjChild model)
		{
			return DAL.ObjChild.Add(model);
		}

        /// <summary>
		/// 增加一条数据
		/// </summary>
		public static Hashtable Add(yny_005.Model.ObjChild model,Hashtable MyHs)
        {
            return DAL.ObjChild.Add(model,MyHs);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(yny_005.Model.ObjChild model)
		{
			return DAL.ObjChild.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public static bool Delete(int ID)
		{
			
			return DAL.ObjChild.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public static bool DeleteList(string IDlist )
		{
			return DAL.ObjChild.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public static yny_005.Model.ObjChild GetModel(int ID)
		{
			
			return DAL.ObjChild.GetModel(ID);
		}

		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public static DataSet GetList(string strWhere)
		{
			return DAL.ObjChild.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public static DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return DAL.ObjChild.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public static List<yny_005.Model.ObjChild> GetModelList(string strWhere)
		{
			DataSet ds = DAL.ObjChild.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public static List<yny_005.Model.ObjChild> DataTableToList(DataTable dt)
		{
			List<yny_005.Model.ObjChild> modelList = new List<yny_005.Model.ObjChild>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				yny_005.Model.ObjChild model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = DAL.ObjChild.DataRowToModel(dt.Rows[n]);
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
			return DAL.ObjChild.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public static DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return DAL.ObjChild.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public static DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return DAL.ObjChild.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

