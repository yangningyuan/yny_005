﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.SessionState;
using Newtonsoft.Json;

namespace yny_005.Web.Handler
{
    /// <summary>
    /// MemberList 的摘要说明
    /// </summary>
    public class MemberList : BaseHandler
    {

        public override void ProcessRequest(HttpContext context)
        {
            Model.Member memberModel = (TModel == null ? BllModel.TModel : TModel);
            if (!memberModel.Role.Super)
            {
                return;
            }
            base.ProcessRequest(context);
            string strWhere = "'1'='1'";
            string RoleCode = "";
            foreach (Model.Roles item in BLL.Roles.RolsList.Values.ToList().Where(emp => emp.VState && !emp.IsAdmin).ToList())
                RoleCode += "'" + item.RType + "',";
            RoleCode = RoleCode.Substring(0, RoleCode.Length - 1);
            if (!string.IsNullOrEmpty(context.Request["mKey"]))
            {
                strWhere += string.Format(" and ( MID='{0}' or MName='{0}') ", (context.Request["mKey"]));
            }
            if (!string.IsNullOrEmpty(context.Request["tState"]))
            {
                strWhere += string.Format(" and MType={0} ", (context.Request["tState"]));
            }
            if (!string.IsNullOrEmpty(context.Request["startDate"]))
            {
                strWhere += " and MDate>'" + context.Request["startDate"] + " 00:00:00' ";
            }
            if (!string.IsNullOrEmpty(context.Request["endDate"]))
            {
                strWhere += " and MDate<'" + context.Request["endDate"] + " 23:59:59' ";
            }
            if (!string.IsNullOrEmpty(context.Request["RoleCode"]))
            {
                strWhere += " and RoleCode in ('" + context.Request["RoleCode"] + "') ";
            }
            else
            {
                strWhere += " and RoleCode in (" + RoleCode + ") ";
            }
            if (!string.IsNullOrEmpty(context.Request["JXType"]))
            {
                if (context.Request["JXType"] == "no")
                    strWhere += " and JXType is NULL ";
                else
                    strWhere += " and JXType='" + context.Request["JXType"] + "'";
            }
            if (!string.IsNullOrEmpty(context.Request["IsClose"]))
            {
                strWhere += " and IsClose='" + context.Request["IsClose"] + "' ";
            }
            if (!string.IsNullOrEmpty(context.Request["IsClock"]))
            {
                strWhere += " and IsClock='" + context.Request["IsClock"] + "' ";
            }
            if (!string.IsNullOrEmpty(context.Request["AgencyCode"]))
            {
                strWhere += " and AgencyCode='" + context.Request["AgencyCode"] + "' ";
            }
            if (!string.IsNullOrEmpty(context.Request["NAgencyCode"]))
            {
                strWhere += " and NAgencyCode='" + context.Request["NAgencyCode"] + "' ";
            }
            if (!string.IsNullOrEmpty(context.Request["ddlPCode"]))
            {
                strWhere += " and (select PCode from MemberConfig where MID=Member.MID)='" + context.Request["ddlPCode"] + "' ";
            }
            if (!string.IsNullOrEmpty(context.Request["OnlyOnLine"]))
            {
                strWhere += " and mid in ('" + String.Join("','", BLL.Member.OnLineMember.ToArray()) + "') ";
            }
            if (!string.IsNullOrWhiteSpace(context.Request["ddlRegion"]))
            {
                strWhere += " and Country = ('" + context.Request["ddlRegion"] + "') ";
            }
            if (!string.IsNullOrWhiteSpace(context.Request["ddlProvince"]))
            {
                strWhere += " and Province = ('" + context.Request["ddlProvince"] + "') ";
            }
            if (!string.IsNullOrWhiteSpace(context.Request["ddlCity"]))
            {
                strWhere += " and City = ('" + context.Request["ddlCity"] + "') ";
            }
            if (!string.IsNullOrWhiteSpace(context.Request["ddlZone"]))
            {
                strWhere += " and Zone = ('" + context.Request["ddlZone"] + "') ";
            }

            int count;
            List<Model.Member> ListMember = BllModel.GetMemberEntityList(strWhere, pageIndex, pageSize, out count);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListMember.Count; i++)
            {
                sb.Append(ListMember[i].MID + "~");
                sb.Append((i + 1) + (pageIndex - 1) * pageSize + "~");
                if (ListMember[i].Role.CanSH)
                {
                    sb.Append("<span style='color:red;'>" + ListMember[i].MID + "[" + (BLL.Member.IfOnLine(ListMember[i].MID) ? "<b style='color:#A8FF24;cursor:help;' onclick='OpenTask(\"" + ListMember[i].MID + "\");'>在线</b>" : "离线") + "]" + "</span>" + "~");
                }
                else
                {
                    sb.Append(ListMember[i].MID + "[" + (BLL.Member.IfOnLine(ListMember[i].MID) ? "<b style='color:#A8FF24;cursor:help;' onclick='OpenTask(\"" + ListMember[i].MID + "\");'>在线</b>" : "离线") + "]" + "~");
                }
                string rostr = "";
                if(!string.IsNullOrEmpty(ListMember[i].FMID))
                    rostr = ListMember[i].FMID.ToString().Replace("0", "检测机构登记证书").Replace("1", "个人身份证").Replace("1", "其他");
                sb.Append(ListMember[i].MName + "~");
                sb.Append((ListMember[i].Role.RName+"~"));
				sb.Append(ListMember[i].Tel+ "~");
                sb.Append( (ListMember[i].RoleCode=="DW"?"":ListMember[i].NumID) + "["+rostr+"]"+"~");
                sb.Append((ListMember[i].IsClose ? "已锁定" : "未锁定") + "~");
                //sb.Append((ListMember[i].IsClock ? "已冻结" : "未冻结") + "~");
                
                
                sb.Append(ListMember[i].MCreateDate.ToString("yyyy-MM-dd HH:mm") + "~");
                sb.Append(ListMember[i].MDate.ToString("yyyy-MM-dd HH:mm") + "~");
                if (!ListMember[i].MState)
                {
                    sb.Append("<a class='btn' href=\"javascript:SHAuto('" + ListMember[i].MID+"')\">审核通过</a>");
                }
                else
                {
                    sb.Append("<span style='color:green;'>正常</span>");
                }
                sb.Append("≌");
            }
            var info = new { PageData = Traditionalized(sb), TotalCount = count };

            context.Response.Write(JavaScriptConvert.SerializeObject(info));
        }
    }
}