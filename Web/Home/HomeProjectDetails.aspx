<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeProjectDetails.aspx.cs" Inherits="yny_005.Web.Home.HomeProjectDetails" %>

<!DOCTYPE html>
<!--[if lt IE 7 ]><html class="ie ie6" lang="en"> <![endif]-->
<!--[if IE 7 ]><html class="ie ie7" lang="en"> <![endif]-->
<!--[if IE 8 ]><html class="ie ie8" lang="en"> <![endif]-->
<!--[if (gte IE 9)|!(IE)]><!-->
<html lang="en">
<!--<![endif]-->
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="description" content="News - Clean HTML5 and CSS3 responsive template">
    <meta name="author" content="MyPassion">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <title><%=WebModel.WebTitle %></title>
    <!-- STYLES -->
    <link rel="stylesheet" type="text/css" href="css/superfish.css" media="screen" />
    <link rel="stylesheet" type="text/css" href="css/fontello/fontello.css" />
    <link rel="stylesheet" type="text/css" href="css/flexslider.css" media="screen" />
    <link rel="stylesheet" type="text/css" href="css/ui.css" />
    <link rel="stylesheet" type="text/css" href="css/base.css" />
    <link rel="stylesheet" type="text/css" href="css/style.css" />
    <link rel="stylesheet" type="text/css" href="css/960.css" />
    <link rel="stylesheet" type="text/css" href="css/devices/1000.css" media="only screen and (min-width: 768px) and (max-width: 1000px)" />
    <link rel="stylesheet" type="text/css" href="css/devices/767.css" media="only screen and (min-width: 480px) and (max-width: 767px)" />
    <link rel="stylesheet" type="text/css" href="css/devices/479.css" media="only screen and (min-width: 200px) and (max-width: 479px)" />
    <link href='http://fonts.googleapis.com/css?family=Merriweather+Sans:400,300,700,800' rel='stylesheet' type='text/css'>
    <!--[if lt IE 9]> <script type="text/javascript" src="js/customM.js"></script> <![endif]-->
