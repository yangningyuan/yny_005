/**  版本信息模板在安装目录下，可自行修改。
* ObjSub.cs
*
* 功 能： N/A
* 类 名： ObjSub
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/11/4 19:33:05   N/A    初版
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
	/// 数据访问类:ObjSub
	/// </summary>
	public  partial class ObjSub
	{
		
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public static int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ObjSub"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public static bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ObjSub");
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
		public static int Add(yny_005.Model.ObjSub model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ObjSub(");
			strSql.Append("OID,URID,MID,ObjID,CID,ResultOne,ResultTwo,ResultAvg,Spare,SpInt,SHInt,Serial,Grouping,ZB,Q1,Q2,IRQ,M,NIRQ,ResultStatus,ObjOID)");
			strSql.Append(" values (");
			strSql.Append("@OID,@URID,@MID,@ObjID,@CID,@ResultOne,@ResultTwo,@ResultAvg,@Spare,@SpInt,@SHInt,@Serial,@Grouping,@ZB,@Q1,@Q2,@IRQ,@M,@NIRQ,@ResultStatus,@ObjOID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.VarChar,50),
					new SqlParameter("@URID", SqlDbType.Int,4),
					new SqlParameter("@MID", SqlDbType.VarChar,50),
					new SqlParameter("@ObjID", SqlDbType.Int,4),
					new SqlParameter("@CID", SqlDbType.Int,4),
					new SqlParameter("@ResultOne", SqlDbType.VarChar,50),
					new SqlParameter("@ResultTwo", SqlDbType.VarChar,50),
					new SqlParameter("@ResultAvg", SqlDbType.VarChar,50),
					new SqlParameter("@Spare", SqlDbType.VarChar,250),
					new SqlParameter("@SpInt", SqlDbType.Int,4),new SqlParameter("@SHInt", SqlDbType.Int,4),
                    new SqlParameter("@Serial", SqlDbType.VarChar,10),
                    new SqlParameter("@Grouping", SqlDbType.VarChar,10),
                    new SqlParameter("@ZB", SqlDbType.VarChar,10),
                    new SqlParameter("@Q1", SqlDbType.VarChar,10),
                    new SqlParameter("@Q2", SqlDbType.VarChar,10),
                    new SqlParameter("@IRQ", SqlDbType.VarChar,10),
                    new SqlParameter("@M", SqlDbType.VarChar,10),
                    new SqlParameter("@NIRQ", SqlDbType.VarChar,10),
                    new SqlParameter("@ResultStatus", SqlDbType.VarChar,10),
                    new SqlParameter("@ObjOID", SqlDbType.VarChar,50),
            };
			parameters[0].Value = model.OID;
			parameters[1].Value = model.URID;
			parameters[2].Value = model.MID;
			parameters[3].Value = model.ObjID;
			parameters[4].Value = model.CID;
			parameters[5].Value = model.ResultOne;
			parameters[6].Value = model.ResultTwo;
			parameters[7].Value = model.ResultAvg;
			parameters[8].Value = model.Spare;
			parameters[9].Value = model.SpInt;
            parameters[10].Value = model.SHInt;

            parameters[11].Value = model.Serial;
            parameters[12].Value = model.Grouping;
            parameters[13].Value = model.ZB;
            parameters[14].Value = model.Q1;
            parameters[15].Value = model.Q2;
            parameters[16].Value = model.IRQ;
            parameters[17].Value = model.M;
            parameters[18].Value = model.NIRQ;
            parameters[19].Value = model.ResultStatus;
            parameters[20].Value = model.ObjOID;

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
		public static Hashtable Add(yny_005.Model.ObjSub model, Hashtable MyHs)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ObjSub(");
            strSql.Append("OID,URID,MID,ObjID,CID,ResultOne,ResultTwo,ResultAvg,Spare,SpInt,SHInt,Serial,Grouping,ZB,Q1,Q2,IRQ,M,NIRQ,ResultStatus,ObjOID)");
            strSql.Append(" values (");
            strSql.Append("@OID,@URID,@MID,@ObjID,@CID,@ResultOne,@ResultTwo,@ResultAvg,@Spare,@SpInt,@SHInt,@Serial,@Grouping,@ZB,@Q1,@Q2,@IRQ,@M,@NIRQ,@ResultStatus,@ObjOID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@OID", SqlDbType.VarChar,50),
                    new SqlParameter("@URID", SqlDbType.Int,4),
                    new SqlParameter("@MID", SqlDbType.VarChar,50),
                    new SqlParameter("@ObjID", SqlDbType.Int,4),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@ResultOne", SqlDbType.VarChar,50),
                    new SqlParameter("@ResultTwo", SqlDbType.VarChar,50),
                    new SqlParameter("@ResultAvg", SqlDbType.VarChar,50),
                    new SqlParameter("@Spare", SqlDbType.VarChar,250),
                    new SqlParameter("@SpInt", SqlDbType.Int,4),new SqlParameter("@SHInt", SqlDbType.Int,4),
                      new SqlParameter("@Serial", SqlDbType.VarChar,10),
                    new SqlParameter("@Grouping", SqlDbType.VarChar,10),
                    new SqlParameter("@ZB", SqlDbType.VarChar,10),
                    new SqlParameter("@Q1", SqlDbType.VarChar,10),
                    new SqlParameter("@Q2", SqlDbType.VarChar,10),
                    new SqlParameter("@IRQ", SqlDbType.VarChar,10),
                    new SqlParameter("@M", SqlDbType.VarChar,10),
                    new SqlParameter("@NIRQ", SqlDbType.VarChar,10),
                    new SqlParameter("@ResultStatus", SqlDbType.VarChar,10),
                    new SqlParameter("@ObjOID", SqlDbType.VarChar,50),
            };
            parameters[0].Value = model.OID;
            parameters[1].Value = model.URID;
            parameters[2].Value = model.MID;
            parameters[3].Value = model.ObjID;
            parameters[4].Value = model.CID;
            parameters[5].Value = model.ResultOne;
            parameters[6].Value = model.ResultTwo;
            parameters[7].Value = model.ResultAvg;
            parameters[8].Value = model.Spare;
            parameters[9].Value = model.SpInt;
            parameters[10].Value = model.SHInt;

            parameters[11].Value = model.Serial;
            parameters[12].Value = model.Grouping;
            parameters[13].Value = model.ZB;
            parameters[14].Value = model.Q1;
            parameters[15].Value = model.Q2;
            parameters[16].Value = model.IRQ;
            parameters[17].Value = model.M;
            parameters[18].Value = model.NIRQ;
            parameters[19].Value = model.ResultStatus;
            parameters[20].Value = model.ObjOID;

            string guid = Guid.NewGuid().ToString();
            strSql.AppendFormat("; select '{0}'", guid);

            MyHs.Add(strSql.ToString(), parameters);

            return MyHs;
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(yny_005.Model.ObjSub model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ObjSub set ");
			strSql.Append("OID=@OID,");
			strSql.Append("URID=@URID,");
			strSql.Append("MID=@MID,");
			strSql.Append("ObjID=@ObjID,");
			strSql.Append("CID=@CID,");
			strSql.Append("ResultOne=@ResultOne,");
			strSql.Append("ResultTwo=@ResultTwo,");
			strSql.Append("ResultAvg=@ResultAvg,");
			strSql.Append("Spare=@Spare,");
			strSql.Append("SpInt=@SpInt,");
            strSql.Append("SHInt=@SHInt,");

            strSql.Append("Serial=@Serial,");
            strSql.Append("Grouping=@Grouping,");
            strSql.Append("ZB=@ZB,");
            strSql.Append("Q1=@Q1,");
            strSql.Append("Q2=@Q2,");
            strSql.Append("IRQ=@IRQ,");
            strSql.Append("M=@M,");
            strSql.Append("NIRQ=@NIRQ,");
            strSql.Append("ResultStatus=@ResultStatus, ");
            strSql.Append("ObjOID=@ObjOID ");

            strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@OID", SqlDbType.VarChar,50),
					new SqlParameter("@URID", SqlDbType.Int,4),
					new SqlParameter("@MID", SqlDbType.VarChar,50),
					new SqlParameter("@ObjID", SqlDbType.Int,4),
					new SqlParameter("@CID", SqlDbType.Int,4),
					new SqlParameter("@ResultOne", SqlDbType.VarChar,50),
					new SqlParameter("@ResultTwo", SqlDbType.VarChar,50),
					new SqlParameter("@ResultAvg", SqlDbType.VarChar,50),
					new SqlParameter("@Spare", SqlDbType.VarChar,250),
					new SqlParameter("@SpInt", SqlDbType.Int,4),
                    new SqlParameter("@SHInt", SqlDbType.Int,4),

                     new SqlParameter("@Serial", SqlDbType.VarChar,10),
                    new SqlParameter("@Grouping", SqlDbType.VarChar,10),
                    new SqlParameter("@ZB", SqlDbType.VarChar,10),
                    new SqlParameter("@Q1", SqlDbType.VarChar,10),
                    new SqlParameter("@Q2", SqlDbType.VarChar,10),
                    new SqlParameter("@IRQ", SqlDbType.VarChar,10),
                    new SqlParameter("@M", SqlDbType.VarChar,10),
                    new SqlParameter("@NIRQ", SqlDbType.VarChar,10),
                    new SqlParameter("@ResultStatus", SqlDbType.VarChar,10),
                    new SqlParameter("@ObjOID", SqlDbType.VarChar,50),

                    new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.OID;
			parameters[1].Value = model.URID;
			parameters[2].Value = model.MID;
			parameters[3].Value = model.ObjID;
			parameters[4].Value = model.CID;
			parameters[5].Value = model.ResultOne;
			parameters[6].Value = model.ResultTwo;
			parameters[7].Value = model.ResultAvg;
			parameters[8].Value = model.Spare;
			parameters[9].Value = model.SpInt;
            parameters[10].Value = model.SHInt;

            parameters[11].Value = model.Serial;
            parameters[12].Value = model.Grouping;
            parameters[13].Value = model.ZB;
            parameters[14].Value = model.Q1;
            parameters[15].Value = model.Q2;
            parameters[16].Value = model.IRQ;
            parameters[17].Value = model.M;
            parameters[18].Value = model.NIRQ;
            parameters[19].Value = model.ResultStatus;
            parameters[20].Value = model.ObjOID;
            parameters[21].Value = model.ID;

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
        public static Hashtable Update(yny_005.Model.ObjSub model, Hashtable MyHs)
        {
            string guid = Guid.NewGuid().ToString();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ObjSub set ");
            strSql.Append("OID=@OID,");
            strSql.Append("URID=@URID,");
            strSql.Append("MID=@MID,");
            strSql.Append("ObjID=@ObjID,");
            strSql.Append("CID=@CID,");
            strSql.Append("ResultOne=@ResultOne,");
            strSql.Append("ResultTwo=@ResultTwo,");
            strSql.Append("ResultAvg=@ResultAvg,");
            strSql.Append("Spare=@Spare,");
            strSql.Append("SpInt=@SpInt,");
            strSql.Append("SHInt=@SHInt,");

            strSql.Append("Serial=@Serial,");
            strSql.Append("Grouping=@Grouping,");
            strSql.Append("ZB=@ZB,");
            strSql.Append("Q1=@Q1,");
            strSql.Append("Q2=@Q2,");
            strSql.Append("IRQ=@IRQ,");
            strSql.Append("M=@M,");
            strSql.Append("NIRQ=@NIRQ,");
            strSql.Append("ResultStatus=@ResultStatus, ");
            strSql.Append("ObjOID=@ObjOID ");

            strSql.Append(" where ID=@ID");
            strSql.AppendFormat(" ;select '{0}'", guid);
            SqlParameter[] parameters = {
                    new SqlParameter("@OID", SqlDbType.VarChar,50),
                    new SqlParameter("@URID", SqlDbType.Int,4),
                    new SqlParameter("@MID", SqlDbType.VarChar,50),
                    new SqlParameter("@ObjID", SqlDbType.Int,4),
                    new SqlParameter("@CID", SqlDbType.Int,4),
                    new SqlParameter("@ResultOne", SqlDbType.VarChar,50),
                    new SqlParameter("@ResultTwo", SqlDbType.VarChar,50),
                    new SqlParameter("@ResultAvg", SqlDbType.VarChar,50),
                    new SqlParameter("@Spare", SqlDbType.VarChar,250),
                    new SqlParameter("@SpInt", SqlDbType.Int,4),
                    new SqlParameter("@SHInt", SqlDbType.Int,4),
                     new SqlParameter("@Serial", SqlDbType.VarChar,10),
                    new SqlParameter("@Grouping", SqlDbType.VarChar,10),
                    new SqlParameter("@ZB", SqlDbType.VarChar,10),
                    new SqlParameter("@Q1", SqlDbType.VarChar,10),
                    new SqlParameter("@Q2", SqlDbType.VarChar,10),
                    new SqlParameter("@IRQ", SqlDbType.VarChar,10),
                    new SqlParameter("@M", SqlDbType.VarChar,10),
                    new SqlParameter("@NIRQ", SqlDbType.VarChar,10),
                    new SqlParameter("@ResultStatus", SqlDbType.VarChar,10),

                    new SqlParameter("@ObjOID", SqlDbType.VarChar,50),

                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.OID;
            parameters[1].Value = model.URID;
            parameters[2].Value = model.MID;
            parameters[3].Value = model.ObjID;
            parameters[4].Value = model.CID;
            parameters[5].Value = model.ResultOne;
            parameters[6].Value = model.ResultTwo;
            parameters[7].Value = model.ResultAvg;
            parameters[8].Value = model.Spare;
            parameters[9].Value = model.SpInt;
            parameters[10].Value = model.SHInt;
            parameters[11].Value = model.Serial;
            parameters[12].Value = model.Grouping;
            parameters[13].Value = model.ZB;
            parameters[14].Value = model.Q1;
            parameters[15].Value = model.Q2;
            parameters[16].Value = model.IRQ;
            parameters[17].Value = model.M;
            parameters[18].Value = model.NIRQ;
            parameters[19].Value = model.ResultStatus;
            parameters[20].Value = model.ObjOID;

            parameters[21].Value = model.ID;

            MyHs.Add(strSql.ToString(), parameters);
            return MyHs;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ObjSub ");
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
			strSql.Append("delete from ObjSub ");
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
		public static yny_005.Model.ObjSub GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,OID,URID,MID,ObjID,CID,ResultOne,ResultTwo,ResultAvg,Spare,SpInt,SHInt,Serial,Grouping,ZB,Q1,Q2,IRQ,M,NIRQ,ResultStatus,ObjOID from ObjSub ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			yny_005.Model.ObjSub model=new yny_005.Model.ObjSub();
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
        /// 获得数据列表
        /// </summary>
        public static DataTable GetTable(string strWhere, int pageIndex, int pageSize, out int count)
        {
            return DAL.CommonBase.GetTable("ObjSub", "ID", "ID desc", strWhere, pageIndex, pageSize, out count);
        }
        public static List<Model.ObjSub> GetList(string strWhere, int pageIndex, int pageSize, out int count)
        {
            List<Model.ObjSub> list = new List<Model.ObjSub>();

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
        public static yny_005.Model.ObjSub DataRowToModel(DataRow row)
		{
			yny_005.Model.ObjSub model=new yny_005.Model.ObjSub();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["OID"]!=null)
				{
					model.OID=row["OID"].ToString();
				}
				if(row["URID"]!=null && row["URID"].ToString()!="")
				{
					model.URID=int.Parse(row["URID"].ToString());
				}
				if(row["MID"]!=null)
				{
					model.MID=row["MID"].ToString();
				}
				if(row["ObjID"]!=null && row["ObjID"].ToString()!="")
				{
					model.ObjID=int.Parse(row["ObjID"].ToString());
				}
				if(row["CID"]!=null && row["CID"].ToString()!="")
				{
					model.CID=int.Parse(row["CID"].ToString());
				}
				if(row["ResultOne"]!=null)
				{
					model.ResultOne=row["ResultOne"].ToString();
				}
				if(row["ResultTwo"]!=null)
				{
					model.ResultTwo=row["ResultTwo"].ToString();
				}
				if(row["ResultAvg"]!=null)
				{
					model.ResultAvg=row["ResultAvg"].ToString();
				}
				if(row["Spare"]!=null)
				{
					model.Spare=row["Spare"].ToString();
				}
				if(row["SpInt"]!=null && row["SpInt"].ToString()!="")
				{
					model.SpInt=int.Parse(row["SpInt"].ToString());
				}
                if (row["SHInt"] != null && row["SHInt"].ToString() != "")
                {
                    model.SHInt = int.Parse(row["SHInt"].ToString());
                }

                if (row["Serial"] != null)
                {
                    model.Serial = row["Serial"].ToString();
                }
                if (row["Grouping"] != null)
                {
                    model.Grouping = row["Grouping"].ToString();
                }
                if (row["ZB"] != null)
                {
                    model.ZB = row["ZB"].ToString();
                }
                if (row["Q1"] != null)
                {
                    model.Q1 = row["Q1"].ToString();
                }
                if (row["Q2"] != null)
                {
                    model.Q2 = row["Q2"].ToString();
                }
                if (row["IRQ"] != null)
                {
                    model.IRQ = row["IRQ"].ToString();
                }
                if (row["M"] != null)
                {
                    model.M = row["M"].ToString();
                }
                if (row["NIRQ"] != null)
                {
                    model.NIRQ = row["NIRQ"].ToString();
                }
                if (row["ResultStatus"] != null)
                {
                    model.ResultStatus = row["ResultStatus"].ToString();
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
			strSql.Append("select ID,OID,URID,MID,ObjID,CID,ResultOne,ResultTwo,ResultAvg,Spare,SpInt,SHInt,Serial,Grouping,ZB,Q1,Q2,IRQ,M,NIRQ,ResultStatus,ObjOID ");
			strSql.Append(" FROM ObjSub ");
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
			strSql.Append(" ID,OID,URID,MID,ObjID,CID,ResultOne,ResultTwo,ResultAvg,Spare,SpInt,SHInt,Serial,Grouping,ZB,Q1,Q2,IRQ,M,NIRQ,ResultStatus,ObjOID ");
			strSql.Append(" FROM ObjSub ");
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
			strSql.Append("select count(1) FROM ObjSub ");
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
			strSql.Append(")AS Row, T.*  from ObjSub T ");
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
			parameters[0].Value = "ObjSub";
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

