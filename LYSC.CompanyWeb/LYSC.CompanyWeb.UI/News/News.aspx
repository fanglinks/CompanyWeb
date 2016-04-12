<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPager.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="LYSC.CompanyWeb.UI.GuoUI.News.News" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Nav" runat="server">

    <a class="graylink" href="../index.html">首页</a>&nbsp;&lt;&nbsp;
                    <span class="color0range">新闻中心</span>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <%foreach (var hksmain in mainShowo)
      { %>
    <li>
        <span><%= hksmain.Date.ToShortDateString() %></span>
        <a href="NewsShow.aspx?ID=<%=hksmain.ID %>" target="_blank"><%=hksmain.title %></a>
    </li>
    <% } %>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="NavPage" runat="server">
    <%=NavPager %>
</asp:Content>
