/**  版本信息模板在安装目录下，可自行修改。
* ObjSample.cs
*
* 功 能： N/A
* 类 名： ObjSample
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
using System.Collections;
using System.Collections.Generic;

namespace yny_005.DAL
{
	/// <summary>
	/// 数据访问类:ObjSample
	/// </summary>
	public partial class ObjSample
	{
		
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public static int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ObjSample"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public static bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ObjSample");
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
		public static int Add(yny_005.Model.ObjSample model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ObjSample(");
			strSql.Append("ObjID,MID,YangPinCode,YangPinImgUrl,CreateDate,SState,Spare,SpInt,OID,OjbOID)");
			strSql.Append(" values (");
			strSql.Append("@ObjID,@MID,@YangPinCode,@YangPinImgUrl,@CreateDate,@SState,@Spare,@SpInt,@OID,@OjbOID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjID", SqlDbType.Int,4),
					new SqlParameter("@MID", SqlDbType.VarChar,50),
					new SqlParameter("@YangPinCode", SqlDbType.VarChar,50),
					new SqlParameter("@YangPinImgUrl", SqlDbType.VarChar,250),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@SState", SqlDbType.Int,4),
					new SqlParameter("@Spare", SqlDbType.VarChar,250),
					new SqlParameter("@SpInt", SqlDbType.Int,4),
                    new SqlParameter("@OID", SqlDbType.VarChar,50),
                    new SqlParameter("@OjbOID", SqlDbType.VarChar,50)
            };
			parameters[0].Value = model.ObjID;
			parameters[1].Value = model.MID;
			parameters[2].Value = model.YangPinCode;
			parameters[3].Value = model.YangPinImgUrl;
			parameters[4].Value = model.CreateDate;
			parameters[5].Value = model.SState;
			parameters[6].Value = model.Spare;
			parameters[7].Value = model.SpInt;
            parameters[8].Value = model.OID;
            parameters[9].Value = model.OjbOID;

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
		public static Hashtable Add(yny_005.Model.ObjSample model, Hashtable MyHs)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ObjSample(");
            strSql.Append("ObjID,MID,YangPinCode,YangPinImgUrl,CreateDate,SState,Spare,SpInt,OID,OjbOID)");
            strSql.Append(" values (");
            strSql.Append("@ObjID,@MID,@YangPinCode,@YangPinImgUrl,@CreateDate,@SState,@Spare,@SpInt,@OID,@OjbOID)");
            SqlParameter[] parameters = {
                    new SqlParameter("@ObjID", SqlDbType.Int,4),
                    new SqlParameter("@MID", SqlDbType.VarChar,50),
                    new SqlParameter("@YangPinCode", SqlDbType.VarChar,50),
                    new SqlParameter("@YangPinImgUrl", SqlDbType.VarChar,250),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@SState", SqlDbType.Int,4),
                    new SqlParameter("@Spare", SqlDbType.VarChar,250),
                    new SqlParameter("@SpInt", SqlDbType.Int,4),
                    new SqlParameter("@OID", SqlDbType.VarChar,50),
                    new SqlParameter("@OjbOID", SqlDbType.VarChar,50)
            };
            parameters[0].Value = model.ObjID;
            parameters[1].Value = model.MID;
            parameters[2].Value = model.YangPinCode;
            parameters[3].Value = model.YangPinImgUrl;
            parameters[4].Value = model.CreateDate;
            parameters[5].Value = model.SState;
            parameters[6].Value = model.Spare;
            parameters[7].Value = model.SpInt;
            parameters[8].Value = model.OID;
            parameters[9].Value = model.OjbOID;
            string guid = Guid.NewGuid().ToString();
            strSql.AppendFormat("; select '{0}'", guid);

            MyHs.Add(strSql.ToString(), parameters);

            return MyHs;
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(yny_005.Model.ObjSample model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ObjSample set ");
			strSql.Append("ObjID=@ObjID,");
			strSql.Append("MID=@MID,");
			strSql.Append("YangPinCode=@YangPinCode,");
			strSql.Append("YangPinImgUrl=@YangPinImgUrl,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("SState=@SState,");
			strSql.Append("Spare=@Spare,");
			strSql.Append("SpInt=@SpInt,");
            strSql.Append("OID=@OID,");
            strSql.Append("OjbOID=@OjbOID");
            strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjID", SqlDbType.Int,4),
					new SqlParameter("@MID", SqlDbType.VarChar,50),
					new SqlParameter("@YangPinCode", SqlDbType.VarChar,50),
					new SqlParameter("@YangPinImgUrl", SqlDbType.VarChar,250),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@SState", SqlDbType.Int,4),
					new SqlParameter("@Spare", SqlDbType.VarChar,250),
					new SqlParameter("@SpInt", SqlDbType.Int,4),
                    new SqlParameter("@OID", SqlDbType.VarChar,50),
                    new SqlParameter("@OjbOID", SqlDbType.VarChar,50),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ObjID;
			parameters[1].Value = model.MID;
			parameters[2].Value = model.YangPinCode;
			parameters[3].Value = model.YangPinImgUrl;
			parameters[4].Value = model.CreateDate;
			parameters[5].Value = model.SState;
			parameters[6].Value = model.Spare;
			parameters[7].Value = model.SpInt;
            parameters[8].Value = model.OID;
            parameters[9].Value = model.OjbOID;
            parameters[10].Value = model.ID;

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
        /// 更新一条数据
        /// </summary>
        public static Hashtable Update(yny_005.Model.ObjSample model, Hashtable MyHs)
        {
            string guid = Guid.NewGuid().ToString();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ObjSample set ");
            strSql.Append("ObjID=@ObjID,");
            strSql.Append("MID=@MID,");
            strSql.Append("YangPinCode=@YangPinCode,");
            strSql.Append("YangPinImgUrl=@YangPinImgUrl,");
            strSql.Append("CreateDate=@CreateDate,");
            strSql.Append("SState=@SState,");
            strSql.Append("Spare=@Spare,");
            strSql.Append("SpInt=@SpInt,");
            strSql.Append("OID=@OID,");
            strSql.Append("OjbOID=@OjbOID");
            strSql.Append(" where ID=@ID");
            strSql.AppendFormat(" ;select '{0}'", guid);
            SqlParameter[] parameters = {
                    new SqlParameter("@ObjID", SqlDbType.Int,4),
                    new SqlParameter("@MID", SqlDbType.VarChar,50),
                    new SqlParameter("@YangPinCode", SqlDbType.VarChar,50),
                    new SqlParameter("@YangPinImgUrl", SqlDbType.VarChar,250),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@SState", SqlDbType.Int,4),
                    new SqlParameter("@Spare", SqlDbType.VarChar,250),
                    new SqlParameter("@SpInt", SqlDbType.Int,4),
                    new SqlParameter("@OID", SqlDbType.VarChar,50),
                    new SqlParameter("@OjbOID", SqlDbType.VarChar,50),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.ObjID;
            parameters[1].Value = model.MID;
            parameters[2].Value = model.YangPinCode;
            parameters[3].Value = model.YangPinImgUrl;
            parameters[4].Value = model.CreateDate;
            parameters[5].Value = model.SState;
            parameters[6].Value = model.Spare;
            parameters[7].Value = model.SpInt;
            parameters[8].Value = model.OID;
            parameters[9].Value = model.OjbOID;
            parameters[10].Value = model.ID;

            MyHs.Add(strSql.ToString(), parameters);
            return MyHs;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ObjSample ");
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
			strSql.Append("delete from ObjSample ");
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
		public static yny_005.Model.ObjSample GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ObjID,MID,YangPinCode,YangPinImgUrl,CreateDate,SState,Spare,SpInt,OID,OjbOID from ObjSample ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			yny_005.Model.ObjSample model=new yny_005.Model.ObjSample();
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
		public static yny_005.Model.ObjSample GetModelOID(string OID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,ObjID,MID,YangPinCode,YangPinImgUrl,CreateDate,SState,Spare,SpInt,OID,OjbOID from ObjSample ");
            strSql.Append(" where OID=@OID");
            SqlParameter[] parameters = {
                    new SqlParameter("@OID", SqlDbType.VarChar,50)
            };
            parameters[0].Value = OID;

            yny_005.Model.ObjSample model = new yny_005.Model.ObjSample();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataTable GetTable(string strWhere, int pageIndex, int pageSize, out int count)
        {
            return DAL.CommonBase.GetTable("ObjSample", "ID", "ID desc", strWhere, pageIndex, pageSize, out count);
        }
        public static List<Model.ObjSample> GetList(string strWhere, int pageIndex, int pageSize, out int count)
        {
            List<Model.ObjSample> list = new List<Model.ObjSample>();

            DataTable table = GetTable(strWhere, pageIndex, pageSize, out count);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                list.Add(DataRowToModel(table.Rows[i]));
            }

            return list;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public static yny_005.Model.ObjSample DataRowToModel(DataRow row)
		{
			yny_005.Model.ObjSample model=new yny_005.Model.ObjSample();
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
				if(row["MID"]!=null)
				{
					model.MID=row["MID"].ToString();
				}

                if (row["OID"] != null)
                {
                    model.OID = row["OID"].ToString();
                }
                if (row["OjbOID"] != null)
                {
                    model.OjbOID = row["OjbOID"].ToString();
                }

                if (row["YangPinCode"]!=null)
				{
					model.YangPinCode=row["YangPinCode"].ToString();
				}
				if(row["YangPinImgUrl"]!=null)
				{
					model.YangPinImgUrl=row["YangPinImgUrl"].ToString();
				}
				if(row["CreateDate"]!=null && row["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(row["CreateDate"].ToString());
				}
				if(row["SState"]!=null && row["SState"].ToString()!="")
				{
					model.SState=int.Parse(row["SState"].ToString());
				}
				if(row["Spare"]!=null)
				{
					model.Spare=row["Spare"].ToString();
				}
				if(row["SpInt"]!=null && row["SpInt"].ToString()!="")
				{
					model.SpInt=int.Parse(row["SpInt"].ToString());
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
			strSql.Append("select ID,ObjID,MID,YangPinCode,YangPinImgUrl,CreateDate,SState,Spare,SpInt,OID,OjbOID ");
			strSql.Append(" FROM ObjSample ");
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
			strSql.Append(" ID,ObjID,MID,YangPinCode,YangPinImgUrl,CreateDate,SState,Spare,SpInt,OID,OjbOID ");
			strSql.Append(" FROM ObjSample ");
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
			strSql.Append("select count(1) FROM ObjSample ");
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
			strSql.Append(")AS Row, T.*  from ObjSample T ");
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
			parameters[0].Value = "ObjSample";
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

