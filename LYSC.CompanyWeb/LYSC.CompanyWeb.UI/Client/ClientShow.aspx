<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPager.Master" AutoEventWireup="true" CodeBehind="ClientShow.aspx.cs" Inherits="LYSC.CompanyWeb.UI.Client.ClientShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Nav" runat="server">
        <a class="graylink" href="../index.html">首页</a>&nbsp;&lt;&nbsp;
    <a class="graylink" href="Client.aspx">典型客户</a>&nbsp;&lt;&nbsp;
    <span class="color0range">客户详情</span>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1 class="title" runat="server" id="title">
        <%=ClientsShow.title %>
    </h1>
    <br />
    <div>
        <%=ClientsShow.content %>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="NavPage" runat="server">
</asp:Content>
