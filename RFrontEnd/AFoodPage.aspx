<!DOCTYPE html>
<html>
<head>
    <title>Main Menu</title>
	<meta charset="utf-8" />
    <style type="text/css">
        .auto-style1 {
            width: 750px;
        }
    </style>
</head>
<body>
    <form id="AddFood" runat="server">
    <center>
        <table>
            <tr>
                <td><img src="images/logo.jpg" alt="logo" style="width:200px; height:170px;"></td>
                <td class="auto-style1">
                    <h1>Add Food</h1>
                </td>
            </tr> 
        </table>
    </center>
        <center>
        <div>
        <asp:Label runat="server" Text="FoodName"></asp:Label>
        <br />
            <asp:TextBox ID="FoodID" runat="server"></asp:TextBox>
            <br />
        <br />
        <asp:Label runat="server" Text="FoodName"></asp:Label>
        <br />
            <asp:TextBox ID="FoodName" runat="server"></asp:TextBox>
            <br />
        <br />
        <asp:Label runat="server" Text="FoodPrice"></asp:Label>
            <br />
            <asp:TextBox ID="FoodPrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Quantity"></asp:Label>
            <br />
            <asp:TextBox ID="Quantity" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <button style="height: 32px; width: 73px">Add</button>
        <button style="height: 32px; width: 73px"">Reset</button>
        </center>
    </form>
</body>
</html>
