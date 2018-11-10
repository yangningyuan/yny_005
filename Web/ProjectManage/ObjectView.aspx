<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ObjectView.aspx.cs" Inherits="yny_005.Web.ProjectManage.ObjectView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>报名</title>
    <meta http-equiv="Content-Type" content="text/html;charset=utf-8" />

</head>
<body>
    <div id="mempay">
        <div id="finance">
            <form id="form1">
                <input type="hidden" id="uid" runat="server" />
                <input type="hidden" id="oid" runat="server" />
                <table cellpadding="0" cellspacing="0">
                    <tr>
                        <td colspan="2">
                            <b style="margin-left: 5%;">报名信息</b><span>(<%=oapply.SState.ToString().Replace("0","未审核").Replace("1","审核不通过").Replace("3","<span style='color:green;'>审核通过</span>") %>)</span>
                        </td>
                    </tr>
                       <tr>
                        <td width="15%" align="right">报名顺序号(未审核为0)
                        </td>
                        <td width="75%" style="height: 40px;">
                          <span style="color:red;"> <%=oapply.BMInt %></span>
                        </td>
                    </tr>
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
                        <td width="15%" align="right">参加检测子项<input type="hidden" id="ChildValue" runat="server" />
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
                                            <%=item.ChildName %></td>
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
                        <td width="75%" style="height: 40px;"><%=!string.IsNullOrEmpty(tmember.FMID)? tmember.FMID.Replace("0","检测机构登记证书").Replace("1","个人身份证").Replace("2","其他"):"" %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">证件编号
                        </td>
                        <td width="75%" style="height: 40px;"><%=tmember.NumID %>
                        </td>
                    </tr>


                    <tr>
                        <td width="15%" align="right">联系人
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=tmember.BankCardName %>
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right">联系电话
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=tmember.Tel %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">电子邮件
                        </td>
                        <td width="75%" style="height: 40px;">
                            <%=tmember.Email %>
                        </td>
                    </tr>
                    <tr>
                        <td align="right">报名表图片:
                        </td>
                        <td>
                            <a href="<%=oapply.BaoMingImgUrl %>" target="_blank">
                                <img id="DataImg" src="<%=oapply.BaoMingImgUrl %>" style="width: 100px; height: 100px;" />
                            </a>


                        </td>
                    </tr>
                    <tr>
                        <td align="right">报名表图片:
                        </td>
                        <td>
                            <a href="<%=oapply.FeiYongImgUrl %>" target="_blank">
                                <img id="DataImg2" src="<%=oapply.FeiYongImgUrl %>" style="width: 100px; height: 100px;" />
                            </a>
                        </td>
                    </tr>

                    <tr>
                        <td width="15%" align="right"></td>
                        <td width="75%" align="left"></td>
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

                    <%--样品--%>
                    <%
                        if (objsample != null)
                        {
                    %>
                    <tr>
                        <td colspan="2">
                            <b style="margin-left: 5%;">样品信息</b><span>(<%=objsample.SState.ToString().Replace("0","未寄送").Replace("1","已寄送").Replace("2","损坏").Replace("3","<span style='color:green;'>确认样品</span>") %>)</span>
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
                        <td width="15%" align="right">样品编号
                        </td>
                        <td width="75%" style="height: 40px;"><%=objsample.YangPinCode %>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">邮寄地址
                        </td>
                        <td width="75%" style="height: 40px;"><%=objsample.Spare%>
                        </td>
                    </tr>
                    <tr>
                        <td width="15%" align="right">样品确认图片
                        </td>
                        <td width="75%" style="height: 40px;"><a href="<%=objsample.YangPinImgUrl %>" target="_blank">
                            <img id="DataImg3" src="<%=objsample.YangPinImgUrl %>" style="width: 100px; height: 100px;" />
                        </a>
                        </td>
                    </tr>

                    <%
                        }
                    %>

                    <%--结果信息--%>
                    <%
                        if (objsubuser != null)
                        {
                    %>
                             <tr>
                        <td colspan="2">
                            <b style="margin-left: 5%;">结果信息</b><span>(<%=objsubuser.SState.ToString().Replace("0","未审核").Replace("1","审核不通过").Replace("3","<span style='color:green;'>审核已通过</span>") %>)</span>
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
                        <td width="15%" align="right">使用方法标准
                        </td>
                        <td width="75%" style="height: 40px;"><span> <%=objsubuser.RFangFa %></span>
                        </td>
                    </tr>
                      <tr>
                        <td width="15%" align="right">仪器设备
                        </td>
                        <td width="75%" style="height: 40px;"><span> <%=objsubuser.RSheBei %></span>
                        </td>
                    </tr>
                     <tr>
                        <td width="15%" align="right">异常现象
                        </td>
                        <td width="75%" style="height: 40px;"><span> <%=objsubuser.RYiChang %></span>
                        </td>
                    </tr>
                  
                    <tr>
                        <td width="15%" align="right">结果凭证
                        </td>
                        <td width="75%" style="height: 40px;"><a href="<%=objsubuser.ResultImgUrl %>" target="_blank">
                            <img id="DataImg5" src="<%=objsubuser.ResultImgUrl %>" style="width: 100px; height: 100px;" />
                        </a>
                        </td>
                    </tr>

                    <%
                        if (objsublist != null)
                        {
                            %>
                         <tr>
                        <td width="15%" align="right">参加检测子项
                        </td>
                        <td width="75%" style="height: 40px;">
                            <table class="layui-table">

                                <thead>
                                    <tr>
                                        <th>检测子项名称</th>
                                        <th>结果1</th>
                                        <th>结果2</th>
                                        <th>平均结果</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <%
                                        if (objsublist != null)
                                        {
                                            foreach (var item in objsublist)
                                            {
                                    %>
                                    <tr>
                                        <td>
                                            <%=item.Spare %></td>
                                        <td>
                                            <%=item.ResultOne %>
                                        </td>
                                        <td>
                                            <%=item.ResultTwo %>
                                        </td>
                                        <td>
                                            <%=item.ResultAvg %>
                                        </td>
                                    </tr>
                                    <%
                                            }
                                        }
                                    %>
                                </tbody>
                            </table>

                        </td>
                    </tr>
                    <%
                        }
                         %>
                    

                    <%
                        }
                    %>
                </table>
            </form>
        </div>
    </div>
</body>
</html>
