<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="yny_005.Web.Manage.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
     <meta charset="UTF-8">
    <meta name="renderer" content="webkit">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <title><%=WebModel.WebTitle %></title>
    <link rel="stylesheet" href="/admin/frame/layui/css/layui.css">
    <link rel="stylesheet" href="/admin/frame/static/css/style.css">
    <link rel="icon" href="/admin/frame/static/image/code.png">



    <script src="../Admin/pop/js/ajax.js" type="text/javascript"></script>
    <script src="js/jquery-1.8.3.min.js" type="text/javascript"></script>
    <link href="../plugin/layer/skin/layer.css" rel="stylesheet" type="text/css" />
    <script src="../plugin/layer/layer.js" type="text/javascript"></script>
    <script src="../Admin/pop/js/V5-UI.js" type="text/javascript"></script>
    <script type="text/javascript">
        function Login() {
            if ($("#username").val() == "") {
                v5.error('用户不能为空', '1', 'true');
            } else if (pwd = $("#password").val() == "") {
                v5.error('密码不能为空', '1', 'true');
            } else {
                $.ajax({
                    type: "post",
                    url: "../Login.aspx?type=login",
                    data: {
                        txtname: $("#username").val(), txtpwd: $("#password").val(), href: window.location.href
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
                                window.location.href = "../Default.aspx";
                                break;
                            default:
                                if (data)
                                    v5.error(data, '1', 'true');
                                break;
                        }
                    }
                })
            }
        }

        function keyLogin() {
            if (event.keyCode == 13)   //回车键的键值为13   
                Login();
        }
        function reset() {
            $("#username").val("");
            $("#password").val("");
        }

     
    </script>
</head>

<body  class="login-body body">
    
    <div class="login-box">
        <form class="layui-form layui-form-pane" method="post"  id="form1">
            <div class="layui-form-item">
                <h3>后台登录系统</h3>
            </div>
            <div class="layui-form-item">
                <label class="layui-form-label">账号：</label>

                <div class="layui-input-inline">
                    <input type="text" name="username" id="username" class="layui-input" placeholder="账号"
                        autocomplete="on" maxlength="20" />
                </div>
            </div>
            <div class="layui-form-item">
                <label class="layui-form-label">密码：</label>

                <div class="layui-input-inline">
                    <input type="password" name="password" id="password" class="layui-input" placeholder="密码"
                        maxlength="20" />
                </div>
            </div>
           <%-- <div class="layui-form-item">
                <label class="layui-form-label">验证码：</label>

                <div class="layui-input-inline">
                    <input type="number" name="code" class="layui-input" lay-verify="code" placeholder="验证码" maxlength="4" /><img
                        src="../frame/static/image/v.png" alt="">
                </div>
            </div>--%>
            <div class="layui-form-item">
                <button type="reset" class="layui-btn layui-btn-danger btn-reset">重置</button>
                <button type="button" class="layui-btn btn-submit"  lay-filter="sub" onclick="Login()">立即登录</button>
            </div>
        </form>
    </div>
    <script type="text/javascript" src="/admin/frame/layui/layui.js"></script>
</body>
</html>
