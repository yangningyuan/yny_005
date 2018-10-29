﻿/**  版本信息模板在安装目录下，可自行修改。
* Object.cs
*
* 功 能： N/A
* 类 名： Object
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/10/29 21:42:43   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;//Please add references
namespace yny_005.DAL
{
	/// <summary>
	/// 数据访问类:Object
	/// </summary>
	public partial class Object
	{
		
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public static int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Object"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public static bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Object");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public static int Add(yny_005.Model.Object model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Object(");
			strSql.Append("ObjOID,ObjName,ReObjMID,ReObjNiName,ObjChild,ObjExcel,BMDate,JGDate,Remark)");
			strSql.Append(" values (");
			strSql.Append("@ObjOID,@ObjName,@ReObjMID,@ReObjNiName,@ObjChild,@ObjExcel,@BMDate,@JGDate,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjOID", SqlDbType.VarChar,50),
					new SqlParameter("@ObjName", SqlDbType.VarChar,150),
					new SqlParameter("@ReObjMID", SqlDbType.VarChar,50),
					new SqlParameter("@ReObjNiName", SqlDbType.VarChar,50),
					new SqlParameter("@ObjChild", SqlDbType.Int,4),
					new SqlParameter("@ObjExcel", SqlDbType.Int,4),
					new SqlParameter("@BMDate", SqlDbType.DateTime),
					new SqlParameter("@JGDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ObjOID;
			parameters[1].Value = model.ObjName;
			parameters[2].Value = model.ReObjMID;
			parameters[3].Value = model.ReObjNiName;
			parameters[4].Value = model.ObjChild;
			parameters[5].Value = model.ObjExcel;
			parameters[6].Value = model.BMDate;
			parameters[7].Value = model.JGDate;
			parameters[8].Value = model.Remark;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public static bool Update(yny_005.Model.Object model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Object set ");
			strSql.Append("ObjOID=@ObjOID,");
			strSql.Append("ObjName=@ObjName,");
			strSql.Append("ReObjMID=@ReObjMID,");
			strSql.Append("ReObjNiName=@ReObjNiName,");
			strSql.Append("ObjChild=@ObjChild,");
			strSql.Append("ObjExcel=@ObjExcel,");
			strSql.Append("BMDate=@BMDate,");
			strSql.Append("JGDate=@JGDate,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjOID", SqlDbType.VarChar,50),
					new SqlParameter("@ObjName", SqlDbType.VarChar,150),
					new SqlParameter("@ReObjMID", SqlDbType.VarChar,50),
					new SqlParameter("@ReObjNiName", SqlDbType.VarChar,50),
					new SqlParameter("@ObjChild", SqlDbType.Int,4),
					new SqlParameter("@ObjExcel", SqlDbType.Int,4),
					new SqlParameter("@BMDate", SqlDbType.DateTime),
					new SqlParameter("@JGDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.VarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ObjOID;
			parameters[1].Value = model.ObjName;
			parameters[2].Value = model.ReObjMID;
			parameters[3].Value = model.ReObjNiName;
			parameters[4].Value = model.ObjChild;
			parameters[5].Value = model.ObjExcel;
			parameters[6].Value = model.BMDate;
			parameters[7].Value = model.JGDate;
			parameters[8].Value = model.Remark;
			parameters[9].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public static bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Object ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public static bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Object ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public static yny_005.Model.Object GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ObjOID,ObjName,ReObjMID,ReObjNiName,ObjChild,ObjExcel,BMDate,JGDate,Remark from Object ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			yny_005.Model.Object model=new yny_005.Model.Object();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public static yny_005.Model.Object DataRowToModel(DataRow row)
		{
			yny_005.Model.Object model=new yny_005.Model.Object();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["ObjOID"]!=null)
				{
					model.ObjOID=row["ObjOID"].ToString();
				}
				if(row["ObjName"]!=null)
				{
					model.ObjName=row["ObjName"].ToString();
				}
				if(row["ReObjMID"]!=null)
				{
					model.ReObjMID=row["ReObjMID"].ToString();
				}
				if(row["ReObjNiName"]!=null)
				{
					model.ReObjNiName=row["ReObjNiName"].ToString();
				}
				if(row["ObjChild"]!=null && row["ObjChild"].ToString()!="")
				{
					model.ObjChild=int.Parse(row["ObjChild"].ToString());
				}
				if(row["ObjExcel"]!=null && row["ObjExcel"].ToString()!="")
				{
					model.ObjExcel=int.Parse(row["ObjExcel"].ToString());
				}
				if(row["BMDate"]!=null && row["BMDate"].ToString()!="")
				{
					model.BMDate=DateTime.Parse(row["BMDate"].ToString());
				}
				if(row["JGDate"]!=null && row["JGDate"].ToString()!="")
				{
					model.JGDate=DateTime.Parse(row["JGDate"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public static DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,ObjOID,ObjName,ReObjMID,ReObjNiName,ObjChild,ObjExcel,BMDate,JGDate,Remark ");
			strSql.Append(" FROM Object ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public static DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,ObjOID,ObjName,ReObjMID,ReObjNiName,ObjChild,ObjExcel,BMDate,JGDate,Remark ");
			strSql.Append(" FROM Object ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public static int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Object ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public static DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from Object T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public static DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Object";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}
