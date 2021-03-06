﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class ATreatment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this is the first time the button is being loaded then view all the items
        //which is the meaning of IsPostBack is false
        //else dont bother to use this block of code below
        if (IsPostBack != true)
        {
            // make the data grid invisible as we are not using it here , we are using the list;
            //PatientDataGridView.Visible = false;

            // invoke the method ViewAllPatients() in the load page  to view the data in a list
            //ViewAllPatients("", "");


            // make the list invisible as it is not needed if we use the gridview to display patients data
            lstPatients.Visible = false;

            // invoke the method for displaying the patients in a datagridview in the load page 
            PatientsInDataGridView("", "");
        }

    }

    // Filter all patients to be displayed in the listbox based on their fullname
    public Int32 ViewAllPatients(string firstNameFilter, string lastNameFilter)
    {
        //Declare the variables that will be visible in the list
        Int32 patientID;
        string gender;
        string firstName;
        string lastName;
        DateTime dateOfBirth;
        DateTime dateAdmitted;
        DateTime dateDischarged;

        //The foreign keys in the tblPatient are WardNo and TreatmentId .. 
        //Int32  WardNo;
        //Int32 TreatmentID;


        //create an instance of the class clsPatientCollection
        clsPatientCollection MyPatients = new clsPatientCollection();

        // apply the filter by full name
        MyPatients.FindPatientByName(firstNameFilter, lastNameFilter);

        // variable to store the count of records in the object MyPatients
        Int32 recordCount = MyPatients.Count;

        // variable to store the index for the loop
        Int32 index = 0;

        // clear any data off the list first
        lstPatients.Items.Clear();

        // loop while there are still some records to process
        while (index < recordCount)
        {
            patientID = MyPatients.PatientList[index].PatientID; // get the primary key of the patient
            gender = MyPatients.PatientList[index].Gender;//get the patient's gender
            firstName = MyPatients.PatientList[index].FirstName;//get the patient's firstname
            lastName = MyPatients.PatientList[index].LastName;//get the patient's LastName
            dateOfBirth = MyPatients.PatientList[index].DateOfBirth;
            dateAdmitted = MyPatients.PatientList[index].DateAdmitted; // get the date admmited
            dateDischarged = MyPatients.PatientList[index].DateDischarged; // get the date discharged

            // create a new entry for the listbox in the UI
            ListItem newEntry = new ListItem(gender + "  " +
                                             firstName + "  " +
                                             lastName + "  " +
                                             dateOfBirth.ToString("dd/MM/yyyy") + "  " + // ToString() to display just date without time
                                             dateAdmitted + "  " +
                                             dateDischarged + "  ", patientID.ToString());

            // add the patients data collected from newEntry to the list
            lstPatients.Items.Add(newEntry);

            // move the index to the next record for the loop to continue
            index++;
        }

        // Tell the user how many records were found
        lblPatientMessage.Text = "There are  " + recordCount + " Patient(s) found and they are sorted alphabetically by their Last Name.";

        // return the count of the records found
        return recordCount;

    }


    // Method to filter all patients in the listbox based by their WardNo 
    // given the WardNo is 0 , 1, 2.... as we will be using a ddlSelectedIndex value to identify the WardNo
    public Int32 ViewAllPatientsByWard(Int32 wardNoFilter)
    {
        //Declare the variables that will be visible in the list
        Int32 patientID;
        string gender;
        string firstName;
        string lastName;
        DateTime dateOfBirth;
        DateTime dateAdmitted;
        DateTime dateDischarged;

        //The foreign keys in the tblPatient are WardNo and TreatmentId .. 
        //Int32  WardNo;
        //Int32 TreatmentID;


        //create an instance of the class clsPatientCollection
        clsPatientCollection MyPatients = new clsPatientCollection();

        // apply the filter by the wardNo
        MyPatients.FindPatientByWard(wardNoFilter);

        // variable to store the count of records in the object MyPatients
        Int32 recordCount = MyPatients.Count;

        // variable to store the index for the loop
        Int32 index = 0;

        // clear any data off the list first
        lstPatients.Items.Clear();

        // loop while there are still some records to process
        while (index < recordCount)
        {
            patientID = MyPatients.PatientList[index].PatientID; // get the primary key of the patient
            gender = MyPatients.PatientList[index].Gender;//get the patient's gender
            firstName = MyPatients.PatientList[index].FirstName;//get the patient's firstname
            lastName = MyPatients.PatientList[index].LastName;//get the patient's LastName
            dateOfBirth = MyPatients.PatientList[index].DateOfBirth;
            dateAdmitted = MyPatients.PatientList[index].DateAdmitted; // get the date admmited
            dateDischarged = MyPatients.PatientList[index].DateDischarged; // get the date discharged

            // create a new entry for the listbox in the UI
            ListItem newEntry = new ListItem(gender + "  " +
                                             firstName + "  " +
                                             lastName + "  " +
                                             dateOfBirth.ToString("dd/MM/yyyy") + " " +
                                             dateAdmitted + "  " +
                                             dateDischarged + "  ", patientID.ToString());

            // add the patients data collected from newEntry to the list
            lstPatients.Items.Add(newEntry);

            // move the index to the next record for the loop to continue
            index++;
        }

        // Tell the user how many records were found
        lblPatientMessage.Text = "There are  " + recordCount + " Patient(s) found and they are sorted alphabetically by their Last Name.";

        // return the count of the records found
        return recordCount;

    }

    /***** Methods to view patients data in the PatientDataGridView ***/

    // This method will allow us to display a record based on the patient's full name search 
    public Int32 PatientsInDataGridView(string firstNameFilter, string lastNameFilter)
    {

        //create an instance of the class clsPatientCollection
        clsPatientCollection MyPatients = new clsPatientCollection();

        //apply the method FindPatientByName to find the patients in the database
        MyPatients.FindPatientByName(firstNameFilter, lastNameFilter);

        // apply the data table method to the gridview now and don't forget it is not a method as such it is a property
        PatientDataGridView.DataSource = MyPatients.Patients_DataTable;

        //Now Bind the data to the gridview
        PatientDataGridView.DataBind();

        // Make the the Gridview visible now
        PatientDataGridView.Visible = true;

        // variable to store the count of records in the object MyPatients
        Int32 recordCount = MyPatients.Count;

        // see the number of records found
        lblPatientMessage.Text = " There are " + recordCount + " Patient(s) found and they are sorted alphabetically by their Last Name.";

        //return the count of the records
        return recordCount;
    }

    // This method will allow us to display a record based on the patient's ward  
    public Int32 PatientsInDataGridViewByWard(Int32 WardNoFilter)
    {

        //create an instance of the class clsPatientCollection
        clsPatientCollection MyPatients = new clsPatientCollection();

        //apply the method FindPatientByName to find the patients in the database
        MyPatients.FindPatientByWard(WardNoFilter);

        // apply the data table method to the gridview now and don't forget it is not a method as such it is a property
        PatientDataGridView.DataSource = MyPatients.Patients_DataTable;

        //Now Bind the data to the gridview
        PatientDataGridView.DataBind();

        // Make the the Gridview visible now
        PatientDataGridView.Visible = true;

        // variable to store the count of records in the object MyPatients
        Int32 recordCount = MyPatients.Count;

        // see the number of records found
        lblPatientMessage.Text = " There are " + recordCount + " Patient(s) found and they are sorted alphabetically by their Last Name.";

        //return the count of the records
        return recordCount;
    }

    // Adding some rowdatabinding and selected index on the datagrid view 
    protected void PatientDataGridView_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            // hide select button cell in row header
            e.Row.Cells[0].Style.Add(HtmlTextWriterStyle.Display, "none");
        }
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            // hide select button cell for each data row
            e.Row.Cells[0].Style.Add(HtmlTextWriterStyle.Display, "none");

            // hide cell containing primary key
            //e.Row.Cells[1].Style.Add(HtmlTextWriterStyle.Display, "none");

            // attach on click event for entire row
            e.Row.Attributes["onclick"] = ClientScript.GetPostBackClientHyperlink(this.PatientDataGridView, "Select$" + e.Row.RowIndex);
        }
    }

    // Selecting the index in the gridview in order to add and edit a patient's details
    protected void PatientDataGridView_SelectedIndexChanged(object sender, EventArgs e)
    {
        int PatientID;

        try
        {
            PatientID = Convert.ToInt32(PatientDataGridView.SelectedRow.Cells[1].Text);

            // get that PatientID and save it as the session object
            Session["PatientID"] = PatientID;

            // and direct it straight to the Patient add and edit page with that PatientID as the passing attribute
            Response.Redirect("ATreatmentPage.aspx?PatientID=" + PatientID);
        }
        catch
        {
            //System Error;
            lblPatientMessage.Text = "There is a problem with the system, Contact System administrator - Manage Patient - PatientDataGridView_SelectedIndexChanged Error.";
        }
    }

    /**** End of the methods for the gridview ***/



   
    protected void btnExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");// redirect to default page
    }

    protected void btnEditTreatment_Click(object sender, EventArgs e)
    {
        PatientsInDataGridView("", "");// display the grid view first 
        lblPatientMessage.Text = ""; // clear any previous message displayed first
        lblPatientMessage.Text = "Search and select a patient from the list in order to edit patient's treatment details."; // Message to user
        lblPatientMessage.ForeColor = System.Drawing.Color.Red;// set the message color to red to attract the attention of the user
        
    }

    protected void btnAddTreatment_Click(object sender, EventArgs e)
    {
        //Navigate to the patient treatment page to add a patient treatment details on the form 
        // Redirect to a patient treatment form page with TreatmentID = -1
        Response.Redirect("ATreatmentPage.aspx?TreatmentID=" + -1); // this is a must as we are adding a treatemnt so its TreatmentID=-1
    }

    protected void btnArchiveTreatment_Click(object sender, EventArgs e)
    {
        Response.Redirect("ArchiveTreatment.aspx");
    }

    protected void btnSearchByWard_Click(object sender, EventArgs e)
    {
        // display only the result  that match the search from the WardNo in the listbox
        //ViewAllPatientsByWard(ddlWard.SelectedIndex);

        //dipslay the results of the search in the data gridview
        PatientsInDataGridViewByWard(ddlWard.SelectedIndex);

        // clear all the texts
        //txtPatientName.Text = "";
    }

    protected void btnSearchByName_Click(object sender, EventArgs e)
    {
        // display only the result  that match the search filter  in the listbox
        //ViewAllPatients(txtPatientName.Text,txtPatientName.Text);

        // display only the result applied that match the search filter in the textbox
        PatientsInDataGridView(txtPatientName.Text, txtPatientName.Text);

        // clear all the texts in the textfield
        txtPatientName.Text = "";

        // tell the user waht data to enter in the textfield
        txtPatientName.Text = "Enter Patient's first or last name";

    }
}