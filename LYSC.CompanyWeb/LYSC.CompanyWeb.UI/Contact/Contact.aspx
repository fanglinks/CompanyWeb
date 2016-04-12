<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPager.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="LYSC.CompanyWeb.UI.GuoUI.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Nav" runat="server">
    <a class="graylink" href="../index.html">首页</a>&nbsp;&lt;&nbsp;
    <span class="color0range">联系我们</span>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <table style="width: 100%">

        <tr>
            <th>ID</th>
            <th>Address</th>
            <th>Zip</th>
            <th>plane</th>
            <th>Fax</th>
            <th>QQ_MSN</th>
            <th>Date</th>
            <th>people</th>
        </tr>
        <%foreach (var contact in ContactShow)
          {%>
        <tr>
            <td><%=contact.ID %></td>
            <td><%=contact.Address %></td>
            <td><%=contact.Zip %></td>
            <td><%=contact.plane %></td>
            <td><%=contact.Fax %></td>
            <td><%=contact.QQ_MSN %></td>
            <td><%=contact.Date %></td>
            <td><%=contact.people %></td>


        </tr>
        <%} %>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="NavPage" runat="server">
    <%=NavPager%>
</asp:Content>
