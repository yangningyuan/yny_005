/**  版本信息模板在安装目录下，可自行修改。
* ObjUserApply.cs
*
* 功 能： N/A
* 类 名： ObjUserApply
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/10/29 21:42:45   N/A    初版
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
	/// ObjUserApply
	/// </summary>
	public static partial class ObjUserApply
	{
		
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public static int GetMaxId()
		{
			return DAL.ObjUserApply.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public static bool Exists(int ID)
		{
			return DAL.ObjUserApply.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public static int  Add(yny_005.Model.ObjUserApply model)
		{
			return DAL.ObjUserApply.Add(model);
		}
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static Hashtable Add(yny_005.Model.ObjUserApply model, Hashtable MyHs)
        {
            return DAL.ObjUserApply.Add(model, MyHs);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(yny_005.Model.ObjUserApply model)
		{
			return DAL.ObjUserApply.Update(model);
		}

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static Hashtable Update(yny_005.Model.ObjUserApply model, Hashtable MyHs)
        {
            return DAL.ObjUserApply.Update(model, MyHs);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool Delete(int ID)
		{
			
			return DAL.ObjUserApply.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public static bool DeleteList(string IDlist )
		{
			return DAL.ObjUserApply.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public static yny_005.Model.ObjUserApply GetModel(int ID)
		{
			
			return DAL.ObjUserApply.GetModel(ID);
		}

        /// <summary>
		/// 得到一个对象实体
		/// </summary>
		public static yny_005.Model.ObjUserApply GetModelOID(String OID)
        {

            return DAL.ObjUserApply.GetModelOID(OID);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetList(string strWhere)
		{
			return DAL.ObjUserApply.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public static DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return DAL.ObjUserApply.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public static List<yny_005.Model.ObjUserApply> GetModelList(string strWhere)
		{
			DataSet ds = DAL.ObjUserApply.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}

        public static List<Model.ObjUserApply> GetList(string strWhere, int pageIndex, int pageSize, out int count)
        {
            return DAL.ObjUserApply.GetList(strWhere, pageIndex, pageSize, out count);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static List<yny_005.Model.ObjUserApply> DataTableToList(DataTable dt)
		{
			List<yny_005.Model.ObjUserApply> modelList = new List<yny_005.Model.ObjUserApply>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				yny_005.Model.ObjUserApply model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = DAL.ObjUserApply.DataRowToModel(dt.Rows[n]);
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
			return DAL.ObjUserApply.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public static DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return DAL.ObjUserApply.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public static DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return DAL.ObjUserApply.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

