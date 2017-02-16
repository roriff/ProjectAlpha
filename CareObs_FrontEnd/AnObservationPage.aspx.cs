using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnObservationPage : System.Web.UI.Page
{
    // variable PatientID to store the value of the PatientID
    Int32 PatientID;

    // Session object that we will use to pass the StaffID using the system at that time
    //Int32 StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Disabled the butttons that are not meant to be used on this page
        btnAddObservation.Enabled = false;
        btnEditObservation.Enabled = false;
        btnArchiveObservation.Enabled = false;

        txtObservationID.Enabled = false;


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
                //(PatientID);
            }

            //else // in case the patient doesn't exist then it is adding an object meaning the ItemNo is -1 
            //{
            // Use the session  object that is being passed between the pages in the server and store it as sellerID
            //StaffID = (string)Session["UserName"];
            //lblUserName.Text = StaffID;
            //}
        }

    }

    protected void btnArchiveObservation_Click(object sender, EventArgs e)
    {

    }
    protected void btnExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {

    }

    protected void btnDoNotSave_Click(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnEditObservation_Click(object sender, EventArgs e)
    {

    }

    protected void btnAddObservation_Click(object sender, EventArgs e)
    {

    }
}