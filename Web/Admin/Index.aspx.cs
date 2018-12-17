using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.Admin
{
    public partial class Index : BasePage
    {
        private List<Model.RolePowers> listPowers;
        public List<Model.OObject> listObj = null;

        public int 已完成验证 = 0;

        public int 正在进行中 = 0;

        public int 报名资格未通过 = 0;
        public int 报名资格审核通过 = 0;
        public int 样品已寄出 = 0;
        public string Homebtn = "";

        public int 是否修改 = 0;

        protected override void SetPowerZone()
        {

            if (TModel.FHState && !TModel.MState)
            {
                是否修改 = 1;
            }

            if (TModel.RoleCode != "Nomal")
            {
                Homebtn = "callhtml('/ProjectManage/MProjectList.aspx','MD用户项目列表');onclickMenu()";
            }

            listPowers = TModel.Role.PowersList.Where(emp => emp.Content.VState).ToList();
            listObj= BLL.OObject.GetModelList("  BMDate>'"+DateTime.Now+"' and sstate=0 ");

            if (TModel.RoleCode == "DW")
            {
                listObj = BLL.OObject.GetModelList("  BMDate>'" + DateTime.Now + "' and sstate=0 AND REOBJMID='"+TModel.MID+"' ");
            }


            if (TModel.RoleCode == "Manage")
            {
                已完成验证 = Convert.ToInt32(BLL.CommonBase.GetSingle(" select COUNT(*) from ObjUser where  USState=3; "));
            }
            else {
                已完成验证 = Convert.ToInt32(BLL.CommonBase.GetSingle(" select COUNT(*) from ObjUser where MID='" + TModel.MID + "' and USState=3; "));
            }

            if (TModel.RoleCode == "Manage")
            {
                正在进行中 = Convert.ToInt32(BLL.CommonBase.GetSingle(" select COUNT(*) from ObjUser where  USState!=3; "));
            }
            else {
                正在进行中 = Convert.ToInt32(BLL.CommonBase.GetSingle(" select COUNT(*) from ObjUser where MID='" + TModel.MID + "' and USState!=3; "));
            }

            if (TModel.RoleCode == "Manage")
            {
                报名资格未通过 = Convert.ToInt32(BLL.CommonBase.GetSingle(" select COUNT(*) from ObjUserApply where  SState!=3; "));
            }
            else {
                报名资格未通过 = Convert.ToInt32(BLL.CommonBase.GetSingle(" select COUNT(*) from ObjUserApply where MID='" + TModel.MID + "' and SState!=3; "));
            }
            if (TModel.RoleCode == "Manage")
            {
                报名资格审核通过 = Convert.ToInt32(BLL.CommonBase.GetSingle(" select COUNT(*) from ObjUserApply where  SState=3; "));
            }
            else {
                报名资格审核通过 = Convert.ToInt32(BLL.CommonBase.GetSingle(" select COUNT(*) from ObjUserApply where MID='" + TModel.MID + "' and SState=3; "));
            }
            if (TModel.RoleCode == "Manage")
            {
                样品已寄出 = Convert.ToInt32(BLL.CommonBase.GetSingle(" select COUNT(*) from ObjSample where  SState>0; "));
            }
            else {
                样品已寄出 = Convert.ToInt32(BLL.CommonBase.GetSingle(" select COUNT(*) from ObjSample where MID='" + TModel.MID + "' and SState>0; "));
            }

        }

        protected List<Model.RolePowers> GetPowers(string cfid)
        {
            return listPowers.Where(emp => emp.Content.CFID == cfid).ToList();
        }

        protected List<Model.RolePowers> GetQuickMenu()
        {
            List<Model.RolePowers> list = listPowers.Where(emp => emp.Content.IsQuickMenu).ToList();
            return list;
        }
    }
}