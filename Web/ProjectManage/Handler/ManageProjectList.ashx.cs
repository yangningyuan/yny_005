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

            //如果是单位部门的话 能管理自己发布的项目
            if (!TModel.Role.IsAdmin)
            {
                strWhere += " and  ReObjMID='" + TModel.MID + "'  ";
            }

            int count;
            List<Model.OObject> ListO = BLL.OObject.GetList(strWhere, pageIndex, pageSize, out count);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListO.Count; i++)
            {
                sb.Append(ListO[i].ID + "~");
                sb.Append((i + 1) + (pageIndex - 1) * pageSize + "~");
                //sb.Append(ListO[i].ObjOID + "~");
                sb.Append(ListO[i].ObjName + "~");
                sb.Append(ListO[i].ReObjMID + "~");
                sb.Append(ListO[i].ReObjNiName + "~");
                sb.Append(ListO[i].BMDate + "~");
                sb.Append(ListO[i].JGDate + "~");
                //sb.Append((ListO[i].Remark.Length>20? ListO[i].Remark.ToString().Substring(0,20)+"...": ListO[i].Remark) + "~");
                sb.Append(ListO[i].CreateDate.ToString("yyyy-MM-dd HH:mm") + "~");
                sb.Append((ListO[i].SState==0? "<span style='color:green;'>未结束</span>" : "<span style='color:red;'>已结束</span>") + "~");

                sb.Append("<div  class=\"pay btn btn-success\" onclick=\"callhtml('/ProjectManage/ManageSHSignProjectList.aspx?bmoid=" + ListO[i].ID + "','报名列表')\">报名列表</div>"+"~");
                sb.Append("<div  class=\"pay btn btn-success\" onclick=\"callhtml('/ProjectManage/MSampleList.aspx?bmoid=" + ListO[i].ID + "','样品列表')\">样品列表</div>" + "~");
                sb.Append("<div  class=\"pay btn btn-success\" onclick=\"callhtml('/ProjectManage/MProjectList.aspx?bmoid=" + ListO[i].ID + "','结果验证列表')\">结果验证列表</div>" + "~");


                sb.Append("<div  class=\"pay btn btn-warning\" onclick=\"callhtml('/ProjectManage/ObjectModify.aspx?xxid=" + ListO[i].ID + "','修改')\">修改</div>");
               
                sb.Append("≌");
            }
            var info = new { PageData = Traditionalized(sb), TotalCount = count };

            //var json = new { PageData = sb.ToString(), TotalCount = count };匿名类
            context.Response.Write(JavaScriptConvert.SerializeObject(info));
        }
    }
}