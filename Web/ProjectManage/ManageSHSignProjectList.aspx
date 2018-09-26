<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageSHSignProjectList.aspx.cs" Inherits="yny_005.Web.ProjectManage.ManageSHSignProjectList" %>

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
                                <option value="">报名状态</option>
                                <option value="true">报名已通过</option>
                                <option value="false">报名未通过</option>
                            </select>
                        </td>
                        

                    </tr>
                </table>
            </div>

           <div class="search" id="DivSearch" runat="server">
                <input type="button" value="查询" class="ssubmit" onclick="SearchByCondition()" />
                <%--<input type="button" value="从业人员信息管理报表" class="btn btn-success" onclick="exportExcel()" />--%>
                <input name="txtKey" data-name="txtKey" id="mKey" placeholder="单位名称" value="单位名称"
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
                    <th>报名单位名称
                    </th>
                    <th>报名日期
                    </th>
                    <th>报名费凭证
                    </th>
                    <th>状态
                    </th>
                    <th>操作
                    </th>
                    

                </tr>
                <tr onclick="trClick(this)">
                    <td><em>
                        <input type="checkbox" id="chk_000" checked="checked" name="chkGroup" onclick="SelectChk(this);"></em></td>
                    <td>1&nbsp;</td>
                    <td>hnnj-2018-06</td>
                    <td>测试检测</td>
                    <td>xx实验</td>
                    <td>2018-06-30</td>
                    <td><img src="" style="width:100px; height:100px;" /></td>
                    <td>成功</td>
                    <td><a href=" javascript:callhtml('/ProjectManage/AddProject.aspx','新增项目');onclickMenu();">详情</a></td>
                </tr>
                   <tr onclick="trClick(this)">
                    <td><em>
                        <input type="checkbox" id="chk_000" checked="checked" name="chkGroup" onclick="SelectChk(this);"></em></td>
                    <td>1&nbsp;</td>
                    <td>hnnj-2018-06</td>
                    <td>测试检测</td>
                    <td>xx实验</td>
                    <td>2018-06-30</td>
                    <td><img src="" style="width:100px; height:100px;" /></td>
                    <td>成功</td>
                    <td><a href=" javascript:callhtml('/ProjectManage/AddProject.aspx','新增项目');onclickMenu();">详情</a></td>
                </tr>
            </table>
            <div class="ui_table_control">
                <em style="vertical-align: middle;">
                    <input type="checkbox" id="chkAll" onclick="SelectChk(this);" /></em>
                <div class="pn">
                      <span id="DivOperation" runat="server"><a href="javascript:void(0);" title="激活" onclick="RunAjaxByList('false','ShMember',',');">
                        批量审核</a> </span>
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