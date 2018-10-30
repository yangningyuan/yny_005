/**  版本信息模板在安装目录下，可自行修改。
* Object.cs
*
* 功 能： N/A
* 类 名： Object
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
namespace yny_005.Model
{
	/// <summary>
	/// Object:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OObject
	{
		public OObject()
		{}
		#region Model
		private int _id;
		private string _objoid;
		private string _objname;
		private string _reobjmid;
		private string _reobjniname;
		private string _objchild;
		private string _objexcel;
		private DateTime _bmdate;
		private DateTime _jgdate;
		private string _remark;
        public DateTime CreateDate { get; set; }
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 项目编号
		/// </summary>
		public string ObjOID
		{
			set{ _objoid=value;}
			get{return _objoid;}
		}
		/// <summary>
		/// 项目名称
		/// </summary>
		public string ObjName
		{
			set{ _objname=value;}
			get{return _objname;}
		}
		/// <summary>
		/// 发布项目人
		/// </summary>
		public string ReObjMID
		{
			set{ _reobjmid=value;}
			get{return _reobjmid;}
		}
		/// <summary>
		/// 发布项目名称
		/// </summary>
		public string ReObjNiName
		{
			set{ _reobjniname=value;}
			get{return _reobjniname;}
		}
		/// <summary>
		/// 项目子项
		/// </summary>
		public string ObjChild
		{
			set{ _objchild=value;}
			get{return _objchild;}
		}
		/// <summary>
		/// 项目文档
		/// </summary>
		public string ObjExcel
		{
			set{ _objexcel=value;}
			get{return _objexcel;}
		}
		/// <summary>
		/// 报名截止时间
		/// </summary>
		public DateTime BMDate
		{
			set{ _bmdate=value;}
			get{return _bmdate;}
		}
		/// <summary>
		/// 结果截止时间
		/// </summary>
		public DateTime JGDate
		{
			set{ _jgdate=value;}
			get{return _jgdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}

        
		#endregion Model

	}
}

