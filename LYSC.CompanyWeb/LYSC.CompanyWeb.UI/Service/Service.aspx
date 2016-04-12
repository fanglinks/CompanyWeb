<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPager.Master" AutoEventWireup="true" CodeBehind="Service.aspx.cs" Inherits="LYSC.CompanyWeb.UI.GuoUI.Service.Service" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Nav" runat="server">
    <a class="graylink" href="../index.html">首页</a>&nbsp;&lt;&nbsp;
    <span class="color0range">客户服务</span>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <%foreach (var service in ServicesShow)
      { %>
    <%=service.Context %>
    <% } %>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="NavPage" runat="server">
</asp:Content>
