using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class ValidationResult : BasePage
    {
        public Model.OObject obj = null;
        public List<Model.ObjExcel> listExcel = null;
        public List<Model.ObjChild> listChild = null;
        protected string rdstr = "";
        public Model.ObjUser OUSER = null;
        protected override void SetPowerZone()
        {
            int pid = Convert.ToInt32(Request.QueryString["xxid"]);
            OUSER=BLL.ObjUser.GetModel(pid);
            uid.Value = pid.ToString();
            oid.Value = OUSER.ObjID.ToString();
            obj = BLL.OObject.GetModel(OUSER.ObjID);

            Model.ObjUserApply oA = BLL.ObjUserApply.GetModelOID(OUSER.BaoMingOID);
            listExcel = BLL.ObjExcel.GetModelList(" ObjOID='" + obj.ObjOID + "' ");
            listChild = BLL.ObjChild.GetModelList(" ID in(" + oA.SubID+ ") ");
            Random rd = new Random();
            int cc = rd.Next(1000, 9999);
            roam.Value = cc.ToString();
            rdstr = cc.ToString();
        }

        protected override string btnAdd_Click()
        {
            Hashtable MyHs = new Hashtable();

            Model.ObjUser OU = BLL.ObjUser.GetModel(Convert.ToInt32(Request.Form["uid"]));
            if (Convert.ToInt32(BLL.CommonBase.GetSingle("select COUNT(*) from ObjSubUser where mid='" + TModel.MID + "' AND SpInt='" + OU.ObjID + "';")) > 0)
            {
                return "您已提交过结果，请等待审核";
            }

            OU.RState = 1;
            OU.RImgUrl= Request.Form["uploadurl"];
            OU.RUpLoadDate = DateTime.Now;
            BLL.ObjUser.Update(OU,MyHs);

            Model.ObjUserApply oA = BLL.ObjUserApply.GetModelOID(OU.BaoMingOID);
            List<Model.ObjChild> listChild2 = BLL.ObjChild.GetModelList(" ID in(" + oA.SubID + ") ");
            string suboid = "";
            foreach (var item in listChild2)
            {
                string childone= Request.Form["ChildOne" + item.ID.ToString()];
                string childtwo = Request.Form["ChildTwo" + item.ID.ToString()];
                string childavg = Request.Form["ChildAvg" + item.ID.ToString()];

                if (string.IsNullOrEmpty(childone) || string.IsNullOrEmpty(childtwo) || string.IsNullOrEmpty(childavg))
                    return "请填入结果值";
                Model.ObjSub OSub = new Model.ObjSub();
                OSub.MID = TModel.MID;
                OSub.OID = Guid.NewGuid().ToString("N");
                OSub.ResultOne = childone;
                OSub.ResultTwo = childtwo;
                OSub.ResultAvg = childavg;
                OSub.Spare = item.ChildName;
                BLL.ObjSub.Add(OSub, MyHs);
                suboid += OSub.OID+",";
            }

            Model.ObjSubUser objapply = new Model.ObjSubUser();
            objapply.MID = TModel.MID;
            objapply.RFangFa = Request.Form["FangFa"];
            objapply.RSheBei = Request.Form["YiQi"];
            objapply.RYiChang = Request.Form["YiChang"];
            objapply.ResultImgUrl = Request.Form["uploadurl"];
            objapply.SpInt = Convert.ToInt32(Request.Form["oid"]);
            objapply.MID = TModel.MID;
            objapply.SState = 0;
            objapply.Spare = suboid.Substring(0,suboid.Length-1);
            BLL.ObjSubUser.Add(objapply, MyHs);
            if (BLL.CommonBase.RunHashtable(MyHs))
            {
                BLL.OperationRecordBLL.Add(TModel.MID, "结果提交", "项目名称为：" + obj.ObjName);
                return "结果提交成功，请等待审核";
            }
            else {
                return "提交失败";
            }
        }
    }
}