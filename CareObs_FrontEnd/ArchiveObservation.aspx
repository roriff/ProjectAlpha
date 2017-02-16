<%@ Page Title="Archive Observation" Language="C#" MasterPageFile="~/CareObs.master" AutoEventWireup="true" CodeFile="ArchiveObservation.aspx.cs" Inherits="ArchiveObservation" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <nav>
        <asp:Label ID="lblManageObservation" runat="server" Font-Bold="True" ForeColor="Blue" Text="Manage Observation"></asp:Label>
        <asp:Button ID="btnAddObservation" class="buttonNav" runat="server" style="z-index: 1; left: 20px; top: 286px; position: absolute; width: 145px;" Text="Add Observation" OnClick="btnAddObservation_Click" />
        <asp:Button ID="btnEditObservation" class="buttonNav" runat="server" style="z-index: 1; left: 19px; top: 352px; position: absolute; width: 145px" Text="Edit Observation" OnClick="btnEditObservation_Click" />
        <asp:Button ID="btnArchiveObservation" class="buttonNav" runat="server" style="z-index: 1; left: 18px; top: 420px; position: absolute; width: 145px" Text="Archive Observation" OnClick="btnArchiveObservation_Click" />
        <asp:Button ID="btnExit" class="buttonNav" runat="server" OnClick="btnExit_Click" style="z-index: 1; left: 18px; top: 487px; position: absolute; width: 140px" Text="Exit" />
    </nav>

     <asp:Label ID="lblDeleteObservationTitle" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" style="z-index: 1; left: 490px; top: 225px; position: absolute; width: 304px" Text="ARCHIVE OBSERVATION"></asp:Label>
     <asp:Label ID="lblObservationToArchive" runat="server" style="z-index: 1; left: 329px; top: 321px; position: absolute; width: 171px" Text="Observation To Archive"></asp:Label>
     <asp:TextBox ID="txtObservationToArchive" runat="server" style="z-index: 1; left: 505px; top: 320px; position: absolute; width: 299px">ObservationID or Observation Name</asp:TextBox>
     
     <asp:Label ID="lblArchiveMessage" runat="server" Font-Bold="True" ForeColor="Red" style="z-index: 1; left: 294px; top: 375px; position: absolute; width: 580px" Text="Are you sure you want to archive this observation from the system?"></asp:Label>
     
     <asp:Button class="buttonNav" ID="btnYes" runat="server" style="z-index: 1; left: 306px; top: 421px; position: absolute; width: 140px" Text="Yes" OnClick="btnYes_Click" />
     <asp:Button class="buttonNav" ID="btnNo" runat="server" style="z-index: 1; left: 514px; top: 421px; position: absolute; width: 140px" Text="No" OnClick="btnNo_Click" />   
     <asp:Button class="buttonNav" ID="btnCancel" runat="server" style="z-index: 1; left: 725px; top: 422px; position: absolute; width: 140px" Text="Cancel" OnClick="btnCancel_Click" />
    
</asp:Content>

