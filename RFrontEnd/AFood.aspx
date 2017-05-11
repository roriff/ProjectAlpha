<!DOCTYPE html>
<script runat="server">
</script>

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
        <asp:Label runat="server" Text="Search By Food"></asp:Label>
        <br />
            <asp:TextBox ID="FoodName" runat="server"></asp:TextBox>
            <br />
        <br />
        <asp:Label runat="server" Text="Search By Food Price"></asp:Label>
        <br />
            <asp:TextBox ID="FoodPrice" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
        </div>
        <nav>
        <asp:Button ID="btnAddFood" class="buttonNav" runat="server" style="z-index: 1; left: 20px; top: 286px; width: 145px;" Text="Add Food" OnClick="btnAddFood_Click" />
        <asp:Button ID="btnEditFood" class="buttonNav" runat="server" style="z-index: 1; left: 19px; top: 352px; width: 145px" Text="Edit Food" OnClick="btnEditFood_Click" />
        <asp:Button ID="btnArchiveFood" class="buttonNav" runat="server" style="z-index: 1; left: 18px; top: 420px; width: 145px" Text="Archive Food" OnClick="btnArchiveFood_Click" />
        <asp:Button ID="btnReset" class="buttonNav" runat="server" OnClick="btnReset_Click" style="z-index: 1; left: 18px; top: 487px; width: 145px" Text="Reset" />
        </nav>
        <asp:ListBox ID="lstFood" runat="server" Height="257px" Width="645px"></asp:ListBox>
        <asp:GridView ID="FoodDataGridView" runat="server" Height="257px" Width="645px" DataSourceID="SqlDataSource1"></asp:GridView>
        </center>
    </form>
</body>
</html>