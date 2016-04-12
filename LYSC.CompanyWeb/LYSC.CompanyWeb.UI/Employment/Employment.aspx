<%@ Page Title="" Language="C#" MasterPageFile="~/Master/MasterPager.Master" AutoEventWireup="true" CodeBehind="Employment.aspx.cs" Inherits="LYSC.CompanyWeb.UI.GuoUI.Employment.Employment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Nav" runat="server">
    <a class="graylink" href="../index.html">首页</a>&nbsp;&lt;&nbsp;
    <span class="color0range">人才招聘</span>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <table style="width: 100%">
         <tr>
            <th>编号</th>
            <th>招聘职位</th>
            <th>招聘内容</th>
            <th>求职要求</th>
            <th>发布日期</th>
            <th>状态</th>
            <th>负责人</th>
        </tr>

        <%foreach (var empoyees in Empoyees)
          {%>
        <tr>
            <td><%=empoyees.ID %></td>
            <td><%=empoyees.title %></td>
            <td><%=empoyees.content %></td>
            <td><%=empoyees.people %></td>
            <td><%=empoyees.date %></td>
            <td><%=empoyees.status %></td>
            <td><%=empoyees.MainPeople %></td>
        </tr>
        <%}   %>
    </table>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="NavPage" runat="server">
    <%=NavPager %>
</asp:Content>
