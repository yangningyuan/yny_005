using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class SHSignProject : BasePage
    {
        public Model.OObject obj = null;
        public Model.ObjUserApply oapply = null;
        public List<Model.ObjChild> listChild = null;
        public Model.Member tmember = null;
        protected override void SetPowerZone()
        {
            int oid = Convert.ToInt32(Request.QueryString["xxid"]);
            oaid.Value = oid.ToString();
            oapply = BLL.ObjUserApply.GetModel(oid);
            listChild = BLL.ObjChild.GetModelList(" ID IN(" + oapply.SubID+ ") ");
            obj = BLL.OObject.GetModel(oapply.ObjID);
            tmember= BLL.Member.GetModelByMID(oapply.MID);
        }

        protected override string btnAdd_Click()
        {
            Hashtable MyHs = new Hashtable();
            Model.ObjUserApply oamodel= BLL.ObjUserApply.GetModel(Convert.ToInt32(Request.Form["oaid"]));
            oamodel.SState = 3;
            BLL.ObjUserApply.Update(oamodel,MyHs);

            Model.ObjUser oumodel = BLL.ObjUser.GetModelBaoMingOID(oamodel.BaoMingCode);
            oumodel.BState = 3;
            BLL.ObjUser.Update(oumodel,MyHs);

            Model.Member bmmember= BLL.Member.GetModelByMID(oamodel.MID);
            //添加样品表
            Model.ObjSample ObjS = new Model.ObjSample();
            ObjS.ObjID = oamodel.ObjID;
            ObjS.MID = oamodel.MID;
            ObjS.YangPinCode = "";
            ObjS.CreateDate = DateTime.Now;
            ObjS.SState = 0;
            ObjS.SpInt = oumodel.ID;
            ObjS.Spare = bmmember.Address;
            ObjS.OID = Guid.NewGuid().ToString("N");
            ObjS.OjbOID = oumodel.OID;
            BLL.ObjSample.Add(ObjS,MyHs);

            if (BLL.CommonBase.RunHashtable(MyHs))
            {
                return "审核成功";
            }
            else {
                return "报名审核失败";
            }
        }
    }
}