using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class ModifySignProject : BasePage
    {
        public Model.OObject obj = null;
        public List<Model.ObjExcel> listExcel = null;
        public List<Model.ObjChild> listChild = null;
        public Model.ObjUserApply oua = null;
        protected string rdstr = "";
        protected override void SetPowerZone()
        {
            int pid = Convert.ToInt32(Request.QueryString["xxid"]);
            oid.Value = pid.ToString();

            int bm = Convert.ToInt32(Request.QueryString["bmid"]);
            bmid.Value = bm.ToString();

            oua = BLL.ObjUserApply.GetModel(bm);
            uploadurl.Value = oua.BaoMingImgUrl;
            uploadurl2.Value = oua.FeiYongImgUrl;


            obj = BLL.OObject.GetModel(pid);
            listExcel = BLL.ObjExcel.GetModelList(" ObjOID='" + obj.ObjOID + "' ");
            listChild = BLL.ObjChild.GetModelList(" ObjOID='" + obj.ObjOID + "' ");
            Random rd = new Random();
            int cc = rd.Next(1000, 9999);
            roam.Value = cc.ToString();
            roam2.Value = cc.ToString();
            rdstr = cc.ToString();
        }

        protected override string btnAdd_Click()
        {
            Model.ObjUserApply oua = BLL.ObjUserApply.GetModel(Convert.ToInt32(Request.Form["bmid"]));
            if (oua.SState!=1)
                return "此状态不能修改报名信息";

            Model.OObject obj = BLL.OObject.GetModel(Convert.ToInt32(Request.Form["oid"]));

            if (obj.BMDate < DateTime.Now)
                return "已超出报名时间，不能修改";

            Hashtable MyHs = new Hashtable();
          
            oua.CreateDate = DateTime.Now;
            oua.ComDate = DateTime.MaxValue;
            oua.SubID = Request.Form["ChildValue"];
            oua.BaoMingImgUrl = Request.Form["uploadurl"];
            oua.FeiYongImgUrl = Request.Form["uploadurl2"];
            oua.SState = 0;
            oua.ReSpare = "";
            BLL.ObjUserApply.Update(oua, MyHs);

            Model.ObjUser oumodel = BLL.ObjUser.GetModelBaoMingOID(oua.BaoMingCode);
            oumodel.BState = 0;
            BLL.ObjUser.Update(oumodel, MyHs);
            if (BLL.CommonBase.RunHashtable(MyHs))
            {
                BLL.OperationRecordBLL.Add(TModel.MID, "修改报名信息", "报名编号为：" + oua.BaoMingCode);
                return "报名修改成功";
            }
            else
            {
                return "报名修改失败";
            }
        }
    }
}