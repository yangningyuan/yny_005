﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="yny_005.Web.Member.List" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript">
        tUrl = "Member/Handler/MemberList.ashx";
        tState = "";
        SearchByCondition();
        //        setup();

        // 导出Excel
        function exportExcel() {
            ExportExcel("Car/Handler/ExportExcel.ashx", "DPLBExcel");
        }

        function SHAuto(mid)
        {
            $.ajax({
                type: 'post',
                url: 'Member/List.aspx?Action=Add',
                data: {MID:mid},
                success: function (info) {
                    v5.error(info, '1', 'ture');
                    callhtml('/Member/List.aspx', '人员列表'); onclickMenu()
                }
            });
        }

        function ReAuto(mid){
            //prompt层
            layer.prompt({ title: '请输入不通过原因，并确认', formType: 2 }, function (pass, index) {
                layer.close(index);
                ActionModel("Member/List.aspx?Action=Other", { remsg: pass, MID: mid });
            });
        }
        //setup();
    </script>
</head>
<body>
    <div id="distr">
    </div>
    <div id="mempay">
        <div class="control">
            <div class="cheeckbox" style="float: left;">
                <table cellpadding="0" cellspacing="0">
                    <tr>
                        <%--<td>
                            <select id="AgencyCode" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">员工级别</option>
                                <%=AgencyListStr%>
                            </select>
                        </td>--%>
                        <td>
                            <select id="RoleCode" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">角色类型</option>
                                <%=RoleListStr %>
                            </select>
                            <input type="hidden" id="OnlyOnLine" name="txtKey" data-name="txtKey" value="" />
                        </td>
                        <td>
                            <select id="IsClose" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">锁定状态</option>
                                <option value="true">已锁定</option>
                                <option value="false">未锁定</option>
                            </select>
                        </td>
                      <%--  <td>
                            <select id="IsClock" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">冻结状态</option>
                                <option value="true">已冻结</option>
                                <option value="false">未冻结</option>
                            </select>
                        </td>--%>
                        <%--<td>
                            <select id="ddlProvince" runat="server" data-name="txtKey">
                            </select>
                            <select id="ddlCity" runat="server" data-name="txtKey">
                            </select>
                            <select id="ddlZone" runat="server" data-name="txtKey">
                            </select>
                        </td>--%>
                    </tr>
                </table>
            </div>
            <%--<div id="Div1" runat="server" class="pay" onclick="UpDateByIDOrEmpty('Member/SMSSend.aspx?','发送短信',820,530)">
                发送短信</div>--%>
            <div id="Div1" runat="server" class="pay" onclick="callhtml('/Member/Add.aspx','新增人员');onclickMenu()">
                新增人员
            </div>
            <div id="editMember" runat="server" class="pay" onclick="UpDateByID('Member/ModifyMember.aspx?','修改员工',820,530)">
                修改员工
            </div>
            <div class="search" id="DivSearch" runat="server">
                <input type="button" value="查询" class="ssubmit" onclick="SearchByCondition()" />
                <%--<input type="button" value="从业人员信息管理报表" class="btn btn-success" onclick="exportExcel()" />--%>
                <input name="txtKey" data-name="txtKey" id="mKey" placeholder="账号" value="账号"
                    onfocus="if (value =='账号'){value =''}" onblur="if (value ==''){value='账号'}"
                    type="text" class="sinput" style="width: 120px;" />
                <input type="text" name="txtKey" data-name="txtKey" id="startDate" placeholder="开始日期"
                    value="开始日期" onfocus="if (value =='开始日期'){value =''}" class="daycash_input" style="width: 120px;"
                    onclick="WdatePicker({ maxDate: '#F{$dp.$D(\'endDate\')}' })" />
                <input type="text" name="txtKey" data-name="txtKey" id="endDate" placeholder="截止日期"
                    value="截止日期" onfocus="if (value =='截止日期'){value =''}" class="daycash_input" style="width: 120px;"
                    onclick="WdatePicker({ minDate: '#F{$dp.$D(\'startDate\')}' })" />
            </div>
        </div>
        <div class="ui_table">
            <table cellpadding="0" cellspacing="0" id="Result" class="tabcolor">
                <tr>
                    <th width="50px">全选
                    </th>
                    <th>序号
                    </th>
                    <th>账号
                    </th>
                    <th>实验室单位名称
                    </th>
                    <th>人员类型
                    </th>
                 <th>联系电话
                    </th>
                    <th>检验检测机构登记证件及号码
                    </th>
                    <th>锁定状态
                    </th>
                    
                   
                    <th>注册日期
                    </th>
                    <th>审核时间
                    </th>
                    <th>状态
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
