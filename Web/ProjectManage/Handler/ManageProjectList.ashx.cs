﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace yny_005.Web.ProjectManage.Handler
{
    /// <summary>
    /// ManageProjectList 的摘要说明
    /// </summary>
    public class ManageProjectList : BaseHandler
    {

        public override void ProcessRequest(HttpContext context)
        {
            base.ProcessRequest(context);
            string strWhere = "'1'='1'";
          
            if (!string.IsNullOrEmpty(context.Request["nTitle"]))
            {
                strWhere += " and ObjName like '%" + HttpUtility.UrlDecode(context.Request["nTitle"]) + "%'";
            }
            int count;
            List<Model.OObject> ListO = BLL.OObject.GetList(strWhere, pageIndex, pageSize, out count);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListO.Count; i++)
            {
                sb.Append(ListO[i].ID + "~");
                sb.Append((i + 1) + (pageIndex - 1) * pageSize + "~");
                sb.Append(ListO[i].ObjOID + "~");
                sb.Append(ListO[i].ObjName + "~");
                sb.Append(ListO[i].ReObjMID + "~");
                sb.Append(ListO[i].ReObjNiName + "~");
                sb.Append(ListO[i].BMDate + "~");
                sb.Append(ListO[i].JGDate + "~");
                sb.Append(ListO[i].Remark + "~");
                sb.Append(ListO[i].CreateDate.ToString("yyyy-MM-dd HH:mm") + "~");
                sb.Append( "");
               
                sb.Append("≌");
            }
            var info = new { PageData = Traditionalized(sb), TotalCount = count };

            //var json = new { PageData = sb.ToString(), TotalCount = count };匿名类
            context.Response.Write(JavaScriptConvert.SerializeObject(info));
        }
    }
}