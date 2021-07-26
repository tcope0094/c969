namespace C969_SchedulingSoftware.Forms
{
    partial class ManageCustomers
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
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label city1Label;
            System.Windows.Forms.Label country1Label;
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.editCustomerButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.city1TextBox = new System.Windows.Forms.TextBox();
            this.country1TextBox = new System.Windows.Forms.TextBox();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            city1Label = new System.Windows.Forms.Label();
            country1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(302, 62);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(57, 13);
            address1Label.TabIndex = 15;
            address1Label.Text = "Address 1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(302, 88);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(57, 13);
            address2Label.TabIndex = 17;
            address2Label.Text = "Address 2:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(302, 114);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 19;
            phoneLabel.Text = "Phone:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(302, 140);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel.TabIndex = 21;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // city1Label
            // 
            city1Label.AutoSize = true;
            city1Label.Location = new System.Drawing.Point(302, 166);
            city1Label.Name = "city1Label";
            city1Label.Size = new System.Drawing.Size(27, 13);
            city1Label.TabIndex = 22;
            city1Label.Text = "City:";
            // 
            // country1Label
            // 
            country1Label.AutoSize = true;
            country1Label.Location = new System.Drawing.Point(304, 192);
            country1Label.Name = "country1Label";
            country1Label.Size = new System.Drawing.Size(46, 13);
            country1Label.TabIndex = 23;
            country1Label.Text = "Country:";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(DatabaseModel.customer);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(33, 28);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(205, 220);
            this.customerDataGridView.TabIndex = 0;
            this.customerDataGridView.SelectionChanged += new System.EventHandler(this.customerDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "active";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Active";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(33, 254);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(64, 23);
            this.addCustomerButton.TabIndex = 1;
            this.addCustomerButton.Text = "Add";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // editCustomerButton
            // 
            this.editCustomerButton.Location = new System.Drawing.Point(103, 254);
            this.editCustomerButton.Name = "editCustomerButton";
            this.editCustomerButton.Size = new System.Drawing.Size(64, 23);
            this.editCustomerButton.TabIndex = 2;
            this.editCustomerButton.Text = "Edit";
            this.editCustomerButton.UseVisualStyleBackColor = true;
            this.editCustomerButton.Click += new System.EventHandler(this.editCustomerButton_Click);
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Location = new System.Drawing.Point(173, 254);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(65, 23);
            this.deleteCustomerButton.TabIndex = 4;
            this.deleteCustomerButton.Text = "Delete";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(374, 59);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.ReadOnly = true;
            this.address1TextBox.Size = new System.Drawing.Size(128, 20);
            this.address1TextBox.TabIndex = 16;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(374, 85);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.ReadOnly = true;
            this.address2TextBox.Size = new System.Drawing.Size(128, 20);
            this.address2TextBox.TabIndex = 18;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(374, 111);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(128, 20);
            this.phoneTextBox.TabIndex = 20;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.postalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(374, 137);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.ReadOnly = true;
            this.postalCodeTextBox.Size = new System.Drawing.Size(128, 20);
            this.postalCodeTextBox.TabIndex = 22;
            // 
            // city1TextBox
            // 
            this.city1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.city.city1", true));
            this.city1TextBox.Location = new System.Drawing.Point(374, 163);
            this.city1TextBox.Name = "city1TextBox";
            this.city1TextBox.ReadOnly = true;
            this.city1TextBox.Size = new System.Drawing.Size(128, 20);
            this.city1TextBox.TabIndex = 23;
            // 
            // country1TextBox
            // 
            this.country1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.city.country.country1", true));
            this.country1TextBox.Location = new System.Drawing.Point(374, 189);
            this.country1TextBox.Name = "country1TextBox";
            this.country1TextBox.ReadOnly = true;
            this.country1TextBox.Size = new System.Drawing.Size(128, 20);
            this.country1TextBox.TabIndex = 24;
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 325);
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
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(this.editCustomerButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.customerDataGridView);
            this.Name = "ManageCustomers";
            this.Text = "Manage Customers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button editCustomerButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox city1TextBox;
        private System.Windows.Forms.TextBox country1TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}