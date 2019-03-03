<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="yny_005.Web.Regedit.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>
        <%=WebModel.WebTitle%></title>

    <meta name="renderer" content="webkit" />
    <meta http-equiv="Cache-Control" content="no-siteapp" />
    <link rel="stylesheet" media="screen" href="css/css.css" />

    <link href="css/bootstrap.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="../plugin/kindeditor/themes/default/default.css" />
    <link href="../Admin/pop/css/pop.css" rel="stylesheet" type="text/css" />
    <link href="../Admin/pop/css/V5-UI.css" rel="stylesheet" type="text/css" />
    <script src="../Admin/js/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="/Admin/pop/js/MyValide.js"></script>
    <link href="../plugin/layer/skin/layer.css" rel="stylesheet" type="text/css" />
    <script src="../plugin/layer/layer.js" type="text/javascript"></script>
    <script src="../Admin/pop/js/ajax.js" type="text/javascript"></script>
    <script src="../Admin/pop/js/V5-UI.js" type="text/javascript"></script>
    <script src="../Admin/pop/js/javascript_pop.js" type="text/javascript"></script>
    <script type="text/javascript" src="../plugin/kindeditor/kindeditor-min.js"></script>
    <script type="text/javascript" src="../Admin/pop/js/linkage.js"></script>
    <script type="text/javascript">

        function placeholderSupport() {
            return 'placeholder' in document.createElement('input');
        }

        function sendTelCode() {
            var tel = $.trim($("#txtTel").val());
            if (tel == "") {
                v5.error('手机号码不能为空', '1', 'true');
                return false;
            }
            if (!tel.TryTel()) {
                v5.error('手机号格式不正确', '1', 'true');
                return false;
            }
            var relVal = GetAjaxString('SendCode', tel);
            v5.error(relVal, '1', 'true');
        }
    </script>
    <style>
        .rrrrcss {
            width: 100px;
            float: left;
            padding: 8px 8px;
            margin-top: 3px;
        }

            .rrrrcss span {
                float: right;
            }

        fieldset input {
            float: right;
        }
    </style>
