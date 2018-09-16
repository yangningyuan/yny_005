﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace yny_005.Web.Car.Handler
{
    /// <summary>
    /// BankAccountList 的摘要说明
    /// </summary>
    public class BankAccountList : BaseHandler
    {

        public override void ProcessRequest(HttpContext context)
        {
            base.ProcessRequest(context);
            string strWhere = "'1'='1' ";
            //if (!string.IsNullOrEmpty(context.Request["tState"]))
            //{
            //    strWhere += " and IsDelete='" + context.Request["tState"] + "'";
            //}
            //if (!string.IsNullOrEmpty(context.Request["nTitle"]))
            //{
            //    strWhere += " and PZCode like '%" + HttpUtility.UrlDecode(context.Request["nTitle"]) + "%'";
            //}
            int count;
            List<Model.C_SuppBank> ListNotice = BLL.C_SuppBank.GetList(strWhere, pageIndex, pageSize, out count);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListNotice.Count; i++)
            {
                sb.Append(ListNotice[i].ID + "~");
                sb.Append((i + 1) + (pageIndex - 1) * pageSize + "~");
                sb.Append(ListNotice[i].AccountName + "");
                //sb.Append(ListNotice[i].Money + "~");
                ////sb.Append((ListNotice[i].ImpUnit.ToString())+ "~");
                //sb.Append(ListNotice[i].CardName + "~");
                //sb.Append(ListNotice[i].BankName + "");
                
                //sb.Append("<div class=\"pay btn btn-success\" onclick=\"v5.show('Car/CarList.aspx?id=" + ListNotice[i].ID + "', '查看详情', 'url', 360, 240)\">查看详情</div>");
                sb.Append("≌");
            }
            var info = new { PageData = Traditionalized(sb), TotalCount = count };

            //var json = new { PageData = sb.ToString(), TotalCount = count };匿名类
            context.Response.Write(JavaScriptConvert.SerializeObject(info));
        }
    }
}