using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace yny_005.Web.ProjectManage.Handler
{
    /// <summary>
    /// SignProjectList 的摘要说明
    /// </summary>
    public class SignProjectList : BaseHandler
    {

        public override void ProcessRequest(HttpContext context)
        {
            base.ProcessRequest(context);
            string strWhere = "'1'='1' and OState=3 ";

            if (!string.IsNullOrEmpty(context.Request["nTitle"]))
            {
                strWhere += " and ObjName like '%" + HttpUtility.UrlDecode(context.Request["nTitle"]) + "%'";
            }

            int count;
            List<Model.OObject> ListO = BLL.OObject.GetList(strWhere, pageIndex, pageSize, out count);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListO.Count; i++)
            {
                Model.ObjUserApply oba = BLL.ObjUserApply.GetModelList(" MID='" + TModel.MID + "' and [OBJID]=" + ListO[i].ID + "; ").FirstOrDefault();
                sb.Append(ListO[i].ID + "~");
                sb.Append((i + 1) + (pageIndex - 1) * pageSize + "~");
                sb.Append(ListO[i].ReObjMID + "~");
                sb.Append(ListO[i].ObjName + "~");
                //sb.Append(ListO[i].CreateDate.ToString("yyyy-MM-dd HH:mm") + "~");
                sb.Append(ListO[i].BMDate.ToString("yyyy-MM-dd HH:mm") + "~");
                sb.Append((ListO[i].SState==1?"已结束":"正在进行") + "~");
                sb.Append((oba != null ? (oba.SState.ToString().Replace("0", "未审核").Replace("1", "<span style='color:red;'>打回</span>").Replace("3", "<span style='color:green;'>已审核</span>")) : "未报名") + "~");
                sb.Append((oba != null ? oba.ReSpare : "") + "~");
                if (ListO[i].SState == 0)
                {
                    sb.Append((BMState(TModel.MID, ListO[i].ID) == "可报名" ? "<div  class=\"pay btn btn-success\" onclick=\"callhtml('/ProjectManage/SignProject.aspx?xxid=" + ListO[i].ID + "','报名')\">报名</div > " : ""));
                    if (oba != null && oba.SState == 1)
                    {
                        sb.Append("<div  class=\"pay btn btn-success\" onclick=\"callhtml('/ProjectManage/ModifySignProject.aspx?xxid=" + ListO[i].ID + "&bmid=" + oba.ID + "','修改')\">修改</div>");
                    }
                }
                
                sb.Append("≌");
            }
            var info = new { PageData = Traditionalized(sb), TotalCount = count };

            //var json = new { PageData = sb.ToString(), TotalCount = count };匿名类
            context.Response.Write(JavaScriptConvert.SerializeObject(info));
        }
    }
}