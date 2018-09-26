<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SampleCom.aspx.cs" Inherits="yny_005.Web.ProjectManage.SampleCom" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>样品确认</title>
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
                            <b style="margin-left: 5%;">样品表审核<span style="color:red;">（已寄送）</span> </b>
                        </td>
                    </tr>
                      
                    <tr>
                        <td width="15%" align="right">单位名称
                        </td>
                        <td width="75%" style="height: 40px;">XX实验室
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">项目名称
                        </td>
                        <td width="75%" style="height: 40px;">测试项目
                        </td>
                    </tr>

                      <tr>
                        <td width="15%" align="right">参加检测子项
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
                                        <td>氮含量</td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>氮含量</td>
                                        <td></td>
                                    </tr>
                                </tbody>
                            </table>
                          
                        </td>
                    </tr>

                   <tr>
                        <td width="15%" align="right">样品编号
                        </td>
                        <td width="75%" style="height: 40px;">hnjj-2018-06-001
                        </td>
                    </tr>
                      <tr>
                        <td width="15%" align="right">邮寄地址
                        </td>
                        <td width="75%" style="height: 40px;">xx市xx区xx大街xxx号
                        </td>
                    </tr>
                     <tr>
                        <td width="15%" align="right">联系人
                        </td>
                        <td width="75%" style="height: 40px;">张三
                        </td>
                    </tr>
                     <tr>
                        <td width="15%" align="right">电话
                        </td>
                        <td width="75%" style="height: 40px;">0371-88888888
                        </td>
                    </tr>
                     
                     <tr>
                        <td align="right">上传样品确认凭证:
                        </td>
                        <td>
                            <input type="file" name="upload" class="layui-upload-file">
                            <input type="hidden" id="uploadurl" name="uploadurl" runat="server" />
                            <img id="upimage" width="100px;" height="100px" />
                        </td>
                    </tr>
                 
                  
                    <tr>
                        <td width="15%" align="right"></td>
                        <td width="75%" align="left">

                            <input type="button" class="btn-danger" value="样品损坏，重新寄送" onclick="checkChange();" />
                            <input type="button" class="normal_btnok" value="样品确认成功" onclick="checkChange();" />
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