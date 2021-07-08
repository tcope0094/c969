namespace C969_SchedulingSoftware
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label addressIdLabel1;
            System.Windows.Forms.Label cityIdLabel;
            System.Windows.Forms.Label createDateLabel1;
            System.Windows.Forms.Label createdByLabel1;
            System.Windows.Forms.Label lastUpdateLabel1;
            System.Windows.Forms.Label lastUpdateByLabel1;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label postalCodeLabel;
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.addressIdTextBox1 = new System.Windows.Forms.TextBox();
            this.cityIdTextBox = new System.Windows.Forms.TextBox();
            this.createDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.createdByTextBox1 = new System.Windows.Forms.TextBox();
            this.lastUpdateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lastUpdateByTextBox1 = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            addressIdLabel1 = new System.Windows.Forms.Label();
            cityIdLabel = new System.Windows.Forms.Label();
            createDateLabel1 = new System.Windows.Forms.Label();
            createdByLabel1 = new System.Windows.Forms.Label();
            lastUpdateLabel1 = new System.Windows.Forms.Label();
            lastUpdateByLabel1 = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            this.customerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.customerBindingNavigator);
            this.customerGroupBox.Controls.Add(this.customerDataGridView);
            this.customerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(763, 187);
            this.customerGroupBox.TabIndex = 2;
            this.customerGroupBox.TabStop = false;
            this.customerGroupBox.Text = "customerGroupBox";
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = null;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.customerBindingNavigatorSaveItem});
            this.customerBindingNavigator.Location = new System.Drawing.Point(6, 16);
            this.customerBindingNavigator.MoveFirstItem = null;
            this.customerBindingNavigator.MoveLastItem = null;
            this.customerBindingNavigator.MoveNextItem = null;
            this.customerBindingNavigator.MovePreviousItem = null;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = null;
            this.customerBindingNavigator.Size = new System.Drawing.Size(81, 25);
            this.customerBindingNavigator.TabIndex = 3;
            this.customerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(DatabaseModel.customer);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Enabled = false;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customerBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(6, 44);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.RowHeadersWidth = 50;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(744, 130);
            this.customerDataGridView.TabIndex = 2;
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(6, 16);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(53, 13);
            address1Label.TabIndex = 17;
            address1Label.Text = "address1:";
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(91, 13);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(200, 20);
            this.address1TextBox.TabIndex = 18;
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(6, 42);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(53, 13);
            address2Label.TabIndex = 19;
            address2Label.Text = "address2:";
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(91, 39);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(200, 20);
            this.address2TextBox.TabIndex = 20;
            // 
            // addressIdLabel1
            // 
            addressIdLabel1.AutoSize = true;
            addressIdLabel1.Location = new System.Drawing.Point(6, 68);
            addressIdLabel1.Name = "addressIdLabel1";
            addressIdLabel1.Size = new System.Drawing.Size(59, 13);
            addressIdLabel1.TabIndex = 21;
            addressIdLabel1.Text = "address Id:";
            // 
            // addressIdTextBox1
            // 
            this.addressIdTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.addressId", true));
            this.addressIdTextBox1.Location = new System.Drawing.Point(91, 65);
            this.addressIdTextBox1.Name = "addressIdTextBox1";
            this.addressIdTextBox1.Size = new System.Drawing.Size(200, 20);
            this.addressIdTextBox1.TabIndex = 22;
            // 
            // cityIdLabel
            // 
            cityIdLabel.AutoSize = true;
            cityIdLabel.Location = new System.Drawing.Point(6, 94);
            cityIdLabel.Name = "cityIdLabel";
            cityIdLabel.Size = new System.Drawing.Size(38, 13);
            cityIdLabel.TabIndex = 23;
            cityIdLabel.Text = "city Id:";
            // 
            // cityIdTextBox
            // 
            this.cityIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.cityId", true));
            this.cityIdTextBox.Location = new System.Drawing.Point(91, 91);
            this.cityIdTextBox.Name = "cityIdTextBox";
            this.cityIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityIdTextBox.TabIndex = 24;
            // 
            // createDateLabel1
            // 
            createDateLabel1.AutoSize = true;
            createDateLabel1.Location = new System.Drawing.Point(6, 121);
            createDateLabel1.Name = "createDateLabel1";
            createDateLabel1.Size = new System.Drawing.Size(66, 13);
            createDateLabel1.TabIndex = 25;
            createDateLabel1.Text = "create Date:";
            // 
            // createDateDateTimePicker1
            // 
            this.createDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBindingSource, "address.createDate", true));
            this.createDateDateTimePicker1.Location = new System.Drawing.Point(91, 117);
            this.createDateDateTimePicker1.Name = "createDateDateTimePicker1";
            this.createDateDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.createDateDateTimePicker1.TabIndex = 26;
            // 
            // createdByLabel1
            // 
            createdByLabel1.AutoSize = true;
            createdByLabel1.Location = new System.Drawing.Point(6, 146);
            createdByLabel1.Name = "createdByLabel1";
            createdByLabel1.Size = new System.Drawing.Size(61, 13);
            createdByLabel1.TabIndex = 27;
            createdByLabel1.Text = "created By:";
            // 
            // createdByTextBox1
            // 
            this.createdByTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.createdBy", true));
            this.createdByTextBox1.Location = new System.Drawing.Point(91, 143);
            this.createdByTextBox1.Name = "createdByTextBox1";
            this.createdByTextBox1.Size = new System.Drawing.Size(200, 20);
            this.createdByTextBox1.TabIndex = 28;
            // 
            // lastUpdateLabel1
            // 
            lastUpdateLabel1.AutoSize = true;
            lastUpdateLabel1.Location = new System.Drawing.Point(6, 173);
            lastUpdateLabel1.Name = "lastUpdateLabel1";
            lastUpdateLabel1.Size = new System.Drawing.Size(64, 13);
            lastUpdateLabel1.TabIndex = 29;
            lastUpdateLabel1.Text = "last Update:";
            // 
            // lastUpdateDateTimePicker1
            // 
            this.lastUpdateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBindingSource, "address.lastUpdate", true));
            this.lastUpdateDateTimePicker1.Location = new System.Drawing.Point(91, 169);
            this.lastUpdateDateTimePicker1.Name = "lastUpdateDateTimePicker1";
            this.lastUpdateDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.lastUpdateDateTimePicker1.TabIndex = 30;
            // 
            // lastUpdateByLabel1
            // 
            lastUpdateByLabel1.AutoSize = true;
            lastUpdateByLabel1.Location = new System.Drawing.Point(6, 198);
            lastUpdateByLabel1.Name = "lastUpdateByLabel1";
            lastUpdateByLabel1.Size = new System.Drawing.Size(79, 13);
            lastUpdateByLabel1.TabIndex = 31;
            lastUpdateByLabel1.Text = "last Update By:";
            // 
            // lastUpdateByTextBox1
            // 
            this.lastUpdateByTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.lastUpdateBy", true));
            this.lastUpdateByTextBox1.Location = new System.Drawing.Point(91, 195);
            this.lastUpdateByTextBox1.Name = "lastUpdateByTextBox1";
            this.lastUpdateByTextBox1.Size = new System.Drawing.Size(200, 20);
            this.lastUpdateByTextBox1.TabIndex = 32;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(6, 224);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(40, 13);
            phoneLabel.TabIndex = 33;
            phoneLabel.Text = "phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(91, 221);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 34;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(6, 250);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(66, 13);
            postalCodeLabel.TabIndex = 35;
            postalCodeLabel.Text = "postal Code:";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.postalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(91, 247);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.postalCodeTextBox.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "active";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Active";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "createDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Create Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "createdBy";
            this.dataGridViewTextBoxColumn5.HeaderText = "Created By";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "lastUpdate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Last Update";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "lastUpdateBy";
            this.dataGridViewTextBoxColumn7.HeaderText = "Last Update By";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "appointments";
            this.dataGridViewTextBoxColumn9.HeaderText = "Appointments";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(address1Label);
            this.groupBox1.Controls.Add(this.postalCodeTextBox);
            this.groupBox1.Controls.Add(this.address1TextBox);
            this.groupBox1.Controls.Add(postalCodeLabel);
            this.groupBox1.Controls.Add(address2Label);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(this.address2TextBox);
            this.groupBox1.Controls.Add(phoneLabel);
            this.groupBox1.Controls.Add(addressIdLabel1);
            this.groupBox1.Controls.Add(this.lastUpdateByTextBox1);
            this.groupBox1.Controls.Add(this.addressIdTextBox1);
            this.groupBox1.Controls.Add(lastUpdateByLabel1);
            this.groupBox1.Controls.Add(cityIdLabel);
            this.groupBox1.Controls.Add(this.lastUpdateDateTimePicker1);
            this.groupBox1.Controls.Add(this.cityIdTextBox);
            this.groupBox1.Controls.Add(lastUpdateLabel1);
            this.groupBox1.Controls.Add(createDateLabel1);
            this.groupBox1.Controls.Add(this.createdByTextBox1);
            this.groupBox1.Controls.Add(this.createDateDateTimePicker1);
            this.groupBox1.Controls.Add(createdByLabel1);
            this.groupBox1.Location = new System.Drawing.Point(18, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 282);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(470, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 282);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerGroupBox);
            this.Name = "CustomersForm";
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.customerGroupBox.ResumeLayout(false);
            this.customerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox addressIdTextBox1;
        private System.Windows.Forms.TextBox cityIdTextBox;
        private System.Windows.Forms.DateTimePicker createDateDateTimePicker1;
        private System.Windows.Forms.TextBox createdByTextBox1;
        private System.Windows.Forms.DateTimePicker lastUpdateDateTimePicker1;
        private System.Windows.Forms.TextBox lastUpdateByTextBox1;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}