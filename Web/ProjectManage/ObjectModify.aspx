<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ObjectModify.aspx.cs" Inherits="yny_005.Web.ProjectManage.ObjectModify" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>项目新增</title>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <%-- <script>
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

    </script>--%>

    <!--引入uploadify-->
    <script type="text/Javascript" src="/plugin/uploadify/jquery.uploadify.js"></script>
    <link type="text/css" href="/plugin/uploadify/uploadify.css" rel="stylesheet" />

</head>
<body>
    <div id="mempay">
        <div id="finance">
            <form id="form1">
                <input type="hidden" id="fid" runat="server" />
                <input type="hidden" id="oid" runat="server" />
                <input type="hidden" id="xxid" runat="server" />
                <table cellpadding="0" cellspacing="0">
                    <tr>
                        <td colspan="2">
                            <b style="margin-left: 5%;">项目信息</b>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">部门
                        </td>
                        <td width="75%" style="height: 40px;"><%=TModel.MID %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">项目名称
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="ObjName" class="normal_input" value="" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">项目编号
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="ObjCode" class="normal_input" value="" runat="server" style="width: 20%;" readonly="readonly" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">子项
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
                                <tbody id="SubDemo">
                                   
                                        <%
                                            foreach (var item in listChild)
                                            {
                                                %>
                                     <tr>
                                         <td><%=item.ChildName %></td>
                                        <td><%=item.ChildValue %></td>
                                    </tr>
                                    <%
                                            }
                                             %>

                                        
                                </tbody>
                            </table>
                            
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">说明
                        </td>
                        <td width="75%" style="height: 40px;">
                            <textarea id="Remark" class="normal_input" value="" runat="server" style="width: 70%; height:200px;" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">报名截止日期
                        </td>
                        <td width="75%" style="height: 40px;">
                            
                            <input type="text" class="layui-input" id="BMstateDate" name="BMstateDate" runat="server"  style="width: 20%;"  placeholder="">
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">项目结束日期
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input type="text" class="layui-input" id="ComDate"  name="ComDate" style="width: 20%;" runat="server"  placeholder="">
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

                    <tr>
                        <td width="15%" align="right"></td>
                        <td width="75%" align="left">

                            <input type="button" class="normal_btnok" value="修改项目" onclick="checkChange();" />
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>


    <script type="text/javascript">
        layui.use('laydate', function () {
            var laydate = layui.laydate;
            //日期时间选择器
            laydate.render({
                elem: '#BMstateDate'
              , type: 'datetime'
            });
            laydate.render({
                elem: '#ComDate'
             , type: 'datetime'
            });
        });
       

        function checkChange() {
            if ($('#ObjName').val() == "") {
                v5.error('项目名称不能为空', '1', 'ture');
            } else {
                ActionModel("ProjectManage/ObjectModify.aspx?Action=Add", $('#form1').serialize());
            }
        }

    </script>


</body>
</html>
