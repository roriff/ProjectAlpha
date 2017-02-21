<!DOCTYPE html>
<html>
<head>
    <title>Main Menu</title>
	<meta charset="utf-8" />
</head>
<body>
    <form id="MainMenuForm" runat="server">
    <center>
        <table>
            <tr>
                <td><img src="images/logo.jpg" alt="logo" style="width:200px; height:170px;"></td>
                <td>
                    <h1>Main Menu</h1>
                </td>
                <td></td>
            </tr> 
        </table>
    </center>
        <table>
            <tr>
                <td><button style="width: 158px"><a/ href="AddFood.aspx">Add Food<a/></button></td>
            </tr>
            <tr>
                <td><button style="width: 155px"><a// href="AddStaff.aspx">Add Staff<a/></button></td>
            </tr>
            <tr>
                <td><button formaction><a/ href="AddFoodSupplier.apsx">Add Food Supplier<a/></button></td>
            </tr>
        </table>
        <asp:ListBox ID="lstFood" runat="server" style="z-index: 1; left: 388px; top: 374px; position: absolute; width: 560px; height: 327px">
        <asp:ListItem>Food1</asp:ListItem>
        </asp:ListBox>
    </form>
</body>
</html>
