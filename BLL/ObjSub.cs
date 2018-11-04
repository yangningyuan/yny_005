/**  版本信息模板在安装目录下，可自行修改。
* ObjSub.cs
*
* 功 能： N/A
* 类 名： ObjSub
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/11/4 19:33:05   N/A    初版
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
	/// ObjSub
	/// </summary>
	public  partial class ObjSub
	{
		
		/// <summary>
		/// 得到最大ID
		/// </summary>
		public static int GetMaxId()
		{
			return DAL.ObjSub.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public static bool Exists(int ID)
		{
			return DAL.ObjSub.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public static int  Add(yny_005.Model.ObjSub model)
		{
			return DAL.ObjSub.Add(model);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static Hashtable Add(yny_005.Model.ObjSub model, Hashtable MyHs)
        {
            return DAL.ObjSub.Add(model, MyHs);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(yny_005.Model.ObjSub model)
		{
			return DAL.ObjSub.Update(model);
		}
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static Hashtable Update(yny_005.Model.ObjSub model, Hashtable MyHs)
        {
            return DAL.ObjSub.Update(model,MyHs);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool Delete(int ID)
		{
			
			return DAL.ObjSub.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public static bool DeleteList(string IDlist )
		{
			return DAL.ObjSub.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public static yny_005.Model.ObjSub GetModel(int ID)
		{
			
			return DAL.ObjSub.GetModel(ID);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public static DataSet GetList(string strWhere)
		{
			return DAL.ObjSub.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public static DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return DAL.ObjSub.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public static List<yny_005.Model.ObjSub> GetModelList(string strWhere)
		{
			DataSet ds = DAL.ObjSub.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public static List<yny_005.Model.ObjSub> DataTableToList(DataTable dt)
		{
			List<yny_005.Model.ObjSub> modelList = new List<yny_005.Model.ObjSub>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				yny_005.Model.ObjSub model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = DAL.ObjSub.DataRowToModel(dt.Rows[n]);
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
			return DAL.ObjSub.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public static DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return DAL.ObjSub.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public static DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return DAL.ObjSub.GetList(PageSize,PageIndex,strWhere);
		//}

		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

