using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class SignProject : BasePage
    {
        public Model.OObject obj = null;
        public List<Model.ObjExcel> listExcel = null;
        public List<Model.ObjChild> listChild = null;
        protected string rdstr = "";
        protected override void SetPowerZone()
        {
            int pid = Convert.ToInt32(Request.QueryString["xxid"]);
            oid.Value = pid.ToString();
            obj = BLL.OObject.GetModel(pid);
            listExcel = BLL.ObjExcel.GetModelList(" ObjOID='" + obj.ObjOID + "' ");
            listChild = BLL.ObjChild.GetModelList(" ObjOID='"+obj.ObjOID+"' ");
            Random rd = new Random();
            int cc = rd.Next(1000, 9999);
            roam.Value = cc.ToString();
            roam2.Value = cc.ToString();
            rdstr = cc.ToString();
        }

        protected override string btnAdd_Click()
        {
           
            Model.OObject obj = BLL.OObject.GetModel(Convert.ToInt32( Request.Form["oid"]));

            if (obj.BMDate < DateTime.Now)
                return "已超出报名时间，不能报名";

            Hashtable MyHs = new Hashtable();
            Model.ObjUserApply oua = new Model.ObjUserApply();
            oua.ObjID = obj.ID;
            oua.MID = TModel.MID;
            oua.BaoMingCode = Guid.NewGuid().ToString("N");
            oua.DanWeiName = TModel.MName;
            oua.ZiGeZhengShu = TModel.FMID.Replace("0", "检测机构证书").Replace("1", "个人身份证").Replace("2", "其他");
            oua.ZhengShuCode = TModel.NumID;
            oua.CreateDate = DateTime.Now;
            oua.ComDate = DateTime.MaxValue;
            oua.SubID = Request.Form["ChildValue"];
            oua.BaoMingImgUrl = Request.Form["uploadurl"];
            oua.FeiYongImgUrl = Request.Form["uploadurl2"];
            oua.SState = 0;
            BLL.ObjUserApply.Add(oua,MyHs);


            Model.ObjUser user = new Model.ObjUser();
            user.OID = Guid.NewGuid().ToString("N");
            user.BaoMingOID = oua.BaoMingCode;
            user.ObjID = obj.ID;
            user.ObjName = obj.ObjName;
            user.USState = 0;
            user.CreateDate = DateTime.Now;
            user.DanWeiName = TModel.MName;
            user.RState = 0;
            user.BState = 0;
            user.YState = 0;
            user.YangPinOID = "";
            user.MID = TModel.MID;
            BLL.ObjUser.Add(user,MyHs);
            if (BLL.CommonBase.RunHashtable(MyHs))
                return "报名成功";
            else
                return "报名失败";
        }
    }
}