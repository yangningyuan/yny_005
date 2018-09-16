﻿/**  版本信息模板在安装目录下，可自行修改。
* C_Car.cs
*
* 功 能： N/A
* 类 名： C_Car
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/1/19 21:15:26   N/A    初版
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
using System.Data.Common;
using yny_005.Model;
using System.Collections;
using DBUtility;

namespace yny_005.BLL
{
	/// <summary>
	/// C_Car
	/// </summary>
	public  partial class C_Car
	{
		private readonly yny_005.DAL.C_Car dal=new yny_005.DAL.C_Car();
		public  C_Car()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public static int GetMaxId()
		{
			return DAL.C_Car.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public static bool Exists(int ID)
		{
			return DAL.C_Car.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public static int  Add(yny_005.Model.C_Car model)
		{
			return DAL.C_Car.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public static bool Update(yny_005.Model.C_Car model)
		{
			return DAL.C_Car.Update(model);
		}
        /// <summary>
		/// 更新一条数据
		/// </summary>
		public static Hashtable Update(yny_005.Model.C_Car model,Hashtable MyHs)
        {
            return DAL.C_Car.Update(model,MyHs);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool Delete(int ID)
		{
			
			return DAL.C_Car.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public static bool DeleteList(string IDlist )
		{
			return DAL.C_Car.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public static yny_005.Model.C_Car GetModel(int ID)
		{
			
			return DAL.C_Car.GetModel(ID);
		}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static yny_005.Model.C_Car GetModelByCode(string carcode)
        {

            return DAL.C_Car.GetModelByCode(carcode);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetList(string strWhere)
		{
			return DAL.C_Car.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public static DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return DAL.C_Car.GetList(Top,strWhere,filedOrder);
		}

		public static List<Model.C_Car> GetList(string strWhere, int pageIndex, int pageSize, out int count)
		{
			return DAL.C_Car.GetList(strWhere, pageIndex, pageSize, out count);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public static List<yny_005.Model.C_Car> GetModelList(string strWhere)
		{
			DataSet ds = DAL.C_Car.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public static List<yny_005.Model.C_Car> DataTableToList(DataTable dt)
		{
			List<yny_005.Model.C_Car> modelList = new List<yny_005.Model.C_Car>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				yny_005.Model.C_Car model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = DAL.C_Car.DataRowToModel(dt.Rows[n]);
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
			return DAL.C_Car.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public static DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return DAL.C_Car.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}

        public static string DeleteCarList(string midlist)
        {
            string[] arr = midlist.Split(',');
            int succ = 0;
            int erro = 0;
            foreach (string mid in arr)
            {
                if (DbHelperSQL.ExecuteSql(string.Format("update c_car set IsDelete=1 where ID={0}", mid)) > 0)
                {
                    succ++;
                }
                else
                {
                    erro++;
                }
            }
            return "成功：" + succ.ToString() + " , 失败：" + erro.ToString();
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public static DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

