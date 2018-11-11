<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MProjectList.aspx.cs" Inherits="yny_005.Web.ProjectManage.MProjectList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript">
        tUrl = "ProjectManage/Handler/MProjectList.ashx";
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
                       <%-- <td>
                            <select id="IsClose" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">项目状态</option>
                                <option value="true">已截止的验证项目</option>
                                <option value="false">未截止的验证项目</option>
                            </select>
                        </td>--%>
                        <td>
                            <select id="IsBMState" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">报名状态</option>
                                <option value="3">报名已通过</option>
                                <option value="0,1,2">报名未通过</option>
                            </select>
                        </td>
                        <td>
                            <select id="IsYangPin" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">样品状态</option>
                                <option value="3">已确认</option>
                                <option value="0,1,2">未确认</option>
                            </select>
                        </td>
                        <td>
                            <select id="IsRState" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">验证结果状态</option>
                                <option value="3">已通过</option>
                                <option value="0,1,2">未通过</option>
                            </select>
                        </td>

                    </tr>
                </table>

            </div>
             <div class="search" id="DivSearch" runat="server">
                <input type="button" value="查询" class="ssubmit" onclick="SearchByCondition()" />
                 <input id="nTitle" name="txtKey" data-name="txtKey"  type="text" class="sinput" />
                 <input name="txtKey" data-name="txtKey"  id="bmoid"  value="<%=Request.QueryString["bmoid"] %>" type="text" class="sinput" style="width: 120px; display:none;" />
            </div>

        </div>
        <div class="ui_table">
            <table cellpadding="0" cellspacing="0" id="Result" class="tabcolor">
                <tr>
                    <th width="50px">全选
                    </th>
                    <th>序号
                    </th>
                    <th>部门
                    </th>
                    <th>验证项目名称
                    </th>
                    <th>项目截止日期
                    </th>
                  <%--  <th>结果1
                    </th>
                    <th>结果2
                    </th>
                    <th>平均值
                    </th>--%>
                    <th>报名状态
                    </th>
                    <th>样品寄送
                    </th>
                    <th>样品确认
                    </th>
                    <th>验证结果提交
                    </th>
                    <th>结果报告下载
                    </th>
                    <th>结果审核
                    </th>
                    <th>证书
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
