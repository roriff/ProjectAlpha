using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogIn_Click(object sender, EventArgs e)
    {
        // enter the CareObs Default page which is the entry page of the system
        Response.Redirect("Index.aspx"); 
    }
}