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
namespace yny_005.Model
{
	/// <summary>
	/// ObjChild:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ObjChild
	{
		public ObjChild()
		{}
		#region Model
		private int _id;
		private int _objid;
		private string _childname;
		private string _childvalue;
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
		/// 子项名称
		/// </summary>
		public string ChildName
		{
			set{ _childname=value;}
			get{return _childname;}
		}
		/// <summary>
		/// 子项值
		/// </summary>
		public string ChildValue
		{
			set{ _childvalue=value;}
			get{return _childvalue;}
		}
		#endregion Model

	}
}

