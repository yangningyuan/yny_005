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
namespace yny_005.Model
{
	/// <summary>
	/// ObjUser:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ObjUser
	{
		public ObjUser()
		{}
		#region Model
		private int _id;
		private int _objid;
		private string _objname;
		private string _mid;
		private string _zhengshucode;
		private int _yangpinid;
		private int _baomingid=0;
		private int _usstate=0;
		private DateTime _createdate;
		private string _danweiname;
		private string _shiyancode;
		private int _rstate=0;
		private int _bstate=0;
		private int _ystate=0;
		private DateTime? _ruploaddate;
		private string _rimgurl;
		private string _spare;
		private string _spare2;
		private int _spint=0;
		private int _spint2;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 项目ID
		/// </summary>
		public int ObjID
		{
			set{ _objid=value;}
			get{return _objid;}
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
		/// 用户
		/// </summary>
		public string MID
		{
			set{ _mid=value;}
			get{return _mid;}
		}
		/// <summary>
		/// 证书编号
		/// </summary>
		public string ZhengShuCode
		{
			set{ _zhengshucode=value;}
			get{return _zhengshucode;}
		}
		/// <summary>
		/// 样品ID
		/// </summary>
		public int YangPinID
		{
			set{ _yangpinid=value;}
			get{return _yangpinid;}
		}
		/// <summary>
		/// 报名ID
		/// </summary>
		public int BaoMingID
		{
			set{ _baomingid=value;}
			get{return _baomingid;}
		}
		/// <summary>
		/// 项目状态
		/// </summary>
		public int USState
		{
			set{ _usstate=value;}
			get{return _usstate;}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 单位名称
		/// </summary>
		public string DanWeiName
		{
			set{ _danweiname=value;}
			get{return _danweiname;}
		}
		/// <summary>
		/// 实验室代码
		/// </summary>
		public string ShiYanCode
		{
			set{ _shiyancode=value;}
			get{return _shiyancode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int RState
		{
			set{ _rstate=value;}
			get{return _rstate;}
		}
		/// <summary>
		/// 报名状态
		/// </summary>
		public int BState
		{
			set{ _bstate=value;}
			get{return _bstate;}
		}
		/// <summary>
		/// 样品状态
		/// </summary>
		public int YState
		{
			set{ _ystate=value;}
			get{return _ystate;}
		}
		/// <summary>
		/// 结果上传时间
		/// </summary>
		public DateTime? RUpLoadDate
		{
			set{ _ruploaddate=value;}
			get{return _ruploaddate;}
		}
		/// <summary>
		/// 结果凭证
		/// </summary>
		public string RImgUrl
		{
			set{ _rimgurl=value;}
			get{return _rimgurl;}
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
		public string Spare2
		{
			set{ _spare2=value;}
			get{return _spare2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SPInt
		{
			set{ _spint=value;}
			get{return _spint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SPInt2
		{
			set{ _spint2=value;}
			get{return _spint2;}
		}
		#endregion Model

	}
}

