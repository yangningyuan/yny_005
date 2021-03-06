﻿using System;
using System.Data;
using System.Collections.Generic;
using yny_005.Model;
namespace yny_005.BLL
{
    /// <summary>
    /// DepartType
    /// </summary>
    public partial class DepartType
    {
        
        public DepartType()
        { }
        #region  BasicMethod
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public static bool Add(yny_005.Model.DepartType model)
        {
            return DAL.DepartType.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(yny_005.Model.DepartType model)
        {
            return DAL.DepartType.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool Delete(int ID)
        {

            return DAL.DepartType.Delete(ID);
        }
        public static object DeleteDepartType(string IDList)
        {
            if (DAL.DepartType.DeleteDepartType(IDList))
                return "操作成功";
            return "操作失败";
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static yny_005.Model.DepartType GetModel(int ID)
        {

            return DAL.DepartType.GetModel(ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetList(string strWhere)
        {
            return DAL.DepartType.GetList(strWhere);
        }
        public static List<Model.DepartType> GetList(string strWhere, int pageIndex, int pageSize, out int count)
        {
            return DAL.DepartType.GetList(strWhere, pageIndex, pageSize, out count);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public static DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return DAL.DepartType.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static List<yny_005.Model.DepartType> GetModelList(string strWhere)
        {
            DataSet ds = DAL.DepartType.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static List<yny_005.Model.DepartType> DataTableToList(DataTable dt)
        {
            List<yny_005.Model.DepartType> modelList = new List<yny_005.Model.DepartType>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                yny_005.Model.DepartType model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = DAL.DepartType.DataRowToModel(dt.Rows[n]);
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
            return DAL.DepartType.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public static DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return DAL.DepartType.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return DAL.DepartType.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

