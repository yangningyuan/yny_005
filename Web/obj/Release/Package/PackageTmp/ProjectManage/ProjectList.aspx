<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjectList.aspx.cs" Inherits="yny_005.Web.ProjectManage.ProjectList" %>

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
                                <option value="">项目状态</option>
                                <option value="true">已截止的验证项目</option>
                                <option value="false">未截止的验证项目</option>
                            </select>
                        </td>
                        <td>
                            <select id="IsClose" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">报名状态</option>
                                <option value="true">报名已通过</option>
                                <option value="false">报名未通过</option>
                            </select>
                        </td>
                        <td>
                            <select id="IsClose" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">样品状态</option>
                                <option value="true">报名已通过</option>
                                <option value="false">报名未通过</option>
                            </select>
                        </td>
                        <td>
                            <select id="IsClose" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">验证结果状态</option>
                                <option value="true">报名已通过</option>
                                <option value="false">报名未通过</option>
                            </select>
                        </td>

                    </tr>
                </table>
            </div>

            <div id="Div1" runat="server" class="pay" onclick="callhtml('/ProjectManage/AddProject.aspx','新增项目');onclickMenu()">
                新增项目
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
                    <th>结果1
                    </th>
                    <th>结果2
                    </th>
                    <th>平均值
                    </th>
                    <th>报名状态
                    </th>
                    <th>样品寄送
                    </th>
                    <th>样品确认
                    </th>
                    <th>验证结果提交
                    </th>
                    <th>数据统计
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
                <tr onclick="trClick(this)">
                    <td><em>
                        <input type="checkbox" id="chk_000" checked="checked" name="chkGroup" onclick="SelectChk(this);"></em></td>
                    <td>1&nbsp;</td>
                    <td>部门1</td>
                    <td>测试验证项目1</td>
                    <td>2017-08-09</td>
                    <td>10</td>
                    <td>20</td>
                    <td>15</td>
                    <td>未通过</td>
                    <td>未寄送</td>
                    <td><a href="javascript:void(0)" class="btn" onclick="callhtml('ProjectManage/SampleCom.aspx?Id=000','样品确认')">未确认</a></td>
                    <td>未提交</td>
                    <td>数据统计中</td>
                    <td>报告下载</td>
                    <td><a href="javascript:void(0)" class="btn" onclick="callhtml('ProjectManage/ValidationResult.aspx?Id=000','验证结果审核')">未通过</a></td>
                    <td><a href="javascript:void(0)" class="btn" onclick="callhtml('ProjectManage/ViewCertificate.aspx?Id=000','查看证书')">查看</a></td>
                    <td><span style="color: red;">修改</span>&nbsp;</td>
                </tr>
                <tr onclick="trClick(this)">
                    <td><em>
                        <input type="checkbox" id="chk_000" checked="checked" name="chkGroup" onclick="SelectChk(this);"></em></td>
                    <td>1&nbsp;</td>
                    <td>部门1</td>
                    <td>测试验证项目1</td>
                    <td>2017-08-09</td>
                      <td>10</td>
                    <td>20</td>
                    <td>15</td>
                    <td>未通过</td>
                    <td>未寄送</td>
                    <td>未确认</td>
                    <td>未提交</td>
                    <td>数据统计中</td>
                    <td>报告下载</td>
                    <td>未通过</td>
                    <td><span style="color: Blue;">未通过</span>&nbsp;</td>
                    <td><span style="color: red;">修改</span>&nbsp;</td>
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
