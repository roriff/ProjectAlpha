using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBackOffice
{
    public partial class frmFoodPayment : Form
    {
        public frmFoodPayment()
        {
            InitializeComponent();
        }

        private void frmFoodPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alphaDataSet.tblPaymentFood' table. You can move, or remove it, as needed.
            this.tblPaymentFoodTableAdapter.Fill(this.alphaDataSet.tblPaymentFood);

        }

        private void tblPaymentFoodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPaymentFoodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alphaDataSet);

        }
    }
}