</head>
<body>
    <form id="form1" class="msform">
        <!-- progressbar -->
        <ul id="progressbar">
        </ul>
        <fieldset>
            <h2 class="fs-title" style="font-size: 22px;">能力验证平台注册</h2>
            <h3 class="fs-subtitle"></h3>
            <div class="rrrrcss" style="margin-top: -2px;"><span>用户名：</span><span style="color: red; float: right;">*</span></div>
            <input type="text" name="txtMID" id="txtMID" placeholder="用户名" /><br />
            <div class="rrrrcss" style="margin-top: 8px;"><span>实验室：</span><span style="color: red; float: right;">*</span></div>
            <input type="text" name="txtMName" id="txtMName" placeholder="实验室单位名称" /><br />
            <div class="rrrrcss" style="margin-top: 10px;"><span>证书编号：</span><span style="color: red; float: right;">*</span></div>
            <input type="text" name="txtNumID" id="txtNumID" placeholder="检验检测机构计量认证证书编号" style="width: 162px;" />
            <select id="txtFMID" name="txtFMID">
                <option value="0">检验检测机构计量认证证书编号</option>
                <option value="1">个人身份证</option>
                <option value="2">其他</option>
            </select><br />

            <input type="text" id="txtRole" name="txtRole" style="display: none;" value="Nomal" /><br />


            <div class="rrrrcss" style="margin-top: 0px;"><span>省份：</span><span style="color: red; float: right;">*</span></div>
            <input type="text" id="ddlProvince" name="ddlProvince" placeholder="省份" /><br />
            <div class="rrrrcss" style="margin-top: 0px;"><span>市：</span><span style="color: red; float: right;">*</span></div>
            <input type="text" id="ddlCity" name="ddlCity" placeholder="市" /><br />
            <div class="rrrrcss" style="margin-top: 0px;"><span>县区：</span><span style="color: red; float: right;">*</span></div>
            <input type="text" id="ddlZone" name="ddlZone" placeholder="县区" /><br />

            <div class="rrrrcss" style="margin-top: 0px;"><span>地址：</span><span style="color: red; float: right;">*</span></div>
            <input type="text" id="txtAddress" name="txtAddress" placeholder="地址" /><br />
            <div class="rrrrcss" style="margin-top: 0px;"><span>邮编：</span><span style="color: red; float: right;">*</span></div>
            <input type="text" id="txtYouBian" name="txtYouBian" placeholder="邮编" /><br />
            <div class="rrrrcss" style="margin-top: 8px;"><span>联系人：</span><span style="color: red; float: right;">*</span></div>
            <input type="text" id="txtBankCardName" name="txtBankCardName" placeholder="联系人" /><br />
            <div class="rrrrcss" style="margin-top: 8px;"><span>电话：</span><span style="color: red; float: right;">*</span></div>
            <input type="text" name="txtTel" id="txtTel" placeholder="电话" /><br />
            <div class="rrrrcss" style="margin-top: 8px;"><span>传真：</span><span style="color: red; float: right;">*</span></div>
            <input type="text" name="txtQQ" id="txtQQ" placeholder="传真" /><br />
            <div class="rrrrcss" style="margin-top: 8px;"><span>电子邮件：</span><span style="color: red; float: right;">*</span></div>
            <input type="text" name="txtEmail" id="txtEmail" placeholder="电子邮件" /><br />
            <div class="rrrrcss" style="margin-top: 8px;"><span>登录密码：</span><span style="color: red; float: right;">*</span></div>
            <input type="password" name="txtPassword" id="txtPassword" placeholder="登录密码" /><br />
            <div class="rrrrcss" style="margin-top: 8px;"><span>确认密码：</span><span style="color: red; float: right;">*</span></div>
            <input type="password" name="txtPassword2" id="txtPassword2" placeholder="确认登录密码" /><br />

            <a href="/Login.aspx" style="float: left; margin-top: 18px;">已有账号？去登录</a>
            <input type="button" name="submit" class="submit action-button" value="注册" onclick="TestEmail()" style="float: right;" />
        </fieldset>
    </form>
    <script>
        function TestEmail() {
            if ($('#txtMID').val() == "") {
                v5.error('员工账号不能为空', '1', 'true');
                //} else if (!$('#txtMName').val().TryEN()) {
                //    v5.error('员工姓名只能输入两位以上的中文字符', '1', 'true');
            } else if ($('#txtTel').val() == "") {
                v5.error('手机号码格式不正确', '1', 'true');
                //} else if ($('#txtRole').val() == "") {
                //    v5.error('职务不能为空', '1', 'true');
                //} else if ($('#txtMTJ').val() == '') {
                //    v5.error('推荐员工帐号不能为空', '1', 'true');
                //} else if ($('#txtMBD').val() == '') {
                //    v5.error('接点员工不能为空', '1', 'true');
            } else if ($('#txtPassword').val() == "") {
                v5.error('登录密码不能为空，且必须为6-20位字母或数字组合', '1', 'true');

                //} else if ($('#txtAnswer').val() == "") {
                //    v5.error('密保答案用于找回密码，不能为空', '1', 'true');
                //} else if ($('#txtSecPsd').val() != $('#txtSecPsd2').val()) {
                //    v5.error('资金密码与确认资金密码不一样', '1', 'true');
                //} else if ($('#txtPassword').val() == $('#txtSecPsd').val()) {
                //    v5.error('资金密码与登录密码不能相同', '1', 'true');

                //} else if ($('#txtTelCode').val() == "") {
                //    v5.error("手机验证码不能为空", '1', 'true');
                //} else if ($('#ddlCity').val() == '地市') {
                //    v5.error('请选择开户地区', '1', 'true');
                //} else if ($('#txtBranch').val() == '') {
                //    v5.error('请输入开户支行', '1', 'true');
                //} else if (!$('#txtBankCardName').val().TryEN()) {
                //    v5.error('员工姓名只能输入两位以上的中文字符', '1', 'true');
                //} else if ($('#txtBankCardName').val() != $('#txtMName').val()) {
                //    v5.error('开户姓名必须与员工姓名一直', '1', 'true');
                //} else if (!$('#txtBankNumber').val().TryBankCard()) {
                //    v5.error('银行卡号只能是16或19位数字', '1', 'true');
                //} else if ($('#txtAnswer').val() == '') {
                //    v5.error('密保答案不能为空', '1', 'true');
            } else {
                $.ajax({
                    type: 'post',
                    url: '/AjaxM/Regedit.ashx?Action=add',
                    data: $('#form1').serialize(),
                    success: function (info) {
                        v5.alert(info, '1', 'true');
                        setTimeout(function () {
                            v5.clearall();
                            if (info == '注册成功') {
                                window.location.href = "/Login.aspx";
                            }
                        }, 1000);
                    }
                });
            }
        }

        //setup();
        //setTimeout(function () {
        //    $('#ddlProvince')[0].selectedIndex = 1;
        //    $('#ddlProvince').change();
        //    $('#ddlCity')[0].selectedIndex = 1;
        //    $('#ddlCity').change();
        //    $('#ddlZone')[0].selectedIndex = 1;
        //}, 50);
    </script>
</body>
</html>
