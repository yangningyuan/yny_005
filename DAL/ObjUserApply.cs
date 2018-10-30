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
using System.Text;
using System.Data.SqlClient;
using DBUtility;//Please add references
using System.Collections;

namespace yny_005.DAL
{
	/// <summary>
	/// 数据访问类:ObjUserApply
	/// </summary>
	public partial class ObjUserApply
	{
		
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public static int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ObjUserApply"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public static bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ObjUserApply");
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
		public static int Add(yny_005.Model.ObjUserApply model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ObjUserApply(");
            strSql.Append("ObjID,MID,BaoMingCode,DanWeiName,ZiGeZhengShu,ZhengShuCode,CreateDate,ComDate,SubID,BaoMingImgUrl,FeiYongImgUrl,SState)");
            strSql.Append(" values (");
            strSql.Append("@ObjID,@MID,@BaoMingCode,@DanWeiName,@ZiGeZhengShu,@ZhengShuCode,@CreateDate,@ComDate,@SubID,@BaoMingImgUrl,@FeiYongImgUrl,@SState)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@ObjID", SqlDbType.Int,4),
                    new SqlParameter("@MID", SqlDbType.VarChar,50),
                    new SqlParameter("@BaoMingCode", SqlDbType.VarChar,50),
                    new SqlParameter("@DanWeiName", SqlDbType.VarChar,50),
                    new SqlParameter("@ZiGeZhengShu", SqlDbType.VarChar,250),
                    new SqlParameter("@ZhengShuCode", SqlDbType.VarChar,250),
                    new SqlParameter("@CreateDate", SqlDbType.DateTime),
                    new SqlParameter("@ComDate", SqlDbType.DateTime),
                    new SqlParameter("@SubID", SqlDbType.VarChar,50),
                    new SqlParameter("@BaoMingImgUrl", SqlDbType.VarChar,250),
                    new SqlParameter("@FeiYongImgUrl", SqlDbType.VarChar,250),
                    new SqlParameter("@SState", SqlDbType.Int,4)};
            parameters[0].Value = model.ObjID;
            parameters[1].Value = model.MID;
            parameters[2].Value = model.BaoMingCode;
            parameters[3].Value = model.DanWeiName;
            parameters[4].Value = model.ZiGeZhengShu;
            parameters[5].Value = model.ZhengShuCode;
            parameters[6].Value = model.CreateDate;
            parameters[7].Value = model.ComDate;
            parameters[8].Value = model.SubID;
            parameters[9].Value = model.BaoMingImgUrl;
            parameters[10].Value = model.FeiYongImgUrl;
            parameters[11].Value = model.SState;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public static Hashtable Add(yny_005.Model.ObjUserApply model, Hashtable MyHs)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ObjUserApply(");
			strSql.Append("ObjID,MID,BaoMingCode,DanWeiName,ZiGeZhengShu,ZhengShuCode,CreateDate,ComDate,SubID,BaoMingImgUrl,FeiYongImgUrl,SState)");
			strSql.Append(" values (");
			strSql.Append("@ObjID,@MID,@BaoMingCode,@DanWeiName,@ZiGeZhengShu,@ZhengShuCode,@CreateDate,@ComDate,@SubID,@BaoMingImgUrl,@FeiYongImgUrl,@SState)");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjID", SqlDbType.Int,4),
					new SqlParameter("@MID", SqlDbType.VarChar,50),
					new SqlParameter("@BaoMingCode", SqlDbType.VarChar,50),
					new SqlParameter("@DanWeiName", SqlDbType.VarChar,50),
					new SqlParameter("@ZiGeZhengShu", SqlDbType.VarChar,250),
					new SqlParameter("@ZhengShuCode", SqlDbType.VarChar,250),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@ComDate", SqlDbType.DateTime),
					new SqlParameter("@SubID", SqlDbType.VarChar,50),
					new SqlParameter("@BaoMingImgUrl", SqlDbType.VarChar,250),
					new SqlParameter("@FeiYongImgUrl", SqlDbType.VarChar,250),
					new SqlParameter("@SState", SqlDbType.Int,4)};
			parameters[0].Value = model.ObjID;
			parameters[1].Value = model.MID;
			parameters[2].Value = model.BaoMingCode;
			parameters[3].Value = model.DanWeiName;
			parameters[4].Value = model.ZiGeZhengShu;
			parameters[5].Value = model.ZhengShuCode;
			parameters[6].Value = model.CreateDate;
			parameters[7].Value = model.ComDate;
			parameters[8].Value = model.SubID;
			parameters[9].Value = model.BaoMingImgUrl;
			parameters[10].Value = model.FeiYongImgUrl;
			parameters[11].Value = model.SState;

            string guid = Guid.NewGuid().ToString();
            strSql.AppendFormat("; select '{0}'", guid);

            MyHs.Add(strSql.ToString(), parameters);

            return MyHs;
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public static bool Update(yny_005.Model.ObjUserApply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ObjUserApply set ");
			strSql.Append("ObjID=@ObjID,");
			strSql.Append("MID=@MID,");
			strSql.Append("BaoMingCode=@BaoMingCode,");
			strSql.Append("DanWeiName=@DanWeiName,");
			strSql.Append("ZiGeZhengShu=@ZiGeZhengShu,");
			strSql.Append("ZhengShuCode=@ZhengShuCode,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("ComDate=@ComDate,");
			strSql.Append("SubID=@SubID,");
			strSql.Append("BaoMingImgUrl=@BaoMingImgUrl,");
			strSql.Append("FeiYongImgUrl=@FeiYongImgUrl,");
			strSql.Append("SState=@SState");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjID", SqlDbType.Int,4),
					new SqlParameter("@MID", SqlDbType.VarChar,50),
					new SqlParameter("@BaoMingCode", SqlDbType.VarChar,50),
					new SqlParameter("@DanWeiName", SqlDbType.VarChar,50),
					new SqlParameter("@ZiGeZhengShu", SqlDbType.VarChar,250),
					new SqlParameter("@ZhengShuCode", SqlDbType.VarChar,250),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@ComDate", SqlDbType.DateTime),
					new SqlParameter("@SubID", SqlDbType.VarChar,50),
					new SqlParameter("@BaoMingImgUrl", SqlDbType.VarChar,250),
					new SqlParameter("@FeiYongImgUrl", SqlDbType.VarChar,250),
					new SqlParameter("@SState", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ObjID;
			parameters[1].Value = model.MID;
			parameters[2].Value = model.BaoMingCode;
			parameters[3].Value = model.DanWeiName;
			parameters[4].Value = model.ZiGeZhengShu;
			parameters[5].Value = model.ZhengShuCode;
			parameters[6].Value = model.CreateDate;
			parameters[7].Value = model.ComDate;
			parameters[8].Value = model.SubID;
			parameters[9].Value = model.BaoMingImgUrl;
			parameters[10].Value = model.FeiYongImgUrl;
			parameters[11].Value = model.SState;
			parameters[12].Value = model.ID;

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
			strSql.Append("delete from ObjUserApply ");
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
			strSql.Append("delete from ObjUserApply ");
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
		public static yny_005.Model.ObjUserApply GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ObjID,MID,BaoMingCode,DanWeiName,ZiGeZhengShu,ZhengShuCode,CreateDate,ComDate,SubID,BaoMingImgUrl,FeiYongImgUrl,SState from ObjUserApply ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			yny_005.Model.ObjUserApply model=new yny_005.Model.ObjUserApply();
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
		public static yny_005.Model.ObjUserApply DataRowToModel(DataRow row)
		{
			yny_005.Model.ObjUserApply model=new yny_005.Model.ObjUserApply();
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
				if(row["BaoMingCode"]!=null)
				{
					model.BaoMingCode=row["BaoMingCode"].ToString();
				}
				if(row["DanWeiName"]!=null)
				{
					model.DanWeiName=row["DanWeiName"].ToString();
				}
				if(row["ZiGeZhengShu"]!=null)
				{
					model.ZiGeZhengShu=row["ZiGeZhengShu"].ToString();
				}
				if(row["ZhengShuCode"]!=null)
				{
					model.ZhengShuCode=row["ZhengShuCode"].ToString();
				}
				if(row["CreateDate"]!=null && row["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(row["CreateDate"].ToString());
				}
				if(row["ComDate"]!=null && row["ComDate"].ToString()!="")
				{
					model.ComDate=DateTime.Parse(row["ComDate"].ToString());
				}
				if(row["SubID"]!=null)
				{
					model.SubID=row["SubID"].ToString();
				}
				if(row["BaoMingImgUrl"]!=null)
				{
					model.BaoMingImgUrl=row["BaoMingImgUrl"].ToString();
				}
				if(row["FeiYongImgUrl"]!=null)
				{
					model.FeiYongImgUrl=row["FeiYongImgUrl"].ToString();
				}
				if(row["SState"]!=null && row["SState"].ToString()!="")
				{
					model.SState=int.Parse(row["SState"].ToString());
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
			strSql.Append("select ID,ObjID,MID,BaoMingCode,DanWeiName,ZiGeZhengShu,ZhengShuCode,CreateDate,ComDate,SubID,BaoMingImgUrl,FeiYongImgUrl,SState ");
			strSql.Append(" FROM ObjUserApply ");
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
			strSql.Append(" ID,ObjID,MID,BaoMingCode,DanWeiName,ZiGeZhengShu,ZhengShuCode,CreateDate,ComDate,SubID,BaoMingImgUrl,FeiYongImgUrl,SState ");
			strSql.Append(" FROM ObjUserApply ");
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
			strSql.Append("select count(1) FROM ObjUserApply ");
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
			strSql.Append(")AS Row, T.*  from ObjUserApply T ");
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
			parameters[0].Value = "ObjUserApply";
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

