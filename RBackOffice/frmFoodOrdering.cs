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
    public partial class frmFoodOrdering : Form
    {
        public frmFoodOrdering()
        {
            InitializeComponent();
        }

        private void tblFoodOrderingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblFoodOrderingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alphaDataSet);

        }

        private void frmFoodOrdering_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alphaDataSet.tblFoodOrdering' table. You can move, or remove it, as needed.
            this.tblFoodOrderingTableAdapter.Fill(this.alphaDataSet.tblFoodOrdering);

        }
    }
}
