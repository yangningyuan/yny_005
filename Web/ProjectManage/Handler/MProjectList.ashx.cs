using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace yny_005.Web.ProjectManage.Handler
{
    /// <summary>
    /// MProjectList 的摘要说明
    /// </summary>
    public class MProjectList : BaseHandler
    {
        public override void ProcessRequest(HttpContext context)
        {
            base.ProcessRequest(context);
            string strWhere = "'1'='1' ";


            if (!string.IsNullOrEmpty(context.Request["nBMTitle"]))
            {
                strWhere += " and DanWeiName like '%" + HttpUtility.UrlDecode(context.Request["nBMTitle"]) + "%'";
            }

            if (!string.IsNullOrEmpty(context.Request["nTitle"]))
            {
                strWhere += " and ObjName like '%" + HttpUtility.UrlDecode(context.Request["nTitle"]) + "%'";
            }

            if (!string.IsNullOrEmpty(context.Request["IsBMState"]))
            {
                strWhere += " and BState in(" + HttpUtility.UrlDecode(context.Request["IsBMState"]) + ")";
            }

            if (!string.IsNullOrEmpty(context.Request["IsYangPin"]))
            {
                strWhere += " and YState in(" + HttpUtility.UrlDecode(context.Request["IsYangPin"]) + ")";
            }

            if (!string.IsNullOrEmpty(context.Request["IsRState"]))
            {
                strWhere += " and RState in(" + HttpUtility.UrlDecode(context.Request["IsRState"]) + ")";
            }

            if (!string.IsNullOrEmpty(context.Request["bmoid"]))
            {
                strWhere += " and OBJID=" + context.Request["bmoid"] + "";
            }


            //如果是单位部门的话 能管理自己发布的项目
            if (!TModel.Role.IsAdmin)
            {
                strWhere += " and  objID IN(SELECT ID FROM OObject WHERE ReObjMID='"+TModel.MID+"') ";
            }

            if (!string.IsNullOrEmpty(context.Request["IsSState"]))
            {
                strWhere += " and  objID IN(SELECT ID FROM OObject WHERE SState='" + context.Request["IsSState"] + "') ";
            }

            int count;
            List<Model.ObjUser> ListO = BLL.ObjUser.GetList(strWhere, pageIndex, pageSize, out count);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListO.Count; i++)
            {
                Model.OObject obj = BLL.OObject.GetModel(ListO[i].ObjID);
                //Model.ObjSubUser objsub = BLL.ObjSubUser.GetModelList(" SpInt=" + obj.ID + " and MID='" + TModel.MID + "' ").FirstOrDefault();
                sb.Append(ListO[i].ID + "~");
                sb.Append((i + 1) + (pageIndex - 1) * pageSize + "~");
                sb.Append(ListO[i].DanWeiName + "~");
                sb.Append(ListO[i].ObjName + "~");
                sb.Append(obj.JGDate + "~");
                //sb.Append((objsub != null ? objsub.ResultOne : "") + "~");
                //sb.Append((objsub != null ? objsub.ResultTwo : "") + "~");
                //sb.Append((objsub != null ? objsub.ResultAvg : "") + "~");
                sb.Append((ListO[i].BState.ToString().Replace("0", "未审核").Replace("1", "打回").Replace("3", "<span style='color:green;'>已审核</span>")) + "~");
                sb.Append((ListO[i].YState.ToString().Replace("0", "未寄送").Replace("1", "已寄送").Replace("2", "样品损坏").Replace("3", "<span style='color:green;'>样品确认</span>")) + "~");
                sb.Append((ListO[i].YState.ToString() == "3" ? "<span style='color:green;'>样品已确认</span>" : "未确认") + "~");
                string isSubResult = "";
                if (ListO[i].RState == 1 )
                {
                    isSubResult = "<div  class=\"pay btn btn-success\" onclick=\"callhtml('/ProjectManage/SHValidationResult.aspx?xxid=" + ListO[i].ID + "','审核结果')\">审核结果</div>";
                }
                sb.Append((ListO[i].RState.ToString().Replace("0", "等待提交").Replace("1", "等待审核").Replace("2", "审核失败").Replace("3", "<span style='color:green;'>审核通过</span>")+ isSubResult) + "~");
                sb.Append("报告下载" + "~");
                sb.Append((ListO[i].USState.ToString().Replace("0","待审核").Replace("2","打回").Replace("3","审核通过")) + "~");
                sb.Append((ListO[i].USState == 3? "<span style='color:green;'><a href='javascript:void(0)' style='color:green;' onclick=\"callhtml('/ProjectManage/PutZhengShu.aspx?xxid=" + ListO[i].ID + "','打印证书')\" >打印证书</a></span>" : "未通过") + "~");
                sb.Append("<div  class=\"pay btn btn-success\" onclick=\"callhtml('/ProjectManage/ObjectView.aspx?xxid=" + ListO[i].ID + "','流程')\">流程</div>");
                sb.Append("≌");
            }
            var info = new { PageData = Traditionalized(sb), TotalCount = count };

            //var json = new { PageData = sb.ToString(), TotalCount = count };匿名类
            context.Response.Write(JavaScriptConvert.SerializeObject(info));
        }
    }
}