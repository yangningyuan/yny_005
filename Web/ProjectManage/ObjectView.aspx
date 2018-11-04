<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ObjectView.aspx.cs" Inherits="yny_005.Web.ProjectManage.ObjectView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>报名</title>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <script type="text/Javascript" src="/plugin/uploadify/jquery.uploadify.js"></script>
    <link type="text/css" href="/plugin/uploadify/uploadify.css" rel="stylesheet" />
</head>
<body>
    <div id="mempay">
        <div id="finance">
            <form id="form1">
                <input type="hidden" id="pid" runat="server" />
                <input type="hidden" id="oid" runat="server" />
                <table cellpadding="0" cellspacing="0">

                    <tr>
                        <td colspan="2">
                            <b style="margin-left: 5%;">项目信息</b>
                        </td>
                    </tr>
                    <%--   <tr>
                        <td width="15%" align="right">报名编号
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text6" class="normal_input" readonly="readonly" value="2018855677777777777" runat="server" style="width: 20%;" /><span style="color:red;"> *证书编号生成规则：项目编号+报名成功顺序号</span>
                        </td>
                    </tr>--%>
                    <tr>
                        <td width="15%" align="right">单位名称
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
                        <td width="15%" align="right">选择参加检测子项<input type="hidden" id="ChildValue" runat="server" />
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
                                            <input type="checkbox" name="ChildID" value="<%=item.ID %>" /><%=item.ChildName %></td>
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
                        <td width="75%" style="height: 40px;"><%=!string.IsNullOrEmpty(TModel.FMID)? TModel.FMID.Replace("0","检测机构登记证书").Replace("1","个人身份证").Replace("2","其他"):"" %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">证件编号
                        </td>
                        <td width="75%" style="height: 40px;"><%=TModel.NumID %>
                        </td>
                    </tr>


                    <tr>
                        <td width="15%" align="right">联系人
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=TModel.BankCardName %>
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">联系电话
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=TModel.Tel %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">电子邮件
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=TModel.Email %>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">上传报名表图片:
                        </td>
                        <td>
                            <input id="fileOne<%=rdstr %>" type="file" capture="camera" class="">
                            <input id="btnOne" value="上传到服务器" type="button" style="display: none;" />
                            <canvas id="canvasOne" width="1200" height="1200" style="display: none;"></canvas>
                            <input id="DataUrl" type="text" style="display: none;" />
                            <img id="DataImg" src="/MQL/images/_20180922122730.png" style="width: 100px; height: 100px;" />
                            <input type="hidden" id="uploadurl" name="uploadurl" runat="server" />
                            <input runat="server" id="roam" style="display: none;" />
                        </td>
                    </tr>
                    <tr>
                        <td align="right">上传报名表图片:
                        </td>
                        <td>
                            <input id="fileOne2<%=rdstr %>" type="file" capture="camera" class="">
                            <input id="btnOne2" value="上传到服务器" type="button" style="display: none;" />
                            <canvas id="canvasOne2" width="1200" height="1200" style="display: none;"></canvas>
                            <input id="DataUrl2" type="text" style="display: none;" />
                            <img id="DataImg2" src="/MQL/images/_20180922122730.png" style="width: 100px; height: 100px;" />
                            <input type="hidden" id="uploadurl2" name="uploadurl2" runat="server" />
                            <input runat="server" id="roam2" style="display: none;" />
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

                                    <%
                                        if (listExcel != null)
                                        {
                                            foreach (var item in listExcel)
                                            {
                                    %>
                                    <tr>
                                        <td><%=item.ExcelName %></td>
                                        <td><a href="<%=item.ExcelUrl %>">下载</a> </td>
                                    </tr>
                                    <%
                                            }
                                        }
                                    %>
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
