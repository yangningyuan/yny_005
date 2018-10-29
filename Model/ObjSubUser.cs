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
namespace yny_005.Model
{
	/// <summary>
	/// ObjSubUser:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ObjSubUser
	{
		public ObjSubUser()
		{}
		#region Model
		private int _id;
		private int _subid;
		private string _mid;
		private string _resultone;
		private string _resulttwo;
		private string _resultavg;
		private string _rfangfa;
		private string _rshebei;
		private string _ryichang;
		private string _rperson;
		private int _ryangpinid=0;
		private string _resultimgurl;
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
		/// 子项ID
		/// </summary>
		public int SubID
		{
			set{ _subid=value;}
			get{return _subid;}
		}
		/// <summary>
		/// 会员名称
		/// </summary>
		public string MID
		{
			set{ _mid=value;}
			get{return _mid;}
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
		/// 所用方法
		/// </summary>
		public string RFangFa
		{
			set{ _rfangfa=value;}
			get{return _rfangfa;}
		}
		/// <summary>
		/// 仪器设备
		/// </summary>
		public string RSheBei
		{
			set{ _rshebei=value;}
			get{return _rshebei;}
		}
		/// <summary>
		/// 异常情况
		/// </summary>
		public string RYiChang
		{
			set{ _ryichang=value;}
			get{return _ryichang;}
		}
		/// <summary>
		/// 负责人
		/// </summary>
		public string RPerson
		{
			set{ _rperson=value;}
			get{return _rperson;}
		}
		/// <summary>
		/// 样品ID
		/// </summary>
		public int RYangPinID
		{
			set{ _ryangpinid=value;}
			get{return _ryangpinid;}
		}
		/// <summary>
		/// 结果凭证
		/// </summary>
		public string ResultImgUrl
		{
			set{ _resultimgurl=value;}
			get{return _resultimgurl;}
		}
		/// <summary>
		/// 状态
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

