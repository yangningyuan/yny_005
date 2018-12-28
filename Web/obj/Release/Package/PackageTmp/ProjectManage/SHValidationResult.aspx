<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SHValidationResult.aspx.cs" Inherits="yny_005.Web.ProjectManage.SHValidationResult" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>验证结果审核</title>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <script type="text/Javascript" src="/plugin/uploadify/jquery.uploadify.js"></script>
    <link type="text/css" href="/plugin/uploadify/uploadify.css" rel="stylesheet" />
</head>
<body>
    <div id="mempay">
        <div id="finance">
            <form id="form1">
                <input type="hidden" id="uid" runat="server" />
                <input type="hidden" id="oid" runat="server" />
                <input type="hidden" id="osuid" runat="server" />
                <table cellpadding="0" cellspacing="0">

                    <tr>
                        <td colspan="2">
                            <b style="margin-left: 5%;">验证结果审核<span style="color: red;">（<%=OUSER.RState.ToString().Replace("0","未提交").Replace("1","待审核").Replace("2","审核未通过").Replace("3","审核通过") %>）</span> </b>
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">单位名称
                        </td>
                        <td width="75%" style="height: 40px;"><%=obj.ReObjNiName %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">项目名称
                        </td>
                        <td width="75%" style="height: 40px;"><%=obj.ObjName %>
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">参加检测子项
                        </td>
                        <td width="75%" style="height: 40px;">
                            <table class="layui-table">

                                <thead>
                                    <tr>
                                        <th>检测子项名称</th>
                                        <th>结果1</th>
                                        <th>结果2</th>
                                        <th>平均结果</th>
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
                                            <%=item.Spare %></td>
                                        <td>
                                            <%=item.ResultOne %>
                                        </td>
                                        <td>
                                            <%=item.ResultTwo %>
                                        </td>
                                        <td>
                                            <%=item.ResultAvg %>
                                        </td>
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
                        <td width="15%" align="right">使用方法标准
                        </td>
                        <td width="75%" style="height: 40px;">
                            <textarea id="FangFa" type="text" class="normal_input" value="" runat="server" style="width: 20%; height: 100px;" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">仪器设备
                        </td>
                        <td width="75%" style="height: 40px;">
                            <textarea id="YiQi" type="text" class="normal_input" value="" runat="server" style="width: 20%; height: 100px;" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">异常现象
                        </td>
                        <td width="75%" style="height: 40px;">
                            <textarea id="YiChang" type="text" class="normal_input" value="" runat="server" style="width: 20%; height: 100px;" />
                        </td>
                    </tr>


                    <tr>
                        <td align="right">结果凭证:
                        </td>
                        <td>
                            
                            <img id="" src="<%=OSU.ResultImgUrl %>" />
                            
                        </td>
                    </tr>


                    <tr>
                        <td width="15%" align="right"> <div class="pay btn btn-warning" onclick="callhtml('/ProjectManage/MProjectList.aspx','项目报名情况及状态查询');onclickMenu()">返回</div><input type="button" class="btn btn-danger" style="" value="审核，不通过" onclick="RecheckChange();" /></td>
                        <td width="75%" align="left">

                            <input type="button" class="normal_btnok" value="通过验证结果" onclick="checkChange();" />
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
     <script>
        function checkChange() {
                ActionModel("ProjectManage/SHValidationResult.aspx?Action=Add", $('#form1').serialize());
        }
        function RecheckChange() {
            ActionModel("ProjectManage/SHValidationResult.aspx?Action=Modify", $('#form1').serialize());
        }
    </script>
</body>

</html>
