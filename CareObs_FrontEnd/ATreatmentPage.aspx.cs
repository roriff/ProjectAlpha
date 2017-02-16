using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ATreatmentPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Disabled the butttons that are not meant to be used on this page
        btnAddTreatment.Enabled = false;
        btnEditTreatment.Enabled = false;
        btnArchiveTreatment.Enabled = false;

        txtTreatmentID.Enabled = false;
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

    protected void btnArchiveTreatment_Click(object sender, EventArgs e)
    {

    }
}