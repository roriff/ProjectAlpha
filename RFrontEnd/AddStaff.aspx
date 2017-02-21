<!DOCTYPE html>
<script runat="server">

    Protected Sub Page_Load(sender As Object, e As EventArgs)

    End Sub

    Protected Sub PhoneNo0_TextChanged(sender As Object, e As EventArgs)

    End Sub
</script>

<html>
<head>
    <title>Main Menu</title>
	<meta charset="utf-8" />
    <style type="text/css">
        .auto-style1 {
            width: 372px;
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
                    <h1>Add Food Staff</h1>
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
        <asp:Label runat="server" Text="StaffID"></asp:Label> <asp:TextBox ID="StaffID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="FirstName"></asp:Label><asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="LastName"></asp:Label><asp:TextBox ID="LastName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="UserName"></asp:Label><asp:TextBox ID="UserName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Password"></asp:Label><asp:TextBox ID="Password" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="PhoneNo"></asp:Label><asp:TextBox ID="PhoneNo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Town/City"></asp:Label><asp:TextBox ID="TownCity" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Title"></asp:Label><asp:TextBox ID="Title" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Street"></asp:Label><asp:TextBox ID="Street" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="IndustrySector"></asp:Label><asp:TextBox ID="IndustrySector" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="HighestQualification"></asp:Label><asp:TextBox ID="HighestQualification" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Gender"></asp:Label><asp:TextBox ID="Gender" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="DateLeft"></asp:Label><asp:TextBox ID="DateLeft" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="DateJoined"></asp:Label><asp:TextBox ID="DateJoined" runat="server"></asp:TextBox>


        </div>
        <button>Add</button>
        <button>Reset</button>
    </form>
</body>
</html>
