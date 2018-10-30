using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class AddProject : BasePage
    {
        protected override void SetPowerZone()
        {
            base.SetPowerZone();
            Random rd = new Random();
            //int dd=rd.Next(100000,999999);
            ObjCode.Value = Guid.NewGuid().ToString("N");
        }

        protected override string btnAdd_Click()
        {
            Hashtable HS = new Hashtable();
            Model.OObject obj = new Model.OObject();
            obj.ObjName = Request.Form["ObjName"];
            obj.ObjOID = Request.Form["ObjCode"];
            obj.ReObjMID = TModel.MID;
            obj.Remark = Request.Form["Remark"];
            obj.BMDate =Convert.ToDateTime(Request.Form["BMstateDate"]);
            obj.JGDate =Convert.ToDateTime(Request.Form["ComDate"]);
            
            int subcount = Convert.ToInt32(Request.Form["SubAddIndex"]);
            int count = 0;
            for (int i = 1; i <= subcount; i++)
            {
                if (string.IsNullOrEmpty(Request.Form["SubTitle" + i]))
                    continue;
                else {
                    count += 1;
                    Model.ObjChild sub = new Model.ObjChild();
                    sub.OID = Guid.NewGuid().ToString("N");
                    sub.ChildName = Request.Form["SubTitle"+i];
                    sub.ChildValue = Request.Form["SubDetails" + i];
                    BLL.ObjChild.Add(sub,HS);
                }
            }
            if (count <= 0)
                return "请至少填写一项检测子项";


            if (string.IsNullOrEmpty(Request.Form["excelValue"]))
                return "请上传文档";
            string[] xx = Request.Form["excelValue"].Split(',');
            foreach (var item in xx)
            {
                if (string.IsNullOrEmpty(item))
                    continue;
                Model.ObjExcel excel = new Model.ObjExcel();
                excel.OID = Guid.NewGuid().ToString("N");
                excel.ObjOID = obj.ObjOID;
                excel.ExcelName = item.Substring(16, item.Length);
                excel.ExcelUrl = item;
                BLL.ObjExcel.Add(excel,HS);
            }

            if (BLL.CommonBase.RunHashtable(HS))
            {
                return "添加项目成功";
            }
            else {
                return "添加项目失败";
            }

        }

    }
}