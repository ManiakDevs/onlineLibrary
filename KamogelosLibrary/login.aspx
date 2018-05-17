<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="KamogelosLibrary.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kamogelo's Library</title>
    <link rel="stylesheet" href="kamogelosLib.css" type="text/css" />
</head>
<body>
    <form id="loginForm" runat="server" method="post" action="home.aspx">


    <div class="login">
        <h1>Kamogelo's Library</h1>
        Username <br /><asp:TextBox ID="userName" runat="server"></asp:TextBox> <br />
        Pasword <br /><asp:TextBox ID="passWord" runat="server"></asp:TextBox> <br />
        <br /> <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" ForeColor="DeepPink" BorderColor="DeepPink" BackColor="Black"  /> <br />
        <br /> <a href="#">Register</a>
    </div>
    </form>
</body>
</html>
