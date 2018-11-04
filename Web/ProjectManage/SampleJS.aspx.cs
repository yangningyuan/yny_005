using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class SampleJS : BasePage
    {
        protected override string btnAdd_Click()
        {
            Hashtable MyHs = new Hashtable();
            Model.ObjSample os= BLL.ObjSample.GetModel(Convert.ToInt32(Request.Form["oaid"]));

            Model.ObjUser ou = BLL.ObjUser.GetModel(os.SpInt);
            if (os.SState != 0 && os.SState != 2)
                return "状态已改变，请刷新页面";

            os.YangPinCode = Request.Form["YangPinCode"];
            os.SState = 1;
            BLL.ObjSample.Update(os,MyHs);
            ou.YState = 1;
            ou.YangPinOID = os.OID;
            BLL.ObjUser.Update(ou,MyHs);
            if (BLL.CommonBase.RunHashtable(MyHs))
                return "寄送成功";
            else
            {
                return "寄送失败";
            }
        }
        public Model.ObjSample objS = null;
        public Model.ObjUser objU = null;
        public Model.ObjUserApply objA = null;
        public List<Model.ObjChild> listChild = null;
        public Model.Member BMMember=null;
        protected override void SetPowerZone()
        {
            int oid = Convert.ToInt32(Request.QueryString["xxid"]);
            oaid.Value = oid.ToString();
            objS = BLL.ObjSample.GetModel(oid);
            YangPinCode.Value = objS.YangPinCode;
            objU = BLL.ObjUser.GetModelOID(objS.OjbOID);
            objA = BLL.ObjUserApply.GetModelOID(objU.BaoMingOID);
            listChild = BLL.ObjChild.GetModelList(" ID IN(" + objA.SubID + ") ");
            BMMember = BLL.Member.GetModelByMID(objA.MID);
        }

    }
}