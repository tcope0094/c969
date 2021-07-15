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
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label city1Label;
            System.Windows.Forms.Label country1Label;
            System.Windows.Forms.Label addressIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.customerGroupBox = new System.Windows.Forms.GroupBox();
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.city1TextBox = new System.Windows.Forms.TextBox();
            this.country1TextBox = new System.Windows.Forms.TextBox();
            this.addressIdTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLastUpdateBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            postalCodeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            city1Label = new System.Windows.Forms.Label();
            country1Label = new System.Windows.Forms.Label();
            addressIdLabel = new System.Windows.Forms.Label();
            this.customerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Enabled = false;
            postalCodeLabel.Location = new System.Drawing.Point(680, 117);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(66, 13);
            postalCodeLabel.TabIndex = 20;
            postalCodeLabel.Text = "postal Code:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Enabled = false;
            phoneLabel.Location = new System.Drawing.Point(680, 91);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(40, 13);
            phoneLabel.TabIndex = 18;
            phoneLabel.Text = "phone:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Enabled = false;
            address2Label.Location = new System.Drawing.Point(680, 66);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(53, 13);
            address2Label.TabIndex = 4;
            address2Label.Text = "address2:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Enabled = false;
            address1Label.Location = new System.Drawing.Point(680, 40);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(53, 13);
            address1Label.TabIndex = 2;
            address1Label.Text = "address1:";
            // 
            // city1Label
            // 
            city1Label.AutoSize = true;
            city1Label.Enabled = false;
            city1Label.Location = new System.Drawing.Point(680, 143);
            city1Label.Name = "city1Label";
            city1Label.Size = new System.Drawing.Size(32, 13);
            city1Label.TabIndex = 21;
            city1Label.Text = "city1:";
            // 
            // country1Label
            // 
            country1Label.AutoSize = true;
            country1Label.Enabled = false;
            country1Label.Location = new System.Drawing.Point(680, 169);
            country1Label.Name = "country1Label";
            country1Label.Size = new System.Drawing.Size(51, 13);
            country1Label.TabIndex = 49;
            country1Label.Text = "country1:";
            // 
            // addressIdLabel
            // 
            addressIdLabel.AutoSize = true;
            addressIdLabel.Location = new System.Drawing.Point(680, 195);
            addressIdLabel.Name = "addressIdLabel";
            addressIdLabel.Size = new System.Drawing.Size(59, 13);
            addressIdLabel.TabIndex = 54;
            addressIdLabel.Text = "address Id:";
            // 
            // customerGroupBox
            // 
            this.customerGroupBox.Controls.Add(this.customerBindingNavigator);
            this.customerGroupBox.Controls.Add(this.customerDataGridView);
            this.customerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.customerGroupBox.Name = "customerGroupBox";
            this.customerGroupBox.Size = new System.Drawing.Size(581, 218);
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
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.saveToolStripButton});
            this.customerBindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.customerBindingNavigator.MoveFirstItem = null;
            this.customerBindingNavigator.MoveLastItem = null;
            this.customerBindingNavigator.MoveNextItem = null;
            this.customerBindingNavigator.MovePreviousItem = null;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = null;
            this.customerBindingNavigator.Size = new System.Drawing.Size(575, 25);
            this.customerBindingNavigator.TabIndex = 3;
            this.customerBindingNavigator.Text = "customerBindingNavigator";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToOrderColumns = true;
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvActive,
            this.dgvCustomerName,
            this.dgvCreateDate,
            this.dgvCreatedBy,
            this.dgvLastUpdate,
            this.dgvLastUpdateBy});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(6, 44);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.Size = new System.Drawing.Size(569, 162);
            this.customerDataGridView.TabIndex = 2;
            this.customerDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellDoubleClick);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(DatabaseModel.city);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(DatabaseModel.country);
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(DatabaseModel.address);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.postalCode", true));
            this.postalCodeTextBox.Enabled = false;
            this.postalCodeTextBox.Location = new System.Drawing.Point(765, 114);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.postalCodeTextBox.TabIndex = 21;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.phone", true));
            this.phoneTextBox.Enabled = false;
            this.phoneTextBox.Location = new System.Drawing.Point(765, 88);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 19;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.address2", true));
            this.address2TextBox.Enabled = false;
            this.address2TextBox.Location = new System.Drawing.Point(765, 63);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(200, 20);
            this.address2TextBox.TabIndex = 5;
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.address1", true));
            this.address1TextBox.Enabled = false;
            this.address1TextBox.Location = new System.Drawing.Point(765, 37);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(200, 20);
            this.address1TextBox.TabIndex = 3;
            // 
            // city1TextBox
            // 
            this.city1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.city.city1", true));
            this.city1TextBox.Enabled = false;
            this.city1TextBox.Location = new System.Drawing.Point(765, 140);
            this.city1TextBox.Name = "city1TextBox";
            this.city1TextBox.Size = new System.Drawing.Size(200, 20);
            this.city1TextBox.TabIndex = 22;
            // 
            // country1TextBox
            // 
            this.country1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.city.country.country1", true));
            this.country1TextBox.Enabled = false;
            this.country1TextBox.Location = new System.Drawing.Point(765, 166);
            this.country1TextBox.Name = "country1TextBox";
            this.country1TextBox.Size = new System.Drawing.Size(200, 20);
            this.country1TextBox.TabIndex = 50;
            // 
            // addressIdTextBox
            // 
            this.addressIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.addressId", true));
            this.addressIdTextBox.Location = new System.Drawing.Point(765, 192);
            this.addressIdTextBox.Name = "addressIdTextBox";
            this.addressIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressIdTextBox.TabIndex = 55;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "Edit Customer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvActive
            // 
            this.dgvActive.DataPropertyName = "active";
            this.dgvActive.HeaderText = "active";
            this.dgvActive.Name = "dgvActive";
            this.dgvActive.Width = 50;
            // 
            // dgvCustomerName
            // 
            this.dgvCustomerName.DataPropertyName = "customerName";
            this.dgvCustomerName.HeaderText = "customerName";
            this.dgvCustomerName.Name = "dgvCustomerName";
            // 
            // dgvCreateDate
            // 
            this.dgvCreateDate.DataPropertyName = "createDate";
            this.dgvCreateDate.HeaderText = "createDate";
            this.dgvCreateDate.Name = "dgvCreateDate";
            this.dgvCreateDate.ReadOnly = true;
            // 
            // dgvCreatedBy
            // 
            this.dgvCreatedBy.DataPropertyName = "createdBy";
            this.dgvCreatedBy.HeaderText = "createdBy";
            this.dgvCreatedBy.Name = "dgvCreatedBy";
            this.dgvCreatedBy.ReadOnly = true;
            // 
            // dgvLastUpdate
            // 
            this.dgvLastUpdate.DataPropertyName = "lastUpdate";
            this.dgvLastUpdate.HeaderText = "lastUpdate";
            this.dgvLastUpdate.Name = "dgvLastUpdate";
            this.dgvLastUpdate.ReadOnly = true;
            // 
            // dgvLastUpdateBy
            // 
            this.dgvLastUpdateBy.DataPropertyName = "lastUpdateBy";
            this.dgvLastUpdateBy.HeaderText = "lastUpdateBy";
            this.dgvLastUpdateBy.Name = "dgvLastUpdateBy";
            this.dgvLastUpdateBy.ReadOnly = true;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 855);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(addressIdLabel);
            this.Controls.Add(this.addressIdTextBox);
            this.Controls.Add(country1Label);
            this.Controls.Add(this.country1TextBox);
            this.Controls.Add(city1Label);
            this.Controls.Add(this.city1TextBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox customerGroupBox;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox city1TextBox;
        private System.Windows.Forms.TextBox country1TextBox;
        private System.Windows.Forms.TextBox addressIdTextBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLastUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLastUpdateBy;
        private System.Windows.Forms.Button button2;
    }
}