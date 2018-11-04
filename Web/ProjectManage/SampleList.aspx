<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SampleList.aspx.cs" Inherits="yny_005.Web.ProjectManage.SampleList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript">
        tUrl = "ProjectManage/Handler/SampleList.ashx";
        tState = "";
        SearchByCondition();
        //        setup();

        // 导出Excel
        function exportExcel() {
            ExportExcel("Car/Handler/ExportExcel.ashx", "DPLBExcel");
        }
        //setup();
    </script>
</head>
<body>
    <div id="mempay">
        <div class="control">
            <div class="cheeckbox" style="float: left;">
                 <table cellpadding="0" cellspacing="0">
                    <tr>
                        <td>
                            <select id="IsState" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">样品状态</option>
                                <option value="0">未寄送</option>
                                <option value="1">已寄送</option>
                                <option value="2">重新寄送</option>
                                <option value="3">已确认</option>
                            </select>
                        </td>
                    </tr>
                </table>
            </div>

           

        </div>
        <div class="ui_table">
            <table cellpadding="0" cellspacing="0" id="Result" class="tabcolor">
                <tr>
                    <th width="50px">全选
                    </th>
                    <th>序号
                    </th>
                    <th>项目编号
                    </th>
                    <th>项目名称
                    </th>
                    <th>报名单位名称
                    </th>
                  <%--  <th>样品名称
                    </th>--%>
                    <th>邮寄地址
                    </th>
                    <th>样品确认单
                    </th>
                    <th>报名日期
                    </th>
                    <th>状态
                    </th>
                    <th>操作
                    </th>
                </tr>
            </table>
            <div class="ui_table_control">
                <em style="vertical-align: middle;">
                    <input type="checkbox" id="chkAll" onclick="SelectChk(this);" /></em>
                <div class="pn">
                      
                </div>
                <div class="pagebar">
                    <div id="Pagination">
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>