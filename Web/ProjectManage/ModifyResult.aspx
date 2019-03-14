<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyResult.aspx.cs" Inherits="yny_005.Web.ProjectManage.ModifyResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="/Admin/css/bootstrap.min.css" rel="stylesheet" />
    <link href="/Admin/css/font-awesome.min.css" rel="stylesheet" />
    <link href="/Admin/css/style.css" rel="stylesheet" />
    <link href="/Admin/css/style-responsive.css" rel="stylesheet" />
    <link href="/Admin/css/reset.css" rel="stylesheet" />
    <link href="/Admin/css/main.css" rel="stylesheet" />
    <link href="/Admin/assets/font-awesome/css/font-awesome.css" rel="stylesheet" />
    <%--<script src="/Admin/js/jquery-1.8.3.min.js"></script>--%>
    <script type="text/javascript" src="/Admin/js/jquery-1.11.1.min.js"></script>
</head>
<body style="background: url();">

    <div>
        <div id="mempay" style="float: left; width: 100%;">
            <div id="finance" style="background-color: #EEEEEE;">
                <form id="form1" runat="server">
                    <input type="hidden" id="rid" name="rid" runat="server" />
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <td width="24%" align="right">序号
                            </td>
                            <td width="24%" style="height: 40px;">
                                <input id="Serial" class="normal_input" runat="server" style="width: 50%;" />
                            </td>
                        </tr>
                        <tr>
                            <td width="24%" align="right">分组
                            </td>
                            <td width="24%" style="height: 40px;">
                                <input id="Grouping" class="normal_input" runat="server" style="width: 50%;" />
                            </td>
                        </tr>
                        <tr>
                            <td width="24%" align="right">ZB
                            </td>
                            <td width="24%" style="height: 40px;">
                                <input id="ZB" class="normal_input" runat="server" style="width: 50%;" />
                            </td>
                        </tr>
                        <tr>
                            <td width="24%" align="right">Q1
                            </td>
                            <td width="24%" style="height: 40px;">
                                <input id="Q1" class="normal_input" runat="server" style="width: 50%;" />
                            </td>
                        </tr>
                        <tr>
                            <td width="24%" align="right">Q2
                            </td>
                            <td width="24%" style="height: 40px;">
                                <input id="Q2" class="normal_input" runat="server" style="width: 50%;" />
                            </td>
                        </tr>
                        <tr>
                            <td width="24%" align="right">IRQ
                            </td>
                            <td width="24%" style="height: 40px;">
                                <input id="IRQ" class="normal_input" runat="server" style="width: 50%;" />
                            </td>
                        </tr>
                        <tr>
                            <td width="24%" align="right">M
                            </td>
                            <td width="24%" style="height: 40px;">
                                <input id="M" class="normal_input" runat="server" style="width: 50%;" />
                            </td>
                        </tr>
                        <tr>
                            <td width="24%" align="right">NIRQ
                            </td>
                            <td width="24%" style="height: 40px;">
                                <input id="NIRQ" class="normal_input" runat="server" style="width: 50%;" />
                            </td>
                        </tr>
                        <tr>
                            <td width="24%" align="right">结果
                            </td>
                            <td width="24%">
                                <select id="ResultStatus" name="ResultStatus" runat="server">
                                    <option value=""></option>
                                    <option value="满意">满意</option>
                                    <option value="可疑">可疑</option>
                                    <option value="不满意">不满意</option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td width="24%" align="right"></td>
                            <td width="24%" align="left">
                                <input type="button" class="pay btn btn-success" value="修改" onclick="subaccChange();" />
                            </td>
                        </tr>
                        <tr></tr>
                        <tr></tr>
                    </table>
                </form>
            </div>
        </div>
    </div>
    <script src="/Admin/js/bootstrap.min.js"></script>
    <script src="/Admin/js/jquery.scrollTo.min.js"></script>
    <script src="/Admin/js/jquery.nicescroll.js"></script>
    <script src="/Admin/js/common-scripts.js"></script>

    <script src="/Admin/js/EPjs.js" type="text/javascript"></script>
    <link rel="stylesheet" type="text/css" href="/Admin/pop/css/pop.css" />
    <link rel="stylesheet" type="text/css" href="/Admin/pop/css/V5-UI.css" />
    <link rel="stylesheet" type="text/css" href="/Admin/pop/css/next_page_search.css" />
    <link rel="stylesheet" type="text/css" href="/plugin/layer/skin/layer.css" />
    <link rel="stylesheet" type="text/css" href="/plugin/kindeditor/themes/default/default.css" />
    <script type="text/javascript" src="/plugin/layer/layer.js"></script>
    <script type="text/javascript" src="/Admin/pop/js/MyValide.js"></script>
    <script type="text/javascript" src="/Admin/pop/js/TableToExcel.js"></script>
    <script type="text/javascript" src="/Admin/pop/js/linkage.js"></script>

    <link href="/plugin/layui/css/layui.css" rel="stylesheet" />
    <script src="/plugin/layui/layui.js"></script>
    <script type="text/javascript" src="/Shop/js/shopJs.js"></script>
    <%--<script type="text/javascript" src="Module/Investment/js/invest.js"></script>--%>
    <script type="text/javascript" src="/Admin/pop/js/javascript_main.js"></script>
    <script type="text/javascript" src="/Admin/pop/js/ajax.js"></script>
    <script type="text/javascript" src="/Admin/pop/js/javascript_pop.js"></script>
    <script type="text/javascript" src="/Admin/pop/js/V5-UI.js"></script>
    <script type="text/javascript" src="/Admin/pop/js/jquery.pagination.js" charset="gbk"></script>
    <script type="text/javascript" src="/plugin/date/WdatePicker.js"></script>
    <script type="text/javascript" src="/plugin/ZeroClipboard/ZeroClipboard.js"></script>
    <script type="text/javascript" src="/plugin/kindeditor/kindeditor-min.js"></script>
    <script src="/Admin/pop/js/jquery.qrcode.min.js"></script>
    <script>
        function subaccChange() {

            $.ajax({
                type: 'post',
                url: '/ProjectManage/ModifyResult.aspx?Action=Modify',
                data: $('#form1').serialize(),
                success: function (info) {
                    v5.alert(info, '1', 'true');
                    setTimeout(function () {
                        //window.parent.location.reload(); //刷新父页面
                        if (info == '修改成功') {
                            var index = parent.layer.getFrameIndex(window.name); //获取窗口索引
                            parent.layer.close(index);  // 关闭layer

                            setTimeout(function () {
                                parent.callhtml('/Car/AccountUPList.aspx', '付款单列表'); onclickMenu();
                            }, 1000);

                        }
                    }, 1000);
                }
            });
        }
    </script>
</body>
</html>
