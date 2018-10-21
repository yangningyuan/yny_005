<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProject.aspx.cs" Inherits="yny_005.Web.ProjectManage.AddProject" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>项目新增</title>
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
                <input type="hidden" id="fid" runat="server" />
                <input type="hidden" id="oid" runat="server" />
                <table cellpadding="0" cellspacing="0">

                    <tr>
                        <td colspan="2">
                            <b style="margin-left: 5%;">项目信息</b>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">部门
                        </td>
                        <td width="75%" style="height: 40px;">部门1
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">项目名称
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text2" class="normal_input" value="" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">项目编号
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text1" class="normal_input" value="" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">添加子项
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
                                <tbody id="SubDemo">
                                    <tr>
                                        <td><input id="SubTitle1" class="normal_input" value="" runat="server" style="width: 40%;" /></td>
                                        <td><input id="SubDetails1" class="normal_input" value="" runat="server" style="width: 40%;" /></td>
                                    </tr>
                                </tbody>
                            </table>
                            <input type="hidden" id="SubAddIndex" value="1" />
                            <div id="Div1" class="pay btn btn-success" onclick="SubAddHTML()">
                                添加子项
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">说明
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text3" class="normal_input" value="" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">报名截止日期
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text4" class="normal_input" value="" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">项目结束日期
                        </td>
                        <td width="75%" style="height: 40px;">
                            <input id="Text5" class="normal_input" value="" runat="server" style="width: 20%;" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">添加文档
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%-- <table class="layui-table">
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
                                    <tr>
                                        <td>作业指导书.doc</td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>作业指导书.doc</td>
                                        <td></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div id="Div1" class="pay btn btn-success" onclick="callhtml('/Member/Add.aspx','添加子项');onclickMenu()">
                                添加文档
                            </div>--%>

                            <table class="table table-bordered table-striped">
                                <tbody>

                                    <tr class="odd gradeC">
                                        <td style="text-align: left">
                                            <div id="fileQueue" class="fileQueue" style="width: 670px; height: 100px;"></div>

                                        </td>
                                        <td>
                                            <input type="file" name="file_upload" id="file_upload" /></td>
                                    </tr>

                                    <tr class="even gradeX">

                                        <td colspan="3">

                                            <p>
                                                <input type="button" class="btn btn-info" id="btnUpload" onclick="doUpload()" value="上传" />

                                                <%--<input type="button" class="btn btn-info" id="btnCancelUpload" onclick="$('#file_upload').uploadify('cancel')" value="取消" />--%>
                                            </p>
                                            <div id="div_show_files"></div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>



                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right"></td>
                        <td width="75%" align="left">

                            <input type="button" class="normal_btnok" value="提交处理" onclick="checkChange();" />
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>


    <script type="text/javascript">
        function SubAddHTML()
        {
            var index = $("#SubAddIndex").val();
            var useindex = parseInt(index) + 1;
            var str = "";
            str += "<tr>";
            str += "<td><input id='SubTitle" + useindex + "' style='height: 34px;padding: 6px;font-size: 14px;line-height: 1.42857143;color: #555;background-color: #fff;background-image: none;border: 1px solid #ccc;width: 40%;' value=''  /></td>";
            str += "<td><input id='SubDetails" + useindex + "'  style='height: 34px;padding: 6px;font-size: 14px;line-height: 1.42857143;color: #555;background-color: #fff;background-image: none;border: 1px solid #ccc;width: 40%;' value=''  /></td>";
            str += "</tr>";
            $("#SubDemo").append(str);
            $("#SubAddIndex").val(useindex);
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
