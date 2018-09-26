<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageSumSignProjectList.aspx.cs" Inherits="yny_005.Web.ProjectManage.ManageSumSignProjectList" %>

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
               
            </div>

           <div class="search" id="DivSearch" runat="server">
                <input type="button" value="查询" class="ssubmit" onclick="SearchByCondition()" />
                <%--<input type="button" value="从业人员信息管理报表" class="btn btn-success" onclick="exportExcel()" />--%>
                <input name="txtKey" data-name="txtKey" id="mKey" placeholder="项目名称或编号" value="项目名称或编号"
                    onfocus="if (value =='账号'){value =''}" onblur="if (value ==''){value='账号'}"
                    type="text" class="sinput" style="width: 120px;" />
              
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
                    <th>报名截止日期
                    </th>
                    <th>项目发布日期
                    </th>
                    <th>项目结束日期
                    </th>
                    <th>已报名单位
                    </th>
                    <th>已审核单位
                    </th>
                    

                </tr>
                <tr onclick="trClick(this)">
                    <td><em>
                        <input type="checkbox" id="chk_000" checked="checked" name="chkGroup" onclick="SelectChk(this);"></em></td>
                    <td>1&nbsp;</td>
                    <td>hnnj-2018-06</td>
                    <td>测试检测</td>
                    <td>2017-08-09</td>
                    <td>2018-06-30</td>
                    <td>2018-06-30</td>
                    <td>256</td>
                    <td>256</td>
                </tr>
                <tr onclick="trClick(this)">
                    <td><em>
                        <input type="checkbox" id="chk_000" checked="checked" name="chkGroup" onclick="SelectChk(this);"></em></td>
                    <td>1&nbsp;</td>
                    <td>hnnj-2018-06</td>
                    <td>测试检测</td>
                    <td>2017-08-09</td>
                    <td>2018-06-30</td>
                    <td>2018-06-30</td>
                    <td>256</td>
                    <td>256</td>
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