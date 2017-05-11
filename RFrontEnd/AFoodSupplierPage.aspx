<!DOCTYPE html>
<html>
<head>
    <title>Main Menu</title>
	<meta charset="utf-8" />
</head>
<body>
    <form id="AddFood" runat="server">
    <center>
        <table>
            <tr>
                <td><img src="images/logo.jpg" alt="logo" style="width:200px; height:170px;"></td>
                <td>
                    <h1>Add Food Supplier</h1>
                </td>
            </tr> 
        </table>
    </center>
        <br />
        <asp:ListBox ID="lstFood" runat="server" style="z-index: 1; left: 585px; top: 415px; position: absolute; width: 560px; height: 327px">
            <asp:ListItem>FoodSupplier1</asp:ListItem>
        </asp:ListBox>
        <br />
        <div>
        <asp:Label runat="server" Text="FoodSupplierID"></asp:Label> <asp:TextBox ID="FoodSupplierID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="FoodSupplierName"></asp:Label><asp:TextBox ID="FoodSupplierName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="FoodSupplierAddress"></asp:Label><asp:TextBox ID="FoodSupplierAddress" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="FoodSupplierPostcode"></asp:Label><asp:TextBox ID="FoodSupplierPostcode" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="City"></asp:Label><asp:TextBox ID="City" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="County"></asp:Label><asp:TextBox ID="County" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Region"></asp:Label><asp:TextBox ID="Region" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="PhoneNo"></asp:Label><asp:TextBox ID="MobileNo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Email"></asp:Label><asp:TextBox ID="Email" runat="server"></asp:TextBox>
        </div>
        <button>Add</button>
        <button>Reset</button>
    </form>
</body>
</html>
