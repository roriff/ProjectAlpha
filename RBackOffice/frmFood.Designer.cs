namespace RBackOffice
{
    partial class frmFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFood));
            System.Windows.Forms.Label foodIDLabel;
            System.Windows.Forms.Label foodNameLabel;
            System.Windows.Forms.Label foodPriceLabel;
            System.Windows.Forms.Label quantityLabel;
            this.alphaDataSet = new RBackOffice.AlphaDataSet();
            this.tblFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFoodTableAdapter = new RBackOffice.AlphaDataSetTableAdapters.tblFoodTableAdapter();
            this.tableAdapterManager = new RBackOffice.AlphaDataSetTableAdapters.TableAdapterManager();
            this.tblFoodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblFoodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.foodIDTextBox = new System.Windows.Forms.TextBox();
            this.foodNameTextBox = new System.Windows.Forms.TextBox();
            this.foodPriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            foodIDLabel = new System.Windows.Forms.Label();
            foodNameLabel = new System.Windows.Forms.Label();
            foodPriceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alphaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodBindingNavigator)).BeginInit();
            this.tblFoodBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // alphaDataSet
            // 
            this.alphaDataSet.DataSetName = "AlphaDataSet";
            this.alphaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFoodBindingSource
            // 
            this.tblFoodBindingSource.DataMember = "tblFood";
            this.tblFoodBindingSource.DataSource = this.alphaDataSet;
            // 
            // tblFoodTableAdapter
            // 
            this.tblFoodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCarBookingTableAdapter = null;
            this.tableAdapterManager.tblCarTableAdapter = null;
            this.tableAdapterManager.tblClaimTableAdapter = null;
            this.tableAdapterManager.tblCustomerTableAdapter = null;
            this.tableAdapterManager.tblFoodOrderingTableAdapter = null;
            this.tableAdapterManager.tblFoodSupplierTableAdapter = null;
            this.tableAdapterManager.tblFoodTableAdapter = this.tblFoodTableAdapter;
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
            // tblFoodBindingNavigator
            // 
            this.tblFoodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblFoodBindingNavigator.BindingSource = this.tblFoodBindingSource;
            this.tblFoodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblFoodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblFoodBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblFoodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblFoodBindingNavigatorSaveItem});
            this.tblFoodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblFoodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblFoodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblFoodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblFoodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblFoodBindingNavigator.Name = "tblFoodBindingNavigator";
            this.tblFoodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblFoodBindingNavigator.Size = new System.Drawing.Size(878, 27);
            this.tblFoodBindingNavigator.TabIndex = 0;
            this.tblFoodBindingNavigator.Text = "bindingNavigator1";
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
            // tblFoodBindingNavigatorSaveItem
            // 
            this.tblFoodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblFoodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblFoodBindingNavigatorSaveItem.Image")));
            this.tblFoodBindingNavigatorSaveItem.Name = "tblFoodBindingNavigatorSaveItem";
            this.tblFoodBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblFoodBindingNavigatorSaveItem.Text = "Save Data";
            this.tblFoodBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblFoodBindingNavigatorSaveItem_Click);
            // 
            // foodIDLabel
            // 
            foodIDLabel.AutoSize = true;
            foodIDLabel.Location = new System.Drawing.Point(69, 153);
            foodIDLabel.Name = "foodIDLabel";
            foodIDLabel.Size = new System.Drawing.Size(61, 17);
            foodIDLabel.TabIndex = 1;
            foodIDLabel.Text = "Food ID:";
            // 
            // foodIDTextBox
            // 
            this.foodIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodBindingSource, "FoodID", true));
            this.foodIDTextBox.Location = new System.Drawing.Point(136, 150);
            this.foodIDTextBox.Name = "foodIDTextBox";
            this.foodIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.foodIDTextBox.TabIndex = 2;
            // 
            // foodNameLabel
            // 
            foodNameLabel.AutoSize = true;
            foodNameLabel.Location = new System.Drawing.Point(45, 195);
            foodNameLabel.Name = "foodNameLabel";
            foodNameLabel.Size = new System.Drawing.Size(85, 17);
            foodNameLabel.TabIndex = 3;
            foodNameLabel.Text = "Food Name:";
            // 
            // foodNameTextBox
            // 
            this.foodNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodBindingSource, "FoodName", true));
            this.foodNameTextBox.Location = new System.Drawing.Point(136, 192);
            this.foodNameTextBox.Name = "foodNameTextBox";
            this.foodNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.foodNameTextBox.TabIndex = 4;
            // 
            // foodPriceLabel
            // 
            foodPriceLabel.AutoSize = true;
            foodPriceLabel.Location = new System.Drawing.Point(50, 237);
            foodPriceLabel.Name = "foodPriceLabel";
            foodPriceLabel.Size = new System.Drawing.Size(80, 17);
            foodPriceLabel.TabIndex = 5;
            foodPriceLabel.Text = "Food Price:";
            // 
            // foodPriceTextBox
            // 
            this.foodPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodBindingSource, "FoodPrice", true));
            this.foodPriceTextBox.Location = new System.Drawing.Point(136, 234);
            this.foodPriceTextBox.Name = "foodPriceTextBox";
            this.foodPriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.foodPriceTextBox.TabIndex = 6;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(65, 281);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(65, 17);
            quantityLabel.TabIndex = 7;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(136, 278);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.quantityTextBox.TabIndex = 8;
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 658);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(foodPriceLabel);
            this.Controls.Add(this.foodPriceTextBox);
            this.Controls.Add(foodNameLabel);
            this.Controls.Add(this.foodNameTextBox);
            this.Controls.Add(foodIDLabel);
            this.Controls.Add(this.foodIDTextBox);
            this.Controls.Add(this.tblFoodBindingNavigator);
            this.Name = "frmFood";
            this.Text = "frmFood";
            this.Load += new System.EventHandler(this.frmFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alphaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodBindingNavigator)).EndInit();
            this.tblFoodBindingNavigator.ResumeLayout(false);
            this.tblFoodBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AlphaDataSet alphaDataSet;
        private System.Windows.Forms.BindingSource tblFoodBindingSource;
        private AlphaDataSetTableAdapters.tblFoodTableAdapter tblFoodTableAdapter;
        private AlphaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblFoodBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblFoodBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox foodIDTextBox;
        private System.Windows.Forms.TextBox foodNameTextBox;
        private System.Windows.Forms.TextBox foodPriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
    }
}