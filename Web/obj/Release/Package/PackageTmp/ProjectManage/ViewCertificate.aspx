<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCertificate.aspx.cs" Inherits="yny_005.Web.ProjectManage.ViewCertificate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>查看证书</title>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <script>
        layui.use("upload", function () {
            layui.upload({
                url: '/Admin/UpLoadPic/UploadImage.ashx',
                success: function (res) {
                    console.log(res); //上传成功返回值，必须为json格式
                    if (res.isSuccess) {
                        $("#upimage").attr("src", res.msg);
                        $("#uploadurl").val(res.msg);
                    } else {
                        v5.alert(res.msg, '1', 'true')
                    }
                }
            });
        });

    </script>
</head>
<body>
    <div id="mempay">
        <div id="finance">
            <form id="form1">
                <input type="hidden" id="fid" runat="server" />
                <input type="hidden" id="oid" runat="server" />
                <table cellpadding="0" cellspacing="0">
                    <tr>
                        <td colspan="2">
                            <b style="margin-left: 5%;">能力验证满意实验室证书<br /><span style="color:red;margin-left: 5%; ">编号：HNNLYZ-2018-01-001</span> </b>
                        </td>
                    </tr>
                       <tr>
                        <td width="15%" align="right">证书
                        </td>
                        <td width="75%" style="height: 40px;"><img src="/Regedit/images/bg.jpg" style="width:400px; height:300px;" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">单位名称
                        </td>
                        <td width="75%" style="height: 40px;">XX实验室
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">
                        </td>
                        <td width="75%" style="height: 40px;">你实验室参加 2018 年度河南省质量技术监督局组织的XXXXXXXXXXXXX验证测试<br /> 能力验证项目，提交的测试为满意结果，特此证明。<br /><span style="margin-right:-5%;">二零一八年十二月三十日</span>
                        </td>
                    </tr>

                     
                   
                    <tr>
                        <td width="15%" align="right"></td>
                        <td width="75%" align="left">

                            <input type="button" class="normal_btnok" value="下载证书图片" onclick="checkChange();" />
                        </td>
                    </tr>

                  
                </table>
            </form>
        </div>
    </div>
</body>
</html>