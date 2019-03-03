<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageProjectList.aspx.cs" Inherits="yny_005.Web.ProjectManage.ManageProjectList" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript">
        tState = 'false';
        tUrl = "ProjectManage/Handler/ManageProjectList.ashx";
        SearchByCondition();

        // 导出Excel
        function exportExcel() {
            ExportExcel("Car/Handler/ExportExcel.ashx", "项目统计列表");
        }
    </script>
</head>
<body>
    <div id="mempay">
        <div class="control">
            <%-- <div class="select">
                <a href="javascript:void(0)" onclick="SearchByState('',this);" class="btn btn-danger">
                    所有</a> <a href="javascript:void(0);" onclick="SearchByState('1',this);" class="btn btn-success">
                        正常</a> <a href="javascript:void(0)" onclick="SearchByState('0',this);" class="btn btn-success">
                            已作废</a>
            </div>--%>
            <%--<div class="pay" onclick="UpDateByID('Message/NoticeModify.aspx?','修改公告',900,470);">
                修改项目</div>--%>
            <div class="cheeckbox" style="float: left;">
                <table cellpadding="0" cellspacing="0">
                    <tr>
                        <td>
                            <select id="IsJieShu" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">是否结束</option>
                                <option value="1">是</option>
                                <option value="0">否</option>
                            </select>
                        </td>
                        <td>
                            <select id="IsShenHe" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">是否审核</option>
                                <option value="3">是</option>
                                <option value="0,1,2">否</option>
                            </select>
                        </td>
                        <td>
                            <select id="IsGuoQi" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">是否过期</option>
                                <option value="1">是</option>
                                <option value="0">否</option>
                            </select>
                        </td>
                    </tr>
                </table>
            </div>

            <div class="pay" onclick="v5.show('ProjectManage/AddProject.aspx','发布项目','url',900,470)">
                发布项目
            </div>
            <div class="search" id="DivSearch" runat="server">
                <input type="button" value="查询" class="ssubmit" onclick="SearchByCondition()" />
                <input type="button" value="导出Excel" class="btn btn-success" onclick="exportExcel()" />
                <input
                    id="nTitle" name="txtKey" data-name="txtKey" type="text" class="sinput" />
            </div>
        </div>
        <div class="ui_table">
            <table cellpadding="0" cellspacing="0" class="tabcolor" id="Result">
                <tr>
                    <th width="50px">全选
                    </th>
                    <th>编号
                    </th>
                    <%--  <th>
                        项目编号
                    </th>--%>
                    <th>项目名称
                    </th>
                    <th>发布人
                    </th>
                    <th>部门全称
                    </th>
                    <th>报名截止时间
                    </th>
                    <th>项目结束时间
                    </th>
                    <%--<th>
                        备注
                    </th>--%>
                    <th>发布时间
                    </th>
                    <th>是否审核
                    </th>
                    <th>是否结束
                    </th>
                    <th>报名情况
                    </th>
                    <th>样品情况
                    </th>
                    <th>结果验证情况
                    </th>
                    <th>操作
                    </th>
                </tr>
            </table>
            <div class="ui_table_control">
                <em style="vertical-align: middle;">
                    <input type="checkbox" id="chkAll" onclick="SelectChk(this);" /></em>

                <div class="pn">
                    <a href="javascript:void(0);" title="结束项目" onclick="RunAjaxByList('false','ShJSProject',',');">结束项目</a>
                </div>

                <div class="pagebar">
                    <div id="Pagination">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        function RecheckProject(oid) {
            //prompt层
            layer.prompt({ title: '请输入打回原因，并确认', formType: 2 }, function (pass, index) {
                layer.close(index);
                ActionModel("ProjectManage/ManageProjectList.aspx?Action=Modify", { remsg: pass, oid: oid });
            });
        }

        function TocheckProject(oid) {
            ActionModel("ProjectManage/ManageProjectList.aspx?Action=Add", { oid: oid });
        }
    </script>
</body>
</html>
