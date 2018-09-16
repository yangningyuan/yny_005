﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.autoaspx
{
    public partial class hour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (string.IsNullOrEmpty(Request.QueryString["hour"]) || Request.QueryString["hour"] != "yny_005")
                    return;
                //if (yny_005.BLL.Configuration.Model.B_AutoJS)
                {
                    string error = "";
                    try
                    {
                        if (BLL.ChangeMoney.TX())
                        {
                            error += "操作成功！";
                        }
                        else
                        {
                            error += "操作失败！";
                        }
                        BLL.Task.SendManage(BLL.Member.ManageMember.TModel, "每天", error);
                    }
                    catch (Exception ex)
                    {
                        BLL.Task.SendManage(BLL.Member.ManageMember.TModel, "每小时", ex.ToString());
                    }

                    Response.Write(error);
                }
            }
        }
    }
}