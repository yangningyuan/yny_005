using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class ModifyResult : BasePage
    {
        protected string id = "";
        protected override void SetPowerZone()
        {
            id = Request.QueryString["rid"];
            rid.Value = id;
            var sub= BLL.ObjSub.GetModel(Convert.ToInt32(id));
            Serial.Value = sub.Serial;
            Grouping.Value = sub.Grouping;
            ZB.Value = sub.ZB;
            Q1.Value = sub.Q1;
            Q2.Value = sub.Q2;
            IRQ.Value = sub.IRQ;
            M.Value = sub.M;
            NIRQ.Value = sub.NIRQ;
            ResultStatus.Value = sub.ResultStatus;

        }

        protected override string btnModify_Click()
        {
            Hashtable MyHs = new Hashtable();
           
            var account = BLL.ObjSub.GetModel(Convert.ToInt32(Request.Form["rid"]));

            account.Serial = Request.Form["Serial"];
            account.Grouping = Request.Form["Grouping"];
            account.ZB = Request.Form["ZB"];
            account.Q1 = Request.Form["Q1"];
            account.Q2 = Request.Form["Q2"];
            account.IRQ = Request.Form["IRQ"];
            account.M = Request.Form["M"];
            account.NIRQ = Request.Form["NIRQ"];
            account.ResultStatus = Request.Form["ResultStatus"];
            BLL.ObjSub.Update(account, MyHs);
            if (BLL.CommonBase.RunHashtable(MyHs))
            {
                return "修改成功";
            }
            else {
                return "修改失败";
            }

        }
    }
}