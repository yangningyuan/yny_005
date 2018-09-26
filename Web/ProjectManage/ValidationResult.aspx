<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidationResult.aspx.cs" Inherits="yny_005.Web.ProjectManage.ValidationResult" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>验证结果审核</title>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
    <script>
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

    </script>
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
                            <b style="margin-left: 5%;">验证结果审核<span style="color:red;">（未审核）</span> </b>
                        </td>
                    </tr>
                      
                    <tr>
                        <td width="15%" align="right">单位名称
                        </td>
                        <td width="75%" style="height: 40px;">XX实验室
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">项目名称
                        </td>
                        <td width="75%" style="height: 40px;">测试项目
                        </td>
                    </tr>

                      <tr>
                        <td width="15%" align="right">参加检测子项
                        </td>
                        <td width="75%" style="height: 40px;">
                            <table class="layui-table">
                                <colgroup>
                                    <col width="150">
                                    <col width="200">
                                </colgroup>
                                <thead>
                                    <tr>
                                        <th> 检测子项名称</th>
                                        <th>结果1</th>
                                        <th>结果2</th>
                                        <th>平均结果</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>氮含量</td>
                                        <td>30</td>
                                        <td>20</td>
                                        <td>25</td>
                                    </tr>
                                    <tr>
                                        <td>氮含量</td>
                                         <td>30</td>
                                        <td>20</td>
                                        <td>25</td>
                                    </tr>
                                </tbody>
                            </table>
                          
                        </td>
                    </tr>

                   <tr>
                        <td width="15%" align="right">使用方法标准
                        </td>
                        <td width="75%" style="height: 40px;"><textarea id="Textarea2" type="text" class="normal_input" value="" runat="server" style="width: 20%; height:100px;" />
                        </td>
                    </tr>
                      <tr>
                        <td width="15%" align="right">仪器设备
                        </td>
                        <td width="75%" style="height: 40px;"><textarea id="Textarea1" type="text" class="normal_input" value="" runat="server" style="width: 20%; height:100px;" />
                        </td>
                    </tr>
                     <tr>
                        <td width="15%" align="right">异常现象
                        </td>
                        <td width="75%" style="height: 40px;"><textarea id="Text2" type="text" class="normal_input" value="" runat="server" style="width: 20%; height:100px;" />
                        </td>
                    </tr>
                  
                     
                     <tr>
                        <td align="right">上传结果凭证:
                        </td>
                        <td>
                            <input type="file" name="upload" class="layui-upload-file">
                            <input type="hidden" id="uploadurl" name="uploadurl" runat="server" />
                            <img id="upimage" width="100px;" height="100px" />
                        </td>
                    </tr>
                 
                  
                    <tr>
                        <td width="15%" align="right"></td>
                        <td width="75%" align="left">

                            <input type="button" class="normal_btnok" value="提交验证结果" onclick="checkChange();" />
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
                                    <tr>
                                        <td>作业指导书.doc</td>
                                        <td><a href="">下载</a> </td>
                                    </tr>
                                    <tr>
                                        <td>作业指导书.doc</td>
                                        <td><a href="">下载</a> </td>
                                    </tr>
                                </tbody>
                            </table>
                           
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>
</body>
</html>