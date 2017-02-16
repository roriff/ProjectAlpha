<%@ Page Title="Add and Edit Patient" Language="C#" MasterPageFile="~/CareObs.master" AutoEventWireup="true" CodeFile="APatientPage.aspx.cs" Inherits="APatientPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <nav>
        <asp:Label ID="lblManagePatient" runat="server" Font-Bold="True" ForeColor="Blue" Text="Manage Patient"></asp:Label>
        <asp:Button class="buttonNav" ID="btnAddPatient" runat="server" style="z-index: 1; left: 19px; top: 292px; position: absolute; width: 140px;" Text="Add Patient" OnClick="btnAddPatient_Click" />
        <asp:Button class="buttonNav" ID="btnEditPatient" runat="server" style="z-index: 1; left: 19px; top: 355px; position: absolute; width: 140px" Text="Edit Patient" OnClick="btnEditPatient_Click" />
        <asp:Button class="buttonNav" ID="btnArchivePatient" runat="server" style="z-index: 1; left: 19px; top: 419px; position: absolute; width: 140px" Text="Archive Patient" OnClick="btnArchivePatient_Click" />    
        <asp:Button class="buttonNav" ID="btnExit" runat="server" OnClick="btnExit_Click" style="z-index: 1; left: 20px; top: 484px; position: absolute; width: 140px" Text="Exit" />             
        <asp:Label ID="lblFirstNameMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 338px; top: 344px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblLastNameMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 340px; top: 398px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblDateOfBirthMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 321px; top: 452px; position: absolute; width: 300px"></asp:Label>
        <asp:Label ID="lblStreetMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 342px; top: 560px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblTownMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 345px; top: 617px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblPostCodeMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 344px; top: 745px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblMobileNoMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 349px; top: 868px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblNotesMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 719px; top: 928px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblCountyMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 346px; top: 680px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblOccupationMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 342px; top: 935px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblNextOfKinMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 347px; top: 997px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblNextOfKinPhoneNoMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 346px; top: 1063px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblDateAdmittedMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 753px; top: 344px; position: absolute; width: 250px; height: 13px;"></asp:Label>
        <asp:Label ID="lblDateDischargedMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 767px; top: 400px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblLandlineNoMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 347px; top: 807px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblGPDetailsMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 742px; top: 745px; position: absolute; width: 250px"></asp:Label>
        <asp:Label ID="lblDateMessage" runat="server" Font-Size="X-Small" ForeColor="Red" style="z-index: 1; left: 767px; top: 386px; position: absolute; width: 250px; height: 13px;"></asp:Label>
    </nav>

        <asp:Label ID="lblAddOrEditPatientTitle" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Blue" style="z-index: 1; left: 457px; top: 219px; position: absolute; width: 336px" Text="ADD OR EDIT PATIENT"></asp:Label>
        
        <asp:Label ID="lblDateExample3" runat="server" Font-Bold="False" Font-Size="X-Small" ForeColor="Blue" style="z-index: 1; left: 664px; top: 437px; position: absolute; width: 104px" Text="Default is 1 jan 2117 i.e. not discharged yet"></asp:Label>
        <asp:Label ID="lblDateExample2" runat="server" Font-Bold="False" Font-Size="X-Small" ForeColor="Blue" style="z-index: 1; left: 649px; top: 382px; position: absolute; width: 126px" Text="Default is Today's date"></asp:Label>
        <asp:Label ID="lblDateExample1" runat="server" Font-Bold="False" Font-Size="X-Small" ForeColor="Blue" style="z-index: 1; left: 232px; top: 490px; position: absolute; width: 102px" Text="e.g. 01 jan 1985 "></asp:Label>
        
        <asp:Label ID="lblPatientID" runat="server" Font-Bold="True" style="z-index: 1; left: 234px; top: 264px; position: absolute" Text="PatientID"></asp:Label>
        <asp:TextBox ID="txtPatientID" runat="server" ReadOnly="True" style="z-index: 1; left: 335px; top: 262px; position: absolute; width: 150px"></asp:TextBox>
        
        <asp:Label ID="lblTitle" runat="server" Font-Bold="True" style="z-index: 1; left: 233px; top: 311px; position: absolute" Text="Title"></asp:Label>
        <asp:DropDownList ID="ddlTitle" runat="server" style="z-index: 1; left: 336px; top: 310px; position: absolute; height: 22px; width: 150px">
             <asp:ListItem>Unknown</asp:ListItem>
             <asp:ListItem>Mr</asp:ListItem>
             <asp:ListItem>Mrs</asp:ListItem>
             <asp:ListItem>Ms</asp:ListItem>
             <asp:ListItem>Miss</asp:ListItem>
             <asp:ListItem>Dr</asp:ListItem>
         </asp:DropDownList>
         <asp:Label ID="lblFirstName" runat="server" Font-Bold="True" style="z-index: 1; left: 221px; top: 361px; position: absolute; width: 110px" Text="First Name"></asp:Label>
         <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 338px; top: 361px; position: absolute; width: 250px"></asp:TextBox>
         <asp:Label ID="lblLastName" runat="server" Font-Bold="True" style="z-index: 1; left: 221px; top: 414px; position: absolute; width: 110px" Text="Last Name"></asp:Label>
         <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 339px; top: 414px; position: absolute; width: 250px"></asp:TextBox>
         <asp:Label ID="lblDateOfBirth" runat="server" Font-Bold="True" style="z-index: 1; left: 230px; top: 470px; position: absolute; width: 110px; height: 19px;" Text="Date Of Birth"></asp:Label>
         <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 341px; top: 469px; position: absolute; width: 250px"></asp:TextBox>
         <asp:Label ID="lblGender" runat="server" Font-Bold="True" style="z-index: 1; left: 236px; top: 520px; position: absolute" Text="Gender"></asp:Label>
         <asp:DropDownList ID="ddlGender" runat="server" style="z-index: 1; left: 343px; top: 517px; position: absolute; height: 22px; width: 250px">
             <asp:ListItem>Undisclosed</asp:ListItem>
             <asp:ListItem>Male</asp:ListItem>
             <asp:ListItem>Female</asp:ListItem>
             <asp:ListItem>Transgender</asp:ListItem>
         </asp:DropDownList>
         <asp:Label ID="lblStreet" runat="server" Font-Bold="True" style="z-index: 1; left: 234px; top: 579px; position: absolute" Text="Street"></asp:Label>
         <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 341px; top: 575px; position: absolute; width: 250px"></asp:TextBox>
         <asp:Label ID="lblTown" runat="server" Font-Bold="True" style="z-index: 1; left: 234px; top: 635px; position: absolute; height: 19px;" Text="Town"></asp:Label>
         <asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 342px; top: 632px; position: absolute; width: 250px"></asp:TextBox>
         <asp:Label ID="lblCounty" runat="server" Font-Bold="True" style="z-index: 1; left: 233px; top: 698px; position: absolute; height: 19px; width: 59px;" Text="County"></asp:Label>
         <asp:TextBox ID="txtCounty" runat="server" style="z-index: 1; left: 342px; top: 696px; position: absolute; width: 250px"></asp:TextBox>
         <asp:Label ID="lblPostCode" runat="server" Font-Bold="True" style="z-index: 1; left: 228px; top: 762px; position: absolute; width: 91px" Text="Post Code"></asp:Label>
         <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 344px; top: 759px; position: absolute; width: 250px"></asp:TextBox>
         <asp:Label ID="lblLandlineNo" runat="server" Font-Bold="True" style="z-index: 1; left: 233px; top: 825px; position: absolute" Text="LandlineNo"></asp:Label>
         <asp:TextBox ID="txtLandlineNo" runat="server" style="z-index: 1; left: 345px; top: 822px; position: absolute; width: 250px"></asp:TextBox>
         <asp:Label ID="lblMobileNo" runat="server" Font-Bold="True" style="z-index: 1; left: 233px; top: 889px; position: absolute" Text="MobileNo"></asp:Label>
         <asp:TextBox ID="txtMobileNo" runat="server" style="z-index: 1; left: 344px; top: 885px; position: absolute; width: 250px"></asp:TextBox>
         <asp:Label ID="lblOccupation" runat="server" Font-Bold="True" style="z-index: 1; left: 221px; top: 952px; position: absolute; width: 110px" Text="Occupation"></asp:Label>
         <asp:TextBox ID="txtOccupation" runat="server" style="z-index: 1; left: 343px; top: 949px; position: absolute; width: 250px"></asp:TextBox>
         <asp:TextBox ID="txtNextOfKinName" runat="server" style="z-index: 1; left: 344px; top: 1012px; position: absolute; width: 250px"></asp:TextBox>
         <asp:Label ID="lblWard" runat="server" Font-Bold="True" style="z-index: 1; left: 656px; top: 265px; position: absolute" Text="Ward"></asp:Label>
         
         <asp:DropDownList ID="ddlWard" runat="server" style="z-index: 1; left: 799px; top: 264px; position: absolute; height: 22px; width: 160px; bottom: 322px;">
             <asp:ListItem>Ward 1 - Male</asp:ListItem>
             <asp:ListItem>Ward 2 - Male</asp:ListItem>
             <asp:ListItem>Ward 3 - Female</asp:ListItem>
             <asp:ListItem>Ward 4 - Female</asp:ListItem>
             <asp:ListItem>Ward 5 - Transgender</asp:ListItem>
         </asp:DropDownList>
         
         <asp:Label ID="lblMedicalCondition" runat="server" Font-Bold="True" style="z-index: 1; left: 656px; top: 311px; position: absolute" Text="Medical Condition"></asp:Label>
         <asp:DropDownList ID="ddlMedicalCondition" runat="server" style="z-index: 1; left: 800px; top: 310px; position: absolute; height: 22px; width: 160px; bottom: 276px;">
             <asp:ListItem>Not Stated</asp:ListItem>
             <asp:ListItem>Huntington</asp:ListItem>
             <asp:ListItem>Schizophrenia</asp:ListItem>
             <asp:ListItem>Delusion</asp:ListItem>
             <asp:ListItem>Anxiety</asp:ListItem>
             <asp:ListItem>Dementia</asp:ListItem>
             <asp:ListItem>Mental Breakdown</asp:ListItem>
             <asp:ListItem>Bipolar Disorder</asp:ListItem>
         </asp:DropDownList>
    
    
         <asp:Label ID="lblMaritalStatus" runat="server" Font-Bold="True" style="z-index: 1; left: 654px; top: 471px; position: absolute; width: 110px" Text="Marital Status"></asp:Label>
         <asp:DropDownList ID="ddlMaritalStatus" runat="server" style="z-index: 1; left: 805px; top: 469px; position: absolute; height: 22px; width: 160px">
             <asp:ListItem>Undisclosed</asp:ListItem>
             <asp:ListItem>Married</asp:ListItem>
             <asp:ListItem>Divorced</asp:ListItem>
             <asp:ListItem>Engaged</asp:ListItem>
             <asp:ListItem>Single</asp:ListItem>
             <asp:ListItem>Civil partnership</asp:ListItem>
             <asp:ListItem>Long partnership</asp:ListItem>   
         </asp:DropDownList>
         <asp:Label ID="lblSexualOrientation" runat="server" Font-Bold="True" style="z-index: 1; left: 646px; top: 521px; position: absolute; width: 160px" Text="Sexual Orientation"></asp:Label>
         <asp:DropDownList ID="ddlSexualOrientation" runat="server" style="z-index: 1; left: 806px; top: 519px; position: absolute; height: 22px; width: 160px">
             <asp:ListItem>Undisclosed</asp:ListItem>
             <asp:ListItem>Heterosexual</asp:ListItem>
             <asp:ListItem>Homosexual</asp:ListItem>
             <asp:ListItem>Bixesual</asp:ListItem>
             <asp:ListItem>Lesbian</asp:ListItem>
         </asp:DropDownList>
         <asp:Label ID="lblEthnicity" runat="server" Font-Bold="True" style="z-index: 1; left: 657px; top: 579px; position: absolute" Text="Ethnicity"></asp:Label>
         <asp:DropDownList ID="ddlEthnicity" runat="server" style="z-index: 1; left: 805px; top: 577px; position: absolute; height: 22px; width: 160px">
             <asp:ListItem>Undisclosed</asp:ListItem>
             <asp:ListItem>White</asp:ListItem>
             <asp:ListItem>Black</asp:ListItem>
             <asp:ListItem>Asian Indian</asp:ListItem>
             <asp:ListItem>Asian Chinese</asp:ListItem>
             <asp:ListItem>Asian Arab</asp:ListItem>
             <asp:ListItem>Mixed race</asp:ListItem>
         </asp:DropDownList>
         <asp:Label ID="lblReligion" runat="server" Font-Bold="True" style="z-index: 1; left: 657px; top: 636px; position: absolute" Text="Religion"></asp:Label>
         <asp:TextBox ID="txtNextOfKinPhoneNo" runat="server" style="z-index: 1; left: 345px; top: 1077px; position: absolute; width: 250px"></asp:TextBox>
         <asp:DropDownList ID="ddlReligion" runat="server" style="z-index: 1; left: 806px; top: 634px; position: absolute; height: 22px; width: 160px">
             <asp:ListItem>Undisclosed</asp:ListItem>
             <asp:ListItem>Christian</asp:ListItem>
             <asp:ListItem>Muslim</asp:ListItem>
             <asp:ListItem>Buddhist</asp:ListItem>
             <asp:ListItem>Hindu</asp:ListItem>
             <asp:ListItem>Agnostic</asp:ListItem>
         </asp:DropDownList>
         <asp:Label ID="lblFirstLanguage" runat="server" Font-Bold="True" style="z-index: 1; left: 647px; top: 699px; position: absolute; width: 139px; height: 19px;" Text="First Language"></asp:Label>
         <asp:DropDownList ID="ddlFirstLanguage" runat="server" style="z-index: 1; left: 808px; top: 697px; position: absolute; height: 22px; width: 160px">
             <asp:ListItem>Undisclosed</asp:ListItem>
             <asp:ListItem>English</asp:ListItem>
             <asp:ListItem>German</asp:ListItem>
             <asp:ListItem>French</asp:ListItem>
             <asp:ListItem>Dutch</asp:ListItem>
             <asp:ListItem>Indian</asp:ListItem>
             <asp:ListItem>Arabic</asp:ListItem>
             <asp:ListItem>Chinese</asp:ListItem>
             <asp:ListItem>Afrikaans</asp:ListItem>
             <asp:ListItem>Russian</asp:ListItem>
             <asp:ListItem>Spanish</asp:ListItem>
             <asp:ListItem>Portuguese</asp:ListItem>
             <asp:ListItem>Creole</asp:ListItem>
         </asp:DropDownList>
         <asp:Label ID="lblNextOfKinName" runat="server" Font-Bold="True" style="z-index: 1; left: 225px; top: 1015px; position: absolute; width: 101px" Text="Next Of Kin"></asp:Label>
         <asp:Label ID="lblNextOfKinPhoneNo" runat="server" Font-Bold="True" style="z-index: 1; left: 215px; top: 1080px; position: absolute; width: 135px" Text="Kin PhoneNo"></asp:Label>
         <asp:Label ID="lblDateAdmitted" runat="server" Font-Bold="True" style="z-index: 1; left: 651px; top: 364px; position: absolute; width: 120px" Text="Date Admitted"></asp:Label>
         <asp:TextBox ID="txtDateAdmitted" runat="server" style="z-index: 1; left: 800px; top: 360px; position: absolute; width: 160px"></asp:TextBox>
         <asp:Label ID="lblDateDischarged" runat="server" Font-Bold="True" style="z-index: 1; left: 652px; top: 417px; position: absolute; width: 135px" Text="Date Discharged"></asp:Label>
         <asp:TextBox ID="txtDateDischarged" runat="server" style="z-index: 1; left: 801px; top: 415px; position: absolute; width: 160px"></asp:TextBox>
         <asp:Label ID="lblGPDetails" runat="server" Font-Bold="True" style="z-index: 1; left: 657px; top: 741px; position: absolute; height: 19px; width: 88px" Text="GP Details"></asp:Label>
         <asp:TextBox ID="txtGPDetails" runat="server" style="z-index: 1; left: 662px; top: 768px; position: absolute; width: 308px; height: 132px" TextMode="MultiLine"></asp:TextBox>
         <asp:Label ID="lblNotes" runat="server" Font-Bold="True" style="z-index: 1; left: 657px; top: 925px; position: absolute; height: 19px; width: 57px" Text="Notes"></asp:Label>
         <asp:TextBox ID="txtNotes" runat="server" style="z-index: 1; left: 659px; top: 949px; position: absolute; width: 308px; height: 148px" TextMode="MultiLine"></asp:TextBox>
         
    <asp:Button class="buttonNav" ID="btnSave" runat="server" OnClick="btnSave_Click" style="z-index: 1; left: 340px; top: 1189px; position: absolute; width: 140px" Text="Save" />
    <asp:Button class="buttonNav" ID="btnDoNotSave" runat="server" OnClick="btnDoNotSave_Click" style="z-index: 1; left: 554px; top: 1189px; position: absolute; width: 140px" Text="Do Not Save" />
    <asp:Button class="buttonNav" ID="btnCancel" runat="server" style="z-index: 1; left: 770px; top: 1188px; position: absolute; width: 140px" Text="Cancel" OnClick="btnCancel_Click" />

</asp:Content>

