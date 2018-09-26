<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SampleList.aspx.cs" Inherits="yny_005.Web.ProjectManage.SampleList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript">
        //tUrl = "Member/Handler/MemberList.ashx";
        tState = "";
        SearchByCondition();
        //        setup();

        // 导出Excel
        function exportExcel() {
            ExportExcel("Car/Handler/ExportExcel.ashx", "DPLBExcel");
        }
        //setup();
    </script>
</head>
<body>
    <div id="mempay">
        <div class="control">
            <div class="cheeckbox" style="float: left;">
                 <table cellpadding="0" cellspacing="0">
                    <tr>
                       
                        <td>
                            <select id="IsClose" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">样品状态</option>
                                <option value="true">未寄送</option>
                                <option value="false">已寄送</option>
                                <option value="false">重新寄送</option>
                                <option value="false">已确认</option>
                            </select>
                        </td>
                        

                    </tr>
                </table>
            </div>

           

        </div>
        <div class="ui_table">
            <table cellpadding="0" cellspacing="0" id="Result" class="tabcolor">
                <tr>
                    <th width="50px">全选
                    </th>
                    <th>序号
                    </th>
                    <th>项目编号
                    </th>
                    <th>项目名称
                    </th>
                    <th>报名单位名称
                    </th>
                    <th>样品名称
                    </th>
                    <th>邮寄地址
                    </th>
                    <th>状态
                    </th>
                    <th>操作
                    </th>
                    

                </tr>
                  <td><em>
                        <input type="checkbox" id="chk_000" checked="checked" name="chkGroup" onclick="SelectChk(this);"></em></td>
                    <td>1&nbsp;</td>
                    <td>hnnj-2018-06</td>
                    <td>测试检测</td>
                    <td>xx实验</td>
                    <td>测试样品1</td>
                    <td>邮寄地址1邮寄地址1邮寄地址1</td>
                    <td>未寄送</td>
                    <td><a href=" javascript:callhtml('/ProjectManage/SendSample.aspx','寄送');onclickMenu();">寄送（会员方显示自己数据）</a>

                        <a href=" javascript:callhtml('ProjectManage/SampleCom.aspx?Id=000','样品确认')">审核（已寄送状态管理员操作）</a>
                    </td>
                </tr>
                   <tr onclick="trClick(this)">
                    <td><em>
                        <input type="checkbox" id="chk_000" checked="checked" name="chkGroup" onclick="SelectChk(this);"></em></td>
                    <td>1&nbsp;</td>
                    <td>hnnj-2018-06</td>
                    <td>测试检测</td>
                    <td>xx实验</td>
                    <td>测试样品1</td>
                    <td>邮寄地址1邮寄地址1邮寄地址1</td>
                    <td>未寄送</td>
                    <td><a href=" javascript:callhtml('/ProjectManage/SendSample.aspx','寄送');onclickMenu();">寄送（会员方显示自己数据）</a>

                        <a href=" javascript:callhtml('ProjectManage/SampleCom.aspx?Id=000','样品确认')">审核（已寄送状态管理员操作）</a>
                    </td>
                </tr>
            </table>
            <div class="ui_table_control">
                <em style="vertical-align: middle;">
                    <input type="checkbox" id="chkAll" onclick="SelectChk(this);" /></em>
                <div class="pn">
                      
                </div>
                <div class="pagebar">
                    <div id="Pagination">
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>