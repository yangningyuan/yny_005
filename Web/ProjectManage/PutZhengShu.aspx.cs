﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yny_005.Web.ProjectManage
{
    public partial class PutZhengShu : BasePage
    {
        public string HardUrl = "";
        public Model.ObjUser obj = null;
        public Model.ObjUserApply userapply = null;
        public string JGDate = "";
        protected override void SetPowerZone()
        {
            HardUrl = BLL.Member.ManageMember.TModel.QRCode;
            int xxid = Convert.ToInt32(Request.QueryString["xxid"]);
            obj = BLL.ObjUser.GetModel(xxid);
            JGDate = Baodate2Chinese(Convert.ToDateTime(obj.RDate).ToString("yyyy-MM-dd"));
            userapply = BLL.ObjUserApply.GetModelOID(obj.BaoMingOID);
            

        }


        private static string Baodate2Chinese(string strDate)
        {
            char[] strChinese = new char[] {
                 '〇','一','二','三','四','五','六','七','八','九','十'
             };
            StringBuilder result = new StringBuilder();

            //// 依据正则表达式判断参数是否正确
            //Regex theReg = new Regex(@"(d{2}|d{4})(/|-)(d{1,2})(/|-)(d{1,2})");

            if (!string.IsNullOrEmpty(strDate))
            {
                // 将数字日期的年月日存到字符数组str中
                string[] str = null;
                if (strDate.Contains("-"))
                {
                    str = strDate.Split('-');
                }
                else if (strDate.Contains("/"))
                {
                    str = strDate.Split('/');
                }
                // str[0]中为年，将其各个字符转换为相应的汉字
                for (int i = 0; i < str[0].Length; i++)
                {
                    result.Append(strChinese[int.Parse(str[0][i].ToString())]);
                }
                result.Append("年");

                // 转换月
                int month = int.Parse(str[1]);
                int MN1 = month / 10;
                int MN2 = month % 10;

                if (MN1 > 1)
                {
                    result.Append(strChinese[MN1]);
                }
                if (MN1 > 0)
                {
                    result.Append(strChinese[10]);
                }
                if (MN2 != 0)
                {
                    result.Append(strChinese[MN2]);
                }
                result.Append("月");

                // 转换日
                int day = int.Parse(str[2]);
                int DN1 = day / 10;
                int DN2 = day % 10;

                if (DN1 > 1)
                {
                    result.Append(strChinese[DN1]);
                }
                if (DN1 > 0)
                {
                    result.Append(strChinese[10]);
                }
                if (DN2 != 0)
                {
                    result.Append(strChinese[DN2]);
                }
                result.Append("日");
            }
            else
            {
                throw new ArgumentException();
            }

            return result.ToString();
        }
    }
}