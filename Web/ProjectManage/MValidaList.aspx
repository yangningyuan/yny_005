<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MValidaList.aspx.cs" Inherits="yny_005.Web.ProjectManage.MValidaList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript">
        tUrl = "ProjectManage/Handler/MValidaList.ashx";
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
                        <%--<td>
                            <select id="IsBMState" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">报名状态</option>
                                <option value="3">报名已通过</option>
                                <option value="0,1,2">报名未通过</option>
                            </select>
                        </td>
                        <td>
                            <select id="IsYangPin" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">样品状态</option>
                                <option value="3">已确认</option>
                                <option value="0,1,2">未确认</option>
                            </select>
                        </td>
                        <td>
                            <select id="IsRState" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">验证结果状态</option>
                                <option value="3">已通过</option>
                                <option value="0,1,2">未通过</option>
                            </select>
                        </td>--%>
                        <td>
                            <select id="SHState" name="txtKey" data-name="txtKey" onchange="SearchByCondition()">
                                <option value="">审核状态</option>
                                <option value="0">未审核</option>
                                <option value="1">合格</option>
                                <option value="2">不合格</option>
                            </select>
                        </td>
                    </tr>
                </table>

            </div>
            <div class="search" id="DivSearch" runat="server">
                <input type="button" value="查询" class="ssubmit" onclick="SearchByCondition()" />

                <select id="JGWhere" name="txtKey" data-name="txtKey">
                    <option value="">查询结果</option>
                    <option value="ResultOne">结果1</option>
                    <option value="ResultTwo">结果2</option>
                    <option value="ResultAvg">平均值</option>
                </select>
                <select id="JGType" name="txtKey" data-name="txtKey" >
                    <option value="">查询类型</option>
                    <option value=">">></option>
                    <option value="<"><</option>
                    <option value=">=">>=</option>
                    <option value="<="><=</option>
                </select>
                <input id="JGValue" name="txtKey" placeholder="值" data-name="txtKey" type="text" class="sinput" />


                <input id="HYmid" name="txtKey" placeholder="会员名称" data-name="txtKey" type="text" class="sinput" />
                <input id="ObjName" name="txtKey" placeholder="项目名称" data-name="txtKey" type="text" class="sinput" />
                <input id="ObjCode" name="txtKey" placeholder="项目编号" data-name="txtKey" type="text" class="sinput" />
                <input id="ObjReMID" name="txtKey" placeholder="发布项目单位账号" data-name="txtKey" type="text" class="sinput" />
                <input name="txtKey" data-name="txtKey" id="bmoid" value="<%=Request.QueryString["bmoid"] %>" type="text" class="sinput" style="width: 120px; display: none;" />
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
                    <th>参加子项
                    </th>
                    <th>状态
                    </th>
                    <th>结果1
                    </th>
                    <th>结果2
                    </th>
                    <th>平均值
                    </th>
                    <th>合格状态
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
    <script>
        function SHChange(id) {
            layer.confirm("是否审核合格此数据？", function () {
                ActionModel("ProjectManage/MValidaList.aspx?Action=Add&sid=" + id, $('#form1').serialize());
            });
        }
        function DHChange(id) {
            layer.confirm("是否审核不合格此数据？", function () {
                ActionModel("ProjectManage/MValidaList.aspx?Action=Modify&sid=" + id, $('#form1').serialize());
            });
        }
    </script>
</body>
</html>
