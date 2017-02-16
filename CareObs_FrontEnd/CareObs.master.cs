using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CareObs : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnManagePatient_Click(object sender, EventArgs e)
    {
        Response.Redirect("APatient.aspx"); // always redirect to the patient page
    }
    protected void btnManageObservation_Click(object sender, EventArgs e)
    {
        Response.Redirect("AnObservation.aspx"); // redirect to the Observation page
    }
    protected void btnManageTreatment_Click(object sender, EventArgs e)
    {
        Response.Redirect("ATreatment.aspx"); // redirect to the treatment page
    }

    protected void btnLogOut_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx"); // redirect to login page
    }
}
