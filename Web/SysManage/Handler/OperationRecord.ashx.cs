using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace yny_005.Web.SysManage.Handler
{
    /// <summary>
    /// OperationRecord 的摘要说明
    /// </summary>
    public class OperationRecord : BaseHandler
    {

        public override void ProcessRequest(HttpContext context)
        {
            base.ProcessRequest(context);
            string strWhere = "'1'='1' and mid='" + TModel.MID + "' ";

            if (!string.IsNullOrEmpty(context.Request["startDate"]))
            {
                strWhere += " and Time>'" + context.Request["startDate"] +"'";
            }
            if (!string.IsNullOrEmpty(context.Request["endDate"]))
            {
                strWhere += " and Time<'" + context.Request["endDate"] +"'";
            }
            int count;
            List<Model.Member_OperationRecord> ListO = BLL.OperationRecordBLL.GetList(strWhere, pageIndex, pageSize, out count);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListO.Count; i++)
            {
                sb.Append(ListO[i].ID + "~");
                sb.Append((i + 1) + (pageIndex - 1) * pageSize + "~");
                sb.Append(ListO[i].MID + "~");
                sb.Append(BLL.Roles.RolsList[ListO[i].RoleCode].RName + "~");
                sb.Append(ListO[i].Time.ToString("yyyy-MM-dd HH:mm:ss") + "~");
                sb.Append(ListO[i].TypeCode + "~");
                sb.Append(ListO[i].Operation);
                sb.Append("≌");
            }
            var info = new { PageData = Traditionalized(sb), TotalCount = count };

            //var json = new { PageData = sb.ToString(), TotalCount = count };匿名类
            context.Response.Write(JavaScriptConvert.SerializeObject(info));
        }
    }
}