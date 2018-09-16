﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace yny_005.BLL
{
    //OrderDetail
    public class OrderDetail
    {
        public static Model.OrderDetail GetModel(object obj)
        {
            return yny_005.DAL.OrderDetail.GetModel(obj);
        }

        public static Model.OrderDetail GetModelCode(string code)
        {
            return yny_005.DAL.OrderDetail.GetModelCode(code);
        }

        public static Hashtable Insert(Model.OrderDetail model, Hashtable MyHs)
        {
            return yny_005.DAL.OrderDetail.Insert(model, MyHs);
        }

        public static bool Insert(Model.OrderDetail model)
        {
            return yny_005.DAL.OrderDetail.Insert(model);
        }

        public static Hashtable Update(Model.OrderDetail model, Hashtable MyHs)
        {
            return yny_005.DAL.OrderDetail.Update(model, MyHs);
        }

        public static bool Update(Model.OrderDetail model)
        {
            return yny_005.DAL.OrderDetail.Update(model);
        }

        public static Hashtable Delete(object obj, Hashtable MyHs)
        {
            return yny_005.DAL.OrderDetail.Delete(obj, MyHs);
        }

        public static bool Delete(object obj)
        {
            return yny_005.DAL.OrderDetail.Delete(obj);
        }

        public static DataTable GetTable(string strWhere)
        {
            return yny_005.DAL.OrderDetail.GetTable(strWhere);
        }

        public static DataTable GetTable(string strWhere, int pageIndex, int pageSize, out int count)
        {
            return yny_005.DAL.OrderDetail.GetTable(strWhere, pageIndex, pageSize, out count);
        }

        public static List<Model.OrderDetail> GetList(string strWhere)
        {
            return yny_005.DAL.OrderDetail.GetList(strWhere);
        }

        public static List<Model.OrderDetail> GetList(string strWhere, int pageIndex, int pageSize, out int count)
        {
            return yny_005.DAL.OrderDetail.GetList(strWhere, pageIndex, pageSize, out count);
        }
    }
}
