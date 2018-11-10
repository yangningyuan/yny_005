using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class ObjectView : BasePage
    {
        public Model.OObject obj = null;
        public Model.ObjUser objuser = null;
        public Model.ObjUserApply oapply = null;
        public List<Model.ObjChild> listChild = null;
        public List<Model.ObjExcel> listExcel = null;
        public Model.ObjSample objsample = null;//样品
        public Model.Member tmember = null;

        public Model.ObjSubUser objsubuser = null;//结果信息
        public List<Model.ObjSub> objsublist = null;//结果值
        protected override void SetPowerZone()
        {
            int id = Convert.ToInt32(Request.QueryString["xxid"]);
            uid.Value = id.ToString();
            objuser = BLL.ObjUser.GetModel(id);
            obj = BLL.OObject.GetModel(objuser.ObjID);
            oapply = BLL.ObjUserApply.GetModelOID(objuser.BaoMingOID);
            listChild = BLL.ObjChild.GetModelList(" ID IN(" + oapply.SubID + ") ");
            listExcel = BLL.ObjExcel.GetModelList(" ObjOID='" + obj.ObjOID + "' ");


            objsample = BLL.ObjSample.GetModelOID(objuser.YangPinOID);
            obj = BLL.OObject.GetModel(oapply.ObjID);
            tmember = BLL.Member.GetModelByMID(oapply.MID);


            objsubuser = BLL.ObjSubUser.GetModelList(" SpInt="+obj.ID+" AND MID='"+tmember.MID+"'").FirstOrDefault();
            if (objsubuser != null)
            {
                string[] sublist = objsubuser.Spare.Split(',');
                string substr = "";
                foreach (var item in sublist)
                {
                    if (string.IsNullOrEmpty(item))
                        continue;
                    substr += "'" + item + "',";
                }

                objsublist = BLL.ObjSub.GetModelList(" OID in(" + substr.Substring(0, substr.Length - 1) + ") ");
            }
            
        }
    }
}