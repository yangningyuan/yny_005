using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class AddResultDown : BasePage
    {
        public Model.OObject obj = null;
        public Model.ObjUser objuser = null;

        public List<string> listDown = null;
        protected override void SetPowerZone()
        {
            int id = Convert.ToInt32(Request.QueryString["xxid"]);
            oid.Value = id.ToString();

            objuser = BLL.ObjUser.GetModel(id);
            obj = BLL.OObject.GetModel(objuser.ObjID);

            if (!string.IsNullOrEmpty(objuser.Spare))
            {
                listDown = objuser.Spare.Split(';').ToList();
                //foreach (var item in xx)
                //{
                //    if (!string.IsNullOrEmpty(item))
                //    {
                //        listDown.Add(item);
                //    }
                //}
            }
        }
        /// <summary>
        /// 添加文档
        /// </summary>
        /// <returns></returns>
        protected override string btnAdd_Click()
        {
            if (string.IsNullOrEmpty(Request.Form["excelValue"]))
                return "请上传文档";
            string xx = Request.Form["excelValue"];

            Model.ObjUser objmodel = BLL.ObjUser.GetModel(Convert.ToInt32(Request.Form["oid"]));
            if (objmodel == null)
                return "未查询到实体";

            objmodel.Spare = xx.Substring(0,xx.Length-1);
            if (BLL.ObjUser.Update(objmodel))
                return "上载成功";
            else
                return "上载失败，请重试";
        }
    }
}