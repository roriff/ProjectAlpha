<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Login</title>
    <link id="pagestyle" rel="stylesheet" type="text/css" href="css/mystyles.css">
    <style type="text/css">
        .auto-style1 {
            height: 518px;
        }
        .auto-style3 {
            width: 81px;
            height: 33px;
        }
        .auto-style4 {
            width: 113px;
            height: 40px;
        }
    </style>
</head>
<body>
    <form id="loginform" runat="server" class="auto-style1">
            <h1 class="auto-style4">Login</h1>
            <br />
        <br />
        <br />
        <br />
        <br />

            Username:

            <asp:TextBox ID="Username" runat="server"></asp:TextBox>
 
            <br />
        <br />
        <br />
 
            Password:

            <asp:TextBox ID="Password" runat="server"></asp:TextBox>

        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <button class="auto-style3">Go</button>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <button class="auto-style3">Reset</button>
    </form>
</body>
</html>
