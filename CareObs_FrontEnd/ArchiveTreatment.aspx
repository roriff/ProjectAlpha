<%@ Page Title="Archive Treatment" Language="C#" MasterPageFile="~/CareObs.master" AutoEventWireup="true" CodeFile="ArchiveTreatment.aspx.cs" Inherits="ArchiveTreatment" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <nav>
        <asp:Label ID="lblManageTreatment" runat="server" Font-Bold="True" ForeColor="Blue" Text="Manage Treatment"></asp:Label>         
        <asp:Button ID="btnAddTreatment" class="buttonNav" runat="server" style="z-index: 1; left: 18px; top: 284px; position: absolute; width: 140px;" Text="Add Treatment" OnClick="btnAddTreatment_Click" />
        <asp:Button ID="btnEditTreatment" class="buttonNav" runat="server" style="z-index: 1; left: 18px; top: 350px; position: absolute; width: 140px" Text="Edit Treatment" OnClick="btnEditTreatment_Click" />
        <asp:Button ID="btnArchiveTreatment" class="buttonNav" runat="server" style="z-index: 1; left: 19px; top: 414px; position: absolute; width: 140px" Text="Archive Treatment" OnClick="btnArchiveTreatment_Click" />
        <asp:Button ID="btnExit" class="buttonNav" runat="server" OnClick="btnExit_Click" style="z-index: 1; left: 18px; top: 481px; position: absolute; width: 140px" Text="Exit" />
     </nav>

     <asp:Label ID="lblDeleteTreatmentTitle" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" style="z-index: 1; left: 498px; top: 225px; position: absolute; width: 281px" Text="ARCHIVE TREATMENT"></asp:Label>
     <asp:Label ID="lblTreatmentToArchive" runat="server" style="z-index: 1; left: 344px; top: 322px; position: absolute; width: 157px" Text="Treatment To Archive"></asp:Label>
     <asp:TextBox ID="txtTreatmentToArchive" runat="server" style="z-index: 1; left: 505px; top: 320px; position: absolute; width: 299px"> TreatmentID or Treatment Name</asp:TextBox>
     
     <asp:Label ID="lblArchiveMessage" runat="server" Font-Bold="True" ForeColor="Red" style="z-index: 1; left: 291px; top: 374px; position: absolute; width: 583px" Text="Are you sure you want to archive this treatment from the system?"></asp:Label>
     
     <asp:Button class="buttonNav" ID="btnYes" runat="server" style="z-index: 1; left: 306px; top: 421px; position: absolute; width: 140px" Text="Yes" OnClick="btnYes_Click" />
     <asp:Button class="buttonNav" ID="btnNo" runat="server" style="z-index: 1; left: 514px; top: 421px; position: absolute; width: 140px" Text="No" OnClick="btnNo_Click" />   
     <asp:Button class="buttonNav" ID="btnCancel" runat="server" style="z-index: 1; left: 725px; top: 422px; position: absolute; width: 140px" Text="Cancel" OnClick="btnCancel_Click" />
    
</asp:Content>

