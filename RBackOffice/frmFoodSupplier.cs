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
    public partial class frmFoodSupplier : Form
    {
        public frmFoodSupplier()
        {
            InitializeComponent();
        }

        private void tblFoodSupplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblFoodSupplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alphaDataSet);

        }

        private void frmFoodSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alphaDataSet.tblFoodSupplier' table. You can move, or remove it, as needed.
            this.tblFoodSupplierTableAdapter.Fill(this.alphaDataSet.tblFoodSupplier);

        }
    }
}
