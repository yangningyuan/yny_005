<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TJNet.aspx.cs" Inherits="yny_003.Web.Member.TJNet" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
    <title></title>
    <link rel="stylesheet" type="text/css" href="plugin/jOrgChart/css/jquery.jOrgChart.css" />
    <script type="text/javascript" src="plugin/jOrgChart/prettify.js"></script>
    <script type="text/javascript" src="plugin/jOrgChart/jquery.jOrgChart.js"></script>
    <script type="text/javascript">
        var level = 1;
        var defalutinfo = "������Ա���˺�,�㼶";
        GetAjaxTJInfo($('#txtMid').val());
    </script>
    <style type="text/css">
        .tablefilter td
        {
            width: auto;
            font-size: 14px;
			    background-color: #D48A6A;
    color: #DBDBDB;
        }
        td a
        {
                color: #3C3229;
    /* font-weight: bold; */
    border-bottom: solid 1px #F1B093;
        }
        .node table
        {
            min-width: 80px;
        }
        #chart table
        {
            margin: auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="mempay">
        <div class="control">
            <div class="search" id="DivSearch" runat="server">
                <input type="button" value="��ѯ" class="ssubmit" onclick="GetAjaxTJInfo($('#txtMid').val())" /><input
                    id="txtMid" runat="server" value="������Ա���˺�" onfocus="if (value =='������Ա���˺�'){value =''}"
                    onblur="if (value ==''){value='������Ա���˺�'}" type="text" class="sinput" /><input id="txtLevel"
                        runat="server" value="3" onfocus="if (value =='�㼶'){value =''}" onblur="if (value ==''){value='�㼶'}"
                        type="text" class="sinput" style="width: 100px;" /></div>
            <div class="cheeckbox">
                <table cellpadding="0" cellspacing="0" style="font-size: 21px; color: White;">
                    <tr>
                        <%=MAgencyTypeColor%>
                    </tr>
                </table>
            </div>
        </div>
        <div class="tree_table">
            <ul id="org" style="display: none">
            </ul>
            <div id="chart" class="jOrgChart">
            </div>
        </div>
    </div>
    </form>
</body>
</html>
