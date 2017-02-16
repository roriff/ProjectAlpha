<%@ Page Title="Archive Patient" Language="C#" MasterPageFile="~/CareObs.master" AutoEventWireup="true" CodeFile="ArchivePatient.aspx.cs" Inherits="ArchivePatient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      
     <nav>
        <asp:Label ID="lblManagePatient" runat="server" Font-Bold="True" ForeColor="Blue" Text="Manage Patient"></asp:Label>
        <asp:Button class="buttonNav" ID="btnAddPatient" runat="server" style="z-index: 1; left: 19px; top: 292px; position: absolute; width: 140px;" Text="Add Patient" OnClick="btnAddPatient_Click" />
        <asp:Button class="buttonNav" ID="btnEditPatient" runat="server" style="z-index: 1; left: 19px; top: 355px; position: absolute; width: 140px" Text="Edit Patient" OnClick="btnEditPatient_Click" />
        <asp:Button class="buttonNav" ID="btnArchivePatient" runat="server" style="z-index: 1; left: 19px; top: 419px; position: absolute; width: 140px" Text="Archive Patient" OnClick="btnArchivePatient_Click" />    
        <asp:Button class="buttonNav" ID="btnExit" runat="server" OnClick="btnExit_Click" style="z-index: 1; left: 20px; top: 484px; position: absolute; width: 140px" Text="Exit" />              
    </nav>

     <asp:Label ID="lblDeletePatientTitle" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" style="z-index: 1; left: 512px; top: 224px; position: absolute; width: 250px" Text="ARCHIVE PATIENT"></asp:Label>
     <asp:Label ID="lblPatientToArchive" runat="server" style="z-index: 1; left: 355px; top: 321px; position: absolute; width: 154px" Text="Patient To Archive"></asp:Label>
     <asp:TextBox ID="txtPatientToArchive" runat="server" style="z-index: 1; left: 505px; top: 320px; position: absolute; width: 299px"> PatientID or Patient Full Name</asp:TextBox>
     
     <asp:Label ID="lblArchiveMessage" runat="server" Font-Bold="True" ForeColor="Red" style="z-index: 1; left: 316px; top: 375px; position: absolute; width: 535px" Text="Are you sure you want to archive this patient from the system?"></asp:Label>
     
     <asp:Button class="buttonNav" ID="btnYes" runat="server" style="z-index: 1; left: 306px; top: 421px; position: absolute; width: 140px" Text="Yes" OnClick="btnYes_Click" />
     <asp:Button class="buttonNav" ID="btnNo" runat="server" style="z-index: 1; left: 514px; top: 421px; position: absolute; width: 140px" Text="No" OnClick="btnNo_Click" />   
     <asp:Button class="buttonNav" ID="btnCancel" runat="server" style="z-index: 1; left: 725px; top: 422px; position: absolute; width: 140px" Text="Cancel" OnClick="btnCancel_Click" />
    
</asp:Content>

