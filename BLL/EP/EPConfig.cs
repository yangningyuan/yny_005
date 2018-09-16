using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Collections;
using System.Data;

namespace yny_005.BLL
{
    //EPConfig
    public class EPConfig
    {
        public static Model.EPConfig EPConfigModel
        {
            get
            {
                return DAL.EPConfig.EPConfigModel;
            }
            set
            {
                DAL.EPConfig.EPConfigModel = value;
            }
        }
        public static yny_005.Model.EPConfig GetModel()
        {
            return yny_005.DAL.EPConfig.GetModel();
        }

        public static bool Update(yny_005.Model.EPConfig model)
        {
            return yny_005.DAL.EPConfig.Update(model);
        }

        public static bool ResetEP()
        {
            return yny_005.DAL.EPConfig.ResetEP();
        }
    }
}
