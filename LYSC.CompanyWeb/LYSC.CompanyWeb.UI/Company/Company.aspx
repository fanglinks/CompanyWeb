<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPager.Master" AutoEventWireup="true" CodeBehind="Company.aspx.cs" Inherits="LYSC.CompanyWeb.UI.GuoUI.Company.Company" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Nav" runat="server">

    <a class="graylink" href="../index.html">首页</a>&nbsp;&lt;&nbsp;
        <span class="color0range">相识华科</span>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <%foreach (var service in ServicesShow)
      { %>
    <%=service.Context %>
    <% } %>
</asp:Content>
