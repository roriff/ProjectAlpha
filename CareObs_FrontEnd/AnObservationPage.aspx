<%@ Page Title="Add and Edit Observation" Language="C#" MasterPageFile="~/CareObs.master" AutoEventWireup="true" CodeFile="AnObservationPage.aspx.cs" Inherits="AnObservationPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <nav>
        <asp:Label ID="lblManageObservation" runat="server" Font-Bold="True" ForeColor="Blue" Text="Manage Observation"></asp:Label>
        <asp:Button ID="btnAddObservation" class="buttonNav" runat="server" style="z-index: 1; left: 20px; top: 286px; position: absolute; width: 145px;" Text="Add Observation" OnClick="btnAddObservation_Click" />
        <asp:Button ID="btnEditObservation" class="buttonNav" runat="server" style="z-index: 1; left: 19px; top: 352px; position: absolute; width: 145px" Text="Edit Observation" OnClick="btnEditObservation_Click" />
        <asp:Button ID="btnArchiveObservation" class="buttonNav" runat="server" style="z-index: 1; left: 18px; top: 420px; position: absolute; width: 145px" Text="Archive Observation" OnClick="btnArchiveObservation_Click" />
        <asp:Button ID="btnExit" class="buttonNav" runat="server" OnClick="btnExit_Click" style="z-index: 1; left: 18px; top: 487px; position: absolute; width: 140px" Text="Exit" />        
        <asp:Label ID="lblHeightMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 378px; top: 461px; position: absolute"></asp:Label>
        <asp:Label ID="lblWeightMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 379px; top: 390px; position: absolute"></asp:Label>
        <asp:Label ID="lblTemperatureMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 380px; top: 535px; position: absolute"></asp:Label>
        <asp:Label ID="lblBloodPressureMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 384px; top: 617px; position: absolute"></asp:Label>
        <asp:Label ID="lblPulseMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 384px; top: 700px; position: absolute"></asp:Label>
        <asp:Label ID="lblMRIScanMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 382px; top: 800px; position: absolute"></asp:Label>
        <asp:Label ID="lblPhysicalNotesMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 662px; top: 601px; position: absolute"></asp:Label>
        <asp:Label ID="lblMentalNotesMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 664px; top: 863px; position: absolute"></asp:Label>
               
    </nav>
        <asp:Label ID="lblDateTimeTaken" runat="server" Font-Bold="False" Font-Size="X-Small" ForeColor="Blue" style="z-index: 1; left: 654px; top: 359px; position: absolute; width: 126px; height: 13px;" Text="e.g. 01 jan 2017 10:51am"></asp:Label>
        
        <asp:Label ID="lblOnlyJPEG" runat="server" ForeColor="Red" style="z-index: 1; left: 376px; top: 845px; position: absolute; width: 186px" Text="[ Only .jpeg file allowed ]"></asp:Label>
        
        <asp:Label ID="lblHeightExample" runat="server" Font-Bold="False" Font-Size="X-Small" ForeColor="Blue" style="z-index: 1; left: 207px; top: 500px; position: absolute; width: 102px" Text="e.g.  1.34"></asp:Label>
        
        <asp:Label ID="lblWeightExample" runat="server" Font-Bold="False" Font-Size="X-Small" ForeColor="Blue" style="z-index: 1; left: 210px; top: 432px; position: absolute; width: 102px" Text="e.g.  48.78"></asp:Label>
        
        <asp:Label ID="lblPulseExample" runat="server" Font-Bold="False" Font-Size="X-Small" ForeColor="Blue" style="z-index: 1; left: 202px; top: 740px; position: absolute; width: 102px" Text="e.g.  85"></asp:Label>
        
         <asp:Label ID="lblPatient" runat="server" Font-Bold="True" style="z-index: 1; left: 657px; top: 284px; position: absolute" Text="Patient's Name"></asp:Label>
         <asp:TextBox ID="txtPatientName" runat="server" ReadOnly="True" style="z-index: 1; left: 788px; top: 282px; position: absolute; width: 180px"></asp:TextBox>
         
         <asp:Label ID="lblBloodPressureExample" runat="server" Font-Bold="False" Font-Size="X-Small" ForeColor="Blue" style="z-index: 1; left: 227px; top: 656px; position: absolute; width: 102px" Text="e.g. 123 / 84"></asp:Label>
        
         <asp:Label ID="lblTempExample" runat="server" Font-Bold="False" Font-Size="X-Small" ForeColor="Blue" style="z-index: 1; left: 218px; top: 575px; position: absolute; width: 102px" Text="e.g.  37.8"></asp:Label>
        
         <asp:Label ID="lblAddOrEditObservationTitle" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" style="z-index: 1; left: 445px; top: 224px; position: absolute; width: 359px" Text="ADD OR EDIT OBSERVATION"></asp:Label>
         
         <asp:Label ID="lblDateTimeTakenMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 787px; top: 322px; position: absolute; height: 13px"></asp:Label>
         
         <asp:Label ID="lblObservationID" runat="server" Font-Bold="True" style="z-index: 1; left: 233px; top: 283px; position: absolute" Text="ObservationID"></asp:Label>
         <asp:TextBox ID="txtObservationID" runat="server" ReadOnly="True" style="z-index: 1; left: 380px; top: 282px; position: absolute; width: 180px">-1</asp:TextBox>
        
         <asp:Label ID="lblObservationType" runat="server" Font-Bold="True" style="z-index: 1; left: 233px; top: 340px; position: absolute" Text="Observation Type"></asp:Label>
         <asp:DropDownList ID="ddlObservationType" runat="server" style="z-index: 1; left: 382px; top: 337px; position: absolute; height: 22px; width: 180px">
            <asp:ListItem>Physical Observation</asp:ListItem>
            <asp:ListItem>Mental Observation</asp:ListItem>
            <asp:ListItem>Both Mental and Physical</asp:ListItem>
         </asp:DropDownList>
         <asp:TextBox ID="txtWeight" runat="server" style="z-index: 1; left: 380px; top: 406px; position: absolute; width: 150px"></asp:TextBox>
         <asp:Label ID="lblWeight" runat="server" Font-Bold="True" style="z-index: 1; left: 233px; top: 410px; position: absolute; height: 19px;" Text="Weight"></asp:Label>
         <asp:TextBox ID="txtHeight" runat="server" style="z-index: 1; left: 379px; top: 476px; position: absolute; width: 150px"></asp:TextBox>
         <asp:Label ID="lblHeight" runat="server" Font-Bold="True" style="z-index: 1; left: 233px; top: 477px; position: absolute" Text="Height"></asp:Label>
         <asp:TextBox ID="txtTemperature" runat="server" style="z-index: 1; left: 379px; top: 551px; position: absolute; width: 150px"></asp:TextBox>
         <asp:Label ID="lblTemperature" runat="server" Font-Bold="True" style="z-index: 1; left: 231px; top: 552px; position: absolute; width: 96px" Text="Temperature"></asp:Label>
         <asp:TextBox ID="txtBloodPressure" runat="server" style="z-index: 1; left: 383px; top: 632px; position: absolute; width: 150px"></asp:TextBox>
         <asp:Label ID="lblBloodPressure" runat="server" Font-Bold="True" style="z-index: 1; left: 233px; top: 632px; position: absolute" Text="Blood Pressure"></asp:Label>
         <asp:TextBox ID="txtPulse" runat="server" style="z-index: 1; left: 382px; top: 717px; position: absolute; width: 150px"></asp:TextBox>
         <asp:Label ID="lblPulse" runat="server" Font-Bold="True" style="z-index: 1; left: 233px; top: 720px; position: absolute" Text="Pulse"></asp:Label>
         <asp:TextBox ID="txtDateTimeTaken" runat="server" style="z-index: 1; left: 789px; top: 340px; position: absolute; width: 180px"></asp:TextBox>
         <asp:Label ID="lblDateTaken" runat="server" Font-Bold="True" style="z-index: 1; left: 655px; top: 340px; position: absolute; width: 131px" Text="Date Time Taken"></asp:Label>
         
         <asp:Label ID="lblMRIScanImage" runat="server" Font-Bold="True" style="z-index: 1; left: 219px; top: 818px; position: absolute; width: 148px" Text="MRI Scan Image"></asp:Label>
         <asp:FileUpload ID="FileUpload" runat="server" style="z-index: 1; left: 381px; top: 817px; position: absolute" />
         
         <asp:Label ID="lblPhysicalStateNotes" runat="server" Font-Bold="True" style="z-index: 1; left: 659px; top: 409px; position: absolute; width: 160px" Text="Physical State Notes"></asp:Label>
         <asp:TextBox ID="txtPhysicalStateNotes" runat="server" style="z-index: 1; left: 659px; top: 431px; position: absolute; height: 160px; width: 310px" TextMode="MultiLine"></asp:TextBox>
         
         <asp:Label ID="lblMentalStateNotes" runat="server" Font-Bold="True" style="z-index: 1; left: 654px; top: 664px; position: absolute; width: 160px" Text="Mental State Notes"></asp:Label>
         <asp:TextBox ID="txtMentalStateNotes" runat="server" style="z-index: 1; left: 662px; top: 691px; position: absolute; height: 160px; width: 310px" TextMode="MultiLine"></asp:TextBox>
         
         <asp:Label ID="lblKg" runat="server" Font-Bold="False" style="z-index: 1; left: 537px; top: 408px; position: absolute" Text="Kg"></asp:Label>
         <asp:Label ID="lblMeter" runat="server" Font-Bold="False" style="z-index: 1; left: 538px; top: 477px; position: absolute" Text="Meter"></asp:Label>
         <asp:Label ID="lblDegreeCelcius" runat="server" Font-Bold="False" style="z-index: 1; left: 530px; top: 552px; position: absolute; width: 105px" Text="Degr. Celcius"></asp:Label>
         
         <asp:Button class="buttonNav" ID="btnSave" runat="server" OnClick="btnSave_Click" style="z-index: 1; left: 379px; top: 953px; position: absolute; width: 140px" Text="Save" />
         <asp:Button class="buttonNav" ID="btnDoNotSave" runat="server" OnClick="btnDoNotSave_Click" style="z-index: 1; left: 600px; top: 954px; position: absolute; width: 140px" Text="Do Not Save" />
         <asp:Button class="buttonNav" ID="btnCancel" runat="server" style="z-index: 1; left: 796px; top: 951px; position: absolute; width: 140px" Text="Cancel" OnClick="btnCancel_Click" />

</asp:Content>

