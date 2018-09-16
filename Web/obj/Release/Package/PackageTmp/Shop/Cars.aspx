﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="yny_003.Web.Shop.Cars" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript">
        tUrl = "Shop/Handler/CarList.ashx";
        tState = "";
        SearchByCondition();
    </script>
</head>
<body>
    <div id="mempay">
        <div class="ui_table">
            <form id="form1">
                <%--<div id="receiveDiv" style="display: none">
                    <table class="table">
                        <asp:Repeater ID="repReceiveList" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <input type="radio" name="rdreecive" <%#Convert.ToBoolean(Eval("IsMain"))?"checked='checked'":""%>
                                            value="<%#Eval("Id")%>" />
                                    </td>
                                    <td>
                                        <%#Eval("Receiver")%>
                                    </td>
                                    <td>
                                        <%#Eval("DetailAddress")%>
                                    </td>
                                    <td>
                                        <%#Eval("Phone")%>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                        <tr>
                            <td colspan="4">
                                <input type="button" onclick="choiceReceive()" class="btn btn-success btn-sm" value="确定" />
                            </td>
                        </tr>
                    </table>
                </div>--%>
                <table cellpadding="0" cellspacing="0" id="Result" class="tabcolor">
                    <tr>
                        <th width="4%">全选
                        </th>
                        <th>序号
                        </th>
                        <th>商品名称
                        </th>
                        <th>单价
                        </th>
                        <th>数量
                        </th>
                        <th>总价
                        </th>
                        <%--<th>折后价
                        </th>--%>
                        <th>库存数量
                        </th>
                    </tr>
                </table>
                <div class="ui_table_control">
                    <em style="vertical-align: middle;">
                        <input type="checkbox" id="chkAll" onclick="SelectChk(this);" /></em>
                    <div class="pn">
                        <a href="javascript:void(0);" title="生成订单" onclick="choiceReceive()">生成订单</a>
                    </div>
                    <div class="pagebar">
                        <div id="Pagination">
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </div>
    <script type="text/javascript">
        var pageii;
        
        function showReceiveInfo() {
            if ($("#receiveDiv tr").length < 2) {
                v5.alert("您未添加收货人，请先添加收货人", '1', 'true', function () {
                    //跳转到收货人
                    callhtml('Shop/AddReceive.aspx?Auto=1', '收货人');
                });
                return;
            }
            pageii = layer.open({
                type: 1,
                shade: [0.5],
                area: ['auto', 'auto'],
                title: '选择收货人',
                border: [5, 0.3, '#000'],
                content: $('#receiveDiv')
            });
        }

        function choiceReceive() {
            var rid = "0";
            //layer.close(pageii);
            //var rid = $('input:radio:checked').val();
            //if (typeof (rid) == "undefined" || rid == "") {
            //    v5.alert("您未添加收货人，请在[收货人管理]中添加收货人", '3', 'true');
            //    return false;
            //}
            RunAjaxByListAddKeyShop('', 'SubmitOrder', ',', rid, function () { callhtml('Shop/OrderList.aspx', '订单列表'); });
        }
    </script>
</body>
</html>