</head>
<body>
    <!-- Body Wrapper -->
    <div class="body-wrapper">
        <div class="controller">
            <div class="controller2">
                <!-- Header -->
                <header id="header">
                    <div class="container">
                        <div class="column">
                            <div class="logo">
                                <span style="font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif; font-size: 22px; font-weight: bold; color: #ea4748;">能力验证平台</span>
                            </div>
                            <div class="search" style="width:30px;">
                                <form action="" method="post">
                                    <input type="button" name="submit" class="submit action-button" value="返回" onclick="window.location.href = '/Home/Index.aspx'" style="float: right;">
                                </form>
                            </div>
                        </div>
                    </div>
                </header>
                <!-- /Header -->
                <!-- Content -->
                <section id="content">
                    <div class="container">
                        <!-- Main Content -->
                        <div class="main-content">
                            <!-- Single -->
                            <div class="column-two-third single" style="width: 920px;">
                                <div class="comments">
                                    <h5 class="line" style="width: 940px;"><span>验证项目详情介绍.</span></h5>
                                    <ul>
                                        <li>
                                            <div style="width: 919px;">
                                                <div class="comment-avatar">
                                                    <img src="img/avatar.png" alt="MyPassion">
                                                </div>
                                                <div class="commment-text-wrap">
                                                    <div class="comment-data">
                                                        <p>
                                                            <a href="#" class="url"><%=obj.ObjName %><span style="color: #ea4748;"> [<%=obj.ReObjNiName %>]</span></a>&nbsp;&nbsp;<a href="javascript:alert('请登录')" class="comment-reply-link">报名</a>
                                                            <br>
                                                            <span><%=obj.BMDate %> - <%=obj.JGDate %></span>
                                                        </p>
                                                    </div>
                                                    <div class="comment-text"><a href="#"></a></div>
                                                </div>
                                            </div>
                                        </li>

                                    </ul>

                                    <h3 style="border-bottom: 1px solid #ea4748; padding-bottom: 8px; margin-bottom: 10px; text-transform: uppercase;">项目说明.</h3>
                                    <div>
                                        <p><%=obj.Remark %></p>
                                    </div>

                                    <h3 style="border-bottom: 1px solid #ea4748; padding-bottom: 8px; margin-bottom: 10px; text-transform: uppercase;">项目子项.</h3>
                                    <div>
                                        <table class="layui-table table table-bordered table-striped table-white">
                                            <colgroup>
                                                <col width="150">
                                                <col width="200">
                                            </colgroup>
                                            <thead>
                                                <tr>
                                                    <th>检测子项名称</th>
                                                    <th>说明</th>
                                                </tr>
                                            </thead>
                                            <tbody id="SubDemo">


                                                  <%
                                            foreach (var item in listChild)
                                            {
                                                %>
                                     <tr>
                                         <td><%=item.ChildName %></td>
                                        <td><%=item.ChildValue %></td>
                                    </tr>
                                    <%
                                            }
                                             %>



                                            </tbody>
                                        </table>
                                    </div>

                                    <h3 style="border-bottom: 1px solid #ea4748; padding-bottom: 8px; margin-bottom: 10px; text-transform: uppercase;">文档下载.</h3>
                                    <div>
                                        <table class="layui-table table table-bordered table-striped table-white">
                                            <colgroup>
                                                <col width="150">
                                                <col width="200">
                                            </colgroup>
                                            <thead>
                                                <tr>
                                                    <th>文档名称</th>
                                                    <th>说明</th>

                                                </tr>
                                            </thead>
                                            <tbody>


                                               <%
                                        if (listExcel != null)
                                        {
                                            foreach (var item in listExcel)
                                            {
                                    %>
                                    <tr>
                                        <td><%=item.ExcelName %></td>
                                        <td><a href="<%=item.ExcelUrl %>">下载</a> </td>
                                    </tr>
                                    <%
                                            }
                                        }
                                    %>

                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <!-- /Single -->
                        </div>
                        <!-- /Main Content -->
                        <!-- Left Sidebar -->
                        <%--<div class="column-one-third">
							<div class="sidebar">
								<h5 class="line"><span>最新公告.</span></h5>
								<div id="accordion">

                                    <%
                                        foreach (var item in listNote)
                                        {
                                             Regex regex = new Regex("<.+?>", RegexOptions.IgnoreCase);
                                            string strOutput = regex.Replace(item.NContent, "");
                                            %>
                                    <h3><%=item.NTitle.Length>20?item.NTitle.Substring(0,20):item.NTitle %></h3>
									<div>
										<p><%=strOutput.Length>300?strOutput.Substring(0,300):strOutput %></p>
									</div>
                                    <%
                                        }
                                         %>
								</div>
							</div>
						</div>--%>
                        <!-- /Left Sidebar -->
                    </div>
                </section>
                <!-- / Content -->
            </div>
        </div>
    </div>
    <!-- / Body Wrapper -->
    <!-- SCRIPTS -->
    <script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="js/easing.min.js"></script>
    <script type="text/javascript" src="js/1.8.2.min.js"></script>
    <script type="text/javascript" src="js/ui.js"></script>
    <script type="text/javascript" src="js/carouFredSel.js"></script>
    <script type="text/javascript" src="js/superfish.js"></script>
    <script type="text/javascript" src="js/customM.js"></script>
    <script type="text/javascript" src="js/flexslider-min.js"></script>
    <script type="text/javascript" src="js/tweetable.js"></script>
    <script type="text/javascript" src="js/timeago.js"></script>
    <script type="text/javascript" src="js/jflickrfeed.min.js"></script>
    <script type="text/javascript" src="js/mobilemenu.js"></script>
    <!--[if lt IE 9]> <script type="text/javascript" src="js/html5.js"></script> <![endif]-->
    <script type="text/javascript" src="js/mypassion.js"></script>
</body>
</html>
