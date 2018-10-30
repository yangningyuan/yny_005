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
using System.Text;
using System.Data.SqlClient;
using DBUtility;
using System.Collections;

namespace yny_005.DAL
{
	/// <summary>
	/// 数据访问类:ObjChild
	/// </summary>
	public partial class ObjChild
	{
		
		#region  BasicMethod

	
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public static bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ObjChild");
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
		public static int Add(yny_005.Model.ObjChild model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ObjChild(");
			strSql.Append("ObjID,ChildName,ChildValue,OID,ObjOID)");
			strSql.Append(" values (");
			strSql.Append("@ObjID,@ChildName,@ChildValue,@OID,@ObjOID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjID", SqlDbType.Int,4),
					new SqlParameter("@ChildName", SqlDbType.VarChar,150),
					new SqlParameter("@ChildValue", SqlDbType.VarChar,250),new SqlParameter("@OID", SqlDbType.VarChar,50),new SqlParameter("@ObjOID", SqlDbType.VarChar,50)};
			parameters[0].Value = model.ObjID;
			parameters[1].Value = model.ChildName;
			parameters[2].Value = model.ChildValue;
            parameters[3].Value = model.OID;
            parameters[4].Value = model.ObjOID;

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
		/// 增加一条数据
		/// </summary>
		public static Hashtable Add(yny_005.Model.ObjChild model, Hashtable MyHs)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ObjChild(");
            strSql.Append("ObjID,ChildName,ChildValue,OID,ObjOID)");
            strSql.Append(" values (");
            strSql.Append("@ObjID,@ChildName,@ChildValue,@OID,@ObjOID)");
            SqlParameter[] parameters = {
                    new SqlParameter("@ObjID", SqlDbType.Int,4),
                    new SqlParameter("@ChildName", SqlDbType.VarChar,150),
                    new SqlParameter("@ChildValue", SqlDbType.VarChar,250),new SqlParameter("@OID", SqlDbType.VarChar,50),new SqlParameter("@ObjOID", SqlDbType.VarChar,50)};
            parameters[0].Value = model.ObjID;
            parameters[1].Value = model.ChildName;
            parameters[2].Value = model.ChildValue;
            parameters[3].Value = model.OID;
            parameters[4].Value = model.ObjOID;
            string guid = Guid.NewGuid().ToString();
            strSql.AppendFormat("; select '{0}'", guid);

            MyHs.Add(strSql.ToString(), parameters);

            return MyHs;
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(yny_005.Model.ObjChild model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ObjChild set ");
			strSql.Append("ObjID=@ObjID,");
			strSql.Append("ChildName=@ChildName,");
			strSql.Append("ChildValue=@ChildValue,");
            strSql.Append("OID=@OID,");
            strSql.Append("ObjOID=@ObjOID");
            strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjID", SqlDbType.Int,4),
					new SqlParameter("@ChildName", SqlDbType.VarChar,150),
					new SqlParameter("@ChildValue", SqlDbType.VarChar,250),
                    new SqlParameter("@OID", SqlDbType.VarChar,50),
                    new SqlParameter("@ObjOID", SqlDbType.VarChar,50),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ObjID;
			parameters[1].Value = model.ChildName;
			parameters[2].Value = model.ChildValue;
            parameters[3].Value = model.OID;
            parameters[4].Value = model.ObjOID;
            parameters[5].Value = model.ID;

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
			strSql.Append("delete from ObjChild ");
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
			strSql.Append("delete from ObjChild ");
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
		public static yny_005.Model.ObjChild GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ObjID,ChildName,ChildValue,OID,ObjOID from ObjChild ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			yny_005.Model.ObjChild model=new yny_005.Model.ObjChild();
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
		public static yny_005.Model.ObjChild DataRowToModel(DataRow row)
		{
			yny_005.Model.ObjChild model=new yny_005.Model.ObjChild();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["ObjID"]!=null && row["ObjID"].ToString()!="")
				{
					model.ObjID=int.Parse(row["ObjID"].ToString());
				}
				if(row["ChildName"]!=null)
				{
					model.ChildName=row["ChildName"].ToString();
				}
				if(row["ChildValue"]!=null)
				{
					model.ChildValue=row["ChildValue"].ToString();
				}
                if (row["OID"] != null)
                {
                    model.OID= row["OID"].ToString();
                }
                if (row["ObjOID"] != null)
                {
                    model.ObjOID = row["ObjOID"].ToString();
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
			strSql.Append("select ID,ObjID,ChildName,ChildValue,OID,ObjOID ");
			strSql.Append(" FROM ObjChild ");
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
			strSql.Append(" ID,ObjID,ChildName,ChildValue,OID,ObjOID ");
			strSql.Append(" FROM ObjChild ");
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
			strSql.Append("select count(1) FROM ObjChild ");
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
			strSql.Append(")AS Row, T.*  from ObjChild T ");
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
			parameters[0].Value = "ObjChild";
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

