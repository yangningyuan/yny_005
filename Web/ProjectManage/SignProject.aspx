<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignProject.aspx.cs" Inherits="yny_005.Web.ProjectManage.SignProject" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>报名</title>
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
                            <b style="margin-left: 5%;">项目信息</b>
                        </td>
                    </tr>
                      <tr>
                        <td width="15%" align="right">报名编号
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text6" class="normal_input" readonly="readonly" value="2018855677777777777" runat="server" style="width: 20%;" /><span style="color:red;"> *证书编号生成规则：项目编号+报名成功顺序号</span>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">单位名称
                        </td>
                        <td width="75%" style="height: 40px;">XX实验室
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">验证项目
                        </td>
                        <td width="75%" style="height: 40px;">测试项目
                        </td>
                    </tr>

                      <tr>
                        <td width="15%" align="right">选择参加检测子项
                        </td>
                        <td width="75%" style="height: 40px;">
                            <table class="layui-table">
                                <colgroup>
                                    <col width="150">
                                    <col width="200">
                                </colgroup>
                                <thead>
                                    <tr>
                                        <th> 检测子项名称</th>
                                        <th>说明</th>

                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td><input type="checkbox" />氮含量</td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td><input type="checkbox" />氮含量</td>
                                        <td></td>
                                    </tr>
                                </tbody>
                            </table>
                          
                        </td>
                    </tr>

                   <tr>
                        <td width="15%" align="right">证件
                        </td>
                        <td width="75%" style="height: 40px;">XXXXXX证书
                        </td>
                    </tr>
                      <tr>
                        <td width="15%" align="right">证件编号
                        </td>
                        <td width="75%" style="height: 40px;">XXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                        </td>
                    </tr>
                     
                    
                    <tr>
                        <td width="15%" align="right">联系人
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text1" class="normal_input" value="张三李四" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                  
                      <tr>
                        <td width="15%" align="right">联系电话
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text3" class="normal_input" value="037166666666" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                      <tr>
                        <td width="15%" align="right">电子邮件
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text4" class="normal_input" value="XXXXX@qq.com" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                     <tr>
                        <td align="right">上传报名表图片:
                        </td>
                        <td>
                            <input type="file" name="upload" class="layui-upload-file">
                            <input type="hidden" id="uploadurl" name="uploadurl" runat="server" />
                            <img id="upimage" width="100px;" height="100px" />
                        </td>
                    </tr>
                      <tr>
                        <td align="right">上传报名缴费凭证:
                        </td>
                        <td>
                            <input type="file" name="upload" class="layui-upload-file">
                            <input type="hidden" id="Hidden1" name="uploadurl" runat="server" />
                            <img id="upimage" width="100px;" height="100px" />
                        </td>
                    </tr>
                    
                  
                    <tr>
                        <td width="15%" align="right"></td>
                        <td width="75%" align="left">

                            <input type="button" class="normal_btnok" value="提交报名表" onclick="checkChange();" />
                        </td>
                    </tr>

                      <tr>
                        <td width="15%" align="right">文档
                        </td>
                        <td width="75%" style="height: 40px;">
                            <table class="layui-table">
                                <colgroup>
                                    <col width="150">
                                    <col width="200">
                                </colgroup>
                                <thead>
                                    <tr>
                                        <th>文档名称</th>
                                        <th>说明</th>

                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>作业指导书.doc</td>
                                        <td><a href="">下载</a> </td>
                                    </tr>
                                    <tr>
                                        <td>作业指导书.doc</td>
                                        <td><a href="">下载</a> </td>
                                    </tr>
                                </tbody>
                            </table>
                           
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>
</body>
</html>
