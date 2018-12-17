<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignProject.aspx.cs" Inherits="yny_005.Web.ProjectManage.SignProject" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>报名</title>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <script type="text/Javascript" src="/plugin/uploadify/jquery.uploadify.js"></script>
    <link type="text/css" href="/plugin/uploadify/uploadify.css" rel="stylesheet" />
</head>
<body>
    <div id="mempay">
        <div id="finance">
            <form id="form1">
                <input type="hidden" id="pid" runat="server" />
                <input type="hidden" id="oid" runat="server" />
                <table cellpadding="0" cellspacing="0">

                    <tr>
                        <td colspan="2">
                            <b style="margin-left: 5%;">项目信息</b>
                        </td>
                    </tr>
                    <%--   <tr>
                        <td width="15%" align="right">报名编号
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text6" class="normal_input" readonly="readonly" value="2018855677777777777" runat="server" style="width: 20%;" /><span style="color:red;"> *证书编号生成规则：项目编号+报名成功顺序号</span>
                        </td>
                    </tr>--%>
                    <tr>
                        <td width="15%" align="right">单位名称
                        </td>
                        <td width="75%" style="height: 40px;"><%=obj.ReObjNiName %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">验证项目
                        </td>
                        <td width="75%" style="height: 40px;"><%=obj.ObjName %>
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">选择参加检测子项<input type="hidden" id="ChildValue" runat="server"/>
                        </td>
                        <td width="75%" style="height: 40px;">
                            <table class="layui-table">
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
                                <tbody>
                                    <%
                                        if (listChild != null)
                                        {
                                            foreach (var item in listChild)
                                            {
                                    %>
                                    <tr>
                                        <td>
                                            <input type="checkbox" name="ChildID" value="<%=item.ID %>" /><%=item.ChildName %></td>
                                        <td><%=item.ChildValue %></td>
                                    </tr>
                                    <%
                                            }
                                        }
                                    %>
                                </tbody>
                            </table>

                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">证件
                        </td>
                        <td width="75%" style="height: 40px;"><%=!string.IsNullOrEmpty(TModel.FMID)? TModel.FMID.Replace("0","检测机构登记证书").Replace("1","个人身份证").Replace("2","其他"):"" %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">证件编号
                        </td>
                        <td width="75%" style="height: 40px;"><%=TModel.NumID %>
                        </td>
                    </tr>


                    <tr>
                        <td width="15%" align="right">联系人
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=TModel.BankCardName %>
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">联系电话
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=TModel.Tel %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">电子邮件
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=TModel.Email %>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">上传报名表图片:
                        </td>
                        <td>
                            <input id="fileOne<%=rdstr %>" type="file" capture="camera" class="">
                            <input id="btnOne" value="上传到服务器" type="button" style="display: none;" />
                            <canvas id="canvasOne" width="1200" height="1200" style="display: none;"></canvas>
                            <input id="DataUrl" type="text" style="display: none;" />
                            <img id="DataImg" src="/MQL/images/_20180922122730.png" style="width: 100px; height: 100px;" />
                            <input type="hidden" id="uploadurl" name="uploadurl" runat="server" />
                            <input runat="server" id="roam" style="display: none;" />
                            文件类型约束为：jpg，jpeg，png，gif，bmp 大小不超过多少600K
                        </td>
                    </tr>
                    <tr>
                        <td align="right">上传缴费凭证:
                        </td>
                        <td>
                            <input id="fileOne2<%=rdstr %>" type="file" capture="camera" class="">
                            <input id="btnOne2" value="上传到服务器" type="button" style="display: none;" />
                            <canvas id="canvasOne2" width="1200" height="1200" style="display: none;"></canvas>
                            <input id="DataUrl2" type="text" style="display: none;" />
                            <img id="DataImg2" src="/MQL/images/_20180922122730.png" style="width: 100px; height: 100px;" />
                            <input type="hidden" id="uploadurl2" name="uploadurl2" runat="server" />
                            <input runat="server" id="roam2" style="display: none;" />
                            文件类型约束为：jpg，jpeg，png，gif，bmp 大小不超过多少600K
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right"></td>
                        <td width="75%" align="left">

                            <input type="button" class="normal_btnok" value="提交报名表" onclick="checkChange();" />
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">文档
                        </td>
                        <td width="75%" style="height: 40px;">
                            <table class="layui-table">
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
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>
    <script>
       

        $(function () {
            var guid = '<%=Request["guid"] %>';
             var type = '<%=Request["type"] %>';
             if (guid == null || guid == "") {
                 guid = newGuid();
             }
             if (type != null) {
                 type = type + '/';
             }
             var returnImgUrl = "";
             $('#file_upload').uploadify({
                 'swf': '/plugin/uploadify/uploadify.swf',              //FLash文件路径
                 'buttonText': '浏  览',                        //按钮文本
                 'uploader': '/Admin/UpLoadPic/FileUpload.ashx?guid=' + guid, //处理ASHX页面
                 'formData': { 'folder': 'picture', 'isCover': 1 },         //传参数
                 'queueID': 'fileQueue',                        //队列的ID
                 'queueSizeLimit': 1,                          //队列最多可上传文件数量，默认为999
                 'auto': true,                                 //选择文件后是否自动上传，默认为true
                 'multi': true,                                 //是否为多选，默认为true
                 'removeCompleted': false,                       //是否完成后移除序列，默认为true
                 'fileSizeLimit': '1KB',                          //单个文件大小，0为无限制，可接受KB,MB,GB等单位的字符串值
                 'fileTypeDesc': 'All Files',                   //文件描述
                 'fileTypeExts': '*.jpg;*.png;*.gif;*.bmp',                         //上传的文件后缀过滤器
                 'onQueueComplete': function (queueData) {      //所有队列完成后事件
                     if (queueData.filesQueued > 0) {
                         //alert("上传完毕！");
                         $("#excelValue").val(returnImgUrl);
                         //alert(returnImgUrl);
                     }
                 },
                 'onError': function (event, queueId, fileObj, errorObj) {
                     alert(errorObj.type + "：" + errorObj.info);
                 },
                 'onUploadStart': function (file) {
                 },
                 'onUploadSuccess': function (file, data, response) {   //一个文件上传成功后的响应事件处理
                     // var data = $.parseJSON(data);//如果data是json格式
                     //var errMsg = "";
                     //	alert(file);
                     returnImgUrl += data;
                     // 	alert(returnImgUrl);
                     if ($.parseJSON(data) == 2) {
                         alert("目录UpLoadImg/Test不存在或名称不对！"); return false;
                     }
                 }

             });
         });

         function newGuid() {
             var guid = "";
             for (var i = 1; i <= 32; i++) {
                 var n = Math.floor(Math.random() * 16.0).toString(16);
                 guid += n;
                 if ((i == 8) || (i == 12) || (i == 16) || (i == 20))
                     guid += "-";
             }
             return guid;
         }

         //执行上传
         function doUpload() {
             $('#file_upload').uploadify('upload', '*');
         }
    </script>


    <script>
        //读取本地文件
        var inputOne = document.getElementById('fileOne<%=rdstr%>');
        inputOne.onchange = function () {
           
            //1.获取选中的文件列表
            var fileList = inputOne.files;
            var file = fileList[0];
           
            if (file.name == null || file.name == "") {
                v5.error('请选择文件', '1', 'ture');
                return;
            } else if (!/.(gif|jpeg|jpg|png|bmp)$/.test(file.name)) {
                v5.error('图片类型必须是.gif,jpeg,jpg,png,bmp中的一种', '1', 'ture');
                return ;
            }
            //设置限制图像的大小为10MB，这里你可以自己设置
            var fSize = 1024 * 1024 * 0.6;
            if (file.size > fSize) {
                v5.error('上传图片限制为600KB', '1', 'ture');
                return ;
            }

            //读取文件内容
            var reader = new FileReader();
            if (file) {
                reader.readAsDataURL(file);
            }
            reader.onload = function (e) {
                //将结果显示到canvas
                showCanvas(reader.result);
            }
        }

        var canvas = document.getElementById('canvasOne');
        var ctx = canvas.getContext('2d');
        //指定图片内容显示
        function showCanvas(dataUrl) {
            //$("#DataUrl").val(dataUrl);
          
            var c = document.getElementById("canvasOne");
            var cxt = c.getContext("2d");
            c.height = c.height;

            //加载图片
            var img = new Image();
            img.onload = function () {
                var imgwidth = img.width * 0.4;
                var imgheight = img.height * 0.4;
                c.height = imgheight;
                c.width = imgwidth;

                //缩小图片
                ctx.scale(0.4, 0.4);
                ctx.drawImage(img, 0, 0, img.width, img.height);
            }
            img.src = dataUrl;
           
            setTimeout(function () {
                upLoad();
            }, 300);
        }

        function upLoad() {
            var data = canvas.toDataURL('image/jpeg', 1);
            $("#DataUrl").val(data);
            document.getElementById("DataImg").src = data;
            $.ajax({
                type: "POST", //提交方式 
                url: "/Admin/UpLoadPic/upload.ashx",//路径 
                data: {
                    "address": data
                },//数据，这里使用的是Json格式进行传输 
                success: function (result) {//返回数据根据结果进行相应的处理 
                    $("#uploadurl").val(result);
                }
            });
        }
    </script>






    <script>
        $(function () {
            var guid = '<%=Request["guid"] %>';
             var type = '<%=Request["type"] %>';
             if (guid == null || guid == "") {
                 guid = newGuid();
             }
             if (type != null) {
                 type = type + '/';
             }
             var returnImgUrl2 = "";
             $('#file_upload').uploadify({
                 'swf': '/plugin/uploadify/uploadify.swf',              //FLash文件路径
                 'buttonText': '浏  览',                        //按钮文本
                 'uploader': '/Admin/UpLoadPic/FileUpload.ashx?guid=' + guid, //处理ASHX页面
                 'formData': { 'folder': 'picture', 'isCover': 1 },         //传参数
                 'queueID': 'fileQueue',                        //队列的ID
                 'queueSizeLimit': 1,                          //队列最多可上传文件数量，默认为999
                 'auto': true,                                 //选择文件后是否自动上传，默认为true
                 'multi': true,                                 //是否为多选，默认为true
                 'removeCompleted': false,                       //是否完成后移除序列，默认为true
                 'fileSizeLimit': '0',                          //单个文件大小，0为无限制，可接受KB,MB,GB等单位的字符串值
                 'fileTypeDesc': 'All Files',                   //文件描述
                 'fileTypeExts': '*.jpg;*.png;*.gif;*.bmp',                         //上传的文件后缀过滤器
                 'onQueueComplete': function (queueData) {      //所有队列完成后事件
                     if (queueData.filesQueued > 0) {
                         //alert("上传完毕！");
                         $("#excelValue").val(returnImgUrl2);
                         //alert(returnImgUrl);
                     }
                 },
                 'onError': function (event, queueId, fileObj, errorObj) {
                     alert(errorObj.type + "：" + errorObj.info);
                 },
                 'onUploadStart': function (file) {
                 },
                 'onUploadSuccess': function (file, data, response) {   //一个文件上传成功后的响应事件处理
                     // var data = $.parseJSON(data);//如果data是json格式
                     //var errMsg = "";
                     //	alert(file);
                     returnImgUrl2 += data;
                     // 	alert(returnImgUrl);
                     if ($.parseJSON(data) == 2) {
                         alert("目录UpLoadImg/Test不存在或名称不对！"); return false;
                     }
                 }

             });
         });



         //执行上传
         function doUpload() {
             $('#file_upload').uploadify('upload', '*');
         }
    </script>


    <script>
        //读取本地文件
        var inputOne2 = document.getElementById('fileOne2<%=rdstr%>');
        inputOne2.onchange = function () {
            //1.获取选中的文件列表
            var fileList = inputOne2.files;
            var file = fileList[0];

            if (file.name == null || file.name == "") {
                v5.error('请选择文件', '1', 'ture');
                return;
            } else if (!/.(gif|jpeg|jpg|png|bmp)$/.test(file.name)) {
                v5.error('图片类型必须是.gif,jpeg,jpg,png,bmp中的一种', '1', 'ture');
                return;
            }
            //设置限制图像的大小为10MB，这里你可以自己设置
            var fSize = 1024 * 1024 * 0.6;
            if (file.size > fSize) {
                v5.error('上传图片限制为600KB', '1', 'ture');
                return;
            }

            //读取文件内容
            var reader = new FileReader();
            if (file) {
                reader.readAsDataURL(file);
            }
            reader.onload = function (e) {
                //将结果显示到canvas
                showCanvas2(reader.result);
            }
        }

        var canvas2 = document.getElementById('canvasOne2');
        var ctx2 = canvas2.getContext('2d');
        //指定图片内容显示
        function showCanvas2(dataUrl) {
            //$("#DataUrl").val(dataUrl);

            var c2 = document.getElementById("canvasOne2");
            var cxt2 = c2.getContext("2d");
            c2.height = c2.height;

            //加载图片
            var img2 = new Image();
            img2.onload = function () {
                var imgwidth = img2.width * 0.4;
                var imgheight = img2.height * 0.4;
                c2.height = imgheight;
                c2.width = imgwidth;

                //缩小图片
                ctx2.scale(0.4, 0.4);
                ctx2.drawImage(img2, 0, 0, img2.width, img2.height);
            }
            img2.src = dataUrl;
            setTimeout(function () {
                upLoad2();
            }, 300);
        }

        function upLoad2() {
            var data = canvas2.toDataURL('image/jpeg', 1);
            $("#DataUrl2").val(data);
            document.getElementById("DataImg2").src = data;
            $.ajax({
                type: "POST", //提交方式 
                url: "/Admin/UpLoadPic/upload.ashx",//路径 
                data: {
                    "address": data
                },//数据，这里使用的是Json格式进行传输 
                success: function (result) {//返回数据根据结果进行相应的处理 
                    $("#uploadurl2").val(result);
                }
            });
        }
    </script>


    <script>
        function checkChange() {

            obj = document.getElementsByName("ChildID");
            check_val = [];
            for (k in obj) {
                if (obj[k].checked)
                    check_val.push(obj[k].value);
            }
            $("#ChildValue").val(check_val);
            if (check_val == "") {
                v5.error('请选择子项', '1', 'ture');
            } else if ($('#uploadurl').val() == "") {
                v5.error('请上传报名凭证', '1', 'ture');
            } else if ($('#uploadurl2').val() == "") {
                v5.error('请上传缴费凭证', '1', 'ture');
            } else {
                ActionModel("ProjectManage/SignProject.aspx?Action=Add", $('#form1').serialize());
            }
        }
    </script>
</body>
</html>
