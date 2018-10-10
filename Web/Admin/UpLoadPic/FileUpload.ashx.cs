using Microsoft.SqlServer.Management.Sdk.Sfc;
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

        private static JavaScriptSerializer jss = new JavaScriptSerializer();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            for (int i = 0; i < context.Request.Files.Count; i++)
            {
                try
                {
                    var file = context.Request.Files[i]; //获取选中文件  
                    var filecombin = file.FileName.Split('.');
                    if (file == null || String.IsNullOrEmpty(file.FileName) || file.ContentLength == 0 || filecombin.Length < 2)
                    {
                        var data=new
                        {
                            fileid = 0,
                            src = "",
                            name = "",
                            msg = "上传出错 请检查文件名 或 文件内容"
                        };

                        StringBuilder stringBuilder = new StringBuilder();
                        JavaScriptSerializer json = new JavaScriptSerializer(); json.Serialize(myInfo, stringBuilder);

                        return data.ToJson();
                    }
                    //定义本地路径位置
                    string local = "/plugin/layui/images";
                    string filePathName = string.Empty;
                    string localPath = Path.Combine(HttpRuntime.AppDomainAppPath, local);

                    var tmpName = context.Server.MapPath("~/plugin/layui/images");
                    var tmp = file.FileName;
                    var tmpIndex = 0;
                    //判断是否存在相同文件名的文件 相同累加1继续判断
                    while (System.IO.File.Exists(tmpName + tmp))
                    {
                        tmp = filecombin[0] + "_" + ++tmpIndex + "." + filecombin[1];
                    }

                    //不带路径的最终文件名
                    filePathName = tmp;
                    if (!System.IO.Directory.Exists(localPath))
                        System.IO.Directory.CreateDirectory(localPath);
                    string localURL = Path.Combine(local, filePathName);
                    file.SaveAs(Path.Combine(localPath, filePathName));   //保存图片（文件夹）
                                                                          //return Json(new
                                                                          //{
                                                                          //    src = localURL.Trim().Replace("\\", "|"),
                                                                          //    name = Path.GetFileNameWithoutExtension(file.FileName),   // 获取文件名不含后缀名
                                                                          //    msg = "上传成功"
                                                                          //});
                }
                catch { }
                //return Json(new
                //{
                //    src = "",
                //    name = "",   // 获取文件名不含后缀名
                //    msg = "上传出错"
                //});
            }
        }
        /// <summary>
        /// 创建一个指定长度的随机alt值
        /// </summary>
        public string CreateSalt(int saltLenght)
        {
            //生成一个加密的随机数
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[saltLenght];
            rng.GetBytes(buff);
            //返回一个Base64随机数的字符串
            return Convert.ToBase64String(buff);
        }
        /// <summary>
        /// 返回加密后的字符串
        /// </summary>
        public string CreatePasswordHash(string pwd, int saltLenght)
        {
            string strSalt = CreateSalt(saltLenght);
            //把密码和Salt连起来
            string saltAndPwd = String.Concat(pwd, strSalt);
            //对密码进行哈希
            string hashenPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(saltAndPwd, "sha1");
            //转为小写字符并截取前16个字符串
            hashenPwd = hashenPwd.ToLower().Substring(0, 16);
            //返回哈希后的值
            return hashenPwd;
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