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

        
    }
}