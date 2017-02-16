using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareObs_BackEnd
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            //clear any previous message
            //lblMessage.Text = "";
        }
        public void FormLoad()
        {
            //FillllstStaff();
            //DisableButtons();
        }

        private void DisableButtons()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnArchive.Enabled = false;
        }

        private void FilllstStaff()
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // create a new object of type
            frmStaffDetails StaffDetailsManager = new frmStaffDetails();

            //set the mdi parent of the created form to the main form 
            StaffDetailsManager.MdiParent = this.Parent.Parent as mdiCareObservation;

            //make the form visible
            StaffDetailsManager.Visible = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // create a new object of type
            frmStaffDetails StaffDetailsManager = new frmStaffDetails();

            //set the mdi parent of the created form to the main form 
            StaffDetailsManager.MdiParent = this.Parent.Parent as mdiCareObservation;

            //make the form visible
            StaffDetailsManager.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // message to user
            lblMessage.Text = "Select a member of staff from the list and delete him/her.";

            string Message = "Are you sure you want to Archive this record?";
            string Title = "Confirm Archive Operation";
            DialogResult Result;
            Result = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo);
            if (Result == System.Windows.Forms.DialogResult.Yes)
            {
                FormLoad(); // call the form load method to disable some buttons while running this operation
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();// Close this form
        }

        
    }
}
