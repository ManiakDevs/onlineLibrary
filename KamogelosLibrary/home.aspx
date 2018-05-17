<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="KamogelosLibrary.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kamogelo's Library</title>
    <link rel="stylesheet" href="kamogelosLib.css" type="text/css" />
</head>
<body>
    <form id="homeForm" runat="server">

    <div class="header">
     <div><h1>
         <asp:TextBox ID="searchBox" runat="server">
         </asp:TextBox><asp:Button ID="searchButton" runat="server" Text="Search" 
         ForeColor="DeepPink"  BackColor="Black" BorderColor="DeepPink" CssClass="searchButton" OnClick="searchButton_Click"/></h1></div>
     <div><h1>Kamogelo's Library</h1></div>
     <div class="icon"><h1>CKT</h1></div>
    </div>

    <div class="wrapper">
     <div>
         <a href="profile.aspx"></a> <br />
         <a href="books.aspx"></a>

     </div>
     <div></div>
     <div></div>
    </div>
    </form>
</body>
</html>
