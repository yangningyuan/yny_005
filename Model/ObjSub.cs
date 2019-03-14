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
namespace yny_005.Model
{
	/// <summary>
	/// ObjSub:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ObjSub
	{
		public ObjSub()
		{}
		#region Model
		private int _id;
		private string _oid;
		private int _urid=0;
		private string _mid;
		private int _objid;
		private int _cid;
		private string _resultone;
		private string _resulttwo;
		private string _resultavg;
		private string _spare;
		private int _spint=0;
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
		public string OID
		{
			set{ _oid=value;}
			get{return _oid;}
		}
		/// <summary>
		/// 用户项目表ID
		/// </summary>
		public int URID
		{
			set{ _urid=value;}
			get{return _urid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MID
		{
			set{ _mid=value;}
			get{return _mid;}
		}
		/// <summary>
		///  项目ID
		/// </summary>
		public int ObjID
		{
			set{ _objid=value;}
			get{return _objid;}
		}
		/// <summary>
		/// 子项ID
		/// </summary>
		public int CID
		{
			set{ _cid=value;}
			get{return _cid;}
		}
		/// <summary>
		/// 结果1
		/// </summary>
		public string ResultOne
		{
			set{ _resultone=value;}
			get{return _resultone;}
		}
		/// <summary>
		/// 结果2
		/// </summary>
		public string ResultTwo
		{
			set{ _resulttwo=value;}
			get{return _resulttwo;}
		}
		/// <summary>
		/// 平均值
		/// </summary>
		public string ResultAvg
		{
			set{ _resultavg=value;}
			get{return _resultavg;}
		}
		/// <summary>
		///  验证子项名称
		/// </summary>
		public string Spare
		{
			set{ _spare=value;}
			get{return _spare;}
		}
		/// <summary>
		///  报名ID
		/// </summary>
		public int SpInt
		{
			set{ _spint=value;}
			get{return _spint;}
		}
        /// <summary>
        /// 审核状态0：未审核  1：审核合格2：不合格
        /// </summary>
        public int SHInt { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public string Serial { get; set; }
        /// <summary>
        /// 分组号
        /// </summary>
        public string Grouping { get; set; }
        /// <summary>
        /// ZB值
        /// </summary>
        public string ZB { get; set; }

        public string Q1 { get; set; }

        public string Q2 { get; set; }
        public string IRQ { get; set; }

        public string M { get; set; }

        public string NIRQ { get; set; }

        public string ResultStatus { get; set; }
        /// <summary>
        /// 项目OID
        /// </summary>
        public string ObjOID { get; set; }
        #endregion Model

    }
}

