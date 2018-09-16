﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TXChange.aspx.cs" Inherits="yny_003.Web.mobile.html.TXChange" %>

<div class="content content-padded">
    <div class="list-block myinfo">
        <form id="form1">
            <input type="hidden" id="bankauto" runat="server" />
            <ul>
                <!-- Text inputs -->
                <li>
                    <div class="item-content">
                        <div class="item-inner">
                            <div class="item-title label">员工ID</div>
                            <div class="item-input">
                                <%=TModel.MID %>
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="item-content">
                        <div class="item-inner">
                            <div class="item-title label">员工姓名</div>
                            <div class="item-input">
                                <%=TModel.MName %>
                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="item-content">
                        <div class="item-inner">
                            <div class="item-title label">可用<%=yny_003.BLL.Reward.List["MHB"].RewardName %></div>
                            <div class="item-input">
                                <input type="text" value=" <%=TModel.MConfig.MJJ.ToFixedString() %>" disabled="disabled">
                            </div>
                        </div>
                    </div>
                </li>
              <li>
                    <div class="item-content">
                        <div class="item-inner">
                            <div class="item-title label">提现钱包</div>
                            <div class="item-input">
                                <label class="label-checkbox item-content">
                                    <input type="radio" name="ddlFrom" checked="checked" value="MHB">
                                    <div class="item-media"><i class="icon icon-form-checkbox"></i></div>
                                    <div class="item-inner">
                                        <div class="item-title-row">
                                            <div class="item-title"><%=yny_003.BLL.Reward.List["MHB"].RewardName %></div>

                                        </div>

                                    </div>
                                </label>

                            </div>
                        </div>
                    </div>
                </li>
                <li>
                    <div class="item-content">
                        <div class="item-inner">
                            <div class="item-title label">提现金额</div>
                            <div class="item-input">
                                <input type="text" value="" name="txtMHB" id="txtMHB" placeholder="请输入提现金额">
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
                <a href="javascript:checkChange();" class="button button-big button-fill button-success">提交</a>
            </div>
        </div>
    </div>
</div>
<script type="text/javascript">
    function checkChange() {
        if ($('#txtMHB').val().trim() == "") {
            layer.msg("提现金额不能为空");
            return;
        } else {
            ActionModel("ChangeMoney/TXChange.aspx?Action=Add", $('#form1').serialize());
        }
    }
</script>
