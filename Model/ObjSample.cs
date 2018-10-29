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
namespace yny_005.Model
{
	/// <summary>
	/// ObjSample:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ObjSample
	{
		public ObjSample()
		{}
		#region Model
		private int _id;
		private int _objid;
		private string _mid;
		private string _yangpincode;
		private string _yangpinimgurl;
		private DateTime _createdate= DateTime.Now;
		private int _sstate=0;
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
		public int ObjID
		{
			set{ _objid=value;}
			get{return _objid;}
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
		/// 
		/// </summary>
		public string YangPinCode
		{
			set{ _yangpincode=value;}
			get{return _yangpincode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YangPinImgUrl
		{
			set{ _yangpinimgurl=value;}
			get{return _yangpinimgurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SState
		{
			set{ _sstate=value;}
			get{return _sstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Spare
		{
			set{ _spare=value;}
			get{return _spare;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SpInt
		{
			set{ _spint=value;}
			get{return _spint;}
		}
		#endregion Model

	}
}

