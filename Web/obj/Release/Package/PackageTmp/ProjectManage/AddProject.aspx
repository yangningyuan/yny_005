<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProject.aspx.cs" Inherits="yny_005.Web.ProjectManage.AddProject" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>项目新增</title>
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
                        <td width="15%" align="right">部门
                        </td>
                        <td width="75%" style="height: 40px;">部门1
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">项目名称
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text2" class="normal_input" value="" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">项目编号
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text1" class="normal_input" value="" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">添加子项
                        </td>
                        <td width="75%" style="height: 40px;">
                            <table class="layui-table">
                                <colgroup>
                                    <col width="150">
                                    <col width="200">
                                </colgroup>
                                <thead>
                                    <tr>
                                        <th>检测子项名称</th>
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
                            <div id="Div1" class="pay btn btn-success" onclick="callhtml('/Member/Add.aspx','添加子项');onclickMenu()">
                                添加子项
                            </div>
                        </td>
                    </tr>
                      <tr>
                        <td width="15%" align="right">说明
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text3" class="normal_input" value="" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                      <tr>
                        <td width="15%" align="right">报名截止日期
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text4" class="normal_input" value="" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                      <tr>
                        <td width="15%" align="right">项目结束日期
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text5" class="normal_input" value="" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                      <tr>
                        <td width="15%" align="right">添加文档
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
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>作业指导书.doc</td>
                                        <td></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div id="Div1" class="pay btn btn-success" onclick="callhtml('/Member/Add.aspx','添加子项');onclickMenu()">
                                添加文档
                            </div>
                        </td>
                    </tr>
                  
                    <tr>
                        <td width="15%" align="right"></td>
                        <td width="75%" align="left">

                            <input type="button" class="normal_btnok" value="提交处理" onclick="checkChange();" />
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>
</body>
</html>
