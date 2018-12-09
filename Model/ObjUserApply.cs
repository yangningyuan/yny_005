/**  版本信息模板在安装目录下，可自行修改。
* ObjUserApply.cs
*
* 功 能： N/A
* 类 名： ObjUserApply
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
	/// ObjUserApply:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ObjUserApply
	{
		public ObjUserApply()
		{}
		#region Model
		private int _id;
		private int _objid;
		private string _mid;
		private string _baomingcode;
		private string _danweiname;
		private string _zigezhengshu;
		private string _zhengshucode;
		private DateTime _createdate= DateTime.Now;
		private DateTime _comdate;
		private string _subid;
		private string _baomingimgurl;
		private string _feiyongimgurl;
		private int _sstate=0;
        /// <summary>
        /// 备注
        /// </summary>
        public string ReSpare { get; set; }
        public int BMInt { get; set; }
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
		/// 用户mid
		/// </summary>
		public string MID
		{
			set{ _mid=value;}
			get{return _mid;}
		}
		/// <summary>
		/// 报名编号
		/// </summary>
		public string BaoMingCode
		{
			set{ _baomingcode=value;}
			get{return _baomingcode;}
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
		/// 资格证书
		/// </summary>
		public string ZiGeZhengShu
		{
			set{ _zigezhengshu=value;}
			get{return _zigezhengshu;}
		}
		/// <summary>
		/// 资格证号
		/// </summary>
		public string ZhengShuCode
		{
			set{ _zhengshucode=value;}
			get{return _zhengshucode;}
		}
		/// <summary>
		/// 报名日期
		/// </summary>
		public DateTime CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 审核日期
		/// </summary>
		public DateTime ComDate
		{
			set{ _comdate=value;}
			get{return _comdate;}
		}
		/// <summary>
		/// 子项ID，可多个
		/// </summary>
		public string SubID
		{
			set{ _subid=value;}
			get{return _subid;}
		}
		/// <summary>
		/// 报名凭证
		/// </summary>
		public string BaoMingImgUrl
		{
			set{ _baomingimgurl=value;}
			get{return _baomingimgurl;}
		}
		/// <summary>
		/// 费用凭证
		/// </summary>
		public string FeiYongImgUrl
		{
			set{ _feiyongimgurl=value;}
			get{return _feiyongimgurl;}
		}
		/// <summary>
		/// 状态  0未审核 1 审核不通过，3 审核通过
		/// </summary>
		public int SState
		{
			set{ _sstate=value;}
			get{return _sstate;}
		}
		#endregion Model

	}
}

