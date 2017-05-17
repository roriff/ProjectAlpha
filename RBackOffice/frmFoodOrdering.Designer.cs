namespace RBackOffice
{
    partial class frmFoodOrdering
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoodOrdering));
            System.Windows.Forms.Label foodOrderIDLabel;
            System.Windows.Forms.Label restaurantIDLabel;
            System.Windows.Forms.Label foodIDLabel;
            System.Windows.Forms.Label paymentIDLabel;
            this.alphaDataSet = new RBackOffice.AlphaDataSet();
            this.tblFoodOrderingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFoodOrderingTableAdapter = new RBackOffice.AlphaDataSetTableAdapters.tblFoodOrderingTableAdapter();
            this.tableAdapterManager = new RBackOffice.AlphaDataSetTableAdapters.TableAdapterManager();
            this.tblFoodOrderingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblFoodOrderingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.foodOrderIDTextBox = new System.Windows.Forms.TextBox();
            this.restaurantIDTextBox = new System.Windows.Forms.TextBox();
            this.foodIDTextBox = new System.Windows.Forms.TextBox();
            this.paymentIDTextBox = new System.Windows.Forms.TextBox();
            foodOrderIDLabel = new System.Windows.Forms.Label();
            restaurantIDLabel = new System.Windows.Forms.Label();
            foodIDLabel = new System.Windows.Forms.Label();
            paymentIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alphaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodOrderingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodOrderingBindingNavigator)).BeginInit();
            this.tblFoodOrderingBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // alphaDataSet
            // 
            this.alphaDataSet.DataSetName = "AlphaDataSet";
            this.alphaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFoodOrderingBindingSource
            // 
            this.tblFoodOrderingBindingSource.DataMember = "tblFoodOrdering";
            this.tblFoodOrderingBindingSource.DataSource = this.alphaDataSet;
            // 
            // tblFoodOrderingTableAdapter
            // 
            this.tblFoodOrderingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCarBookingTableAdapter = null;
            this.tableAdapterManager.tblCarTableAdapter = null;
            this.tableAdapterManager.tblClaimTableAdapter = null;
            this.tableAdapterManager.tblCustomerTableAdapter = null;
            this.tableAdapterManager.tblFoodOrderingTableAdapter = this.tblFoodOrderingTableAdapter;
            this.tableAdapterManager.tblFoodSupplierTableAdapter = null;
            this.tableAdapterManager.tblFoodTableAdapter = null;
            this.tableAdapterManager.tblObservationTableAdapter = null;
            this.tableAdapterManager.tblPatientTableAdapter = null;
            this.tableAdapterManager.tblPaymentFoodTableAdapter = null;
            this.tableAdapterManager.tblPaymentTableAdapter = null;
            this.tableAdapterManager.tblPolicyTableAdapter = null;
            this.tableAdapterManager.tblStaffTableAdapter = null;
            this.tableAdapterManager.tblTreatmentTableAdapter = null;
            this.tableAdapterManager.tblWardTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RBackOffice.AlphaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblFoodOrderingBindingNavigator
            // 
            this.tblFoodOrderingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblFoodOrderingBindingNavigator.BindingSource = this.tblFoodOrderingBindingSource;
            this.tblFoodOrderingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblFoodOrderingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblFoodOrderingBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblFoodOrderingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblFoodOrderingBindingNavigatorSaveItem});
            this.tblFoodOrderingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblFoodOrderingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblFoodOrderingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblFoodOrderingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblFoodOrderingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblFoodOrderingBindingNavigator.Name = "tblFoodOrderingBindingNavigator";
            this.tblFoodOrderingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblFoodOrderingBindingNavigator.Size = new System.Drawing.Size(722, 27);
            this.tblFoodOrderingBindingNavigator.TabIndex = 0;
            this.tblFoodOrderingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tblFoodOrderingBindingNavigatorSaveItem
            // 
            this.tblFoodOrderingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblFoodOrderingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblFoodOrderingBindingNavigatorSaveItem.Image")));
            this.tblFoodOrderingBindingNavigatorSaveItem.Name = "tblFoodOrderingBindingNavigatorSaveItem";
            this.tblFoodOrderingBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblFoodOrderingBindingNavigatorSaveItem.Text = "Save Data";
            this.tblFoodOrderingBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblFoodOrderingBindingNavigatorSaveItem_Click);
            // 
            // foodOrderIDLabel
            // 
            foodOrderIDLabel.AutoSize = true;
            foodOrderIDLabel.Location = new System.Drawing.Point(35, 104);
            foodOrderIDLabel.Name = "foodOrderIDLabel";
            foodOrderIDLabel.Size = new System.Drawing.Size(102, 17);
            foodOrderIDLabel.TabIndex = 1;
            foodOrderIDLabel.Text = "Food Order ID:";
            // 
            // foodOrderIDTextBox
            // 
            this.foodOrderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodOrderingBindingSource, "FoodOrderID", true));
            this.foodOrderIDTextBox.Location = new System.Drawing.Point(143, 101);
            this.foodOrderIDTextBox.Name = "foodOrderIDTextBox";
            this.foodOrderIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.foodOrderIDTextBox.TabIndex = 2;
            // 
            // restaurantIDLabel
            // 
            restaurantIDLabel.AutoSize = true;
            restaurantIDLabel.Location = new System.Drawing.Point(38, 148);
            restaurantIDLabel.Name = "restaurantIDLabel";
            restaurantIDLabel.Size = new System.Drawing.Size(99, 17);
            restaurantIDLabel.TabIndex = 3;
            restaurantIDLabel.Text = "Restaurant ID:";
            // 
            // restaurantIDTextBox
            // 
            this.restaurantIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodOrderingBindingSource, "RestaurantID", true));
            this.restaurantIDTextBox.Location = new System.Drawing.Point(143, 145);
            this.restaurantIDTextBox.Name = "restaurantIDTextBox";
            this.restaurantIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.restaurantIDTextBox.TabIndex = 4;
            // 
            // foodIDLabel
            // 
            foodIDLabel.AutoSize = true;
            foodIDLabel.Location = new System.Drawing.Point(77, 193);
            foodIDLabel.Name = "foodIDLabel";
            foodIDLabel.Size = new System.Drawing.Size(61, 17);
            foodIDLabel.TabIndex = 5;
            foodIDLabel.Text = "Food ID:";
            // 
            // foodIDTextBox
            // 
            this.foodIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodOrderingBindingSource, "FoodID", true));
            this.foodIDTextBox.Location = new System.Drawing.Point(144, 190);
            this.foodIDTextBox.Name = "foodIDTextBox";
            this.foodIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.foodIDTextBox.TabIndex = 6;
            // 
            // paymentIDLabel
            // 
            paymentIDLabel.AutoSize = true;
            paymentIDLabel.Location = new System.Drawing.Point(54, 239);
            paymentIDLabel.Name = "paymentIDLabel";
            paymentIDLabel.Size = new System.Drawing.Size(84, 17);
            paymentIDLabel.TabIndex = 7;
            paymentIDLabel.Text = "Payment ID:";
            // 
            // paymentIDTextBox
            // 
            this.paymentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodOrderingBindingSource, "PaymentID", true));
            this.paymentIDTextBox.Location = new System.Drawing.Point(144, 236);
            this.paymentIDTextBox.Name = "paymentIDTextBox";
            this.paymentIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.paymentIDTextBox.TabIndex = 8;
            // 
            // frmFoodOrdering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 401);
            this.Controls.Add(paymentIDLabel);
            this.Controls.Add(this.paymentIDTextBox);
            this.Controls.Add(foodIDLabel);
            this.Controls.Add(this.foodIDTextBox);
            this.Controls.Add(restaurantIDLabel);
            this.Controls.Add(this.restaurantIDTextBox);
            this.Controls.Add(foodOrderIDLabel);
            this.Controls.Add(this.foodOrderIDTextBox);
            this.Controls.Add(this.tblFoodOrderingBindingNavigator);
            this.Name = "frmFoodOrdering";
            this.Text = "frmFoodOrdering";
            this.Load += new System.EventHandler(this.frmFoodOrdering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alphaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodOrderingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodOrderingBindingNavigator)).EndInit();
            this.tblFoodOrderingBindingNavigator.ResumeLayout(false);
            this.tblFoodOrderingBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AlphaDataSet alphaDataSet;
        private System.Windows.Forms.BindingSource tblFoodOrderingBindingSource;
        private AlphaDataSetTableAdapters.tblFoodOrderingTableAdapter tblFoodOrderingTableAdapter;
        private AlphaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblFoodOrderingBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblFoodOrderingBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox foodOrderIDTextBox;
        private System.Windows.Forms.TextBox restaurantIDTextBox;
        private System.Windows.Forms.TextBox foodIDTextBox;
        private System.Windows.Forms.TextBox paymentIDTextBox;
    }
}