﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace yny_005.BLL
{
    public class CommonBase
    {
        /// <summary>
        /// 执行事物
        /// </summary>
        /// <param name="SQLStringList"></param>
        /// <returns></returns>
        public static bool RunHashtable(Hashtable hashtable)
        {
            return DAL.CommonBase.RunHashtable(hashtable);
        }
        /// <summary>
        /// 随机字符串 时间+6位随机串
        /// </summary>
        /// <returns></returns>
        public static string RamNumber()
        {
            Random rd = new Random();
            int dd = rd.Next(100000, 999999);
            return DateTime.Now.ToString("yyyyMMddHHmmssfff") + dd.ToString();
        }

        

        public static object GetSingle(string strSql)
        {
            return DAL.CommonBase.GetSingle(strSql);
        }


        public static DataTable GetTable(string strSql)
        {
            return DAL.CommonBase.GetTable(strSql);
        }

        public static bool TestSql(string mkey)
        {
            return DAL.CommonBase.TestSql(mkey);
        }
        public static void RunSql(string strSql)
        {
            DAL.CommonBase.RunSql(strSql);
        }
    }
}
