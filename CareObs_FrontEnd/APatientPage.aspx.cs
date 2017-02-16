using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
using TestFrameWork;

public partial class APatientPage : System.Web.UI.Page
{
    // variable PatientID to store the value of the PatientID
    Int32 PatientID;

    // Session object that we will use to pass the StaffID using the system at that time
    //Int32 StaffID;


    protected void Page_Load(object sender, EventArgs e)
    {
        //Disabled the butttons and textboxes that are not meant to be used on this page
        btnAddPatient.Enabled = false;
        btnEditPatient.Enabled = false;
        //btnArchivePatient.Enabled = false;

        // make the PatientID text disabled as user is not meant to access it
        // and it is also set as a read only textbox
        txtPatientID.Enabled = false;

        // copy the data from the query string seen in the browser to the textbox txtPatientID
        PatientID = Convert.ToInt32(Request.QueryString["PatientID"]);

        //view the PatientID in the PatientID textbox
        txtPatientID.Text = Convert.ToString(Request.QueryString["PatientID"]);

        // if the PatientID is not -1 then display the data from the record
        if (IsPostBack != true)
        {

            if (PatientID != -1)
            {
                // display the data of this patient on the form
                DisplayPatient(PatientID);
            }

            //else // in case the patient doesn't exist then it is adding an object meaning the ItemNo is -1 
            //{
                // Use the session  object that is being passed between the pages in the server and store it as sellerID
                //StaffID = (string)Session["UserName"];
                //lblUserName.Text = StaffID;
            //}
        }
    }

