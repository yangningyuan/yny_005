using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class SHValidationResult : BasePage
    {
        public Model.OObject obj = null;
        public List<Model.ObjExcel> listExcel = null;
        public List<Model.ObjSub> listChild = null;
        protected string rdstr = "";
        public Model.ObjUser OUSER = null;
        public Model.ObjSubUser OSU = null;
        protected override void SetPowerZone()
        {
            int pid = Convert.ToInt32(Request.QueryString["xxid"]);
            OUSER = BLL.ObjUser.GetModel(pid);
            uid.Value = pid.ToString();// ObjUser ID
            oid.Value = OUSER.ObjID.ToString(); //OObject ID
            obj = BLL.OObject.GetModel(OUSER.ObjID);

            Model.ObjUserApply oA = BLL.ObjUserApply.GetModelOID(OUSER.BaoMingOID);
            listExcel = BLL.ObjExcel.GetModelList(" ObjOID='" + obj.ObjOID + "' ");

            OSU = BLL.ObjSubUser.GetModelList(" MID='" + OUSER.MID + "' AND SpInt=" + obj.ID + " and SState!=3 ").FirstOrDefault();
            osuid.Value = OSU.ID.ToString();
            FangFa.Value = OSU.RFangFa;
            YiQi.Value = OSU.RSheBei;
            YiChang.Value = OSU.RYiChang;

            string[] sublist = OSU.Spare.Split(',');
            string substr = "";
            foreach (var item in sublist)
            {
                if (string.IsNullOrEmpty(item))
                    continue;
                substr += "'" + item + "',";
            }

            listChild = BLL.ObjSub.GetModelList(" OID in(" + substr.Substring(0, substr.Length - 1) + ") ");
            Random rd = new Random();
            int cc = rd.Next(1000, 9999);
            rdstr = cc.ToString();
        }

        protected override string btnAdd_Click()
        {
            Model.ObjUser ouser = BLL.ObjUser.GetModel(Convert.ToInt32( Request.Form["uid"]));
            Model.ObjSubUser Osubuser = BLL.ObjSubUser.GetModel(Convert.ToInt32(Request.Form["osuid"]));

            Hashtable MyHs = new Hashtable();
            if (ouser.RState != 1)
                return "状态已更新，请刷新";
            ouser.RState = 3;
            ouser.USState = 3;
            ouser.RDate = DateTime.Now;
            ouser.ZhengShuCode = Guid.NewGuid().ToString("D");
            BLL.ObjUser.Update(ouser);

            Osubuser.SState = 3;
            BLL.ObjSubUser.Update(Osubuser,MyHs);

            Model.ObjUserApply oua= BLL.ObjUserApply.GetModelOID(ouser.BaoMingOID);
            oua.YZState = 1;
            BLL.ObjUserApply.Update(oua,MyHs);


            if (BLL.CommonBase.RunHashtable(MyHs))
            {
                BLL.OperationRecordBLL.Add(TModel.MID, "验证结果审核成功", "项目名称为：" + ouser.ObjName+"，结果提交人为："+ouser.MID);
                return "审核成功";
            }
            else
                return "审核失败";
        }

        protected override string btnModify_Click()
        {
            Model.ObjUser ouser = BLL.ObjUser.GetModel(Convert.ToInt32(Request.Form["uid"]));
            Model.ObjSubUser Osubuser = BLL.ObjSubUser.GetModel(Convert.ToInt32(Request.Form["osuid"]));

            Hashtable MyHs = new Hashtable();
            if (ouser.RState != 1)
                return "状态已更新，请刷新";
            ouser.RState = 0;
            ouser.RImgUrl = "";
            BLL.ObjUser.Update(ouser,MyHs);

           
            BLL.ObjSubUser.Delete(Osubuser.ID, MyHs);

            string[] sublist = Osubuser.Spare.Split(',');
            string substr = "";
            foreach (var item in sublist)
            {
                if (string.IsNullOrEmpty(item))
                    continue;
                substr += "'" + item + "',";
            }
            MyHs.Add("DELETE OBJSUB WHERE OID IN("+ substr.Substring(0,substr.Length-1) + ");select " + Guid.NewGuid().ToString("N"),null);
            if (BLL.CommonBase.RunHashtable(MyHs))
            {
                BLL.OperationRecordBLL.Add(TModel.MID, "验证结果审核打回", "项目名称为：" + ouser.ObjName + "，结果提交人为：" + ouser.MID);
                return "返回成功，可重新上传结果";
            }
            else
                return "审核失败";
        }
    }
}