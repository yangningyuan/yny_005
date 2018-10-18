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
                        <dd data-skin="1"><a href="javascript:;">纯白</a></dd>
                        <dd data-skin="2"><a href="javascript:;">蓝白</a></dd>
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
                  <%--  <li class="layui-nav-item  layui-nav-itemed">
                        <a href="javascript:;"><i class="layui-icon">&#xe620;</i>基础</a>
                        <dl class="layui-nav-child">
                            <dd><a href="javascript:;" href-url="demo/btn1.html"><i class="layui-icon">&#xe621;</i>按钮</a></dd>
                            <dd><a href="javascript:;" href-url="demo/form.html"><i class="layui-icon">&#xe621;</i>表单</a></dd>
                            <dd><a href="javascript:;" href-url="demo/table.html"><i class="layui-icon">&#xe621;</i>表格</a></dd>
                            <dd><a href="javascript:;" href-url="demo/tab-card.html"><i class="layui-icon">&#xe621;</i>选项卡</a></dd>
                            <dd><a href="javascript:;" href-url="demo/progress-bar.html"><i class="layui-icon">&#xe621;</i>进度条</a></dd>
                            <dd><a href="javascript:;" href-url="demo/folding-panel.html"><i class="layui-icon">&#xe621;</i>折叠面板</a></dd>
                            <dd><a href="javascript:;" href-url="demo/auxiliar.html"><i class="layui-icon">&#xe621;</i>辅助元素</a></dd>
                        </dl>
                    </li>
                    <li class="layui-nav-item">
                        <a href="javascript:;"><i class="layui-icon">&#xe628;</i>扩展</a>
                        <dl class="layui-nav-child">
                            <dd><a href="javascript:;" href-url="demo/login.html"><i class="layui-icon">&#xe621;</i>登录页</a></dd>
                            <dd><a href="javascript:;" href-url="demo/register.html"><i class="layui-icon">&#xe621;</i>注册页</a></dd>
                            <dd><a href="javascript:;" href-url="demo/login2.html"><i class="layui-icon">&#xe621;</i>登录页2</a></dd>
                            <dd><a href="javascript:;" href-url="demo/map.html"><i class="layui-icon">&#xe621;</i>图表</a></dd>
                            <dd><a href="javascript:;" href-url="demo/add-edit.html"><i class="layui-icon">&#xe621;</i>添加-修改</a></dd>
                            <dd><a href="javascript:;" href-url="demo/data-table.html"><i class="layui-icon">&#xe621;</i>data-table 表格页</a></dd>
                            <dd><a href="javascript:;" href-url="demo/tree-table.html"><i class="layui-icon">&#xe621;</i>Tree table树表格页</a></dd>
                            <dd><a href="javascript:;" href-url="demo/404.html"><i class="layui-icon">&#xe621;</i>404页</a></dd>
                            <dd><a href="javascript:;" href-url="demo/tips.html"><i class="layui-icon">&#xe621;</i>提示页</a></dd>
                        </dl>
                    </li>--%>
                    <%foreach (yny_005.Model.RolePowers item in GetPowers("0"))
                        { %>
                    <li class="layui-nav-item">
                        <a href="javascript:void(0);" class=""><i class="<%=item.Content.CImage %>">&#xe628;</i><%=item.Content.CTitle %></a>
                        <dl class="layui-nav-child">
                            <%foreach (yny_005.Model.RolePowers item2 in GetPowers(item.CID))
                                { %>
                            <dd><a href="javascript:;" href="javascript:void(0)"  onclick="callhtml('<%=item2.Content.CAddress %>','<%=item2.Content.CTitle %>');onclickMenu()"><i class="layui-icon">&#xe626;</i><%=item2.Content.CTitle %></a></dd>
                            <%} %>
                        </dl>
                    </li>
                    <%} %>
                </ul>
            </div>
        </div>
        <!-- body -->
        <div class="layui-body my-body">
            <div class="layui-tab layui-tab-card my-tab" lay-filter="card" lay-allowclose="true">
                <ul class="layui-tab-title">
                    <li class="layui-this" lay-id="1"><span><i class="layui-icon">&#xe638;</i>欢迎页</span></li>
                </ul>
                <div class="layui-tab-content">
                    <div class="layui-tab-item layui-show">
                        <div class="layui-row layui-col-space10 my-index-main" style="padding: 10px; overflow:scroll; height:780px;" id="main-content">
                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/btn.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-btn-danger layui-icon">&#xe756;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip">修改实验室基本信息</p>
                                    </div>
                                </div>
                            </div>
                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/form.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-btn-warm layui-icon">&#xe735;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip">正在进行的能力验证</p>
                                    </div>
                                </div>
                            </div>
                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/table.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-icon">&#xe715;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip">能力验证报名</p>
                                    </div>
                                </div>
                            </div>
                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/tab-card.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-btn-normal layui-icon">&#xe705;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip">已完成的能力验证</p>
                                    </div>
                                </div>
                            </div>
                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/progress-bar.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-bg-cyan layui-icon">&#xe6b2;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip">新闻公告</p>
                                    </div>
                                </div>
                            </div>
                            <div class="layui-col-xs4 layui-col-sm2 layui-col-md2">
                                <div class="my-nav-btn layui-clear" data-href="./demo/folding-panel.html">
                                    <div class="layui-col-md5">
                                        <button class="layui-btn layui-btn-big layui-bg-black layui-icon">&#xe698;</button>
                                    </div>
                                    <div class="layui-col-md7 tc">
                                        <p class="my-nav-text layui-elip">邮寄地址</p>
                                    </div>
                                </div>
                            </div>

                            <div class="layui-col-xs12 layui-col-sm6 layui-col-md6">
                                 <div class="layui-collapse">
                                    <div class="layui-colla-item">
                                        <h2 class="layui-colla-title">基本统计</h2>
                                        <div class="layui-colla-content layui-show">
                                            <style>
                                            #showjiben span{
                                            color:#009688;
                                            font-size:14px;
                                            font-weight:bold;
                                            }
                                            </style>
                                            <table class="layui-table" id="showjiben">
                                                <colgroup>
                                                    <col width="200">
                                                    <col width="200">
                                                </colgroup>
                                                <thead>
                                                    <tr>
                                                        <th>已完成验证：<span>40</span>个</th>
                                                        <th> 正在进行中：<span style="color:#000000;">40</span>个</th>
                                                    </tr>
                                                    <tr>
                                                        <th>我的状态：<span>已审核</span></th>
                                                        <th>验证通过：<span>40</span>个</th>
                                                    </tr>
                                                    <tr>
                                                        <th>样品已寄出：<span>40</span>个</th>
                                                        <th>报名资格审核通过：<span>40</span>个</th>
                                                    </tr>
                                                    <tr>
                                                        <th>报名资格未通过：<span style="color:red;">40</span>个</th>
                                                        <th>通知未读：<span style="color:red;">40</span>个</th>
                                                    </tr>
                                                </thead>
                                               
                                            </table>

                                        </div>
                                    </div>
                                </div>
                            </div>
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
                                                    <tr>
                                                        <td>一部门</td>
                                                        <td>测试验证项目1</td>
                                                        <td>2016-11-29</td>
                                                    </tr>
                                                    <tr>
                                                        <td>二部门</td>
                                                        <td>测试验证项目1测试验证项目1测试验证项目1测试验证项目1…</td>
                                                        <td>2016-11-28</td>
                                                    </tr>
                                                </tbody>
                                            </table>

                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class="layui-col-xs12 layui-col-sm6 layui-col-md4" style="display:none;">
                                <div class="layui-collapse">
                                    <div class="layui-colla-item">
                                        <h2 class="layui-colla-title">版本</h2>
                                        <div class="layui-colla-content layui-show">

                                            <ul class="layui-timeline max-auto">
                                                <li class="layui-timeline-item">
                                                    <i class="layui-icon layui-timeline-axis">&#xe63f;</i>
                                                    <div class="layui-timeline-content layui-text">
                                                        <h3 class="layui-timeline-title">v1.8.0</h3>
                                                        <p>
                                                            更新日期:2017-08-26
                                                        </p>
                                                        <ul>
                                                            <li>更新layui-v1.0.9为layui-v2.0.2版本</li>
                                                            <li>右键增加关闭全部标签按钮</li>
                                                            <li>更新欢迎页面</li>
                                                            <li>更新data-table页面和tree-table页面为layui自带table组件</li>
                                                            <li>
                                                                <h4>新增js功能</h4>
                                                                <ul>
                                                                    <li>
                                                                        <p>vip_table.js</p>
                                                                        <ul>
                                                                            <li>getFullHeight方法  getFullHeight();    // 返回子页面整体高度,用于table组件设置全屏高度</li>
                                                                        </ul>
                                                                    </li>
                                                                </ul>
                                                            </li>
                                                            <li>修改已知BUG</li>
                                                        </ul>
                                                    </div>
                                                </li>
                                                <li class="layui-timeline-item">
                                                    <i class="layui-icon layui-timeline-axis">&#xe63f;</i>
                                                    <div class="layui-timeline-content layui-text">
                                                        <h3 class="layui-timeline-title">v1.7.0</h3>
                                                        <p>更新时间:2017-05-21</p>
                                                        <ul>
                                                            <li>优化主题样式细节</li>
                                                            <li>标签新增双击关闭当前标签功能</li>
                                                            <li>标签新增右键功能</li>
                                                            <li>
                                                                <h5>新增js功能。   详细可查看【frame/static/js】文件夹内的js</h5>
                                                                <ul>
                                                                    <li>
                                                                        <h4>vip_nav.js 【主页菜单js】</h4>
                                                                        <ul>
                                                                            <li>main方法       main(请求地址,过滤ID,是否展开,携带参数);</li>
                                                                            <li>top_left方法   top_left(请求地址,过滤ID,是否展开,携带参数);</li>
                                                                        </ul>
                                                                    </li>
                                                                    <li>
                                                                        <h4>vip_tab.js 【子页面操作父页面选项卡js】</h4>
                                                                        <ul>
                                                                            <li>add方法            add(操作对象，标签标题，url地址);</li>
                                                                            <li>getThisTabId方法   getThisTabId();     // 返回当前展示页面父级窗口标签的lay-id</li>
                                                                            <li>del方法            del(标签lay-id);</li>
                                                                        </ul>
                                                                    </li>
                                                                    <li>
                                                                        <h4>vip_table.js 【表格js,该js属于整合】</h4>
                                                                        <ul>
                                                                            <li>deleteAll方法      deleteAll(ids,请求的url,操作成功跳转url,操作失败跳转url);</li>
                                                                            <li>unixToDate方法     unixToDate(时间戳,是否只显示年月日时分,8);        // 返回正常时间</li>
                                                                            <li>getIds方法         getIds(表格对象,每条数据的属性id);      // 返回需要的 ids</li>
                                                                        </ul>
                                                                    </li>
                                                                </ul>
                                                            </li>
                                                            <li>修改已知BUG。</li>
                                                        </ul>
                                                    </div>
                                                </li>
                                                <li class="layui-timeline-item">
                                                    <i class="layui-icon layui-timeline-axis">&#xe63f;</i>
                                                    <div class="layui-timeline-content layui-text">
                                                        <h3 class="layui-timeline-title">v1.6.0</h3>
                                                        <p>更新时间:2017-04-25</p>
                                                        <ul>
                                                            <li>优化CSS、JS</li>
                                                            <li>新增新的登录、注册页面</li>
                                                            <li>新增主题功能，提供默认、纯白、蓝白三种主题配置</li>
                                                            <li>导航栏添加图标</li>
                                                            <li>修改已知BUG</li>
                                                        </ul>
                                                    </div>
                                                </li>
                                                <li class="layui-timeline-item">
                                                    <i class="layui-icon layui-timeline-axis">&#xe63f;</i>
                                                    <div class="layui-timeline-content layui-text">
                                                        <h3 class="layui-timeline-title">v1.5.1</h3>
                                                        <p>更新时间:2017-03-21</p>
                                                        <ul>
                                                            <li>修改浏览器窗口resize时不断闪烁BUG。  感谢：Clannad-</li>
                                                        </ul>
                                                    </div>
                                                </li>
                                                <li class="layui-timeline-item">
                                                    <i class="layui-icon layui-timeline-axis">&#xe63f;</i>
                                                    <div class="layui-timeline-content layui-text">
                                                        <h3 class="layui-timeline-title">v1.5.0</h3>
                                                        <p>更新时间:2017-03-20</p>
                                                        <ul>
                                                            <li>更新layui框架为最新版1.0.9_rts版本</li>
                                                            <li>优化css,样式更加接近vip-admin管理系统v1.0.5</li>
                                                            <li>新增效果：导航栏点击栏目右侧添加相应tab选项卡,点击已经生成过的选项卡直接跳转到该选选项卡</li>
                                                            <li>新增导航栏收缩按钮</li>
                                                            <li>修改已知BUG</li>
                                                        </ul>
                                                    </div>
                                                </li>
                                                <li class="layui-timeline-item">
                                                    <i class="layui-icon layui-timeline-axis">&#xe63f;</i>
                                                    <div class="layui-timeline-content layui-text">
                                                        <h3 class="layui-timeline-title">1.1.0</h3>
                                                        <p>更新时间:2017-02-27</p>
                                                        <ul>
                                                            <li>登录页面添加头部标题</li>
                                                            <li>新增tree table 页面</li>
                                                            <li>新增404页面</li>
                                                            <li>新增tips提示页面</li>
                                                            <li>
                                                                <h4>js功能: 具体操作请查看 js/table-tool.js</h4>
                                                                <ul>
                                                                    <li>getIds(table对象,获取input为id的属性);</li>
                                                                    <li>deleteAll(ids,请求url,操作成功跳转url,操作失败跳转url);</li>
                                                                    <li>UnixToDate(时间戳,显示年月日时分,加8小时显示正常时间区);</li>
                                                                </ul>
                                                            </li>
                                                            <li>该版本已兼容手机浏览</li>
                                                            <li>修改已知BUG</li>
                                                        </ul>
                                                    </div>
                                                </li>
                                                <li class="layui-timeline-item">
                                                    <i class="layui-icon layui-timeline-axis">&#xe63f;</i>
                                                    <div class="layui-timeline-content layui-text">
                                                        <h3 class="layui-timeline-title">v1.0.1</h3>
                                                        <p>更新时间:2017-02-16</p>
                                                        <ul>
                                                            <li>优化datatables表格，添加排序图标，点击升序降序更加美观；表格全选优化，全选后所有选中项添加背景颜色，使之选中更加明显</li>
                                                            <li>添加echearts图表插件，展示了基本的柱状图和饼图示例</li>
                                                        </ul>
                                                    </div>
                                                </li>
                                                <li class="layui-timeline-item">
                                                    <i class="layui-icon layui-timeline-axis">&#xe63f;</i>
                                                    <div class="layui-timeline-content layui-text">
                                                        <h3 class="layui-timeline-title">v1.0.0</h3>
                                                        <p>更新时间:2017-01-06</p>
                                                        <ul>
                                                            <li>该模板最大化保留了原生layui的基础样式，整合行成的一套后台模板</li>
                                                            <li>该模板集合了layui插件、datatables插件</li>
                                                            <li>该模板使用layui基础样式中的按钮、表单、表格、和选项卡</li>
                                                            <li>datatables表格和layui表格深度整合，使用更加方便、美观、人性化</li>
                                                            <li>扩展了欢迎页面、登录页面</li>
                                                        </ul>
                                                    </div>
                                                </li>
                                                <li class="layui-timeline-item">
                                                    <i class="layui-icon layui-timeline-axis">&#xe63f;</i>
                                                    <div class="layui-timeline-content layui-text">
                                                        <div class="layui-timeline-title">开始于2017年01月06日</div>
                                                    </div>
                                                </li>
                                            </ul>

                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="layui-col-xs12 layui-col-sm6 layui-col-md4"  style="display:none;">
                                <div class="layui-collapse">
                                    <div class="layui-colla-item">
                                        <h2 class="layui-colla-title">图表</h2>
                                        <div class="layui-colla-content layui-show">

                                            <div id="main-line" style="height: 450px;"></div>

                                        </div>
                                    </div>
                                </div>
                            </div>
                           
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
    <%--<iframe id='frameFile' name='frameFile' style='display: none;'></iframe>--%>
    <%--<script type="text/javascript" src="/admin/frame/layui/layui.js"></script>--%>
    <script type="text/javascript" src="/admin/frame/static/js/vip_comm.js"></script>
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
