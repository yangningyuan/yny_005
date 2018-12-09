using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.Home
{
    public partial class HomeProjectDetails : BasePageNoLogin
    {
        public Model.OObject obj = null;
        public List<Model.ObjChild> listChild = null;
        public List<Model.ObjExcel> listExcel = null;
        protected void Page_Load(object sender, EventArgs e)
        {
             obj= BLL.OObject.GetModel(Convert.ToInt32(Request.QueryString["oid"]));
            listChild = BLL.ObjChild.GetModelList(" OBJOID = '" + obj.ObjOID + "' ");
            listExcel = BLL.ObjExcel.GetModelList(" OBJOID = '" + obj.ObjOID + "' ");
        }
    }
}