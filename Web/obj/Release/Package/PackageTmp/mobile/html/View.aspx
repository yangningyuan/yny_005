﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="yny_003.Web.mobile.html.View" %>

<div class="content content-padded">
    <div class="list-block myinfo">
        <form id="form1">
            <ul>
                <!-- Text inputs -->
                <li>
                    <div class="item-content">
                        <div class="item-inner">
                            <div class="item-title label">员工账号</div>
                            <div class="item-input">
                                <%=TModel.MID %>
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="item-content">
                        <div class="item-inner">
                            <div class="item-title label">员工名称</div>
                            <div class="item-input">
                                <input type="text" id="txtMName" runat="server" >
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="item-content">
                        <div class="item-inner">
                            <div class="item-title label">开户地区</div>
                            <div class="item-input">
                                <select id="ddlProvince" runat="server">
                                </select>
                                <select id="ddlCity" runat="server">
                                </select>
                                <select id="ddlZone" runat="server" style="display: none;">
                                </select>
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="item-content">
                        <div class="item-inner">
                            <div class="item-title label">开户银行</div>
                            <div class="item-input">
                                <select id="txtBank" runat="server">
                                </select>
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="item-content">
                        <div class="item-inner">
                            <div class="item-title label">开户支行</div>
                            <div class="item-input">
                                <input id="txtBranch" name="txtBranch" runat="server" maxlength="25" type="text"  />
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="item-content">
                        <div class="item-inner">
                            <div class="item-title label">开户姓名</div>
                            <div class="item-input">
                                <input id="txtBankCardName" name="txtBankCardName" runat="server" maxlength="20"
                                    type="text"  />
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="item-content">
                        <div class="item-inner">
                            <div class="item-title label">卡号</div>
                            <div class="item-input">
                                <input id="txtBankNumber" name="txtBankNumber" runat="server" maxlength="19" type="text"  />
                            </div>
                        </div>
                    </div>
                </li>

            </ul>
        </form>
    </div>
    <div class="content-block">
        <div class="row">
            <div class="col-100">
                <a href="javascript:void(0)" onclick="checkChange();" class="button button-big button-fill button-success">修改资料</a>
            </div>
        </div>
    </div>
</div>
<script>

    setup();
    $(function () {
        $("#ddlProvince").val('<%=provice%>');
        change(1);
        $("#ddlCity").val('<%=City%>');
    });

        function checkChange() {
            if ($('#txtMName').val() == '') {
                layer.msg('员工姓名不能为空');
                
            } else if ($('#txtBranch').val() == '') {
                layer.msg('请输入开户支行');
                
            } else if ($('#txtBankCardName').val() == '') {
                layer.msg('请输入开户姓名');
                
            } else if ($('#ddlCity').val() == '地市') {
                layer.msg('请选择开户地区');
                
            } else if (!$('#txtBankNumber').val().TryBankCard()) {
                layer.msg('银行卡号只能是16-19位数字');
               
            } else {
                ActionModel("Member/Modify.aspx?Action=modify", $('#form1').serialize());
            }
        }
</script>
