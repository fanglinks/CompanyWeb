<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPager.Master" AutoEventWireup="true" CodeBehind="NewsShow.aspx.cs" Inherits="LYSC.CompanyWeb.UI.GuoUI.News.NewsShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Nav" runat="server">
    <a class="graylink" href="../index.html">首页</a>&nbsp;&lt;&nbsp;
    <a class="graylink" href="News.aspx">新闻中心</a>&nbsp;&lt;&nbsp;
    <span class="color0range">新闻详情</span>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1 class="title" runat="server" id="title">
        <%=mainShowInfo.title %>
    </h1>
    <br />
    <p class="info" runat="server" id="date"><%=mainShowInfo.Date.ToString() %></p>
    <div>
        <h2><%=mainShowInfo.content %></h2>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="NavPage" runat="server">
</asp:Content>
