<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StructureB.aspx.cs" Inherits="zx270.Web.Member.StructureB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        var level = 3;
        var defalutinfo = "�������Ա�˺�,�㼶";
        GetAjaxInfoB($('#txtMid').val());
    </script>
    <style type="text/css">
        .tablefilter td
        {
            width: auto;
            font-size: 14px;
            border: 1px solid #ddd;
        }
        td a
        {
            color: #00CCFF;
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
            <div class="pay" style="display: none;" onclick="fullscreen()">
                ȫ���л�</div>
            <div class="search" id="DivSearch" runat="server">
                <input type="button" value="��ѯ" class="ssubmit" onclick="GetAjaxInfoB($('#txtMid').val())" /><input
                    id="txtMid" runat="server" value="�������Ա�˺�" onfocus="if (value =='�������Ա�˺�'){value =''}"
                    onblur="if (value ==''){value='�������Ա�˺�'}" type="text" class="sinput" style="display: none" /><input
                        id="txtLevel" runat="server" value="3" onfocus="if (value =='�㼶'){value =''}"
                        onblur="if (value ==''){value='�㼶'}" type="text" class="sinput" style="width: 70px;" />
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
