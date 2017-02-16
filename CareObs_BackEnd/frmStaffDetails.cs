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
    public partial class frmStaffDetails : Form
    {
        public frmStaffDetails()
        {
            InitializeComponent();
        }

        private void frmStaffDetails_Load(object sender, EventArgs e)
        {
            // Disable the buttons and textboxes that need to be disabled
            txtStaffID.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
