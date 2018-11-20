<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="yny_005.Web.Admin.Index" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <!--	<link rel="Shortcut Icon" href="images/fac.ico" />-->
    <title><%=WebModel.WebTitle %></title>
    <link href="/Admin/pop/css/bootstrap.min.css" rel="stylesheet" />

    <%--<link rel="stylesheet" href="/admin/frame/layui/css/layui.css">--%>

    <link href="/plugin/layui/css/layui.css" rel="stylesheet" />


    <link rel="stylesheet" href="/admin/frame/static/css/style.css">
    <link rel="icon" href="/admin/frame/static/image/code.png">

    <script type="text/javascript" src="/Admin/pop/js/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="/Admin/pop/js/MyValide.js"></script>

</head>
<body>
    <div class="layui-layout layui-layout-admin">
        <!-- 添加skin-1类可手动修改主题为纯白，添加skin-2类可手动修改主题为蓝白 -->
        <!-- header -->
        <div class="layui-header my-header">
            <a href="index.html">
                <!--<img class="my-header-logo" src="" alt="logo">-->
                <div class="my-header-logo"><%=WebModel.WebTitle %> HTML</div>
            </a>
            <div class="my-header-btn">
                <button class="layui-btn layui-btn-small btn-nav"><i class="layui-icon">&#xe65f;</i></button>
            </div>

            <!-- 顶部左侧添加选项卡监听 -->
            <ul class="layui-nav" lay-filter="side-top-left">
                <!--<li class="layui-nav-item"><a href="javascript:;" href-url="demo/btn.html"><i class="layui-icon">&#xe621;</i>按钮</a></li>
            <li class="layui-nav-item">
                <a href="javascript:;"><i class="layui-icon">&#xe621;</i>基础</a>
                <dl class="layui-nav-child">
                    <dd><a href="javascript:;" href-url="demo/btn.html"><i class="layui-icon">&#xe621;</i>按钮</a></dd>
                    <dd><a href="javascript:;" href-url="demo/form.html"><i class="layui-icon">&#xe621;</i>表单</a></dd>
                </dl>
            </li>-->
            </ul>

            <!-- 顶部右侧添加选项卡监听 -->
            <ul class="layui-nav my-header-user-nav" lay-filter="side-top-right">
                <%--<li class="layui-nav-item"><a href="javascript:;" class="pay" href-url="">支持作者</a></li>--%>
                <li class="layui-nav-item">
                    <a class="name" href="javascript:;"><i class="layui-icon">&#xe629;</i>主题</a>
                    <dl class="layui-nav-child">
                        <dd data-skin="0"><a href="javascript:;">默认</a></dd>
                        <%-- <dd data-skin="1"><a href="javascript:;">纯白</a></dd>
                        <dd data-skin="2"><a href="javascript:;">蓝白</a></dd>--%>
                    </dl>
                </li>
                <li class="layui-nav-item">
                    <a class="name" href="javascript:;">
                        <img src="/admin/frame/static/image/code.png" alt="logo">
                        <%=WebModel.WebTitle %> </a>
                    <dl class="layui-nav-child">
                        <dd><a href="/SysManage/out.aspx"><i class="layui-icon">&#x1006;</i>退出</a></dd>
                    </dl>
                </li>
            </ul>

        </div>
        <!-- side -->
        <div class="layui-side my-side">
            <div class="layui-side-scroll">
                <!-- 左侧主菜单添加选项卡监听 -->
                <ul class="layui-nav layui-nav-tree" lay-filter="side-main">
                    <li class="layui-nav-item  layui-nav-itemed">
                        <a href="javascript:window.location.reload()"><i class="layui-icon">&#xe620;</i>首页</a>
                    </li>
                    <%foreach (yny_005.Model.RolePowers item in GetPowers("0"))
                        { %>
                    <li class="layui-nav-item">
                        <a href="javascript:void(0);" class=""><i class="<%=item.Content.CImage %>">&#xe628;</i><%=item.Content.CTitle %></a>
                        <dl class="layui-nav-child">
                            <%foreach (yny_005.Model.RolePowers item2 in GetPowers(item.CID))
                                { %>
                            <dd><a href="javascript:;" href="javascript:void(0)" onclick="callhtml('<%=item2.Content.CAddress %>','<%=item2.Content.CTitle %>');onclickMenu()"><i class="layui-icon">&#xe626;</i><%=item2.Content.CTitle %></a></dd>
                            <%} %>
                        </dl>
                    </li>
                    <%} %>
                </ul>
            </div>
        </div>
        <!-- body -->
        <div class="layui-body my-body">
            <input type="hidden" onclick="<%=Homebtn%>" id="Homebtn" />
            <%
                if (TModel.RoleCode == "Nomal")
                {

                }
            %>
            <div class="layui-tab layui-tab-card my-tab" lay-filter="card" lay-allowclose="true">
                <%
                    if (TModel.RoleCode == "Nomal")
                    {
                %>
                <ul class="layui-tab-title">
                    <li class="layui-this" lay-id="1"><span><i class="layui-icon">&#xe638;</i>欢迎页</span></li>
                </ul>
                <%
                    }
                %>

                <div class="layui-tab-content">


                    <div class="layui-tab-item layui-show">
                        <div class="layui-row layui-col-space10 my-index-main" style="padding: 10px; overflow: scroll; height: 780px;" id="main-content">

                            <%

                                if (TModel.RoleCode == "Nomal")
                                {
                            %>

                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/btn.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-btn-danger layui-icon">&#xe756;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip" onclick="callhtml('/Member/Modify.aspx','基本信息');onclickMenu()">修改实验室基本信息</p>
                                    </div>
                                </div>
                            </div>

                            <%
                                if (TModel.RoleCode == "Manage")
                                {
                            %>
                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/form.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-btn-warm layui-icon">&#xe735;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip" onclick="callhtml('/ProjectManage/MProjectList.aspx','M项目列表');onclickMenu()">正在进行的能力验证</p>
                                    </div>
                                </div>
                            </div>
                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/table.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-icon">&#xe715;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip" onclick="callhtml('/ProjectManage/ManageSHSignProjectList.aspx','M项目报名列表');onclickMenu()">能力验证报名</p>
                                    </div>
                                </div>
                            </div>
                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/tab-card.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-btn-normal layui-icon">&#xe705;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip" onclick="callhtml('/ProjectManage/MProjectList.aspx','项目列表');onclickMenu()">已完成的能力验证</p>
                                    </div>
                                </div>
                            </div>
                            <%
                                }
                                else {
                            %>
                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/form.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-btn-warm layui-icon">&#xe735;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip" onclick="callhtml('/ProjectManage/ProjectList.aspx','项目列表');onclickMenu()">正在进行的能力验证</p>
                                    </div>
                                </div>
                            </div>
                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/table.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-icon">&#xe715;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip" onclick="callhtml('/ProjectManage/SignProjectList.aspx','报名列表');onclickMenu()">能力验证报名</p>
                                    </div>
                                </div>
                            </div>
                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/tab-card.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-btn-normal layui-icon">&#xe705;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip" onclick="callhtml('/ProjectManage/ProjectList.aspx','项目列表');onclickMenu()">已完成的能力验证</p>
                                    </div>
                                </div>
                            </div>

                            <%
                                }
                            %>


                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/progress-bar.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-bg-cyan layui-icon">&#xe6b2;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip" onclick="callhtml('/Message/NoticeViewList.aspx','公告列表');onclickMenu()">新闻公告</p>
                                    </div>
                                </div>
                            </div>
                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/folding-panel.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-bg-black layui-icon">&#xe698;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip" onclick="callhtml('/SecurityCenter/ModifyPwd.aspx','登录密码修改');onclickMenu()">修改密码</p>
                                    </div>
                                </div>
                            </div>

                            <div class="layui-col-xs12 layui-col-sm6 layui-col-md6">
                                <div class="layui-collapse">
                                    <div class="layui-colla-item">
                                        <h2 class="layui-colla-title">基本统计</h2>
                                        <div class="layui-colla-content layui-show">
                                            <style>
                                                #showjiben span {
                                                    color: #009688;
                                                    font-size: 14px;
                                                    font-weight: bold;
                                                }
                                            </style>
                                            <table class="layui-table" id="showjiben">
                                                <colgroup>
                                                    <col width="200">
                                                    <col width="200">
                                                </colgroup>
                                                <thead>
                                                    <tr>
                                                        <th>已完成验证：<span><%=已完成验证 %></span>个</th>
                                                        <th>正在进行中：<span style="color: #000000;"><%=正在进行中 %></span>个</th>
                                                    </tr>
                                                    <tr>
                                                        <th>我的状态：<span><%=TModel.MState?"已审核":"未审核" %></span></th>
                                                        <th>样品已寄出：<span><%=样品已寄出 %></span>个</th>
                                                    </tr>
                                                    <tr>
                                                        <th>报名资格未通过：<span style="color: red;"><%=报名资格未通过 %></span>个</th>
                                                        <th>报名资格审核通过：<span><%=报名资格审核通过 %></span>个</th>
                                                    </tr>

                                                </thead>

                                            </table>

                                        </div>
                                    </div>
                                </div>
                            </div>

                            <%
                                if (TModel.RoleCode != "Nomal")
                                {
                            %>
                            <div class="layui-col-xs12 layui-col-sm6 layui-col-md6">
                                <div class="layui-collapse">
                                    <div class="layui-colla-item">
                                        <h2 class="layui-colla-title">项目概览</h2>
                                        <div class="layui-colla-content layui-show">

                                            <table class="layui-table">
                                                <colgroup>
                                                    <col width="150">
                                                    <col width="200">
                                                    <col>
                                                </colgroup>
                                                <thead>
                                                    <tr>
                                                        <th>部门</th>
                                                        <th>项目名称</th>
                                                        <th>报名截止日期</th>
                                                        <th>项目结束日期</th>
                                                        <th>查看</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <%
                                                        if (listObj != null)
                                                        {
                                                            foreach (var item in listObj)
                                                            {
                                                    %>
                                                    <tr>
                                                        <td><%=item.ObjName %></td>
                                                        <td><%=item.ReObjNiName %></td>
                                                        <td><%=item.BMDate %></td>
                                                        <td><%=item.JGDate %></td>
                                                        <td><a class="normal_btnok" href="javascript:void(0)" onclick="callhtml('/ProjectManage/ManageSHSignProjectList.aspx?bmoid=<%=item.ID %>', '报名列表'); onclickMenu()">报名列表</a><br />
                                                            <a class="normal_btnok" href="javascript:void(0)" onclick="callhtml('/ProjectManage/MSampleList.aspx?bmoid=<%=item.ID %>', '样品列表'); onclickMenu()">样品列表</a><br />
                                                            <a class="normal_btnok" href="javascript:void(0)" onclick="callhtml('/ProjectManage/MProjectList.aspx?bmoid=<%=item.ID %>', '结果验证列表'); onclickMenu()">结果验证列表</a>
                                                        </td>

                                                    </tr>
                                                    <%
                                                        }
                                                    %>

                                                    <%
                                                        }
                                                    %>
                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <%
                                }
                                else
                                {
                            %>
                            <div class="layui-col-xs12 layui-col-sm6 layui-col-md6">
                                <div class="layui-collapse">
                                    <div class="layui-colla-item">
                                        <h2 class="layui-colla-title">项目概览</h2>
                                        <div class="layui-colla-content layui-show">

                                            <table class="layui-table">
                                                <colgroup>
                                                    <col width="150">
                                                    <col width="200">
                                                    <col>
                                                </colgroup>
                                                <thead>
                                                    <tr>
                                                        <th>部门</th>
                                                        <th>项目名称</th>
                                                        <th>报名截止日期</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <%
                                                        if (listObj != null)
                                                        {
                                                            foreach (var item in listObj)
                                                            {
                                                    %>

                                                    <tr>
                                                        <td><%=item.ObjName %></td>
                                                        <td><%=item.ReObjNiName %></td>
                                                        <td><%=item.BMDate %></td>
                                                    </tr>
                                                    <%
                                                        }
                                                    %>

                                                    <%
                                                        }
                                                    %>
                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <%
                                }
                            %>

                            <%
                                }

                            %>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- footer -->
        <div class="layui-footer my-footer">
        </div>
    </div>

    <!-- pay -->
    <div class="my-pay-box none">
        <div>
            <img src="/admin/frame/static/image/zfb.png" alt="支付宝"><p>支付宝</p>
        </div>
        <div>
            <img src="/admin/frame/static/image/wx.png" alt="微信"><p>微信</p>
        </div>
    </div>

    <!-- 右键菜单 -->
    <div class="my-dblclick-box none">
        <table class="layui-tab dblclick-tab">
            <tr class="card-refresh">
                <td><i class="layui-icon">&#x1002;</i>刷新当前标签</td>
            </tr>
            <tr class="card-close">
                <td><i class="layui-icon">&#x1006;</i>关闭当前标签</td>
            </tr>
            <tr class="card-close-all">
                <td><i class="layui-icon">&#x1006;</i>关闭所有标签</td>
            </tr>
        </table>
    </div>

    <link rel="stylesheet" type="text/css" href="Admin/pop/css/pop.css" />
    <link rel="stylesheet" type="text/css" href="Admin/pop/css/V5-UI.css" />
    <link rel="stylesheet" type="text/css" href="Admin/pop/css/next_page_search.css" />
    <link rel="stylesheet" type="text/css" href="plugin/layer/skin/layer.css" />
    <link rel="stylesheet" type="text/css" href="plugin/kindeditor/themes/default/default.css" />
    <%--<script type="text/javascript" src="plugin/layer/layer.js"></script>--%>


    <script type="text/javascript" src="Admin/pop/js/MyValide.js"></script>
    <script type="text/javascript" src="Admin/pop/js/TableToExcel.js"></script>
    <script type="text/javascript" src="Admin/pop/js/linkage.js"></script>

    <script src="/plugin/layui/layui.js"></script>

    <script type="text/javascript" src="/admin/frame/static/js/vip_comm.js"></script>


    <script type="text/javascript" src="Admin/pop/js/javascript_main.js"></script>
    <script type="text/javascript" src="Admin/pop/js/ajax.js"></script>
    <script type="text/javascript" src="Admin/pop/js/javascript_pop.js"></script>
    <script type="text/javascript" src="Admin/pop/js/V5-UI.js"></script>
    <script type="text/javascript" src="Admin/pop/js/jquery.pagination.js" charset="gbk"></script>
    <script type="text/javascript" src="plugin/kindeditor/kindeditor-min.js"></script>
    <script src="/Admin/pop/js/jquery.qrcode.min.js"></script>

    <script type="text/javascript">
        

        KindEditor.ready(function (K) {
            window.KKKK = K;
        });
        function onclickMenu() {
            var width = $(window).width();
            if (width <= 768) {
                var className = document.getElementById("container").className;
                if (className == "") {
                    $(".tooltips").click();
                }
            }
        }
    </script>
    <script>
        $(function () {
            setTimeout(function () {
                $("#Homebtn").click();
            }, 100);
        });
    </script>
    <%--<iframe id='frameFile' name='frameFile' style='display: none;'></iframe>--%>
    <%--<script type="text/javascript" src="/admin/frame/layui/layui.js"></script>--%>
    <%-- <script type="text/javascript">
        layui.use(['layer', 'vip_nav'], function () {

            // 操作对象
            var layer = layui.layer
                , vipNav = layui.vip_nav
                , $ = layui.jquery;

            // 顶部左侧菜单生成 [请求地址,过滤ID,是否展开,携带参数]
            vipNav.top_left('/admin/json/nav_top_left.json', 'side-top-left', false);
            // 主体菜单生成 [请求地址,过滤ID,是否展开,携带参数]
            vipNav.main('/admin/json/nav_main.json', 'side-main', true);

            // you code ...
        });
    </script>--%>
</body>
</html>
