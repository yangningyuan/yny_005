using DBUtility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class MValidaList : BasePage
    {
        protected override string btnAdd_Click()
        {
            int sid = Convert.ToInt32(Request.QueryString["sid"]);
            Model.ObjSub os = BLL.ObjSub.GetModel(sid);
            if (os.SHInt != 0)
                return "状态已改变，请重试";
            os.SHInt = 1;
            if (BLL.ObjSub.Update(os))
                return "审核合格成功";
            else
                return "审核失败";
        }

        protected override string btnModify_Click()
        {
            int sid = Convert.ToInt32(Request.QueryString["sid"]);
            Model.ObjSub os = BLL.ObjSub.GetModel(sid);
            if (os.SHInt != 0)
                return "状态已改变，请重试";
            os.SHInt = 2;
            if (BLL.ObjSub.Update(os))
                return "审核不合格成功";
            else
                return "审核失败";
        }

        protected override string btnOther_Click()
        {
            string objoid = Request.QueryString["objoid"];
            string grouping = Request.QueryString["grouping"];

            if (string.IsNullOrEmpty(objoid) || string.IsNullOrEmpty(grouping))
                return "请正确输入项目编号和分组";
            var sublist = BLL.ObjSub.GetModelList(" objoid='" + objoid + "' and  grouping='" + grouping + "' ");

            if (sublist.Count <= 0)
                return "未查询到数据";

            if (!TModel.Role.IsAdmin)
            {
                if (sublist.Where(a => a.Grouping != null && a.Grouping != "").Count() > 0)
                    return "已排过序";
            }
            //if (sublist.Count < 30)
            //    return "数据少于30条，请手动操作";

            SqlParameter[] para = new SqlParameter[]
           {
                new SqlParameter("@UID",SqlDbType.VarChar,50),
                new SqlParameter("@Grouping",SqlDbType.VarChar,10)
           };
            para[0].Value = objoid;
            para[1].Value = grouping;
            object xx = DbHelperSQL.ProcGetSingleProc("ZB_sort", para);

            return "排序成功";
        }
    }
}