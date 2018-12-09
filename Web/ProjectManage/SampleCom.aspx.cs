using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class SampleCom : BasePage
    {
        protected override string btnAdd_Click()
        {
            Hashtable MyHs = new Hashtable();
            Model.ObjSample os = BLL.ObjSample.GetModel(Convert.ToInt32(Request.Form["oaid"]));

            Model.ObjUser ou = BLL.ObjUser.GetModel(os.SpInt);
            if (os.SState != 1)
                return "状态已改变，请刷新页面";

            os.YangPinImgUrl = Request.Form["uploadurl"];
            os.SState = 3;
            BLL.ObjSample.Update(os, MyHs);
            ou.YState = 3;
            ou.YangPinOID = os.OID;
            BLL.ObjUser.Update(ou, MyHs);
            if (BLL.CommonBase.RunHashtable(MyHs))
            {
                BLL.OperationRecordBLL.Add(TModel.MID, "确认样品成功", "样品编号为：" + os.YangPinCode);
                return "确认样品成功";
            }
            else
            {
                return "确认失败";
            }
        }

        protected override string btnModify_Click()
        {
            Hashtable MyHs = new Hashtable();
            Model.ObjSample os = BLL.ObjSample.GetModel(Convert.ToInt32(Request.Form["oaid"]));

            Model.ObjUser ou = BLL.ObjUser.GetModel(os.SpInt);
            if (os.SState != 1)
                return "状态已改变，请刷新页面";

            os.SState = 2;
            BLL.ObjSample.Update(os, MyHs);
            ou.YState = 2;
            ou.YangPinOID = os.OID;
            BLL.ObjUser.Update(ou, MyHs);
            if (BLL.CommonBase.RunHashtable(MyHs))
            {
                BLL.OperationRecordBLL.Add(TModel.MID, "返回重新寄送", "样品编号为：" + os.YangPinCode);
                return "已返回重新寄送";
            }
            else
            {
                return "返回失败";
            }
        }

        public Model.ObjSample objS = null;
        public Model.ObjUser objU = null;
        public Model.ObjUserApply objA = null;
        public List<Model.ObjChild> listChild = null;
        public Model.Member BMMember = null;
        public List<Model.ObjExcel> listExcel = null;
        protected string rdstr = "";
        protected override void SetPowerZone()
        {
            int oid = Convert.ToInt32(Request.QueryString["xxid"]);
            oaid.Value = oid.ToString();
            objS = BLL.ObjSample.GetModel(oid);
            objU = BLL.ObjUser.GetModelOID(objS.OjbOID);
            objA = BLL.ObjUserApply.GetModelOID(objU.BaoMingOID);
            listChild = BLL.ObjChild.GetModelList(" ID IN(" + objA.SubID + ") ");
            BMMember = BLL.Member.GetModelByMID(objA.MID);
            Model.OObject objO = BLL.OObject.GetModel(objS.ObjID);

            listExcel = BLL.ObjExcel.GetModelList(" ObjOID='" + objO.ObjOID + "' ");

            Random rd = new Random();
            int cc = rd.Next(1000, 9999);
            roam.Value = cc.ToString();
            rdstr = cc.ToString();
        }
    }
}