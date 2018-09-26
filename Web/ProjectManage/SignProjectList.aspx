<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignProjectList.aspx.cs" Inherits="yny_005.Web.ProjectManage.SignProjectList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript">
        //tUrl = "Member/Handler/MemberList.ashx";
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
                            <select id="IsClose" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">报名状态</option>
                                <option value="true">已报名</option>
                                <option value="false">未报名</option>
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
                    <th>部门
                    </th>
                    <th>验证项目名称
                    </th>
                    <th>报名截止日期
                    </th>
                    <th>报名状态
                    </th>
                    <th>操作
                    </th>
                    

                </tr>
                <tr onclick="trClick(this)">
                    <td><em>
                        <input type="checkbox" id="chk_000" checked="checked" name="chkGroup" onclick="SelectChk(this);"></em></td>
                    <td>1&nbsp;</td>
                    <td>部门1</td>
                    <td>测试验证项目1</td>
                    <td>2017-08-09</td>
                    <td>未报名</td>
                    <td><a href="javascript:void(0)" class="btn" onclick="callhtml('ProjectManage/SignProject.aspx?Id=000','报名')">报名</a></td>
                </tr>
              <tr onclick="trClick(this)">
                    <td><em>
                        <input type="checkbox" id="chk_000" checked="checked" name="chkGroup" onclick="SelectChk(this);"></em></td>
                    <td>1&nbsp;</td>
                    <td>部门1</td>
                    <td>测试验证项目1</td>
                    <td>2017-08-09</td>
                    <td>已报名</td>
                    <td></td>
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