    // Method to display the patient on the form
    void DisplayPatient(Int32 PatientID)
    {
        //create an an instance of the class clsPatientColllection
        clsPatientCollection MyPatient= new clsPatientCollection();

        // create an instance of the class clsPatient
        clsPatient PatientToEdit = new clsPatient();

        // get the data for this record
        PatientToEdit = MyPatient.FindPatient(PatientID);

        // display all the patient's data found on the form 
        txtPatientID.Text = Convert.ToString(PatientToEdit.PatientID);

        ddlTitle.SelectedValue = Convert.ToString(PatientToEdit.Title); // take value of the Title and match it to the selected value of the ddlTitle
        txtFirstName.Text = PatientToEdit.FirstName; // put the value of the PatientToEdit FirstName and put it in the textbox txtFirstName
        txtLastName.Text = PatientToEdit.LastName;
        txtDateOfBirth.Text = Convert.ToString(PatientToEdit.DateOfBirth);
        ddlGender.SelectedValue = Convert.ToString(PatientToEdit.Gender);
        txtStreet.Text = PatientToEdit.Street;
        txtTown.Text = PatientToEdit.Town;
        txtCounty.Text = PatientToEdit.County ;
        txtPostCode.Text = PatientToEdit.PostCode;
        txtLandlineNo.Text = PatientToEdit.LandlineNo;
        txtMobileNo.Text = PatientToEdit.MobileNo;
        txtOccupation.Text = PatientToEdit.Occupation;
        txtNextOfKinName.Text = PatientToEdit.NextOfKin;
        txtNextOfKinPhoneNo.Text = PatientToEdit.NextOfKinPhoneNo;

        txtDateAdmitted.Text = Convert.ToString(PatientToEdit.DateAdmitted) ;
        txtDateDischarged.Text = Convert.ToString(PatientToEdit.DateDischarged);

        // take the values from the PatientToEdit and put them in the ddl selected values
        ddlMaritalStatus.SelectedValue = Convert.ToString(PatientToEdit.MaritalStatus);
        ddlSexualOrientation.SelectedValue = Convert.ToString(PatientToEdit.SexualOrientation) ;
        ddlEthnicity.SelectedValue = Convert.ToString(PatientToEdit.Ethnicity);
        ddlTitle.SelectedValue = Convert.ToString(PatientToEdit.Title);
        ddlReligion.SelectedValue = Convert.ToString(PatientToEdit.Religion);
        ddlFirstLanguage.SelectedValue = Convert.ToString(PatientToEdit.FirstLanguage);

        txtGPDetails.Text = PatientToEdit.GPDetails;
        txtNotes.Text = PatientToEdit.Notes ;

        // foreign keys data
        // take the converted integer value of the PatientToEdit WardNo 
        //and put it as the index number of the ddlWard so it displays the selected value of that index in the ddlWard
        ddlWard.SelectedIndex = Convert.ToInt32(PatientToEdit.WardNo) ;

        // take the converted integer value of the PatientToEdit TreatmentID 
        //and put it as the index number of the ddlMedicalCondition so it displays the selectedvalue of that index in the ddlMedicalCondition 
        ddlMedicalCondition.SelectedIndex = Convert.ToInt32(PatientToEdit.TreatmentID); 
        
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        //Response.Redirect("APatient.aspx");

        //create an instance of the clsPatientCollection
        clsPatient ThisPatient = new clsPatient();

        // variable to store any error message
        //string ErrorMessage;

        //test the data entered on the web form by validate each field based on each validation methof from the clsPatient
        string FirstNameErrorMessage = ThisPatient.ValidateFirstName(txtFirstName.Text);
        string LastNameErrorMessage = ThisPatient.ValidateLastName(txtLastName.Text);
        string DateOfBirthErrorMessage = ThisPatient.ValidateDateOfBirth(txtDateOfBirth.Text);
        string StreetErrorMessage = ThisPatient.ValidateStreet(txtStreet.Text) ;
        string TownErrorMessage = ThisPatient.ValidateTown(txtTown.Text);
        string CountyErrorMessage = ThisPatient.ValidateCounty(txtCounty.Text);
        string PostCodeErrorMessage = ThisPatient.ValidatePostCode(txtPostCode.Text);
        string LandlineNoErrorMessage = ThisPatient.ValidateLandlineNo(txtLandlineNo.Text);
        string MobileNoErrorMessage = ThisPatient.ValidateMobileNo(txtMobileNo.Text);
        string OccupationErrorMessage = ThisPatient.ValidateOccupation(txtOccupation.Text);
        string NextOfKinErrorMessage = ThisPatient.ValidateNextOfKin(txtNextOfKinName.Text);
        string NextOfKinPhoneNoErrorMessage = ThisPatient.ValidateNextOfKinPhoneNo(txtNextOfKinPhoneNo.Text);
        string DateAdmittedErrorMessage = ThisPatient.ValidateDateAdmitted(txtDateAdmitted.Text);
        string DateDischargedErrorMessage = ThisPatient.ValidateDateDischarged(txtDateDischarged.Text);

        // compare DateAdmitted and DadteDischarged so admission takes place before discharge
        string DateErrorMessage = ThisPatient.ValidateDateAdmitted_DateDischarged(txtDateAdmitted.Text, txtDateDischarged.Text);

        string GPDetailsErrorMessage = ThisPatient.ValidateGPDetails(txtGPDetails.Text);
        string NotesErrorMessage = ThisPatient.ValidateNotes(txtNotes.Text);

        if ( FirstNameErrorMessage + 
             LastNameErrorMessage + 
             DateOfBirthErrorMessage +
             StreetErrorMessage +
             TownErrorMessage +
             CountyErrorMessage +
             PostCodeErrorMessage +
             LandlineNoErrorMessage +
             MobileNoErrorMessage +
             OccupationErrorMessage + 
             NextOfKinErrorMessage +
             NextOfKinPhoneNoErrorMessage +
             DateAdmittedErrorMessage +
             DateDischargedErrorMessage +
             DateErrorMessage +
             GPDetailsErrorMessage +
             NotesErrorMessage == "") // if the concatenation of those string is empty then all validations passed
        {
            // do something with the data add patient or edit patient e.g insert or update 

            // save the data by adding  the data to the database
            if (PatientID == -1) // if the PatientID is -1 then add the record.....
            {
                // create an new instance of the clsPatient
                clsPatient NewPatient = new clsPatient();

                // copy the all the data from the user interface to the object
                NewPatient.Title = Convert.ToString(ddlTitle.SelectedValue); // selected value in ddl
                NewPatient.FirstName = txtFirstName.Text;
                NewPatient.LastName = txtLastName.Text;
                NewPatient.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
                NewPatient.Gender = Convert.ToString(ddlGender.SelectedValue);
                NewPatient.Street = txtStreet.Text;
                NewPatient.Town = txtTown.Text;
                NewPatient.County = txtCounty.Text;
                NewPatient.PostCode = txtPostCode.Text;
                NewPatient.LandlineNo =txtLandlineNo.Text;
                NewPatient.MobileNo = txtMobileNo.Text;
                NewPatient.Occupation = txtOccupation.Text;
                NewPatient.NextOfKin = txtNextOfKinName.Text;
                NewPatient.NextOfKinPhoneNo =txtNextOfKinPhoneNo.Text;

                NewPatient.DateAdmitted = Convert.ToDateTime(txtDateAdmitted.Text);
                NewPatient.DateDischarged = Convert.ToDateTime(txtDateDischarged.Text);

                NewPatient.MaritalStatus = Convert.ToString(ddlMaritalStatus.SelectedValue);
                NewPatient.SexualOrientation = Convert.ToString(ddlSexualOrientation.SelectedValue);
                NewPatient.Ethnicity = Convert.ToString(ddlEthnicity.SelectedValue);
                NewPatient.Title = Convert.ToString(ddlTitle.SelectedValue);
                NewPatient.Religion = Convert.ToString(ddlReligion.SelectedValue); // selected value in ddl 
                NewPatient.FirstLanguage = Convert.ToString(ddlFirstLanguage.SelectedValue);

                NewPatient.GPDetails = txtGPDetails.Text;
                NewPatient.Notes = txtNotes.Text;

                // foreign keys data
                NewPatient.WardNo = ddlWard.SelectedIndex; // index number of this corresponds to the WardNo
                NewPatient.TreatmentID = ddlMedicalCondition.SelectedIndex; // index of this corresponds to the TreatmentID

                // create a new instance of the clsPatientCollection
                clsPatientCollection NewPatientTable = new clsPatientCollection();

                // insert the new record of the patient table object created above to the database
                NewPatientTable.InsertPatient(NewPatient);
            }

            else // update the patient's record as the record is existing already
            {
                // this is an existing record that we can update
                //creatte a new instance of clsPatient
                clsPatient ExistingPatient = new clsPatient();

                //copy the data from the user interface to the object created above so it can be sent to the database
                ExistingPatient.PatientID = Convert.ToInt32(PatientID);
                ExistingPatient.Title = Convert.ToString(ddlTitle.SelectedValue); // selected value in ddl
                ExistingPatient.FirstName = txtFirstName.Text;
                ExistingPatient.LastName = txtLastName.Text;
                ExistingPatient.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
                ExistingPatient.Gender = Convert.ToString(ddlGender.SelectedValue);
                ExistingPatient.Street = txtStreet.Text;
                ExistingPatient.Town = txtTown.Text;
                ExistingPatient.County = txtCounty.Text;
                ExistingPatient.PostCode = txtPostCode.Text;
                ExistingPatient.LandlineNo = txtLandlineNo.Text;
                ExistingPatient.MobileNo = txtMobileNo.Text;
                ExistingPatient.Occupation = txtOccupation.Text;
                ExistingPatient.NextOfKin = txtNextOfKinName.Text;
                ExistingPatient.NextOfKinPhoneNo = txtNextOfKinPhoneNo.Text;

                // dates from form to the database
                ExistingPatient.DateAdmitted = Convert.ToDateTime(txtDateAdmitted.Text);
                ExistingPatient.DateDischarged = Convert.ToDateTime(txtDateDischarged.Text);

                // selected value in ddl
                ExistingPatient.MaritalStatus = Convert.ToString(ddlMaritalStatus.SelectedValue);
                ExistingPatient.SexualOrientation = Convert.ToString(ddlSexualOrientation.SelectedValue);
                ExistingPatient.Ethnicity = Convert.ToString(ddlEthnicity.SelectedValue);
                ExistingPatient.Religion = Convert.ToString(ddlReligion.SelectedValue);  
                ExistingPatient.FirstLanguage = Convert.ToString(ddlFirstLanguage.SelectedValue);

                ExistingPatient.GPDetails = txtGPDetails.Text;
                ExistingPatient.Notes = txtNotes.Text;

                // foreign keys data
                ExistingPatient.WardNo = ddlWard.SelectedIndex; // index number of this corresponds to the WardNo
                ExistingPatient.TreatmentID = ddlMedicalCondition.SelectedIndex; // index of this corresponds to the TreatmentID
                //create a new instance of the clsPatientCollection
                clsPatientCollection NewPatientTable = new clsPatientCollection();

                //update the existing record
                NewPatientTable.UpdatePatient(ExistingPatient);

                // then go back to the the patient page
                //Response.Redirect("APatient.aspx");

            }

            // then return to the main page if everything went OK
            Response.Redirect("APatient.aspx");
        }

        else // in case there are errors while filling the patient form
        {
            //return the error messages one after the other depending on which data entry fails 
            lblFirstNameMessage.Text = FirstNameErrorMessage;
            lblLastNameMessage.Text = LastNameErrorMessage;
            lblDateOfBirthMessage.Text = DateOfBirthErrorMessage;
            lblStreetMessage.Text = StreetErrorMessage;
            lblTownMessage.Text = TownErrorMessage;
            lblCountyMessage.Text = CountyErrorMessage;
            lblPostCodeMessage.Text = PostCodeErrorMessage;
            lblLandlineNoMessage.Text = LandlineNoErrorMessage;
            lblMobileNoMessage.Text = MobileNoErrorMessage;
            lblOccupationMessage.Text = OccupationErrorMessage;
            lblNextOfKinMessage.Text = NextOfKinErrorMessage;
            lblNextOfKinPhoneNoMessage.Text = NextOfKinPhoneNoErrorMessage;
            lblDateAdmittedMessage.Text = DateAdmittedErrorMessage;
            lblDateDischargedMessage.Text = DateDischargedErrorMessage;
            lblDateMessage.Text = DateErrorMessage; // to display the message between DateAdmitted and DateDischarged
            lblGPDetailsMessage.Text = GPDetailsErrorMessage;
            lblNotesMessage.Text = NotesErrorMessage;
        }
    }

    protected void btnDoNotSave_Click(object sender, EventArgs e)
    {
        Response.Redirect("APatient.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("APatient.aspx");
    }

    protected void btnAddPatient_Click(object sender, EventArgs e)
    {
        // no need for code here as the buuton is disabbled in this form
    }

    protected void btnEditPatient_Click(object sender, EventArgs e)
    {
        // no need for code here as the buuton is disabbled in this form
    }

    protected void btnArchivePatient_Click(object sender, EventArgs e)
    {
        //create session objects to use for the transaction of this button
        Session["PatientID"] = txtPatientID.Text;
        Session["PatientName"] = txtFirstName.Text + " " +  txtLastName.Text;

        // then go to the page archive the patient
        Response.Redirect("ArchivePatient.aspx");
    }

    protected void btnExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

   
}