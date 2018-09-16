﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GMList.aspx.cs" Inherits="yny_003.Web.mobile.html.GMList" %>

<div class="content content-padded pull-to-refresh-content" data-ptr-distance="55">
    <!-- 默认的下拉刷新层 -->
    <div class="pull-to-refresh-layer">
        <div class="preloader"></div>
        <div class="pull-to-refresh-arrow"></div>
    </div>
    <%--<div class="searchbar row">
        <div class="search-input col-80">
            <input type="search" placeholder="员工账号" id="search" />
        </div>
        <a class="button button-fill button-primary col-20">查询</a>
    </div>--%>

    <script type="text/x-jquery-tmpl" id="GMListTmpl">
        <tr>
            <%--<td>${MID}</td>--%>

            <td>${Money}</td>
            <td>${MoneyType}</td>
            <td>${ChangeDate}</td>
        </tr>
    </script>

    <table class=" table table-striped table-bordered ">
        <thead>
            <tr>
                <%--<th>员工账号</th>--%>
                <th>充值金额</th>
                <th>币种</th>
                <th>充值时间</th>
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
</script>
<script type="text/javascript">
    setTimeout(function () {
        $('#page_container').Paging({
            TemplateContainer: '#GMListTmpl',
            DataContainer: '#data_container',
            DataUrl: '/mobile/html/GMList.aspx?Action=Other',
            QueryContainer: '#form1',
            Rendered: function () {
                window.MobileSelectAll();
            }
        });
    }, 50);
</script>
