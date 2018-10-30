using System;
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
        protected string rdstr = "";
        protected override void SetPowerZone()
        {
            int pid = Convert.ToInt32(Request.QueryString["xxid"]);
            obj = BLL.OObject.GetModel(pid);

            Random rd = new Random();
            int cc = rd.Next(1000, 9999);
            roam.Value = cc.ToString();
            rdstr = cc.ToString();
        }

        protected override void SetValue(string id)
        {
            //int pid = Convert.ToInt32(Request.QueryString["id"]);
            Model.OObject obb= BLL.OObject.GetModel(Convert.ToInt32(id));
        }
    }
}