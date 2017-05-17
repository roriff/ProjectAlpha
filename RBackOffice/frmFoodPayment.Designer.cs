namespace RBackOffice
{
    partial class frmFoodPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoodPayment));
            System.Windows.Forms.Label paymentIDLabel;
            System.Windows.Forms.Label cardNumberLabel;
            System.Windows.Forms.Label cardVerificationCodeLabel;
            System.Windows.Forms.Label accountNumberLabel;
            System.Windows.Forms.Label nameOnCardLabel;
            System.Windows.Forms.Label expiryDateLabel;
            System.Windows.Forms.Label sortCodeLabel;
            System.Windows.Forms.Label staffIDLabel;
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.alphaDataSet = new RBackOffice.AlphaDataSet();
            this.tblPaymentFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPaymentFoodTableAdapter = new RBackOffice.AlphaDataSetTableAdapters.tblPaymentFoodTableAdapter();
            this.tableAdapterManager = new RBackOffice.AlphaDataSetTableAdapters.TableAdapterManager();
            this.tblPaymentFoodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblPaymentFoodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.paymentIDTextBox = new System.Windows.Forms.TextBox();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.cardVerificationCodeTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameOnCardTextBox = new System.Windows.Forms.TextBox();
            this.expiryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sortCodeTextBox = new System.Windows.Forms.TextBox();
            this.staffIDTextBox = new System.Windows.Forms.TextBox();
            paymentIDLabel = new System.Windows.Forms.Label();
            cardNumberLabel = new System.Windows.Forms.Label();
            cardVerificationCodeLabel = new System.Windows.Forms.Label();
            accountNumberLabel = new System.Windows.Forms.Label();
            nameOnCardLabel = new System.Windows.Forms.Label();
            expiryDateLabel = new System.Windows.Forms.Label();
            sortCodeLabel = new System.Windows.Forms.Label();
            staffIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alphaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentFoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentFoodBindingNavigator)).BeginInit();
            this.tblPaymentFoodBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(489, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(489, 128);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(489, 183);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // alphaDataSet
            // 
            this.alphaDataSet.DataSetName = "AlphaDataSet";
            this.alphaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPaymentFoodBindingSource
            // 
            this.tblPaymentFoodBindingSource.DataMember = "tblPaymentFood";
            this.tblPaymentFoodBindingSource.DataSource = this.alphaDataSet;
            // 
            // tblPaymentFoodTableAdapter
            // 
            this.tblPaymentFoodTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblFoodTableAdapter = null;
            this.tableAdapterManager.tblObservationTableAdapter = null;
            this.tableAdapterManager.tblPatientTableAdapter = null;
            this.tableAdapterManager.tblPaymentFoodTableAdapter = this.tblPaymentFoodTableAdapter;
            this.tableAdapterManager.tblPaymentTableAdapter = null;
            this.tableAdapterManager.tblPolicyTableAdapter = null;
            this.tableAdapterManager.tblStaffTableAdapter = null;
            this.tableAdapterManager.tblTreatmentTableAdapter = null;
            this.tableAdapterManager.tblWardTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RBackOffice.AlphaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblPaymentFoodBindingNavigator
            // 
            this.tblPaymentFoodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblPaymentFoodBindingNavigator.BindingSource = this.tblPaymentFoodBindingSource;
            this.tblPaymentFoodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblPaymentFoodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblPaymentFoodBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblPaymentFoodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblPaymentFoodBindingNavigatorSaveItem});
            this.tblPaymentFoodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblPaymentFoodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblPaymentFoodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblPaymentFoodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblPaymentFoodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblPaymentFoodBindingNavigator.Name = "tblPaymentFoodBindingNavigator";
            this.tblPaymentFoodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblPaymentFoodBindingNavigator.Size = new System.Drawing.Size(1211, 27);
            this.tblPaymentFoodBindingNavigator.TabIndex = 20;
            this.tblPaymentFoodBindingNavigator.Text = "bindingNavigator1";
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
            // tblPaymentFoodBindingNavigatorSaveItem
            // 
            this.tblPaymentFoodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblPaymentFoodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblPaymentFoodBindingNavigatorSaveItem.Image")));
            this.tblPaymentFoodBindingNavigatorSaveItem.Name = "tblPaymentFoodBindingNavigatorSaveItem";
            this.tblPaymentFoodBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblPaymentFoodBindingNavigatorSaveItem.Text = "Save Data";
            this.tblPaymentFoodBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblPaymentFoodBindingNavigatorSaveItem_Click);
            // 
            // paymentIDLabel
            // 
            paymentIDLabel.AutoSize = true;
            paymentIDLabel.Location = new System.Drawing.Point(92, 99);
            paymentIDLabel.Name = "paymentIDLabel";
            paymentIDLabel.Size = new System.Drawing.Size(84, 17);
            paymentIDLabel.TabIndex = 20;
            paymentIDLabel.Text = "Payment ID:";
            // 
            // paymentIDTextBox
            // 
            this.paymentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPaymentFoodBindingSource, "PaymentID", true));
            this.paymentIDTextBox.Location = new System.Drawing.Point(182, 96);
            this.paymentIDTextBox.Name = "paymentIDTextBox";
            this.paymentIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.paymentIDTextBox.TabIndex = 21;
            // 
            // cardNumberLabel
            // 
            cardNumberLabel.AutoSize = true;
            cardNumberLabel.Location = new System.Drawing.Point(80, 143);
            cardNumberLabel.Name = "cardNumberLabel";
            cardNumberLabel.Size = new System.Drawing.Size(96, 17);
            cardNumberLabel.TabIndex = 21;
            cardNumberLabel.Text = "Card Number:";
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPaymentFoodBindingSource, "CardNumber", true));
            this.cardNumberTextBox.Location = new System.Drawing.Point(182, 140);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.cardNumberTextBox.TabIndex = 22;
            // 
            // cardVerificationCodeLabel
            // 
            cardVerificationCodeLabel.AutoSize = true;
            cardVerificationCodeLabel.Location = new System.Drawing.Point(23, 187);
            cardVerificationCodeLabel.Name = "cardVerificationCodeLabel";
            cardVerificationCodeLabel.Size = new System.Drawing.Size(153, 17);
            cardVerificationCodeLabel.TabIndex = 22;
            cardVerificationCodeLabel.Text = "Card Verification Code:";
            // 
            // cardVerificationCodeTextBox
            // 
            this.cardVerificationCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPaymentFoodBindingSource, "CardVerificationCode", true));
            this.cardVerificationCodeTextBox.Location = new System.Drawing.Point(182, 184);
            this.cardVerificationCodeTextBox.Name = "cardVerificationCodeTextBox";
            this.cardVerificationCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.cardVerificationCodeTextBox.TabIndex = 23;
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new System.Drawing.Point(59, 230);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new System.Drawing.Size(117, 17);
            accountNumberLabel.TabIndex = 23;
            accountNumberLabel.Text = "Account Number:";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPaymentFoodBindingSource, "AccountNumber", true));
            this.accountNumberTextBox.Location = new System.Drawing.Point(182, 227);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.accountNumberTextBox.TabIndex = 24;
            // 
            // nameOnCardLabel
            // 
            nameOnCardLabel.AutoSize = true;
            nameOnCardLabel.Location = new System.Drawing.Point(70, 274);
            nameOnCardLabel.Name = "nameOnCardLabel";
            nameOnCardLabel.Size = new System.Drawing.Size(106, 17);
            nameOnCardLabel.TabIndex = 24;
            nameOnCardLabel.Text = "Name On Card:";
            // 
            // nameOnCardTextBox
            // 
            this.nameOnCardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPaymentFoodBindingSource, "NameOnCard", true));
            this.nameOnCardTextBox.Location = new System.Drawing.Point(182, 271);
            this.nameOnCardTextBox.Name = "nameOnCardTextBox";
            this.nameOnCardTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameOnCardTextBox.TabIndex = 25;
            // 
            // expiryDateLabel
            // 
            expiryDateLabel.AutoSize = true;
            expiryDateLabel.Location = new System.Drawing.Point(92, 314);
            expiryDateLabel.Name = "expiryDateLabel";
            expiryDateLabel.Size = new System.Drawing.Size(84, 17);
            expiryDateLabel.TabIndex = 25;
            expiryDateLabel.Text = "Expiry Date:";
            // 
            // expiryDateDateTimePicker
            // 
            this.expiryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblPaymentFoodBindingSource, "ExpiryDate", true));
            this.expiryDateDateTimePicker.Location = new System.Drawing.Point(182, 314);
            this.expiryDateDateTimePicker.Name = "expiryDateDateTimePicker";
            this.expiryDateDateTimePicker.Size = new System.Drawing.Size(100, 22);
            this.expiryDateDateTimePicker.TabIndex = 26;
            // 
            // sortCodeLabel
            // 
            sortCodeLabel.AutoSize = true;
            sortCodeLabel.Location = new System.Drawing.Point(101, 362);
            sortCodeLabel.Name = "sortCodeLabel";
            sortCodeLabel.Size = new System.Drawing.Size(75, 17);
            sortCodeLabel.TabIndex = 26;
            sortCodeLabel.Text = "Sort Code:";
            // 
            // sortCodeTextBox
            // 
            this.sortCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPaymentFoodBindingSource, "SortCode", true));
            this.sortCodeTextBox.Location = new System.Drawing.Point(182, 359);
            this.sortCodeTextBox.Name = "sortCodeTextBox";
            this.sortCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.sortCodeTextBox.TabIndex = 27;
            // 
            // staffIDLabel
            // 
            staffIDLabel.AutoSize = true;
            staffIDLabel.Location = new System.Drawing.Point(118, 408);
            staffIDLabel.Name = "staffIDLabel";
            staffIDLabel.Size = new System.Drawing.Size(58, 17);
            staffIDLabel.TabIndex = 27;
            staffIDLabel.Text = "Staff ID:";
            // 
            // staffIDTextBox
            // 
            this.staffIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblPaymentFoodBindingSource, "StaffID", true));
            this.staffIDTextBox.Location = new System.Drawing.Point(182, 405);
            this.staffIDTextBox.Name = "staffIDTextBox";
            this.staffIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.staffIDTextBox.TabIndex = 28;
            // 
            // frmFoodPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 722);
            this.Controls.Add(staffIDLabel);
            this.Controls.Add(this.staffIDTextBox);
            this.Controls.Add(sortCodeLabel);
            this.Controls.Add(this.sortCodeTextBox);
            this.Controls.Add(expiryDateLabel);
            this.Controls.Add(this.expiryDateDateTimePicker);
            this.Controls.Add(nameOnCardLabel);
            this.Controls.Add(this.nameOnCardTextBox);
            this.Controls.Add(accountNumberLabel);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(cardVerificationCodeLabel);
            this.Controls.Add(this.cardVerificationCodeTextBox);
            this.Controls.Add(cardNumberLabel);
            this.Controls.Add(this.cardNumberTextBox);
            this.Controls.Add(paymentIDLabel);
            this.Controls.Add(this.paymentIDTextBox);
            this.Controls.Add(this.tblPaymentFoodBindingNavigator);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFoodPayment";
            this.Text = "frmFoodPayment";
            this.Load += new System.EventHandler(this.frmFoodPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alphaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentFoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPaymentFoodBindingNavigator)).EndInit();
            this.tblPaymentFoodBindingNavigator.ResumeLayout(false);
            this.tblPaymentFoodBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private AlphaDataSet alphaDataSet;
        private System.Windows.Forms.BindingSource tblPaymentFoodBindingSource;
        private AlphaDataSetTableAdapters.tblPaymentFoodTableAdapter tblPaymentFoodTableAdapter;
        private AlphaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblPaymentFoodBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblPaymentFoodBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox paymentIDTextBox;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.TextBox cardVerificationCodeTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.TextBox nameOnCardTextBox;
        private System.Windows.Forms.DateTimePicker expiryDateDateTimePicker;
        private System.Windows.Forms.TextBox sortCodeTextBox;
        private System.Windows.Forms.TextBox staffIDTextBox;
    }
}