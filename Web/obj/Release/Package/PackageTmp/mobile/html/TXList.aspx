﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TXList.aspx.cs" Inherits="yny_003.Web.mobile.html.TXList" %>

<div class="content content-padded pull-to-refresh-content" data-ptr-distance="55">
    <!-- 默认的下拉刷新层 -->
    <div class="pull-to-refresh-layer">
        <div class="preloader"></div>
        <div class="pull-to-refresh-arrow"></div>
    </div>
     <p>
        <a href="javascript:void(0)" onclick="pcallhtml('/mobile/html/TXChange.aspx','提现');" class="button button-fill button-success">提现</a>
    </p>
    <%--<div class="searchbar row">
        <div class="search-input col-80">
            <input type="search" placeholder="员工账号" id="search" />
        </div>
        <a class="button button-fill button-primary col-20">查询</a>
    </div>--%>

    <script type="text/x-jquery-tmpl" id="TXListTmpl">
        <tr>
            <%--<td>${MID}</td>--%>

            <td>${Money}</td>
            <td>${sfMoney}</td>
            <td>${State}</td>
            <td>${ChangeDate}</td>
            <td>{{html cdetails}}</td>
        </tr>
    </script>

    <table class=" table table-striped table-bordered ">
        <thead>
            <tr>
                <%--<th>员工账号</th>--%>
                <th>提现金额</th>
                <th>实发金额</th>
                <th>状态</th>
                <th>提现时间</th>
                <th>操作</th>
            </tr>
        </thead>
        <tbody id="data_container">
        </tbody>

    </table>
    <div id="page_container">
    </div>
</div>
<script>
    $(function () {
        $('#data_container').on('click', '.list-detail', function () {
            //console.log(parseInt($(this).next().css('height')));
            if (parseInt($(this).next().css('height')) < 300) {
                $(this).next().css('height', '300px');
            }

            $(this).next().slideDown();
        })
        $('#data_container').on('click', '.detail-close', function () {
            $(this).parent().slideUp();
        })
    })

    function delTX(obj)
    {
        ActionModel("/mobile/html/TXList.aspx?Action=modify&cid=" + obj, $('#form1').serialize(), "/mobile/html/TXList.aspx");
    }
</script>
<script type="text/javascript">
    setTimeout(function () {
        $('#page_container').Paging({
            TemplateContainer: '#TXListTmpl',
            DataContainer: '#data_container',
            DataUrl: '/mobile/html/TXList.aspx?Action=Other',
            QueryContainer: '#form1',
            Rendered: function () {
                window.MobileSelectAll();
            }
        });
    }, 50);

</script>