﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommonBLL;

namespace yny_005.Web.Member
{
    public partial class Modify : BasePage
    {
        protected string pic = "";
        protected string provice = "";
        protected string City = "";
        protected string rdstr = "";
        protected override void SetPowerZone()
        {
            Random rd = new Random();
            int cc = rd.Next(1000, 9999);
            roam.Value = cc.ToString();
            rdstr = cc.ToString();
            if (!TModel.Role.IsAdmin)
            {
                txtMName.Attributes.Add("readonly", "readonly");

                if (!string.IsNullOrEmpty(TModel.BankCardName))
                {
                }
            }

            MemberModel = TModel;
        }

        protected override void SetValue()
        {
        }

        public Model.Member MemberModel
        {
            get
            {
                Model.Member model = TModel;
                //model.Tel = Request.Form["txtTel"].Trim();
                if (TModel.Role.IsAdmin)
                {
                    model.MName = Request.Form["txtMName"].Trim();
                    model.QRCode = Request.Form["txtQRCode"];
                }
                model.Alipay = Request.Form["txtYouBian"];

                model.BankCardName = Request.Form["txtBankCardName"];
                model.Address = Request.Form["txtAddress"].Trim();
                model.NumID = Request.Form["txtNumID"];
                model.FMID = Request.Form["txtFMID"];
                model.Tel = Request.Form["txtTel"];
                model.QQ = Request.Form["txtQQ"];
                model.Email = Request.Form["txtEmail"];

                model.Province =Request.Form["ddlProvince"].Trim();
                model.City = Request.Form["ddlCity"].Trim();
                model.Zone = Request.Form["ddlZone"].Trim();

                if (TModel.MID == "admin")
                {
                    model.QRCode = Request.Form["uploadurl"];
                }
                if (model.FHState)
                {
                    model.FHState = false;
                }
                return model;
            }
            set
            {
                if (value != null)
                {
                    txtMID.Value = value.MID;
                    txtMName.Value = value.MName;
                    txtNumID.Value = value.NumID;
                    txtFMID.Value = value.FMID;
                    txtAddress.Value = value.Address;
                    txtBankCardName.Value = value.BankCardName;
                    txtTel.Value = value.Tel;
                    txtQQ.Value = value.QQ;

                    ddlProvince.Value = value.Province;
                    ddlCity.Value = value.City;
                    ddlZone.Value = value.Zone;

                    txtYouBian.Value = value.Alipay;
                    txtEmail.Value = value.Email;
                   
                }
            }
        }

        /// <summary>
        /// 更新基本资料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override string btnModify_Click()
        {
            string error = "";

            if (string.IsNullOrEmpty(error))
            {
                if (BllModel.Update(MemberModel))
                {
                    BLL.OperationRecordBLL.Add(TModel.MID, "自助修改资料", "修改资料");
                    return "操作成功";
                }
                return "操作失败";
            }
            return error;
        }



    }
}