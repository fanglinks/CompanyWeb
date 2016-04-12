<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LYSC.CompanyWeb.UI.admin.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        form {
            margin-top: 150px;
        }
        .style1
        {
            font-family: 华文行楷;
        }
        .style2 {
            font-family: 华文行楷;
            font-size: x-large;
        }
    </style>
    <link type="text/css" href="content/style.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/jquery-1.7.1.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#Image1").click(function () {
                var originScr = $("#Image1").attr("src");
                $("#Image1").attr("src", originScr + "1");
            });
        });
    </script>
</head>
<body>
 <form id="form1" runat="server" name="form1">
    <div>
  <div>
    <table width="549" height="287" border="0" align="center" cellpadding="0" cellspacing="0" background="content/login_bg.jpg">
      <tbody><tr>
        <td width="23"><img src="content/login_leftbg.jpg" width="23" height="287"></td>
        <td width="503" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tbody><tr> 
            <td width="49%" valign="bottom"><table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
              <tbody><tr>
                <td height="100" valign="top" class="login_text"><div align="left" class="style2">
                    <strong>&nbsp;&nbsp;&nbsp;
                    黑马三期第九组<br />
&nbsp;&nbsp;&nbsp;&nbsp; 后台登录系统</strong></div></td>
              </tr>
              <tr>
                <td><div align="right"><img src="content/login_img.jpg" width="104" height="113"></div></td>
              </tr>
            </tbody></table></td>
            <td width="2%"><img src="content/login_line.jpg" width="6" height="287"></td>
            <td width="49%"><div align="right">
              <table width="223" border="0" cellspacing="0" cellpadding="0">
                <tbody><tr>
                  <td><img src="content/login_tit.jpg" width="223" height="30"></td>
                </tr>
                <tr>
                  <td><table width="100%" border="0" cellspacing="10" cellpadding="0">
                    <tbody><tr>
                      <td width="28%"><div align="left">用户名：</div></td>
                      <td width="72%"><div align="left"><span class="style1">
                          <input name="txtClientID" type="text" id="txtClientID" class="form2" style="height:15px;width:140px;" value="<%=userName %>" />
                      </span></div></td>
                    </tr>
                    <tr>
                      <td><div align="left">密&nbsp;&nbsp;码：</div></td>
                      <td><div align="left"><span class="style1">
                          <input name="txtPassword" type="password" id="txtPassword" class="form2" style="height:15px;width:140px;"></span></div></td>
                    </tr>
                    <tr>
                      <td><div align="left">验证码：</div></td>
                      <td><div align="left">
                          <img id="Image1" src="ValidateCodeProcess.ashx?id=1" style="border-width:0px;">&nbsp;<label style="color:Red"><%=ErrorMsg %></label></div></td>
                    </tr>
                    <tr>
                      <td><div align="left">验证码：</div></td>
                      <td><div align="left"><span class="style1">
                          <input name="txtCode" type="text" size="8" id="txtCode" class="form2" style="height:15px;"></span></div></td>
                    </tr>
                  </tbody></table></td>
                </tr>
                <tr>
                  <td align="center"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tbody><tr>
                      <td><div align="center"><a href="http://www.800kb.com/ClientManager/#"></a></div></td>
                      <td><div align="center">
                         <%-- <input type="image" name="btnLogin" id="btnLogin" src="content/login_menu2.jpg" style="border-width:0px;" onclick="return btnLogin_onclick()">--%>
                          &nbsp;
                          <asp:ImageButton ID="btnLogin" runat="server"  name="btnLogin" 
                              src="content/login_menu2.jpg"  Width="99px" onclick="btnLogin_Click" />
                          <a href="http://www.800kb.com/ClientManager/#"></a>
                          &nbsp;</div></td>
                    </tr>
                  </tbody></table>
                      <strong><span style="color: #3180b7">&nbsp; 国产设备110号</span></strong></td>
                </tr>
              </tbody></table>
            </div></td>
          </tr>
        </tbody></table></td>
        <td width="23"><img src="content/login_rigbg.jpg" width="23" height="287"></td>
      </tr>
    </tbody></table>
    </div>
    </form>
    <%=Js %>
</body>
</html>
