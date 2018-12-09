<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OperationRecord.aspx.cs" Inherits="yny_005.Web.SysManage.OperationRecord" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript">
        tUrl = "SysManage/Handler/OperationRecord.ashx";
        tState = "";
        SearchByCondition();


        layui.use('laydate', function () {
            var laydate = layui.laydate;
            //日期时间选择器
            laydate.render({
                elem: '#startDate'
              , type: 'datetime'
            });
            laydate.render({
                elem: '#endDate'
             , type: 'datetime'
            });
        });
    </script>
</head>
<body>
    <div id="mempay">
        <div class="control">
            <div class="search" id="DivSearch" runat="server">
                <input type="button" value="查询" class="ssubmit" onclick="SearchByCondition()" />
                <input name="txtKey" data-name="txtKey" id="nTitle" placeholder="账号" type="text" class="sinput" style="width: 120px;" />
                <input type="text" name="txtKey" data-name="txtKey" id="startDate"   placeholder="开始时间"
                    class="daycash_input" style="width: 120px;" />
                <input type="text" name="txtKey" data-name="txtKey" id="endDate" placeholder="结束时间"
                    class="daycash_input" style="width: 120px;" />
            </div>
        </div>
        <div class="ui_table">
            <table cellpadding="0" cellspacing="0" id="Result" class="tabcolor">
                <tr>
                    <th width="50px">全选
                    </th>
                    <th>序号
                    </th>
                    <th>操作者
                    </th>
                    <th>角色
                    </th>
                    <th>操作时间
                    </th>
                    <th>操作类型
                    </th>
                    <th>操作
                    </th>
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
