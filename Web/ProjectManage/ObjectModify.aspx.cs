using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class ObjectModify : BasePage
    {
        public List<Model.ObjChild> listChild = null;
        public List<Model.ObjExcel> listExcel = null;
        protected override void SetPowerZone()
        {
            base.SetPowerZone();
            Random rd = new Random();
            //int dd=rd.Next(100000,999999);
            ObjCode.Value = Guid.NewGuid().ToString("N");
            xxid.Value = Request.QueryString["xxid"];
            Model.OObject objModel = BLL.OObject.GetModel(Convert.ToInt32(Request.QueryString["xxid"]));
            listChild = BLL.ObjChild.GetModelList(" OBJOID = '"+objModel.ObjOID+"' ");
            listExcel = BLL.ObjExcel.GetModelList(" OBJOID = '" + objModel.ObjOID + "' ");
            Remark.Value = objModel.Remark;
            BMstateDate.Value = objModel.BMDate.ToString();
            ComDate.Value = objModel.JGDate.ToString();
            ObjName.Value = objModel.ObjName;
            ObjCode.Value = objModel.ObjOID;
        }

        protected override string btnAdd_Click()
        {
            Hashtable HS = new Hashtable();
            Model.OObject obj = BLL.OObject.GetModel(Convert.ToInt32(Request.Form["xxid"]));
            obj.ObjName = Request.Form["ObjName"];
            obj.Remark = Request.Form["Remark"];
            obj.ObjExcel = "";
            obj.ObjChild = "";
            obj.BMDate = Convert.ToDateTime(Request.Form["BMstateDate"]);
            obj.JGDate = Convert.ToDateTime(Request.Form["ComDate"]);
            if (BLL.OObject.Update(obj))
            {
                return "修改项目成功";
            }
            else {
                return "修改项目失败";
            }

        }
    }
}