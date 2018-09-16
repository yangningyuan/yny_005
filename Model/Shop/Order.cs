﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yny_005.Model
{
	public class Order
	{
		/// <summary>
		/// 订单类型 1.装车 2.卸车
		/// </summary>
		public int OType { get; set; }
		/// <summary>
		/// Id
		/// </summary>		
		private int _id;
		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		/// <summary>
		/// Code
		/// </summary>		
		private string _code;
		public string Code
		{
			get { return _code; }
			set { _code = value; }
		}
		/// <summary>
		/// TotalPrice
		/// </summary>		
		private decimal _totalprice;
		/// <summary>
		/// 合计金额
		/// </summary>
		public decimal TotalPrice
		{
			get { return _totalprice; }
			set { _totalprice = value; }
		}

		private decimal _DisCountTotalPrice;
		/// <summary>
		/// 折后价
		/// </summary>
		public decimal DisCountTotalPrice
		{
			get { return _DisCountTotalPrice; }
			set { _DisCountTotalPrice = value; }
		}

		/// <summary>
		/// GoodCount
		/// </summary>		
		private decimal _goodcount;
		public decimal GoodCount
		{
			get { return _goodcount; }
			set { _goodcount = value; }
		}
		/// <summary>
		/// OrderTime
		/// </summary>		
		private DateTime _ordertime;
		public DateTime OrderTime
		{
			get { return _ordertime; }
			set { _ordertime = value; }
		}
		/// <summary>
		/// MID
		/// </summary>		
		private string _mid;
		public string MID
		{
			get { return _mid; }
			set { _mid = value; }
		}
		/// <summary>
		/// PayTime
		/// </summary>		
		private DateTime? _paytime;
		public DateTime? PayTime
		{
			get { return _paytime; }
			set { _paytime = value; }
		}
		/// <summary>
		/// SendTime
		/// </summary>		
		private DateTime? _sendtime;
		public DateTime? SendTime
		{
			get { return _sendtime; }
			set { _sendtime = value; }
		}
		/// <summary>
		/// ReceiveTime
		/// </summary>		
		private DateTime? _receivetime;
		public DateTime? ReceiveTime
		{
			get { return _receivetime; }
			set { _receivetime = value; }
		}
		/// <summary>
		/// Status
		/// </summary>		
		private int _status;
		/// <summary>
		/// 订单状态：1、已打包待调度；2、已调度未完成、3、；4、已完成
		/// </summary>
		public int Status
		{
			get { return _status; }
			set { _status = value; }
		}
		/// <summary>
		/// IsDeleted
		/// </summary>		
		private bool _isdeleted;
		public bool IsDeleted
		{
			get { return _isdeleted; }
			set { _isdeleted = value; }
		}
		/// <summary>
		/// CreatedTime
		/// </summary>		
		private DateTime _createdtime;
		public DateTime CreatedTime
		{
			get { return _createdtime; }
			set { _createdtime = value; }
		}
		/// <summary>
		/// CreatedBy
		/// </summary>		
		private string _createdby;
		public string CreatedBy
		{
			get { return _createdby; }
			set { _createdby = value; }
		}

		private int _ReceiveId;
		public int ReceiveId
		{
			get { return _ReceiveId; }
			set { _ReceiveId = value; }
		}
		/// </summary>		
		/// 调度名称
		/// </summary>		
		private string _expresscompany;
		public string ExpressCompany
		{
			get { return _expresscompany; }
			set { _expresscompany = value; }
		}
		/// <summary>
		/// ExpressCode
		/// </summary>		
		private string _expresscode;
		public string ExpressCode
		{
			get { return _expresscode; }
			set { _expresscode = value; }
		}

		/// <summary>
		/// 备注
		/// </summary>		
		private string _Remarks;
		public string Remarks
		{
			get { return _Remarks; }
			set { _Remarks = value; }
		}
		public List<Model.OrderDetail> OrderDetail { get; set; }//订单详情
	}
}
