/**  版本信息模板在安装目录下，可自行修改。
* ObjSubUser.cs
*
* 功 能： N/A
* 类 名： ObjSubUser
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
using System.Collections;

namespace yny_005.DAL
{
	/// <summary>
	/// 数据访问类:ObjSubUser
	/// </summary>
	public partial class ObjSubUser
	{
		
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public static int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ObjSubUser"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public static bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ObjSubUser");
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
		public static int Add(yny_005.Model.ObjSubUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ObjSubUser(");
			strSql.Append("SubID,MID,ResultOne,ResultTwo,ResultAvg,RFangFa,RSheBei,RYiChang,RPerson,RYangPinID,ResultImgUrl,SState,Spare,SpInt)");
			strSql.Append(" values (");
			strSql.Append("@SubID,@MID,@ResultOne,@ResultTwo,@ResultAvg,@RFangFa,@RSheBei,@RYiChang,@RPerson,@RYangPinID,@ResultImgUrl,@SState,@Spare,@SpInt)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SubID", SqlDbType.Int,4),
					new SqlParameter("@MID", SqlDbType.VarChar,50),
					new SqlParameter("@ResultOne", SqlDbType.VarChar,50),
					new SqlParameter("@ResultTwo", SqlDbType.VarChar,50),
					new SqlParameter("@ResultAvg", SqlDbType.VarChar,50),
					new SqlParameter("@RFangFa", SqlDbType.VarChar,500),
					new SqlParameter("@RSheBei", SqlDbType.VarChar,500),
					new SqlParameter("@RYiChang", SqlDbType.VarChar,500),
					new SqlParameter("@RPerson", SqlDbType.VarChar,50),
					new SqlParameter("@RYangPinID", SqlDbType.Int,4),
					new SqlParameter("@ResultImgUrl", SqlDbType.VarChar,250),
					new SqlParameter("@SState", SqlDbType.Int,4),
					new SqlParameter("@Spare", SqlDbType.VarChar,250),
					new SqlParameter("@SpInt", SqlDbType.Int,4)};
			parameters[0].Value = model.SubID;
			parameters[1].Value = model.MID;
			parameters[2].Value = model.ResultOne;
			parameters[3].Value = model.ResultTwo;
			parameters[4].Value = model.ResultAvg;
			parameters[5].Value = model.RFangFa;
			parameters[6].Value = model.RSheBei;
			parameters[7].Value = model.RYiChang;
			parameters[8].Value = model.RPerson;
			parameters[9].Value = model.RYangPinID;
			parameters[10].Value = model.ResultImgUrl;
			parameters[11].Value = model.SState;
			parameters[12].Value = model.Spare;
			parameters[13].Value = model.SpInt;

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
		public static Hashtable Add(yny_005.Model.ObjSubUser model, Hashtable MyHs)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ObjSubUser(");
            strSql.Append("SubID,MID,ResultOne,ResultTwo,ResultAvg,RFangFa,RSheBei,RYiChang,RPerson,RYangPinID,ResultImgUrl,SState,Spare,SpInt)");
            strSql.Append(" values (");
            strSql.Append("@SubID,@MID,@ResultOne,@ResultTwo,@ResultAvg,@RFangFa,@RSheBei,@RYiChang,@RPerson,@RYangPinID,@ResultImgUrl,@SState,@Spare,@SpInt)");
            SqlParameter[] parameters = {
                    new SqlParameter("@SubID", SqlDbType.Int,4),
                    new SqlParameter("@MID", SqlDbType.VarChar,50),
                    new SqlParameter("@ResultOne", SqlDbType.VarChar,50),
                    new SqlParameter("@ResultTwo", SqlDbType.VarChar,50),
                    new SqlParameter("@ResultAvg", SqlDbType.VarChar,50),
                    new SqlParameter("@RFangFa", SqlDbType.VarChar,500),
                    new SqlParameter("@RSheBei", SqlDbType.VarChar,500),
                    new SqlParameter("@RYiChang", SqlDbType.VarChar,500),
                    new SqlParameter("@RPerson", SqlDbType.VarChar,50),
                    new SqlParameter("@RYangPinID", SqlDbType.Int,4),
                    new SqlParameter("@ResultImgUrl", SqlDbType.VarChar,250),
                    new SqlParameter("@SState", SqlDbType.Int,4),
                    new SqlParameter("@Spare", SqlDbType.VarChar,250),
                    new SqlParameter("@SpInt", SqlDbType.Int,4)};
            parameters[0].Value = model.SubID;
            parameters[1].Value = model.MID;
            parameters[2].Value = model.ResultOne;
            parameters[3].Value = model.ResultTwo;
            parameters[4].Value = model.ResultAvg;
            parameters[5].Value = model.RFangFa;
            parameters[6].Value = model.RSheBei;
            parameters[7].Value = model.RYiChang;
            parameters[8].Value = model.RPerson;
            parameters[9].Value = model.RYangPinID;
            parameters[10].Value = model.ResultImgUrl;
            parameters[11].Value = model.SState;
            parameters[12].Value = model.Spare;
            parameters[13].Value = model.SpInt;

            string guid = Guid.NewGuid().ToString();
            strSql.AppendFormat("; select '{0}'", guid);

            MyHs.Add(strSql.ToString(), parameters);

            return MyHs;
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public static bool Update(yny_005.Model.ObjSubUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ObjSubUser set ");
			strSql.Append("SubID=@SubID,");
			strSql.Append("MID=@MID,");
			strSql.Append("ResultOne=@ResultOne,");
			strSql.Append("ResultTwo=@ResultTwo,");
			strSql.Append("ResultAvg=@ResultAvg,");
			strSql.Append("RFangFa=@RFangFa,");
			strSql.Append("RSheBei=@RSheBei,");
			strSql.Append("RYiChang=@RYiChang,");
			strSql.Append("RPerson=@RPerson,");
			strSql.Append("RYangPinID=@RYangPinID,");
			strSql.Append("ResultImgUrl=@ResultImgUrl,");
			strSql.Append("SState=@SState,");
			strSql.Append("Spare=@Spare,");
			strSql.Append("SpInt=@SpInt");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@SubID", SqlDbType.Int,4),
					new SqlParameter("@MID", SqlDbType.VarChar,50),
					new SqlParameter("@ResultOne", SqlDbType.VarChar,50),
					new SqlParameter("@ResultTwo", SqlDbType.VarChar,50),
					new SqlParameter("@ResultAvg", SqlDbType.VarChar,50),
					new SqlParameter("@RFangFa", SqlDbType.VarChar,500),
					new SqlParameter("@RSheBei", SqlDbType.VarChar,500),
					new SqlParameter("@RYiChang", SqlDbType.VarChar,500),
					new SqlParameter("@RPerson", SqlDbType.VarChar,50),
					new SqlParameter("@RYangPinID", SqlDbType.Int,4),
					new SqlParameter("@ResultImgUrl", SqlDbType.VarChar,250),
					new SqlParameter("@SState", SqlDbType.Int,4),
					new SqlParameter("@Spare", SqlDbType.VarChar,250),
					new SqlParameter("@SpInt", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.SubID;
			parameters[1].Value = model.MID;
			parameters[2].Value = model.ResultOne;
			parameters[3].Value = model.ResultTwo;
			parameters[4].Value = model.ResultAvg;
			parameters[5].Value = model.RFangFa;
			parameters[6].Value = model.RSheBei;
			parameters[7].Value = model.RYiChang;
			parameters[8].Value = model.RPerson;
			parameters[9].Value = model.RYangPinID;
			parameters[10].Value = model.ResultImgUrl;
			parameters[11].Value = model.SState;
			parameters[12].Value = model.Spare;
			parameters[13].Value = model.SpInt;
			parameters[14].Value = model.ID;

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
        public static Hashtable Update(yny_005.Model.ObjSubUser model, Hashtable MyHs)
        {
            string guid = Guid.NewGuid().ToString();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ObjSubUser set ");
            strSql.Append("SubID=@SubID,");
            strSql.Append("MID=@MID,");
            strSql.Append("ResultOne=@ResultOne,");
            strSql.Append("ResultTwo=@ResultTwo,");
            strSql.Append("ResultAvg=@ResultAvg,");
            strSql.Append("RFangFa=@RFangFa,");
            strSql.Append("RSheBei=@RSheBei,");
            strSql.Append("RYiChang=@RYiChang,");
            strSql.Append("RPerson=@RPerson,");
            strSql.Append("RYangPinID=@RYangPinID,");
            strSql.Append("ResultImgUrl=@ResultImgUrl,");
            strSql.Append("SState=@SState,");
            strSql.Append("Spare=@Spare,");
            strSql.Append("SpInt=@SpInt");
            strSql.Append(" where ID=@ID");
            strSql.AppendFormat(" ;select '{0}'", guid);
            SqlParameter[] parameters = {
                    new SqlParameter("@SubID", SqlDbType.Int,4),
                    new SqlParameter("@MID", SqlDbType.VarChar,50),
                    new SqlParameter("@ResultOne", SqlDbType.VarChar,50),
                    new SqlParameter("@ResultTwo", SqlDbType.VarChar,50),
                    new SqlParameter("@ResultAvg", SqlDbType.VarChar,50),
                    new SqlParameter("@RFangFa", SqlDbType.VarChar,500),
                    new SqlParameter("@RSheBei", SqlDbType.VarChar,500),
                    new SqlParameter("@RYiChang", SqlDbType.VarChar,500),
                    new SqlParameter("@RPerson", SqlDbType.VarChar,50),
                    new SqlParameter("@RYangPinID", SqlDbType.Int,4),
                    new SqlParameter("@ResultImgUrl", SqlDbType.VarChar,250),
                    new SqlParameter("@SState", SqlDbType.Int,4),
                    new SqlParameter("@Spare", SqlDbType.VarChar,250),
                    new SqlParameter("@SpInt", SqlDbType.Int,4),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.SubID;
            parameters[1].Value = model.MID;
            parameters[2].Value = model.ResultOne;
            parameters[3].Value = model.ResultTwo;
            parameters[4].Value = model.ResultAvg;
            parameters[5].Value = model.RFangFa;
            parameters[6].Value = model.RSheBei;
            parameters[7].Value = model.RYiChang;
            parameters[8].Value = model.RPerson;
            parameters[9].Value = model.RYangPinID;
            parameters[10].Value = model.ResultImgUrl;
            parameters[11].Value = model.SState;
            parameters[12].Value = model.Spare;
            parameters[13].Value = model.SpInt;
            parameters[14].Value = model.ID;

            MyHs.Add(strSql.ToString(), parameters);
            return MyHs;
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public static bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ObjSubUser ");
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
        /// 删除一条数据
        /// </summary>
        public static Hashtable Delete(int ID, Hashtable MyHs)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ObjSubUser ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int,4)
            };
            parameters[0].Value = ID;
            string guid = Guid.NewGuid().ToString();
            strSql.AppendFormat(" ;select '{0}'", guid);
            MyHs.Add(strSql.ToString(), parameters);
            return MyHs;
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public static bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ObjSubUser ");
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
		public static yny_005.Model.ObjSubUser GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,SubID,MID,ResultOne,ResultTwo,ResultAvg,RFangFa,RSheBei,RYiChang,RPerson,RYangPinID,ResultImgUrl,SState,Spare,SpInt from ObjSubUser ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			yny_005.Model.ObjSubUser model=new yny_005.Model.ObjSubUser();
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
		public static yny_005.Model.ObjSubUser DataRowToModel(DataRow row)
		{
			yny_005.Model.ObjSubUser model=new yny_005.Model.ObjSubUser();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["SubID"]!=null && row["SubID"].ToString()!="")
				{
					model.SubID=int.Parse(row["SubID"].ToString());
				}
				if(row["MID"]!=null)
				{
					model.MID=row["MID"].ToString();
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
				if(row["RFangFa"]!=null)
				{
					model.RFangFa=row["RFangFa"].ToString();
				}
				if(row["RSheBei"]!=null)
				{
					model.RSheBei=row["RSheBei"].ToString();
				}
				if(row["RYiChang"]!=null)
				{
					model.RYiChang=row["RYiChang"].ToString();
				}
				if(row["RPerson"]!=null)
				{
					model.RPerson=row["RPerson"].ToString();
				}
				if(row["RYangPinID"]!=null && row["RYangPinID"].ToString()!="")
				{
					model.RYangPinID=int.Parse(row["RYangPinID"].ToString());
				}
				if(row["ResultImgUrl"]!=null)
				{
					model.ResultImgUrl=row["ResultImgUrl"].ToString();
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
			strSql.Append("select ID,SubID,MID,ResultOne,ResultTwo,ResultAvg,RFangFa,RSheBei,RYiChang,RPerson,RYangPinID,ResultImgUrl,SState,Spare,SpInt ");
			strSql.Append(" FROM ObjSubUser ");
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
			strSql.Append(" ID,SubID,MID,ResultOne,ResultTwo,ResultAvg,RFangFa,RSheBei,RYiChang,RPerson,RYangPinID,ResultImgUrl,SState,Spare,SpInt ");
			strSql.Append(" FROM ObjSubUser ");
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
			strSql.Append("select count(1) FROM ObjSubUser ");
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
			strSql.Append(")AS Row, T.*  from ObjSubUser T ");
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
			parameters[0].Value = "ObjSubUser";
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

