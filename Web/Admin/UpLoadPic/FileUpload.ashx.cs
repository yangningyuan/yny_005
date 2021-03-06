﻿using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace yny_005.Web.Admin.UpLoadPic
{
    /// <summary>
    /// FileUpload 的摘要说明
    /// </summary>
    public class FileUpload : IHttpHandler
    {


        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Request.ContentEncoding = System.Text.Encoding.GetEncoding("UTF-8");
            context.Response.Charset = "UTF-8";
            try
            {
                if (context.Request.Files.Count > 0)
                {
                    string goodspath = HttpContext.Current.Server.MapPath("Upload/Contract");  //用来生成文件夹
                    if (!Directory.Exists(goodspath))
                    {
                        Directory.CreateDirectory(goodspath);
                    }
                    else
                    {
                        //返回图片路径
                        var returnImgUrl = string.Empty;

                        Random rd = new Random();
                        int num = rd.Next(10000,99999);

                        //如果上传路径存在
                        HttpPostedFile file = context.Request.Files["Filedata"];
                        string imgname = file.FileName.Replace(" ","");
                        string imgType = imgname.Substring(imgname.LastIndexOf(".") + 1);
                        string name = imgname.Substring(0,imgname.LastIndexOf(".") );
                        string quanname = num+"_"+ name + "." + imgType;
                        string filePath = Path.Combine(goodspath, quanname);
                        returnImgUrl = "/Admin/UpLoadPic/Upload/Contract/" + quanname + ";";
                        file.SaveAs(filePath);
                        context.Response.Write(returnImgUrl);
                    }
                }
            }
            catch (Exception ex)
            {
            }

        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}