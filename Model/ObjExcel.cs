/**  版本信息模板在安装目录下，可自行修改。
* ObjExcel.cs
*
* 功 能： N/A
* 类 名： ObjExcel
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
namespace yny_005.Model
{
	/// <summary>
	/// ObjExcel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ObjExcel
	{
		public ObjExcel()
		{}
		#region Model
		private int _id;
		private int _objid;
		private string _excelname;
		private string _excelurl;
        public string OID { get; set; }

        public string ObjOID { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ObjID
		{
			set{ _objid=value;}
			get{return _objid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExcelName
		{
			set{ _excelname=value;}
			get{return _excelname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExcelUrl
		{
			set{ _excelurl=value;}
			get{return _excelurl;}
		}
		#endregion Model

	}
}

