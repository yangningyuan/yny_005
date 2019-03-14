<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="yny_005.Web.Member.Modify"
    EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/Javascript" src="/plugin/uploadify/jquery.uploadify.js"></script>
    <link type="text/css" href="/plugin/uploadify/uploadify.css" rel="stylesheet" />
    <title></title>
   
</head>
<body>
    <div id="mempay">
        <div id="finance">
            <form id="form1">
                <input id="hdBankCode" type="hidden" runat="server" />
                <table cellpadding="0" cellspacing="0">
                    <tr>
                        <td width="15%" align="right">用户名:
                        </td>
                        <td width="35%">
                            <input id="txtMID" runat="server" class="normal_input" type="text" readonly="readonly" />
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">实验室单位名称:
                        </td>
                        <td width="35%">
                            <input id="txtMName" maxlength="30" runat="server" class="normal_input" type="text" />
                        </td>
                    </tr>
                     <tr>
                        <td align="right">检验检测机构登记证件及号码:
                        </td>
                        <td>
                            <input id="txtNumID" name="txtNumID" runat="server" class="normal_input" type="text" maxlength="50" /> 
                            <select id="txtFMID" name="txtFMID"  runat="server">
                                <option value="0">检测机构登记证书</option>
                              <option value="1">个人身份证</option>
                                <option value="2">其他</option>
                            </select>
                        </td>
                    </tr>
                       <tr>
                        <td align="right">省份:
                        </td>
                        <td>
                            <input id="ddlProvince" name="ddlProvince" runat="server" class="normal_input" type="text" maxlength="50" /><span class="dotted" style="color: red;"></span>
                        </td>
                    </tr>
                      <tr>
                        <td align="right">市:
                        </td>
                        <td>
                            <input id="ddlCity" name="ddlCity" runat="server" class="normal_input" type="text" maxlength="50" /><span class="dotted" style="color: red;"></span>
                        </td>
                    </tr>
                      <tr>
                        <td align="right">县区:
                        </td>
                        <td>
                            <input id="ddlZone" name="ddlZone" runat="server" class="normal_input" type="text" maxlength="50" /><span class="dotted" style="color: red;"></span>
                        </td>
                    </tr>
                     <tr>
                        <td align="right">地址:
                        </td>
                        <td>
                            <input id="txtAddress" runat="server" name="txtAddress" class="normal_input" type="text" maxlength="50" />
                        </td>
                    </tr>
                      <tr>
                        <td align="right">邮编:
                        </td>
                        <td>
                            <input id="txtYouBian" runat="server" name="txtYouBian" class="normal_input" type="text" maxlength="50" />
                        </td>
                    </tr>
                        <tr>
                        <td align="right">联系人:
                        </td>
                        <td>
                            <input id="txtBankCardName"  runat="server" name="txtBankCardName" class="normal_input" type="text" maxlength="20" />
                            
                        </td>
                    </tr>
                     <tr>
                        <td align="right">电话:
                        </td>
                        <td>
                            <input id="txtTel" name="txtTel" runat="server" class="normal_input" type="text" maxlength="11" />
                            
                        </td>
                    </tr>
                  <tr>
                        <td align="right">传真:
                        </td>
                        <td>
                            <input id="txtQQ" name="txtQQ" runat="server" class="normal_input" type="text" maxlength="50" />
                            
                        </td>
                    </tr>
                  <tr>
                        <td align="right">电子邮件:
                        </td>
                        <td>
                            <input id="txtEmail" name="txtEmail" runat="server" class="normal_input" type="text" maxlength="50" />
                            
                        </td>
                    </tr>
                    <%
                        if(TModel.MID=="admin")
                        {
                            %>
                       <tr>
                        <td align="right">上传结果凭证:
                        </td>
                        <td>
                           <input id="fileOne<%=rdstr %>" type="file" capture="camera" class="">
                            <input id="btnOne" value="上传到服务器" type="button" style="display: none;" />
                            <canvas id="canvasOne" width="1200" height="1200" style="display: none;"></canvas>
                            <input id="DataUrl" type="text" style="display: none;" />
                            <img id="DataImg" src="<%=string.IsNullOrEmpty(TModel.QRCode)?"/MQL/images/_20180922122730.png":TModel.QRCode %>" style="width: 100px; height: 100px;" />
                            <input type="hidden" id="uploadurl" name="uploadurl" runat="server" />
                            <input runat="server" id="roam" style="display: none;" />
                        </td>
                    </tr>




                    <%
                        }
                         %>
                    
                   
                  
                    <tr style="height: 50px;">
                        <td align="right">
                            <input name="重置" type="reset" class="normal_btnok" value="重置" style="display: none;" />
                        </td>
                        <td align="left">
                            <input class="normal_btnok" id="btnOK" type="button" runat="server" value="提交" onclick="checkChange();" />
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>
    <script type="text/javascript">
       
        function checkChange() {
            if ($('#txtMName').val() == '') {
                v5.error('员工姓名不能为空', '1', 'true');
           
            } else {
                ActionModel("Member/Modify.aspx?Action=modify", $('#form1').serialize());
            }
        }
    </script>


    <%
        if (TModel.MID == "admin")
        {
            %>
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
    <script>
        //读取本地文件
        var inputOne = document.getElementById('fileOne<%=rdstr%>');
        inputOne.onchange = function () {
            //1.获取选中的文件列表
            var fileList = inputOne.files;
            var file = fileList[0];
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
    <%
        }
         %>

    
</body>
</html>
