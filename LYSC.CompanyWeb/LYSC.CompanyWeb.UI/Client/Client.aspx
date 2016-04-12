<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPager.Master" AutoEventWireup="true" CodeBehind="Client.aspx.cs" Inherits="LYSC.CompanyWeb.UI.GuoUI.Client.Client" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Nav" runat="server">
    <a class="graylink" href="../index.html">首页</a>&nbsp;&lt;&nbsp;
    <span class="color0range">典型客户</span>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <table style="width: 100%">
        <tr>
            <th>id</th>
            <th>title</th>
            <th>softName</th>
            <th>liaisonPhone</th>
            <th>liaisonPeple</th>
            <th>date</th>
            <th>peple</th>
            <th>content</th>
        </tr>
        <%foreach (var client in ClientsShow)
          {%>
        <tr>
            <td><%=client.id %></td>
            <td><%=client.title %></td>
            <td><%=client.softName %></td>
            <td><%=client.liaisonPhone %></td>
            <td><%=client.liaisonPeple %></td>
            <td><%=client.date %></td>
            <td><%=client.peple %></td>
            <td><a href="ClientShow.aspx?id=<%=client.id %>">点击详情</a></td>
        </tr>
        <%} %>
    </table>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="NavPage" runat="server">
    <%=NavPager %>
</asp:Content>
