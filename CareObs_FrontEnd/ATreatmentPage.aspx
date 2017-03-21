<%@ Page Title="Add and Edit Treatment" Language="C#" MasterPageFile="~/CareObs.master" AutoEventWireup="true" CodeFile="ATreatmentPage.aspx.cs" Inherits="ATreatmentPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <nav>
        <asp:Label ID="lblManageTreatment" runat="server" Font-Bold="True" ForeColor="Blue" Text="Manage Treatment"></asp:Label>         
        <asp:Button ID="btnAddTreatment" class="buttonNav" runat="server" style="z-index: 1; left: 18px; top: 284px; position: absolute; width: 140px;" Text="Add Treatment" />
        <asp:Button ID="btnEditTreatment" class="buttonNav" runat="server" style="z-index: 1; left: 18px; top: 350px; position: absolute; width: 140px" Text="Edit Treatment" />
        <asp:Button ID="btnArchiveTreatment" class="buttonNav" runat="server" style="z-index: 1; left: 19px; top: 414px; position: absolute; width: 140px" Text="Archive Treatment" OnClick="btnArchiveTreatment_Click" />
        <asp:Button ID="btnExit" class="buttonNav" runat="server" OnClick="btnExit_Click" style="z-index: 1; left: 18px; top: 481px; position: absolute; width: 140px" Text="Exit" />
         <asp:DropDownList ID="ddlMedicalCondition" runat="server" style="z-index: 1; left: 385px; top: 408px; position: absolute; height: 22px; width: 300px; bottom: 178px;">
             <asp:ListItem>Not Stated</asp:ListItem>
             <asp:ListItem>Huntington</asp:ListItem>
             <asp:ListItem>Schizophrenia</asp:ListItem>
             <asp:ListItem>Delusion</asp:ListItem>
             <asp:ListItem>Anxiety</asp:ListItem>
             <asp:ListItem>Dementia</asp:ListItem>
             <asp:ListItem>Mental Breakdown</asp:ListItem>
             <asp:ListItem>Bipolar Disorder</asp:ListItem>
             <asp:ListItem>Cerebral Palsy</asp:ListItem>
         </asp:DropDownList>
    
    
    </nav>

    <asp:Label ID="lblAddOrEditTreatmentTitle" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" style="z-index: 1; left: 453px; top: 222px; position: absolute; width: 342px" Text="ADD OR EDIT TREATMENT"></asp:Label>
     
     <asp:Label ID="lblTreatmentID" runat="server" Font-Bold="True" style="z-index: 1; left: 228px; top: 283px; position: absolute" Text="TreatmentID"></asp:Label>
     <asp:TextBox ID="txtTreatmentID" runat="server" ReadOnly="True" style="z-index: 1; left: 380px; top: 282px; position: absolute; width: 150px"></asp:TextBox>
        
     <asp:Label ID="lblTreatmentType" runat="server" Font-Bold="True" style="z-index: 1; left: 227px; top: 341px; position: absolute" Text="Treatment Type"></asp:Label>
         <asp:DropDownList ID="ddlTreatmentType" runat="server" style="z-index: 1; left: 382px; top: 337px; position: absolute; height: 22px; width: 300px">
            <asp:ListItem>Not Stated</asp:ListItem>
            <asp:ListItem>Mental</asp:ListItem>
            <asp:ListItem>Physical</asp:ListItem>
            <asp:ListItem>Mental and Physical</asp:ListItem>
         </asp:DropDownList>
         <asp:Label ID="lblMedicalCondition" runat="server" Font-Bold="True" style="z-index: 1; left: 229px; top: 408px; position: absolute; height: 19px;" Text="Medical Condition"></asp:Label>
         <asp:Label ID="lblMedicationGiven" runat="server" Font-Bold="True" style="z-index: 1; left: 223px; top: 480px; position: absolute; width: 143px" Text="Medication Given"></asp:Label>
         <asp:TextBox ID="txtMedicationGiven" runat="server" style="z-index: 1; left: 383px; top: 478px; position: absolute; width: 300px"></asp:TextBox>
         
         <asp:Label ID="lblComments" runat="server" Font-Bold="True" style="z-index: 1; left: 231px; top: 566px; position: absolute" Text="Comments"></asp:Label>
         <asp:TextBox ID="txtComments" runat="server" style="z-index: 1; left: 384px; top: 564px; position: absolute; height: 150px; width: 300px" TextMode="MultiLine"></asp:TextBox>
    
         <asp:Button class="buttonNav" ID="btnSave" runat="server" OnClick="btnSave_Click" style="z-index: 1; left: 234px; top: 812px; position: absolute; width: 140px" Text="Save" />
         <asp:Button class="buttonNav" ID="btnDoNotSave" runat="server" OnClick="btnDoNotSave_Click" style="z-index: 1; left: 468px; top: 811px; position: absolute; width: 140px" Text="Do Not Save" />
         <asp:Button class="buttonNav" ID="btnCancel" runat="server" style="z-index: 1; left: 692px; top: 811px; position: absolute; width: 140px" Text="Cancel" OnClick="btnCancel_Click" />
</asp:Content>

