using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace yny_005.Web.ProjectManage.Handler
{
    /// <summary>
    /// MSampleList 的摘要说明
    /// </summary>
    public class MSampleList : BaseHandler
    {

        public override void ProcessRequest(HttpContext context)
        {
            base.ProcessRequest(context);
            string strWhere = "'1'='1'";

            if (!string.IsNullOrEmpty(context.Request["IsState"]))
            {
                strWhere += " and SState in(" + HttpUtility.UrlDecode(context.Request["IsState"]) + ")";
            }
            int count;
            List<Model.ObjSample> ListO = BLL.ObjSample.GetList(strWhere, pageIndex, pageSize, out count);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ListO.Count; i++)
            {
                Model.OObject obj = BLL.OObject.GetModel(ListO[i].ObjID);
                Model.ObjUser ouser = BLL.ObjUser.GetModel(ListO[i].SpInt);
                Model.ObjUserApply oapply = BLL.ObjUserApply.GetModelOID(ouser.BaoMingOID);
                sb.Append(ListO[i].ID + "~");
                sb.Append((i + 1) + (pageIndex - 1) * pageSize + "~");
                sb.Append(obj.ObjOID + "~");
                sb.Append(obj.ObjName + "~");
                sb.Append(ouser.DanWeiName + "~");
                sb.Append(ListO[i].Spare + "~");
                sb.Append("<a href='" + ListO[i].YangPinImgUrl + "' target='_blank'><img width='80' height='80' src='" + ListO[i].YangPinImgUrl + "' /></a>" + "~");
                sb.Append(oapply.CreateDate.ToString("yyyy-MM-dd HH:mm") + "~");
                sb.Append(ListO[i].SState.ToString().Replace("0", "未寄送").Replace("1", "已寄送，未确认").Replace("2", "损坏，待重新寄送").Replace("3", "寄送完成") + "~");
                sb.Append(((ListO[i].SState == 0|| ListO[i].SState == 2) ? "<div  class=\"pay btn btn-success\" onclick=\"callhtml('/ProjectManage/SampleJS.aspx?xxid=" + ListO[i].ID + "','样品寄送')\">样品寄送</ div > " : ""));
                sb.Append("≌");
            }
            var info = new { PageData = Traditionalized(sb), TotalCount = count };

            //var json = new { PageData = sb.ToString(), TotalCount = count };匿名类
            context.Response.Write(JavaScriptConvert.SerializeObject(info));
        }
    }
}