/**  版本信息模板在安装目录下，可自行修改。
* ObjUser.cs
*
* 功 能： N/A
* 类 名： ObjUser
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/10/29 21:42:44   N/A    初版
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
	/// 数据访问类:ObjUser
	/// </summary>
	public partial class ObjUser
	{
		
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public static int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ObjUser"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public static bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ObjUser");
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
		public static int Add(yny_005.Model.ObjUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ObjUser(");
			strSql.Append("ObjID,ObjName,MID,ZhengShuCode,YangPinID,BaoMingID,USState,CreateDate,DanWeiName,ShiYanCode,RState,BState,YState,RUpLoadDate,RImgUrl,Spare,Spare2,SPInt,SPInt2)");
			strSql.Append(" values (");
			strSql.Append("@ObjID,@ObjName,@MID,@ZhengShuCode,@YangPinID,@BaoMingID,@USState,@CreateDate,@DanWeiName,@ShiYanCode,@RState,@BState,@YState,@RUpLoadDate,@RImgUrl,@Spare,@Spare2,@SPInt,@SPInt2)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjID", SqlDbType.Int,4),
					new SqlParameter("@ObjName", SqlDbType.VarChar,150),
					new SqlParameter("@MID", SqlDbType.VarChar,50),
					new SqlParameter("@ZhengShuCode", SqlDbType.VarChar,50),
					new SqlParameter("@YangPinID", SqlDbType.Int,4),
					new SqlParameter("@BaoMingID", SqlDbType.Int,4),
					new SqlParameter("@USState", SqlDbType.Int,4),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@DanWeiName", SqlDbType.VarChar,50),
					new SqlParameter("@ShiYanCode", SqlDbType.VarChar,50),
					new SqlParameter("@RState", SqlDbType.Int,4),
					new SqlParameter("@BState", SqlDbType.Int,4),
					new SqlParameter("@YState", SqlDbType.Int,4),
					new SqlParameter("@RUpLoadDate", SqlDbType.DateTime),
					new SqlParameter("@RImgUrl", SqlDbType.VarChar,250),
					new SqlParameter("@Spare", SqlDbType.VarChar,250),
					new SqlParameter("@Spare2", SqlDbType.VarChar,250),
					new SqlParameter("@SPInt", SqlDbType.Int,4),
					new SqlParameter("@SPInt2", SqlDbType.Int,4)};
			parameters[0].Value = model.ObjID;
			parameters[1].Value = model.ObjName;
			parameters[2].Value = model.MID;
			parameters[3].Value = model.ZhengShuCode;
			parameters[4].Value = model.YangPinID;
			parameters[5].Value = model.BaoMingID;
			parameters[6].Value = model.USState;
			parameters[7].Value = model.CreateDate;
			parameters[8].Value = model.DanWeiName;
			parameters[9].Value = model.ShiYanCode;
			parameters[10].Value = model.RState;
			parameters[11].Value = model.BState;
			parameters[12].Value = model.YState;
			parameters[13].Value = model.RUpLoadDate;
			parameters[14].Value = model.RImgUrl;
			parameters[15].Value = model.Spare;
			parameters[16].Value = model.Spare2;
			parameters[17].Value = model.SPInt;
			parameters[18].Value = model.SPInt2;

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
		public static bool Update(yny_005.Model.ObjUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ObjUser set ");
			strSql.Append("ObjID=@ObjID,");
			strSql.Append("ObjName=@ObjName,");
			strSql.Append("MID=@MID,");
			strSql.Append("ZhengShuCode=@ZhengShuCode,");
			strSql.Append("YangPinID=@YangPinID,");
			strSql.Append("BaoMingID=@BaoMingID,");
			strSql.Append("USState=@USState,");
			strSql.Append("CreateDate=@CreateDate,");
			strSql.Append("DanWeiName=@DanWeiName,");
			strSql.Append("ShiYanCode=@ShiYanCode,");
			strSql.Append("RState=@RState,");
			strSql.Append("BState=@BState,");
			strSql.Append("YState=@YState,");
			strSql.Append("RUpLoadDate=@RUpLoadDate,");
			strSql.Append("RImgUrl=@RImgUrl,");
			strSql.Append("Spare=@Spare,");
			strSql.Append("Spare2=@Spare2,");
			strSql.Append("SPInt=@SPInt,");
			strSql.Append("SPInt2=@SPInt2");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ObjID", SqlDbType.Int,4),
					new SqlParameter("@ObjName", SqlDbType.VarChar,150),
					new SqlParameter("@MID", SqlDbType.VarChar,50),
					new SqlParameter("@ZhengShuCode", SqlDbType.VarChar,50),
					new SqlParameter("@YangPinID", SqlDbType.Int,4),
					new SqlParameter("@BaoMingID", SqlDbType.Int,4),
					new SqlParameter("@USState", SqlDbType.Int,4),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@DanWeiName", SqlDbType.VarChar,50),
					new SqlParameter("@ShiYanCode", SqlDbType.VarChar,50),
					new SqlParameter("@RState", SqlDbType.Int,4),
					new SqlParameter("@BState", SqlDbType.Int,4),
					new SqlParameter("@YState", SqlDbType.Int,4),
					new SqlParameter("@RUpLoadDate", SqlDbType.DateTime),
					new SqlParameter("@RImgUrl", SqlDbType.VarChar,250),
					new SqlParameter("@Spare", SqlDbType.VarChar,250),
					new SqlParameter("@Spare2", SqlDbType.VarChar,250),
					new SqlParameter("@SPInt", SqlDbType.Int,4),
					new SqlParameter("@SPInt2", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ObjID;
			parameters[1].Value = model.ObjName;
			parameters[2].Value = model.MID;
			parameters[3].Value = model.ZhengShuCode;
			parameters[4].Value = model.YangPinID;
			parameters[5].Value = model.BaoMingID;
			parameters[6].Value = model.USState;
			parameters[7].Value = model.CreateDate;
			parameters[8].Value = model.DanWeiName;
			parameters[9].Value = model.ShiYanCode;
			parameters[10].Value = model.RState;
			parameters[11].Value = model.BState;
			parameters[12].Value = model.YState;
			parameters[13].Value = model.RUpLoadDate;
			parameters[14].Value = model.RImgUrl;
			parameters[15].Value = model.Spare;
			parameters[16].Value = model.Spare2;
			parameters[17].Value = model.SPInt;
			parameters[18].Value = model.SPInt2;
			parameters[19].Value = model.ID;

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
			strSql.Append("delete from ObjUser ");
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
			strSql.Append("delete from ObjUser ");
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
		public static yny_005.Model.ObjUser GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ObjID,ObjName,MID,ZhengShuCode,YangPinID,BaoMingID,USState,CreateDate,DanWeiName,ShiYanCode,RState,BState,YState,RUpLoadDate,RImgUrl,Spare,Spare2,SPInt,SPInt2 from ObjUser ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			yny_005.Model.ObjUser model=new yny_005.Model.ObjUser();
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
		public static yny_005.Model.ObjUser DataRowToModel(DataRow row)
		{
			yny_005.Model.ObjUser model=new yny_005.Model.ObjUser();
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
				if(row["ObjName"]!=null)
				{
					model.ObjName=row["ObjName"].ToString();
				}
				if(row["MID"]!=null)
				{
					model.MID=row["MID"].ToString();
				}
				if(row["ZhengShuCode"]!=null)
				{
					model.ZhengShuCode=row["ZhengShuCode"].ToString();
				}
				if(row["YangPinID"]!=null && row["YangPinID"].ToString()!="")
				{
					model.YangPinID=int.Parse(row["YangPinID"].ToString());
				}
				if(row["BaoMingID"]!=null && row["BaoMingID"].ToString()!="")
				{
					model.BaoMingID=int.Parse(row["BaoMingID"].ToString());
				}
				if(row["USState"]!=null && row["USState"].ToString()!="")
				{
					model.USState=int.Parse(row["USState"].ToString());
				}
				if(row["CreateDate"]!=null && row["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(row["CreateDate"].ToString());
				}
				if(row["DanWeiName"]!=null)
				{
					model.DanWeiName=row["DanWeiName"].ToString();
				}
				if(row["ShiYanCode"]!=null)
				{
					model.ShiYanCode=row["ShiYanCode"].ToString();
				}
				if(row["RState"]!=null && row["RState"].ToString()!="")
				{
					model.RState=int.Parse(row["RState"].ToString());
				}
				if(row["BState"]!=null && row["BState"].ToString()!="")
				{
					model.BState=int.Parse(row["BState"].ToString());
				}
				if(row["YState"]!=null && row["YState"].ToString()!="")
				{
					model.YState=int.Parse(row["YState"].ToString());
				}
				if(row["RUpLoadDate"]!=null && row["RUpLoadDate"].ToString()!="")
				{
					model.RUpLoadDate=DateTime.Parse(row["RUpLoadDate"].ToString());
				}
				if(row["RImgUrl"]!=null)
				{
					model.RImgUrl=row["RImgUrl"].ToString();
				}
				if(row["Spare"]!=null)
				{
					model.Spare=row["Spare"].ToString();
				}
				if(row["Spare2"]!=null)
				{
					model.Spare2=row["Spare2"].ToString();
				}
				if(row["SPInt"]!=null && row["SPInt"].ToString()!="")
				{
					model.SPInt=int.Parse(row["SPInt"].ToString());
				}
				if(row["SPInt2"]!=null && row["SPInt2"].ToString()!="")
				{
					model.SPInt2=int.Parse(row["SPInt2"].ToString());
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
			strSql.Append("select ID,ObjID,ObjName,MID,ZhengShuCode,YangPinID,BaoMingID,USState,CreateDate,DanWeiName,ShiYanCode,RState,BState,YState,RUpLoadDate,RImgUrl,Spare,Spare2,SPInt,SPInt2 ");
			strSql.Append(" FROM ObjUser ");
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
			strSql.Append(" ID,ObjID,ObjName,MID,ZhengShuCode,YangPinID,BaoMingID,USState,CreateDate,DanWeiName,ShiYanCode,RState,BState,YState,RUpLoadDate,RImgUrl,Spare,Spare2,SPInt,SPInt2 ");
			strSql.Append(" FROM ObjUser ");
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
			strSql.Append("select count(1) FROM ObjUser ");
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
			strSql.Append(")AS Row, T.*  from ObjUser T ");
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
			parameters[0].Value = "ObjUser";
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

