<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login page</title>
    <link href="CareObs.css" rel="stylesheet" type="text/css" media="screen"/>
</head>
<body>
    <form id="wrapper" runat="server">
    <div>
     <h2>Care Observation System Login </h2>
        <p style="border:3px solid blue; padding: 1em; height: 330px;">
            <br /> 
	        
            <asp:Button ID="btnLogIn" runat="server" OnClick="btnLogIn_Click" style="z-index: 1; left: 472px; top: 298px; position: absolute; width: 100px; height: 30px" Text="Log in" />
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 426px; top: 164px; position: absolute; width: 210px">Username</asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 426px; top: 224px; position: absolute; width: 210px">Password</asp:TextBox>
            <asp:Label ID="lblLoginDetails" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Blue" style="z-index: 1; left: 414px; top: 115px; position: absolute; width: 228px" Text="Enter Your login details"></asp:Label>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 323px; top: 167px; position: absolute" Text="User Name"></asp:Label>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 325px; top: 226px; position: absolute" Text="Password"></asp:Label>
	        
            <asp:Label ID="lblLoginMessage" runat="server" ForeColor="Red" style="z-index: 1; left: 309px; top: 350px; position: absolute; width: 378px;" Text="Login Message"></asp:Label>
	        
         </p>

    </div>
    </form>
</body>
</html>
