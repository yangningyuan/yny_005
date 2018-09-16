<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="yny_005.Web.Login" %>

<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <!-- Page title -->
    <title><%=WebModel.WebTitle %></title>
    <link rel="stylesheet" href="/login/css/style.css">
    <link rel="stylesheet" href="/login/css/body.css">


    <script type="text/javascript" src="/Admin/login/js/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="login/js/bootstrap.min.js"></script>
    <link href="plugin/layer/skin/layer.css" rel="stylesheet" type="text/css" />
    <script src="plugin/layer/layer.js" type="text/javascript"></script>
    <link rel="stylesheet" type="text/css" href="Admin/pop/css/V5-UI.css" />
    
    
    <script type="text/javascript" src="Admin/pop/js/javascript_main.js"></script>
    <script type="text/javascript" src="Admin/pop/js/ajax.js"></script>
    <script type="text/javascript" src="Admin/pop/js/javascript_pop.js"></script>
    <script type="text/javascript" src="Admin/pop/js/V5-UI.js"></script>
    <%--<script type="text/javascript" src="Admin/pop/js/uaredirect.js"></script>--%>
   
    <script type="text/javascript">
        function Login() {
            if ($("#username").val() == "") {
                v5.error('用户名不能为空', '1', 'true');
            } else if (pwd = $("#password").val() == "") {
                v5.error('密码不能为空', '1', 'true');
            } else {
                $.ajax({
                    type: "post",
                    url: "Login.aspx?type=login",
                    data: {
                        txtname: $("#username").val(), txtpwd: $("#password").val(), checkCode: $("#checkCode").val(), href: window.location.href
                    },
                    async: true,
                    success: function (data) {
                        switch (data) {
                            case "1":
                                v5.error('用户名不存在', '1', 'true');
                                break;
                            case "2":
                                v5.error('密码不正确', '1', 'true');
                                break;
                            //case "3":
                            //    v5.error('验证码错误', '1', 'true');
                            //    $("#imgcode").click();
                            //    break;
                            case "-1":
                                v5.error('限制登录', '1', 'true');
                                break;
                            case "0":
                                window.location.href = "/Default.aspx?type=pc";
                                break;
                            default:
                                if (data)
                                    v5.error(data, '1', 'true');
                                break;
                        }
                    }
                })
            }
            return false;
        }
        function keyLogin() {
            if (event.keyCode == 13)   //回车键的键值为13   
                Login();
        }
        function reset() {
            $("#username").val("");
            $("#password").val("");
        }
        $(function () {
            if (!placeholderSupport()) {   // 判断浏览器是否支持 placeholder
                $('[placeholder]').focus(function () {
                    var input = $(this);
                    if (input.val() == input.attr('placeholder')) {
                        input.val('');
                        input.removeClass('placeholder');
                    }
                }).blur(function () {
                    var input = $(this);
                    if (input.val() == '' || input.val() == input.attr('placeholder')) {
                        input.addClass('placeholder');
                        input.val(input.attr('placeholder'));
                    }
                }).blur();
            };
        })
        function placeholderSupport() {
            return 'placeholder' in document.createElement('input');
        }
    </script>

 
</head>
<body onkeydown="keyLogin();">
    <div class="container">
	<section id="content">
		<form  method="post" name="login" id="form1">
			<h1>会员登录</h1>
			<div>
				<input type="text" placeholder="账号" required="" id="username" />
			</div>
			<div>
				<input type="password" placeholder="密码" required="" id="password" />
			</div>
			 <div class="">
				<span class="help-block u-errormessage" id="js-server-helpinfo">&nbsp;</span>			</div> 
			<div>
				<!-- <input type="submit" value="Log in" /> -->
				<input type="button"  onclick="Login()" value="登录" class="btn btn-primary" id="js-btn-login"/>
				<a href="#">忘记密码?</a>
				<!-- <a href="#">Register</a> -->
			</div>
		</form><!-- form -->
		 <div class="button">
			<span class="help-block u-errormessage" id="js-server-helpinfo">&nbsp;</span>
			<%--<a href="#">下载网盘</a>--%>	
		</div> <!-- button -->
	</section><!-- content -->
</div>
<!-- container -->


<br><br><br><br>
<div style="text-align:center;">
<p>来源:More Templates <a href="javascript:void(0)" target="_blank" title=""><%=WebModel.WebTitle %></a> - </p>
</div>
</body>
</html>