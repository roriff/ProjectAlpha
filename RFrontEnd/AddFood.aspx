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
                    <h1>Add Food</h1>
                </td>
            </tr> 
        </table>
    </center>
        <br />
        <asp:ListBox ID="lstFood" runat="server" style="z-index: 1; left: 585px; top: 415px; position: absolute; width: 560px; height: 327px">
            <asp:ListItem>Food1</asp:ListItem>
        </asp:ListBox>
        <br />
        <div>
        <asp:Label runat="server" Text="FoodID"></asp:Label> <asp:TextBox ID="FoodID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="FoodName"></asp:Label><asp:TextBox ID="FoodName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="FoodPrice"></asp:Label><asp:TextBox ID="FoodPrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Quantity"></asp:Label><asp:TextBox ID="Quantity" runat="server"></asp:TextBox>
        </div>
        <button>Add</button>
        <button>Reset</button>
    </form>
</body>
</html>
