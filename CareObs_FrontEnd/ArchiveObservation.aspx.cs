using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ArchiveObservation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // disabled the buttons so there are no used in this page
        btnAddObservation.Enabled = false;
        btnEditObservation.Enabled = false;
        btnArchiveObservation.Enabled = false;
    }

    protected void btnAddObservation_Click(object sender, EventArgs e)
    {

    }

    protected void btnEditObservation_Click(object sender, EventArgs e)
    {

    }

    protected void btnArchiveObservation_Click(object sender, EventArgs e)
    {

    }

    protected void btnExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        lblArchiveMessage.Text = "Observation Archived is Observation " + txtObservationToArchive.Text + ".";
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("AnObservation.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AnObservation.aspx");
    }
}