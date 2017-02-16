using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ArchiveTreatment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // disabled the buttons so there are no used in this page
        btnAddTreatment.Enabled = false;
        btnEditTreatment.Enabled = false;
        btnArchiveTreatment.Enabled = false;
    }

    protected void btnAddTreatment_Click(object sender, EventArgs e)
    {

    }

    protected void btnEditTreatment_Click(object sender, EventArgs e)
    {

    }

    protected void btnArchiveTreatment_Click(object sender, EventArgs e)
    {

    }

    protected void btnExit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        lblArchiveMessage.Text = "Treatment Archived is Treatment " + txtTreatmentToArchive.Text + ".";
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ATreatment.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ATreatment.aspx");
    }
}