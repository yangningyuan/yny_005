<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PutZhengShu.aspx.cs" Inherits="yny_005.Web.ProjectManage.PutZhengShu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>打印证书</title>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />

</head>
<body>
    <div id="mempay">
        <div id="finance">
            <input type="hidden" id="oaid" runat="server" />
            <!--startprint-->
            <div style="border: 1px dashed  #808080; width: 600px; height: 470px; margin-top: 100px; margin-left: 120px;">
                <div style="text-align: center;">
                    <img src="<%=HardUrl %>" style="width: 190px; height: 160px; margin-top: 4px;" />
                </div>
                <div style="border: 0px solid #808080; text-align: center; padding: 5px;">
                    <h2 style="font-weight: bold;">能力验证满意实验室证书</h2>
                    <span style="color: red; margin-top: 7px; font-weight: bold; line-height: 2; margin-left: 20px;">编号：<%=obj.ZhengShuCode %>-<%=userapply.BMInt %></span>

                </div>
                <div style="width: 500px; margin-left: 50px;">
                    <span style="margin-left: 50px;"><%=obj.DanWeiName %>：</span><br />
                    <span style="margin-left: 120px;">你实验室参加 <u><%=obj.CreateDate.ToString("yyyy") %></u> 年度河南省质量技术监督局组织的<u> <%=obj.ObjName %> </u>能力验证项目，提交的测试为满意结果，特此证明。</span><br />
                    <br />
                    <br />
                    <span style="float: right;"><u><%=JGDate %></u></span><br />
                    <br />
                    <br />
                    <span style="text-align: center; margin-left: 150px;">河南省质量技术监督局制</span>
                </div>

                <br />
                <br />
                <br />

            </div>
            <!--endprint-->
            <div style="margin-left: 580px; margin-top: 10px;">
                <div class="pay btn btn-success" onclick="doPrint()">打印证书</div>
            </div>
        </div>
    </div>

    <script>
        function doPrint() {
            bdhtml = window.document.body.innerHTML;
            sprnstr = "<!--startprint-->"; //开始打印标识字符串有17个字符
            eprnstr = "<!--endprint-->"; //结束打印标识字符串
            prnhtml = bdhtml.substr(bdhtml.indexOf(sprnstr) + 17); //从开始打印标识之后的内容
            prnhtml = prnhtml.substring(0, prnhtml.indexOf(eprnstr)); //截取开始标识和结束标识之间的内容
            window.document.body.innerHTML = prnhtml; //把需要打印的指定内容赋给body.innerHTML
            window.print(); //调用浏览器的打印功能打印指定区域
            window.document.body.innerHTML = bdhtml; // 最后还原页面
        }
    </script>
</body>
</html>
