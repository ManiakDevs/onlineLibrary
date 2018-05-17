<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="KamogelosLibrary.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kamogelo's Library</title>
    <link rel="stylesheet" href="kamogelosLib.css" type="text/css" />
</head>
<body>
    <form id="registerForm" runat="server" method="post" action="regSuccess.aspx">
    

    <div class="register">
        <h1>Kamogelo's Library</h1>
        Username <br /><asp:TextBox ID="userName" runat="server"></asp:TextBox> <br />
        Email <br /><asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox> <br />
        Password <br /><asp:TextBox ID="passWord" runat="server" TextMode="Password"></asp:TextBox> <br />
        Institution <br /><asp:TextBox ID="institution" runat="server"></asp:TextBox> <br />
        location <br /><asp:TextBox ID="location" runat="server"></asp:TextBox> <br />

        <br /> <asp:Button ID="regBtn" runat="server" Text="Register" OnClick="regBtn_Click" ForeColor="DeepPink" BorderColor="DeepPink" BackColor="Black" /> <br />
        <br /> <a href="login.aspx">Login</a>
    
    </div>
    </form>
</body>
</html>
