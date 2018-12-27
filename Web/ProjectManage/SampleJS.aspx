<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SampleJS.aspx.cs" Inherits="yny_005.Web.ProjectManage.SampleJS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>样品寄送</title>
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
                        <td width="15%" align="right">单位名称
                        </td>
                        <td width="75%" style="height: 40px;"><%=objU.DanWeiName %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">验证项目
                        </td>
                        <td width="75%" style="height: 40px;"><%=objU.ObjName %>
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
                        <td width="15%" align="right">样品编号
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="YangPinCode" class="normal_input" value="" runat="server" style="width: 30%;" />
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">联系人
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=BMMember.BankCardName %>
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">联系电话
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=BMMember.Tel %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">电子邮件
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=BMMember.Email %>
                        </td>
                    </tr>
                    <%
                        if (!string.IsNullOrEmpty(objS.YangPinImgUrl))
                        {
                    %>
                    <tr>
                        <td align="right">样品确认图片:
                        </td>
                        <td>
                            <img src="<%=objS.YangPinImgUrl %>" />
                        </td>
                    </tr>
                    <%
                        }
                    %>

                    <tr>
                        <td width="15%" align="right">
                             <div class="pay btn btn-warning" onclick="callhtml('/ProjectManage/MSampleList.aspx','MD样品列表');onclickMenu()">返回</div>
                        </td>
                        <td width="75%" align="left">

                            <input type="button" class="normal_btnok" value="寄送" onclick="checkChange();" />
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>

    <script>
        function checkChange() {
            if ($('#YangPinCode').val() == "") {
                v5.error('样品编号不能为空', '1', 'ture');
            } else {
                ActionModel("ProjectManage/SampleJS.aspx?Action=Add", $('#form1').serialize());
            }
        }
     
    </script>
</body>
</html>
