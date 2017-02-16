using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ArchivePatient : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {   
        // disabled the buttons so there are no used in this page
        btnAddPatient.Enabled = false;
        btnEditPatient.Enabled = false;
        btnArchivePatient.Enabled = false;

        // use the session object stored in button archive from the page prior to this one
        txtPatientToArchive.Text = (string)Session["PatientName"]; // convert it into string as txtPatientToArchive is string
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        lblArchiveMessage.Text = " Patient Archived is Patient " + txtPatientToArchive.Text + ".";
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("APatient.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("APatient.aspx");
    }

    protected void btnAddPatient_Click(object sender, EventArgs e)
    {
        
    }

    protected void btnEditPatient_Click(object sender, EventArgs e)
    {

    }
    protected void btnArchivePatient_Click(object sender, EventArgs e)
    {

    }
    protected void btnExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    
}