<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="LYSC.CompanyWeb.UI.Users.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <%foreach (var hksUsers in users)
              { %>
                  <tr>
                      <td><%=hksUsers.ID %></td>
                      <td><%=hksUsers.PassWord %></td>
                      <td><%=hksUsers.phone %></td>
                      <td><%=hksUsers.Plane %></td>
                      <td><%=hksUsers.UserName %></td>
                  </tr>
             <%} %> 
        </table>
    </div>
    </form>
</body>
</html>
