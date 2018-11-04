using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace yny_005.Web.ProjectManage.Handler
{
    /// <summary>
    /// ManageSumSignProjectList 的摘要说明
    /// </summary>
    public class ManageSumSignProjectList : BaseHandler
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
                sb.Append(ListO[i].BMDate + "~");
                sb.Append(ListO[i].CreateDate + "~");
                sb.Append(ListO[i].JGDate + "~");
                var bmcount= BLL.CommonBase.GetSingle("select COUNT(*) from ObjUserApply  where objid="+ListO[i].ID+";");
                var sjcount= BLL.CommonBase.GetSingle("select COUNT(*) from ObjUserApply  where sstate=3 and objid=" + ListO[i].ID + ";");
                sb.Append(bmcount + "~");
                sb.Append(sjcount + "");

                sb.Append("≌");
            }
            var info = new { PageData = Traditionalized(sb), TotalCount = count };

            //var json = new { PageData = sb.ToString(), TotalCount = count };匿名类
            context.Response.Write(JavaScriptConvert.SerializeObject(info));
        }
    }
}