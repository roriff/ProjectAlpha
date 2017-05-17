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
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }

        private void tblFoodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblFoodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alphaDataSet);

        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alphaDataSet.tblFood' table. You can move, or remove it, as needed.
            this.tblFoodTableAdapter.Fill(this.alphaDataSet.tblFood);

        }
    }
}
