namespace RBackOffice
{
    partial class frmFoodSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoodSupplier));
            System.Windows.Forms.Label foodSupplierIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label postCodeLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countyLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label phoneNoLabel;
            System.Windows.Forms.Label mobileNoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label foodIDLabel;
            System.Windows.Forms.Label foodOrderingLabel;
            this.alphaDataSet = new RBackOffice.AlphaDataSet();
            this.tblFoodSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFoodSupplierTableAdapter = new RBackOffice.AlphaDataSetTableAdapters.tblFoodSupplierTableAdapter();
            this.tableAdapterManager = new RBackOffice.AlphaDataSetTableAdapters.TableAdapterManager();
            this.tblFoodSupplierBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblFoodSupplierBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.foodSupplierIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.postCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countyTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.mobileNoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.foodIDTextBox = new System.Windows.Forms.TextBox();
            this.foodOrderingTextBox = new System.Windows.Forms.TextBox();
            foodSupplierIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            postCodeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countyLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            phoneNoLabel = new System.Windows.Forms.Label();
            mobileNoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            foodIDLabel = new System.Windows.Forms.Label();
            foodOrderingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alphaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodSupplierBindingNavigator)).BeginInit();
            this.tblFoodSupplierBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // alphaDataSet
            // 
            this.alphaDataSet.DataSetName = "AlphaDataSet";
            this.alphaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFoodSupplierBindingSource
            // 
            this.tblFoodSupplierBindingSource.DataMember = "tblFoodSupplier";
            this.tblFoodSupplierBindingSource.DataSource = this.alphaDataSet;
            // 
            // tblFoodSupplierTableAdapter
            // 
            this.tblFoodSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCarBookingTableAdapter = null;
            this.tableAdapterManager.tblCarTableAdapter = null;
            this.tableAdapterManager.tblClaimTableAdapter = null;
            this.tableAdapterManager.tblCustomerTableAdapter = null;
            this.tableAdapterManager.tblFoodOrderingTableAdapter = null;
            this.tableAdapterManager.tblFoodSupplierTableAdapter = this.tblFoodSupplierTableAdapter;
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
            // tblFoodSupplierBindingNavigator
            // 
            this.tblFoodSupplierBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblFoodSupplierBindingNavigator.BindingSource = this.tblFoodSupplierBindingSource;
            this.tblFoodSupplierBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblFoodSupplierBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblFoodSupplierBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblFoodSupplierBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblFoodSupplierBindingNavigatorSaveItem});
            this.tblFoodSupplierBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblFoodSupplierBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblFoodSupplierBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblFoodSupplierBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblFoodSupplierBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblFoodSupplierBindingNavigator.Name = "tblFoodSupplierBindingNavigator";
            this.tblFoodSupplierBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblFoodSupplierBindingNavigator.Size = new System.Drawing.Size(871, 27);
            this.tblFoodSupplierBindingNavigator.TabIndex = 0;
            this.tblFoodSupplierBindingNavigator.Text = "bindingNavigator1";
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
            // tblFoodSupplierBindingNavigatorSaveItem
            // 
            this.tblFoodSupplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblFoodSupplierBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblFoodSupplierBindingNavigatorSaveItem.Image")));
            this.tblFoodSupplierBindingNavigatorSaveItem.Name = "tblFoodSupplierBindingNavigatorSaveItem";
            this.tblFoodSupplierBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblFoodSupplierBindingNavigatorSaveItem.Text = "Save Data";
            this.tblFoodSupplierBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblFoodSupplierBindingNavigatorSaveItem_Click);
            // 
            // foodSupplierIDLabel
            // 
            foodSupplierIDLabel.AutoSize = true;
            foodSupplierIDLabel.Location = new System.Drawing.Point(78, 76);
            foodSupplierIDLabel.Name = "foodSupplierIDLabel";
            foodSupplierIDLabel.Size = new System.Drawing.Size(117, 17);
            foodSupplierIDLabel.TabIndex = 1;
            foodSupplierIDLabel.Text = "Food Supplier ID:";
            // 
            // foodSupplierIDTextBox
            // 
            this.foodSupplierIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodSupplierBindingSource, "FoodSupplierID", true));
            this.foodSupplierIDTextBox.Location = new System.Drawing.Point(201, 73);
            this.foodSupplierIDTextBox.Name = "foodSupplierIDTextBox";
            this.foodSupplierIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.foodSupplierIDTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(146, 116);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodSupplierBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(201, 113);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(131, 159);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 17);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodSupplierBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(201, 156);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 22);
            this.addressTextBox.TabIndex = 6;
            // 
            // postCodeLabel
            // 
            postCodeLabel.AutoSize = true;
            postCodeLabel.Location = new System.Drawing.Point(118, 202);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(77, 17);
            postCodeLabel.TabIndex = 7;
            postCodeLabel.Text = "Post Code:";
            // 
            // postCodeTextBox
            // 
            this.postCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodSupplierBindingSource, "PostCode", true));
            this.postCodeTextBox.Location = new System.Drawing.Point(201, 199);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.postCodeTextBox.TabIndex = 8;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(160, 246);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 9;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodSupplierBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(201, 243);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 10;
            // 
            // countyLabel
            // 
            countyLabel.AutoSize = true;
            countyLabel.Location = new System.Drawing.Point(139, 289);
            countyLabel.Name = "countyLabel";
            countyLabel.Size = new System.Drawing.Size(56, 17);
            countyLabel.TabIndex = 11;
            countyLabel.Text = "County:";
            // 
            // countyTextBox
            // 
            this.countyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodSupplierBindingSource, "County", true));
            this.countyTextBox.Location = new System.Drawing.Point(201, 286);
            this.countyTextBox.Name = "countyTextBox";
            this.countyTextBox.Size = new System.Drawing.Size(100, 22);
            this.countyTextBox.TabIndex = 12;
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new System.Drawing.Point(138, 334);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(57, 17);
            regionLabel.TabIndex = 13;
            regionLabel.Text = "Region:";
            // 
            // regionTextBox
            // 
            this.regionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodSupplierBindingSource, "Region", true));
            this.regionTextBox.Location = new System.Drawing.Point(201, 331);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(100, 22);
            this.regionTextBox.TabIndex = 14;
            // 
            // phoneNoLabel
            // 
            phoneNoLabel.AutoSize = true;
            phoneNoLabel.Location = new System.Drawing.Point(120, 377);
            phoneNoLabel.Name = "phoneNoLabel";
            phoneNoLabel.Size = new System.Drawing.Size(75, 17);
            phoneNoLabel.TabIndex = 15;
            phoneNoLabel.Text = "Phone No:";
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodSupplierBindingSource, "PhoneNo", true));
            this.phoneNoTextBox.Location = new System.Drawing.Point(201, 374);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneNoTextBox.TabIndex = 16;
            // 
            // mobileNoLabel
            // 
            mobileNoLabel.AutoSize = true;
            mobileNoLabel.Location = new System.Drawing.Point(347, 77);
            mobileNoLabel.Name = "mobileNoLabel";
            mobileNoLabel.Size = new System.Drawing.Size(75, 17);
            mobileNoLabel.TabIndex = 17;
            mobileNoLabel.Text = "Mobile No:";
            // 
            // mobileNoTextBox
            // 
            this.mobileNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodSupplierBindingSource, "MobileNo", true));
            this.mobileNoTextBox.Location = new System.Drawing.Point(428, 74);
            this.mobileNoTextBox.Name = "mobileNoTextBox";
            this.mobileNoTextBox.Size = new System.Drawing.Size(100, 22);
            this.mobileNoTextBox.TabIndex = 18;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(376, 119);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 19;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodSupplierBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(428, 116);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 20;
            // 
            // foodIDLabel
            // 
            foodIDLabel.AutoSize = true;
            foodIDLabel.Location = new System.Drawing.Point(361, 159);
            foodIDLabel.Name = "foodIDLabel";
            foodIDLabel.Size = new System.Drawing.Size(61, 17);
            foodIDLabel.TabIndex = 21;
            foodIDLabel.Text = "Food ID:";
            // 
            // foodIDTextBox
            // 
            this.foodIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodSupplierBindingSource, "FoodID", true));
            this.foodIDTextBox.Location = new System.Drawing.Point(428, 156);
            this.foodIDTextBox.Name = "foodIDTextBox";
            this.foodIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.foodIDTextBox.TabIndex = 22;
            // 
            // foodOrderingLabel
            // 
            foodOrderingLabel.AutoSize = true;
            foodOrderingLabel.Location = new System.Drawing.Point(318, 202);
            foodOrderingLabel.Name = "foodOrderingLabel";
            foodOrderingLabel.Size = new System.Drawing.Size(104, 17);
            foodOrderingLabel.TabIndex = 23;
            foodOrderingLabel.Text = "Food Ordering:";
            // 
            // foodOrderingTextBox
            // 
            this.foodOrderingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblFoodSupplierBindingSource, "FoodOrdering", true));
            this.foodOrderingTextBox.Location = new System.Drawing.Point(428, 199);
            this.foodOrderingTextBox.Name = "foodOrderingTextBox";
            this.foodOrderingTextBox.Size = new System.Drawing.Size(100, 22);
            this.foodOrderingTextBox.TabIndex = 24;
            // 
            // frmFoodSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 483);
            this.Controls.Add(foodOrderingLabel);
            this.Controls.Add(this.foodOrderingTextBox);
            this.Controls.Add(foodIDLabel);
            this.Controls.Add(this.foodIDTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(mobileNoLabel);
            this.Controls.Add(this.mobileNoTextBox);
            this.Controls.Add(phoneNoLabel);
            this.Controls.Add(this.phoneNoTextBox);
            this.Controls.Add(regionLabel);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(countyLabel);
            this.Controls.Add(this.countyTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(postCodeLabel);
            this.Controls.Add(this.postCodeTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(foodSupplierIDLabel);
            this.Controls.Add(this.foodSupplierIDTextBox);
            this.Controls.Add(this.tblFoodSupplierBindingNavigator);
            this.Name = "frmFoodSupplier";
            this.Text = "frmFoodSupplier";
            this.Load += new System.EventHandler(this.frmFoodSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alphaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodSupplierBindingNavigator)).EndInit();
            this.tblFoodSupplierBindingNavigator.ResumeLayout(false);
            this.tblFoodSupplierBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AlphaDataSet alphaDataSet;
        private System.Windows.Forms.BindingSource tblFoodSupplierBindingSource;
        private AlphaDataSetTableAdapters.tblFoodSupplierTableAdapter tblFoodSupplierTableAdapter;
        private AlphaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblFoodSupplierBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblFoodSupplierBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox foodSupplierIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox postCodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countyTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.TextBox mobileNoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox foodIDTextBox;
        private System.Windows.Forms.TextBox foodOrderingTextBox;
    }
}