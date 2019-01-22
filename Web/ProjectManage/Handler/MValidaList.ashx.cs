using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace yny_005.Web.ProjectManage.Handler
{
    /// <summary>
    /// MValidaList 的摘要说明
    /// </summary>
    public class MValidaList : BaseHandler
    {

        public override void ProcessRequest(HttpContext context)
        {
            base.ProcessRequest(context);
            string strWhere = "'1'='1' ";

            //if (!string.IsNullOrEmpty(context.Request["nBMTitle"]))
            //{
            //    strWhere += " and DanWeiName like '%" + HttpUtility.UrlDecode(context.Request["nBMTitle"]) + "%'";
            //}

            if (!string.IsNullOrEmpty(context.Request["HYmid"]))
            {
                strWhere += " and MID like '%" + context.Request["HYmid"] + "%'";
            }

            //if (!string.IsNullOrEmpty(context.Request["IsBMState"]))
            //{
            //    strWhere += " and BState in(" + HttpUtility.UrlDecode(context.Request["IsBMState"]) + ")";
            //}

            //if (!string.IsNullOrEmpty(context.Request["IsYangPin"]))
            //{
            //    strWhere += " and YState in(" + HttpUtility.UrlDecode(context.Request["IsYangPin"]) + ")";
            //}

            if (!string.IsNullOrEmpty(context.Request["SHState"]))
            {
                strWhere += " and SHInt ="+context.Request["SHState"] +" ";
            }

            if (!string.IsNullOrEmpty(context.Request["ObjCode"]))
            {
                strWhere += " and  objID IN(SELECT ID FROM OObject WHERE ObjOID like  '%" + context.Request["ObjCode"].Trim() + "%') ";
            }

            if (!string.IsNullOrEmpty(context.Request["ObjName"]))
            {
                strWhere += " and  objID IN(SELECT ID FROM OObject WHERE ObjName like  '%" + context.Request["ObjName"].Trim() + "%') ";
            }

            if (!string.IsNullOrEmpty(context.Request["ObjReMID"]))
            {
                strWhere += " and  objID IN(SELECT ID FROM OObject WHERE ReObjMID =  '" + context.Request["ObjReMID"].Trim() + "') ";
            }

            if (!string.IsNullOrEmpty(context.Request["JGWhere"])&& !string.IsNullOrEmpty(context.Request["JGType"])&& !string.IsNullOrEmpty(context.Request["JGValue"]))
            {
                strWhere += " and "+ context.Request["JGWhere"] + context.Request["JGType"] + context.Request["JGValue"] + " ";
            }

            //如果是单位部门的话 能管理自己发布的项目
            if (!TModel.Role.IsAdmin)
            {
                strWhere += " and  objID IN(SELECT ID FROM OObject WHERE ReObjMID='" + TModel.MID + "') ";
            }

            if (!string.IsNullOrEmpty(context.Request["IsSState"]))
            {
                strWhere += " and  objID IN(SELECT ID FROM OObject WHERE SState='" + context.Request["IsSState"] + "') ";
            }

            int count;
            List<Model.ObjSub> ListO = BLL.ObjSub.GetList(strWhere, pageIndex, pageSize, out count);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListO.Count; i++)
            {
                Model.OObject obj = BLL.OObject.GetModel(ListO[i].ObjID);
                Model.ObjUserApply oua = BLL.ObjUserApply.GetModel(ListO[i].SpInt);
                Model.ObjUser ou = BLL.ObjUser.GetModel(ListO[i].URID);

                //Model.ObjSubUser objsub = BLL.ObjSubUser.GetModelList(" SpInt=" + obj.ID + " and MID='" + TModel.MID + "' ").FirstOrDefault();
                sb.Append(ListO[i].ID + "~");
                sb.Append((i + 1) + (pageIndex - 1) * pageSize + "~");
                sb.Append(obj.ObjOID + "~");
                sb.Append(obj.ObjName + "~");
                sb.Append(oua.DanWeiName + "~");
                sb.Append(oua.CreateDate + "~");
                sb.Append(ListO[i].Spare + "~");
                sb.Append((ou.USState.ToString().Replace("0", "待审核").Replace("2", "打回").Replace("3", "审核通过")) + "~");
                sb.Append((ListO[i].ResultOne) + "~");
                sb.Append((ListO[i].ResultTwo) + "~");
                sb.Append((ListO[i].ResultAvg) + "~");
                sb.Append((ListO[i].SHInt.ToString().Replace("0", "待审核").Replace("2", "不合格").Replace("1", "合格")) + "~");
                if (ListO[i].SHInt == 0)
                {
                    sb.Append("<div  class=\"pay btn btn-success\" onclick=\"SHChange('" + ListO[i].ID + "')\">合格</div>");
                    sb.Append("<div  class=\"pay btn btn-warning\" onclick=\"DHChange('" + ListO[i].ID + "')\">不合格</div>");
                }
                sb.Append("≌");
            }
            var info = new { PageData = Traditionalized(sb), TotalCount = count };

            //var json = new { PageData = sb.ToString(), TotalCount = count };匿名类
            context.Response.Write(JavaScriptConvert.SerializeObject(info));
        }
    }
}