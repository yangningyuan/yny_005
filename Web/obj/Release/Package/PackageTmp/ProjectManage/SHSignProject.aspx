<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SHSignProject.aspx.cs" Inherits="yny_005.Web.ProjectManage.SHSignProject" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>报名审核</title>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <script type="text/Javascript" src="/plugin/uploadify/jquery.uploadify.js"></script>
    <link type="text/css" href="/plugin/uploadify/uploadify.css" rel="stylesheet" />
</head>
<body>
    <div id="mempay">
        <div id="finance">
            <form id="form1">
                <input type="hidden" id="oaid" runat="server" />
                <table cellpadding="0" cellspacing="0">

                    <tr>
                        <td colspan="2">
                            <b style="margin-left: 5%;">项目信息</b>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">发布项目单位名称
                        </td>
                        <td width="75%" style="height: 40px;"><%=obj.ReObjNiName %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">验证项目
                        </td>
                        <td width="75%" style="height: 40px;"><%=obj.ObjName %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">报名用户
                        </td>
                        <td width="75%" style="height: 40px;"><%=oapply.MID %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">报名实验室单位名称
                        </td>
                        <td width="75%" style="height: 40px;"><%=obj.ObjName %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">参加检测子项<input type="hidden" id="ChildValue" />
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
                                    <%
                                        if (listChild != null)
                                        {
                                            foreach (var item in listChild)
                                            {
                                    %>
                                    <tr>
                                        <td>
                                            <%=item.ChildName %></td>
                                        <td><%=item.ChildValue %></td>
                                    </tr>
                                    <%
                                            }
                                        }
                                    %>
                                </tbody>
                            </table>

                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">证件
                        </td>
                        <td width="75%" style="height: 40px;"><%=!string.IsNullOrEmpty(tmember.FMID)? tmember.FMID.Replace("0","检测机构登记证书").Replace("1","个人身份证").Replace("2","其他"):"" %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">证件编号
                        </td>
                        <td width="75%" style="height: 40px;"><%=tmember.NumID %>
                        </td>
                    </tr>


                    <tr>
                        <td width="15%" align="right">联系人
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=tmember.BankCardName %>
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">联系电话
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=tmember.Tel %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">电子邮件
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=tmember.Email %>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">上传报名表图片:
                        </td>
                        <td>
                            <img src="<%=oapply.BaoMingImgUrl %>" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">上传费用表图片:
                        </td>
                        <td>
                            <img src="<%=oapply.FeiYongImgUrl %>" />
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">
                             <div class="pay btn btn-warning" onclick="callhtml('/ProjectManage/ManageSHSignProjectList.aspx','MD项目报名列表');onclickMenu()">返回</div>
                            <input type="button" class="btn btn-danger" style="" value="不符合，打回" onclick="RecheckChange();" />
                        </td>
                        <td width="75%" align="left">

                            <input type="button" class="normal_btnok" value="审核成功" onclick="checkChange();" />
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>

    <script>
        function checkChange() {
            ActionModel("ProjectManage/SHSignProject.aspx?Action=Add", $('#form1').serialize());
        }
        function RecheckChange() {
            //prompt层
            layer.prompt({ title: '请输入打回原因，并确认', formType: 2 }, function (pass, index) {
                layer.close(index);
                ActionModel("ProjectManage/SHSignProject.aspx?Action=Modify", { remsg: pass, oaid: $("#oaid").val() });
            });
        }
    </script>
</body>
</html>
