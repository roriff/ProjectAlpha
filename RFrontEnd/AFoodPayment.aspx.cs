using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AFoodPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /* disable the button edit observation as staff are not supposed to edit an observation
Once an observation is saved , it is saved , we can't edit it or change it for integrity, security purpose
and also to avoid falsification of entered data when a huge mistake or temperature reading has been made
*/
        btnEditObservation.Enabled = false; // disable the edit observation button
        btnArchiveObservation.Enabled = false; // disable the archive button on this page as well

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