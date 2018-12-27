using System;
using System.Collections.Generic;
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
    }
}