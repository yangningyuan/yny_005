<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddResultDown.aspx.cs" Inherits="yny_005.Web.ProjectManage.AddResultDown" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>项目报告下载</title>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <%-- <script>
        layui.use("upload", function () {
            layui.upload({
                url: '/Admin/UpLoadPic/UploadImage.ashx',
                success: function (res) {
                    console.log(res); //上传成功返回值，必须为json格式
                    if (res.isSuccess) {
                        $("#upimage").attr("src", res.msg);
                        $("#uploadurl").val(res.msg);
                    } else {
                        v5.alert(res.msg, '1', 'true')
                    }
                }
            });
        });

    </script>--%>

    <!--引入uploadify-->
    <script type="text/Javascript" src="/plugin/uploadify/jquery.uploadify.js"></script>
    <link type="text/css" href="/plugin/uploadify/uploadify.css" rel="stylesheet" />

</head>
<body>
    <div id="mempay">
        <div id="finance">
            <form id="form1">
                <input type="hidden" id="oid" runat="server" />
                <table cellpadding="0" cellspacing="0">

                    <tr>
                        <td colspan="2">
                            <b style="margin-left: 5%;">项目信息</b>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">项目名称
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%= obj.ObjName %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">项目编号
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%= obj.ObjOID %>
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">说明
                        </td>
                        <td width="75%" style="height: 40px;">
                            <span><%= obj.Remark %></span>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">报名截止日期
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=obj.BMDate %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">项目结束日期
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=obj.JGDate %>
                        </td>
                    </tr>


                    <%
                        if (TModel.RoleCode != "Nomal")
                        {
                    %>
                    <tr>
                        <td width="15%" align="right">添加文档
                        </td>
                        <td width="75%" style="height: 40px;">

                            <table class="table table-bordered table-striped">
                                <tbody>
                                    <tr class="odd gradeC">
                                        <td style="text-align: left">
                                            <div id="fileQueue" class="fileQueue" style="width: 670px; height: 100px;"></div>
                                        </td>
                                        <td>
                                            <input type="hidden" id="excelValue" name="excelValue" value="" />
                                            <input type="file" name="file_upload" id="file_upload" /></td>
                                    </tr>
                                    <tr class="even gradeX">
                                        <td colspan="3">
                                            <p>
                                                <input type="button" class="btn btn-info" id="btnUpload" onclick="doUpload()" value="上传" />
                                            </p>
                                            <div id="div_show_files"></div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">
                            <div class="pay btn btn-warning" onclick="javascript:StackPop()">返回</div>
                        </td>
                        <td width="75%" align="left">

                            <input type="button" class="normal_btnok" value="上传文档" onclick="checkChange();" />
                        </td>
                    </tr>
                    <%
                        }
                    %>

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
                                        if (listDown != null)
                                        {
                                            int index = 0;
                                            foreach (var item in listDown)
                                            {
                                                index++;
                                    %>
                                    <tr>
                                        <td>报告<%=index %></td>
                                        <td><a href="<%=item %>">下载</a> </td>
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


    <script type="text/javascript">


        function checkChange() {
            ActionModel("ProjectManage/AddResultDown.aspx?Action=Add", $('#form1').serialize());
        }


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
                'queueSizeLimit': 999,                          //队列最多可上传文件数量，默认为999
                'auto': false,                                 //选择文件后是否自动上传，默认为true
                'multi': true,                                 //是否为多选，默认为true
                'removeCompleted': false,                       //是否完成后移除序列，默认为true
                'fileSizeLimit': '0',                          //单个文件大小，0为无限制，可接受KB,MB,GB等单位的字符串值
                'fileTypeDesc': 'All Files',                   //文件描述
                'fileTypeExts': '*.jpg;*.png;*.gif;*.bmp;*.txt;*.docx;*.xlsx',                         //上传的文件后缀过滤器
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


</body>
</html>
