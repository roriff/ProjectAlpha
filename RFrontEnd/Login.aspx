<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Login</title>
    <link id="pagestyle" rel="stylesheet" type="text/css" href="css/mystyles.css">
</head>
<body>
    <form id="loginform" runat="server">
    <div>
    <table>
        <tr>
            <td>
            <h1>Login</h1>
            </td>
        </tr>
    </table>
    </div>
    <table>
        <tr>
            <td>
            Username:
            </td>
            <td>
            <asp:TextBox ID="Username" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
            Password:
            </td>
            <td>
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <button>Go</button>
    <button>Reset</button>
    </form>
</body>
</html>
