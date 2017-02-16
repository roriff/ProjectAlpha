<%@ Page Title="Manage Patient Treatment" Language="C#" MasterPageFile="~/CareObs.master" AutoEventWireup="true" CodeFile="ATreatment.aspx.cs" Inherits="ATreatment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <nav>
        <asp:Label ID="lblManageTreatment" runat="server" Font-Bold="True" ForeColor="Blue" Text="Manage Treatment"></asp:Label>         
        <asp:Button ID="btnAddTreatment" class="buttonNav" runat="server" style="z-index: 1; left: 18px; top: 284px; position: absolute; width: 140px;" Text="Add Treatment" OnClick="btnAddTreatment_Click" />
        <asp:Button ID="btnEditTreatment" class="buttonNav" runat="server" style="z-index: 1; left: 18px; top: 350px; position: absolute; width: 140px" Text="Edit Treatment" OnClick="btnEditTreatment_Click" />
        <asp:Button ID="btnArchiveTreatment" class="buttonNav" runat="server" style="z-index: 1; left: 19px; top: 414px; position: absolute; width: 140px" Text="Archive Treatment" OnClick="btnArchiveTreatment_Click" />
        <asp:Button ID="btnExit" class="buttonNav" runat="server" OnClick="btnExit_Click" style="z-index: 1; left: 18px; top: 481px; position: absolute; width: 140px" Text="Exit" />
    </nav>

    <asp:Label ID="lblManageTreatmentTitle" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" style="z-index: 1; left: 486px; top: 224px; position: absolute; width: 296px" Text="MANAGE TREATMENT"></asp:Label>
    
    <asp:Label ID="lblSearchByWard" runat="server" style="z-index: 1; left: 328px; top: 325px; position: absolute; width: 178px" Text="Search Patient by Ward"></asp:Label>
    <asp:DropDownList ID="ddlWard" runat="server" style="z-index: 1; left: 535px; top: 324px; position: absolute; width: 200px; height: 22px">
        <asp:ListItem>Ward 1 - Male</asp:ListItem>
        <asp:ListItem>Ward 2 - Male</asp:ListItem>
        <asp:ListItem>Ward 3 - Female</asp:ListItem>
        <asp:ListItem>Ward 4 - Female</asp:ListItem>
        <asp:ListItem>Ward 5 - Transgender</asp:ListItem>
    </asp:DropDownList>

    <asp:Button class="buttonNav" ID="btnSearchByWard" runat="server" style="z-index: 1; left: 775px; top: 321px; position: absolute; width: 140px" Text="Search" OnClick="btnSearchByWard_Click" />
    
    <asp:Label ID="lblOr" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; left: 599px; top: 363px; position: absolute; height: 25px; width: 35px;" Text="OR"></asp:Label>
    
    <asp:Label ID="lblSearchByName" runat="server" style="z-index: 1; left: 328px; top: 408px; position: absolute; width: 184px" Text="Search Patient By Name"></asp:Label>
    <asp:TextBox ID="txtPatientName" runat="server" style="z-index: 1; left: 537px; top: 406px; position: absolute; width: 200px;">Enter patient&#39;s first or last name</asp:TextBox>
    <asp:Button class="buttonNav" ID="btnSearchByName" runat="server" style="z-index: 1; left: 779px; top: 404px; position: absolute; width: 140px" Text="Search" OnClick="btnSearchByName_Click" />
    
    <asp:Label ID="lblPatientMessage" runat="server" ForeColor="Blue" style="z-index: 1; left: 335px; top: 488px; position: absolute" Text="Message About Patients" Font-Bold="False"></asp:Label>

    <asp:ListBox ID="lstPatients" runat="server" style="z-index: 1; left: 336px; top: 525px; position: absolute; width: 598px; height: 160px">
            <asp:ListItem>Patient1</asp:ListItem>
            <asp:ListItem>Patient2</asp:ListItem>
            <asp:ListItem>Patient3</asp:ListItem>
            <asp:ListItem>Patient4</asp:ListItem>
            <asp:ListItem>Patient5</asp:ListItem>
            <asp:ListItem>Patient6</asp:ListItem>
            <asp:ListItem>Patient7</asp:ListItem>
            <asp:ListItem>Patient8</asp:ListItem>
            <asp:ListItem></asp:ListItem>
    </asp:ListBox>
    
    <!-- We will use a datagridview to display the data instaed of using a list as list are just too limited-->
    <asp:GridView ID="PatientDataGridView" runat="server" 
     style="z-index: 1; left: 335px; top: 530px; position: absolute; height: 128px; width: 598px"
     AutoGenerateColumns ="False"
     Height="10px"
     CssClass="GridView"
     OnRowDataBound="PatientDataGridView_RowDataBound"
     OnSelectedIndexChanged="PatientDataGridView_SelectedIndexChanged" 
     AutoGenerateSelectButton="True">

     <Columns>
       <asp:BoundField DataField="PatientID" ShowHeader="true" ControlStyle-Width="20" HeaderText="PatientID" >
        <ControlStyle Width="20px"></ControlStyle>
         <HeaderStyle BackColor="#6699FF" />
       </asp:BoundField>
       
       <asp:BoundField DataField="Gender" HeaderText= "Gender" ShowHeader="true" ControlStyle-Width="200" >
         <ControlStyle Width="200px"></ControlStyle>
         <HeaderStyle BackColor="#6699FF" />
       </asp:BoundField>

         <asp:BoundField DataField="LastName" HeaderText= "Last Name" ShowHeader="true" ControlStyle-Width="200" >
        <ControlStyle Width="200px"></ControlStyle>
         <FooterStyle BackColor="#6699FF" />
         <HeaderStyle BackColor="#6699FF" />
       </asp:BoundField>

       <asp:BoundField DataField="FirstName" HeaderText= "First Name" ShowHeader="true" ControlStyle-Width="200" >
         <ControlStyle Width="200px"></ControlStyle>
         <HeaderStyle BackColor="#6699FF" />
       </asp:BoundField>

         <asp:BoundField DataField="DateOfBirth" HeaderText= "Date of Birth" ShowHeader="true" ControlStyle-Width="200" >
        <ControlStyle Width="200px"></ControlStyle>
         <FooterStyle BackColor="#6699FF" />
         <HeaderStyle BackColor="#6699FF" />
       </asp:BoundField>

       <asp:BoundField DataField="DateAdmitted" HeaderText= "Admission Date" ShowHeader="true" ControlStyle-Width="200" >
         <ControlStyle Width="200px"></ControlStyle>
         <HeaderStyle BackColor="#6699FF" />
       </asp:BoundField>
       
       <asp:BoundField DataField="DateDischarged" HeaderText= "Discharge Date" ShowHeader="true" ControlStyle-Width="200" >
         <ControlStyle Width="200px"></ControlStyle>
         <HeaderStyle BackColor="#6699FF" />
       </asp:BoundField>

     </Columns>

        <RowStyle BorderStyle="None" CssClass="GridViewHover" />
     </asp:GridView>
 
</asp:Content>

