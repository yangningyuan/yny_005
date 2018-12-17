using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.Member
{
    public partial class List : BasePage
    {
        protected string RoleListStr;
        protected int OnLineCount;
        protected string AgencyListStr;
        protected string NAgencyListStr;

        protected override void SetPowerZone()
        {
            if (!TModel.Role.IsAdmin)
            {
                editMember.Visible = false;
            }
            foreach (Model.Roles item in BLL.Roles.RolsList.Values.ToList().Where(emp => emp.VState).ToList())
                RoleListStr += "<option value='" + item.RType + "'>" + item.RName + "</option>";
            foreach (Model.SHMoney item in BLL.Configuration.Model.SHMoneyList.Values.ToList())
                AgencyListStr += "<option value='" + item.MAgencyType + "'>" + item.MAgencyName + "</option>";
            //foreach (Model.NewSHMoney item in BLL.Configuration.Model.NewSHMoneyList.Values.ToList())
            //    NAgencyListStr += "<option value='" + item.NType + "'>" + item.NName + "</option>";
            OnLineCount = BLL.Member.OnLineCount;
        }
		protected override string btnAdd_Click()
		{
            Hashtable MyHs = new Hashtable();
            string mid= Request.Form["MID"];
            Model.Member member = BLL.Member.GetModelByMID(mid);
            
            BLL.Member.UpdateMemberTran(mid, "MState", "1", member, true, System.Data.SqlDbType.Bit, MyHs);
            BLL.Member.UpdateMemberTran(mid, "MDate",DateTime.Now.ToString(), member, true, System.Data.SqlDbType.DateTime, MyHs);
            if (BLL.CommonBase.RunHashtable(MyHs))
            {
                return "审核完成";
            }
            else {
                return "审核失败";
            }
		}


        protected override string btnOther_Click()
        {
            Hashtable MyHs = new Hashtable();
            string mid = Request.Form["MID"];
            string remsg = Request.Form["remsg"];
            Model.Member member = BLL.Member.GetModelByMID(mid);
            //设为已审核
            BLL.Member.UpdateMemberTran(mid, "FHState", "1", member, true, System.Data.SqlDbType.Bit, MyHs);
            BLL.Member.UpdateMemberTran(mid, "Country", remsg, member, true, System.Data.SqlDbType.VarChar, MyHs);
            if (BLL.CommonBase.RunHashtable(MyHs))
            {
                return "设置不通过成功";
            }
            else {
                return "设置失败";
            }
        }
        protected override string btnModify_Click()
        {
            try
            {
                string req = Request.Form["gid"];
                Model.Goods cc = BLL.Goods.GetModel(int.Parse(req));
                if (cc != null)
                {
                    return cc.Unit;
                }
                else {
                    return "-1";
                }
            }
            catch (Exception e)
            {
                return "-1";
            }
        }
        
    }
}