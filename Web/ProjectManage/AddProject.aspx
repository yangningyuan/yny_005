<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProject.aspx.cs" Inherits="yny_005.Web.ProjectManage.AddProject" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>项目新增</title>
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
                                <tbody>
                                    <tr>
                                        <td>氮含量</td>
                                        <td></td>
                                    </tr>
                                    <tr>
                                        <td>氮含量</td>
                                        <td></td>
                                    </tr>
                                </tbody>
                            </table>
                            <div id="Div1" class="pay btn btn-success" onclick="callhtml('/Member/Add.aspx','添加子项');onclickMenu()">
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

                            <div class="layui-upload">
                                <button type="button" class="layui-btn layui-btn-normal" id="testList">选择多文件</button>
                                <div class="layui-upload-list">
                                    <table class="layui-table">
                                        <thead>
                                            <tr>
                                                <th>文件名</th>
                                                <th>大小</th>
                                                <th>状态</th>
                                                <th>操作</th>
                                            </tr>
                                        </thead>
                                        <tbody id="demoList"></tbody>
                                    </table>
                                </div>
                                <button type="button" class="layui-btn" id="testListAction">开始上传</button>
                            </div>
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


    <script>
        layui.use('upload', function () {
            var $ = layui.jquery
            , upload = layui.upload;

            //普通图片上传
            var uploadInst = upload.render({
                elem: '#test1'
              , url: '/upload/'
              , before: function (obj) {
                  //预读本地文件示例，不支持ie8
                  obj.preview(function (index, file, result) {
                      $('#demo1').attr('src', result); //图片链接（base64）
                  });
              }
              , done: function (res) {
                  //如果上传失败
                  if (res.code > 0) {
                      return layer.msg('上传失败');
                  }
                  //上传成功
              }
              , error: function () {
                  //演示失败状态，并实现重传
                  var demoText = $('#demoText');
                  demoText.html('<span style="color: #FF5722;">上传失败</span> <a class="layui-btn layui-btn-xs demo-reload">重试</a>');
                  demoText.find('.demo-reload').on('click', function () {
                      uploadInst.upload();
                  });
              }
            });

            //多图片上传
            upload.render({
                elem: '#test2'
              , url: '/upload/'
              , multiple: true
              , before: function (obj) {
                  //预读本地文件示例，不支持ie8
                  obj.preview(function (index, file, result) {
                      $('#demo2').append('<img src="' + result + '" alt="' + file.name + '" class="layui-upload-img">')
                  });
              }
              , done: function (res) {
                  //上传完毕
              }
            });

            //指定允许上传的文件类型
            upload.render({
                elem: '#test3'
              , url: '/upload/'
              , accept: 'file' //普通文件
              , done: function (res) {
                  console.log(res)
              }
            });
            upload.render({ //允许上传的文件后缀
                elem: '#test4'
              , url: '/upload/'
              , accept: 'file' //普通文件
              , exts: 'zip|rar|7z' //只允许上传压缩文件
              , done: function (res) {
                  console.log(res)
              }
            });
            upload.render({
                elem: '#test5'
              , url: '/upload/'
              , accept: 'video' //视频
              , done: function (res) {
                  console.log(res)
              }
            });
            upload.render({
                elem: '#test6'
              , url: '/upload/'
              , accept: 'audio' //音频
              , done: function (res) {
                  console.log(res)
              }
            });

            //设定文件大小限制
            upload.render({
                elem: '#test7'
              , url: '/upload/'
              , size: 60 //限制文件大小，单位 KB
              , done: function (res) {
                  console.log(res)
              }
            });

            //同时绑定多个元素，并将属性设定在元素上
            upload.render({
                elem: '.demoMore'
              , before: function () {
                  layer.tips('接口地址：' + this.url, this.item, { tips: 1 });
              }
              , done: function (res, index, upload) {
                  var item = this.item;
                  console.log(item); //获取当前触发上传的元素，layui 2.1.0 新增
              }
            })

            //选完文件后不自动上传
            upload.render({
                elem: '#test8'
              , url: '/upload/'
              , auto: false
                //,multiple: true
              , bindAction: '#test9'
              , done: function (res) {
                  console.log(res)
              }
            });

            //拖拽上传
            upload.render({
                elem: '#test10'
              , url: '/upload/'
              , done: function (res) {
                  console.log(res)
              }
            });

            //多文件列表示例
            var demoListView = $('#demoList')
            , uploadListIns = upload.render({
                elem: '#testList'
              , url: '/upload/'
              , accept: 'file'
              , multiple: true
              , auto: false
              , bindAction: '#testListAction'
              , choose: function (obj) {
                  var files = this.files = obj.pushFile(); //将每次选择的文件追加到文件队列
                  //读取本地文件
                  obj.preview(function (index, file, result) {
                      var tr = $(['<tr id="upload-' + index + '">'
                        , '<td>' + file.name + '</td>'
                        , '<td>' + (file.size / 1014).toFixed(1) + 'kb</td>'
                        , '<td>等待上传</td>'
                        , '<td>'
                          , '<button class="layui-btn layui-btn-xs demo-reload layui-hide">重传</button>'
                          , '<button class="layui-btn layui-btn-xs layui-btn-danger demo-delete">删除</button>'
                        , '</td>'
                      , '</tr>'].join(''));

                      //单个重传
                      tr.find('.demo-reload').on('click', function () {
                          obj.upload(index, file);
                      });

                      //删除
                      tr.find('.demo-delete').on('click', function () {
                          delete files[index]; //删除对应的文件
                          tr.remove();
                          uploadListIns.config.elem.next()[0].value = ''; //清空 input file 值，以免删除后出现同名文件不可选
                      });

                      demoListView.append(tr);
                  });
              }
              , done: function (res, index, upload) {
                  if (res.code == 0) { //上传成功
                      var tr = demoListView.find('tr#upload-' + index)
                      , tds = tr.children();
                      tds.eq(2).html('<span style="color: #5FB878;">上传成功</span>');
                      tds.eq(3).html(''); //清空操作
                      return delete this.files[index]; //删除文件队列已经上传成功的文件
                  }
                  this.error(index, upload);
              }
              , error: function (index, upload) {
                  var tr = demoListView.find('tr#upload-' + index)
                  , tds = tr.children();
                  tds.eq(2).html('<span style="color: #FF5722;">上传失败</span>');
                  tds.eq(3).find('.demo-reload').removeClass('layui-hide'); //显示重传
              }
            });

            //绑定原始文件域
            upload.render({
                elem: '#test20'
              , url: '/upload/'
              , done: function (res) {
                  console.log(res)
              }
            });

        });
    </script>

</body>
</html>
