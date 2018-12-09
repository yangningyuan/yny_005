using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class ManageProjectList : BasePage
    {
        protected override string btnModify_Click()
        {
            string xx = Request.Form["remsg"];
            Hashtable MyHs = new Hashtable();
            Model.OObject oamodel = BLL.OObject.GetModel(Convert.ToInt32(Request.Form["oid"]));
            if (oamodel.OState != 0)
                return "此状态不能打回";
            oamodel.OState = 2;
            oamodel.ReSpare = xx;
            oamodel.ObjExcel = "";
            oamodel.ObjChild = "";
            
            if (BLL.OObject.Update(oamodel))
            {
                BLL.OperationRecordBLL.Add(TModel.MID,"验证项目打回","OID为："+oamodel.ObjOID);
                return "打回成功";
            }
            else {
                return "验证项目审核打回失败";
            }
        }

        protected override string btnAdd_Click()
        {
            Model.OObject oamodel = BLL.OObject.GetModel(Convert.ToInt32(Request.Form["oid"]));
            if (oamodel.OState != 0)
                return "此状态不能通过";
            oamodel.OState = 3;
            oamodel.ObjExcel = "";
            oamodel.ObjChild = "";
            if (BLL.OObject.Update(oamodel))
            {
                BLL.OperationRecordBLL.Add(TModel.MID, "验证项目通过", "OID为：" + oamodel.ObjOID);
                return "审核通过";
            }
            else {
                return "验证项目审核失败";
            }
        }
    }
}