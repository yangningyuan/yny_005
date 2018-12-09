using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace yny_005.Web.ProjectManage.Handler
{
    /// <summary>
    /// ManageSHSignProjectList 的摘要说明
    /// </summary>
    public class ManageSHSignProjectList : BaseHandler
    {

        public override void ProcessRequest(HttpContext context)
        {
            base.ProcessRequest(context);
            string strWhere = "'1'='1'";

            if (!string.IsNullOrEmpty(context.Request["nTitle"]))
            {
                strWhere += " and  objID IN(SELECT ID FROM OObject WHERE OBJNAME='" + context.Request["nTitle"] + "') ";
            }

            if (!string.IsNullOrEmpty(context.Request["bmoid"]))
            {
                strWhere += " and OBJID="+ context.Request["bmoid"] + "";
            }

            //如果是单位部门的话 能管理自己发布的项目
            if (!TModel.Role.IsAdmin)
            {
                strWhere += " and  objID IN(SELECT ID FROM OObject WHERE ReObjMID='" + TModel.MID + "') ";
            }

            int count;
            List<Model.ObjUserApply> ListO = BLL.ObjUserApply.GetList(strWhere, pageIndex, pageSize, out count);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListO.Count; i++)
            {
                Model.OObject obj = BLL.OObject.GetModel(ListO[i].ObjID);
                sb.Append(ListO[i].ID + "~");
                sb.Append((i + 1) + (pageIndex - 1) * pageSize + "~");
                sb.Append(obj.ObjOID + "~");
                sb.Append(ListO[i].BaoMingCode + "~");
                sb.Append(obj.ObjName + "~");
                sb.Append(ListO[i].MID + "~");
                sb.Append(ListO[i].DanWeiName + "~");
                sb.Append(ListO[i].CreateDate.ToString("yyyy-MM-dd HH:mm") + "~");
                sb.Append("<a href='" + ListO[i].FeiYongImgUrl + "' target='_blank'><img width='80' height='80' src='" + ListO[i].FeiYongImgUrl + "' /></a>" + "~");
                sb.Append("<a href='" + ListO[i].BaoMingImgUrl + "' target='_blank'><img width='80' height='80' src='" + ListO[i].BaoMingImgUrl + "' /></a>" + "~");
                sb.Append(ListO[i].ReSpare + "~");
                sb.Append(ListO[i].SState.ToString().Replace("0", "未审核").Replace("1", "审核不通过").Replace("3", "审核通过") + "~");
                sb.Append((ListO[i].SState == 0 ? "<div  class=\"pay btn btn-success\" onclick=\"callhtml('/ProjectManage/SHSignProject.aspx?xxid=" + ListO[i].ID + "','审核报名信息')\">审核报名</ div > " : ""));
                sb.Append("≌");
            }
            var info = new { PageData = Traditionalized(sb), TotalCount = count };

            //var json = new { PageData = sb.ToString(), TotalCount = count };匿名类
            context.Response.Write(JavaScriptConvert.SerializeObject(info));
        }
    }
}