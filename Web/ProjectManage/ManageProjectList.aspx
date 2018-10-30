﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageProjectList.aspx.cs" Inherits="yny_005.Web.ProjectManage.ManageProjectList" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript">
        tState = '';
        tUrl = "ProjectManage/Handler/ManageProjectList.ashx";
        SearchByCondition();
    </script>
</head>
<body>
    <div id="mempay">
        <div class="control">
           <%-- <div class="select">
                <a href="javascript:void(0)" onclick="SearchByState('',this);" class="btn btn-danger">
                    所有</a> <a href="javascript:void(0);" onclick="SearchByState('1',this);" class="btn btn-success">
                        正常</a> <a href="javascript:void(0)" onclick="SearchByState('0',this);" class="btn btn-success">
                            已作废</a>
            </div>--%>
            <%--<div class="pay" onclick="UpDateByID('Message/NoticeModify.aspx?','修改公告',900,470);">
                修改项目</div>--%>
            <div class="pay" onclick="v5.show('ProjectManage/AddProject.aspx','发布项目','url',900,470)">
                发布项目</div>
            <div class="search" id="DivSearch" runat="server">
                <input type="button" value="查询" class="ssubmit" onclick="SearchByCondition()" /><input
                    id="nTitle" name="txtKey" data-name="txtKey"  type="text" class="sinput" />
            </div>
        </div>
        <div class="ui_table">
            <table cellpadding="0" cellspacing="0" class="tabcolor" id="Result">
                <tr>
                    <th width="50px">
                        全选
                    </th>
                    <th>
                        编号
                    </th>
                     <th>
                        项目编号
                    </th>
                    <th>
                        项目名称
                    </th>
                    <th>
                        发布人
                    </th>
                    <th>
                        部门全称
                    </th>
                    <th>
                        报名截止时间
                    </th>
                    <th>
                        项目结束时间
                    </th>
                    <th>
                        备注
                    </th>
                    <th>
                        发布时间
                    </th>
                    <th>
                        操作
                    </th>
                </tr>
            </table>
            <div class="ui_table_control">
                <em style="vertical-align: middle;">
                    <input type="checkbox" id="chkAll" onclick="SelectChk(this);" /></em>
               <%-- <div class="pn">
                    <a href="javascript:void(0);" title="" onclick="RunAjaxByList('0','ShowNotice',',');">
                        恢复</a> <a href="javascript:void(0);" title="" onclick="RunAjaxByList('1','HideNotice',',');">
                            作废</a> <a href="javascript:void(0);" title="" onclick="RunAjaxByList('','Del_Notice',',');">
                                删除</a>
                </div>--%>
                <div class="pagebar">
                    <div id="Pagination">
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>