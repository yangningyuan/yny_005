using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.Home
{
    public partial class Index : BasePageNoLogin
    {
        public List<Model.OObject> listObj = null;
        public List<Model.Notice> listNote = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            listNote= BLL.Notice.GetNoticeLists(15, false);
            listObj = BLL.OObject.GetModelList("  BMDate>'" + DateTime.Now + "' and SState=0 and OState=3  ");
        }
    }
}