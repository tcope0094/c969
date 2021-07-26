namespace C969_SchedulingSoftware.Forms
{
    partial class AddEditCustomer
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
            System.Windows.Forms.Label activeLabel;
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label cityIdLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label country1Label;
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityLinkLabel = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.country1TextBox = new System.Windows.Forms.TextBox();
            activeLabel = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            address1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityIdLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            country1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(20, 228);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(40, 13);
            activeLabel.TabIndex = 1;
            activeLabel.Text = "Active:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(21, 40);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(85, 13);
            customerNameLabel.TabIndex = 11;
            customerNameLabel.Text = "Customer Name:";
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(21, 67);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(57, 13);
            address1Label.TabIndex = 17;
            address1Label.Text = "Address 1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(21, 93);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(57, 13);
            address2Label.TabIndex = 19;
            address2Label.Text = "Address 2:";
            // 
            // cityIdLabel
            // 
            cityIdLabel.AutoSize = true;
            cityIdLabel.Location = new System.Drawing.Point(21, 120);
            cityIdLabel.Name = "cityIdLabel";
            cityIdLabel.Size = new System.Drawing.Size(27, 13);
            cityIdLabel.TabIndex = 23;
            cityIdLabel.Text = "City:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(21, 174);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 33;
            phoneLabel.Text = "Phone:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(21, 200);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            postalCodeLabel.TabIndex = 35;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // country1Label
            // 
            country1Label.AutoSize = true;
            country1Label.Location = new System.Drawing.Point(21, 148);
            country1Label.Name = "country1Label";
            country1Label.Size = new System.Drawing.Size(46, 13);
            country1Label.TabIndex = 38;
            country1Label.Text = "Country:";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(DatabaseModel.customer);
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customerBindingSource, "active", true));
            this.activeCheckBox.Location = new System.Drawing.Point(110, 223);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activeCheckBox.TabIndex = 15;
            this.activeCheckBox.UseVisualStyleBackColor = true;
            this.activeCheckBox.CheckedChanged += new System.EventHandler(this.activeCheckBox_CheckedChanged);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "customerName", true));
            this.customerNameTextBox.Location = new System.Drawing.Point(111, 37);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerNameTextBox.TabIndex = 1;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(111, 64);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(200, 20);
            this.address1TextBox.TabIndex = 3;
            this.address1TextBox.TextChanged += new System.EventHandler(this.address1TextBox_TextChanged);
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(111, 90);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(200, 20);
            this.address2TextBox.TabIndex = 5;
            this.address2TextBox.Tag = "not required";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(111, 171);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 11;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "address.postalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(111, 197);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.postalCodeTextBox.TabIndex = 13;
            this.postalCodeTextBox.TextChanged += new System.EventHandler(this.postalCodeTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(24, 258);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cityComboBox
            // 
            this.cityComboBox.DataSource = this.cityBindingSource;
            this.cityComboBox.DisplayMember = "city1";
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(111, 116);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(200, 21);
            this.cityComboBox.TabIndex = 7;
            this.cityComboBox.ValueMember = "cityId";
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(DatabaseModel.city);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(DatabaseModel.country);
            // 
            // cityLinkLabel
            // 
            this.cityLinkLabel.AutoSize = true;
            this.cityLinkLabel.Location = new System.Drawing.Point(317, 119);
            this.cityLinkLabel.Name = "cityLinkLabel";
            this.cityLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.cityLinkLabel.TabIndex = 9;
            this.cityLinkLabel.TabStop = true;
            this.cityLinkLabel.Text = "Add New";
            this.cityLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cityLinkLabel_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // country1TextBox
            // 
            this.country1TextBox.Location = new System.Drawing.Point(111, 143);
            this.country1TextBox.Name = "country1TextBox";
            this.country1TextBox.ReadOnly = true;
            this.country1TextBox.Size = new System.Drawing.Size(199, 20);
            this.country1TextBox.TabIndex = 999;
            this.country1TextBox.Tag = "not required";
            // 
            // AddEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 315);
            this.Controls.Add(this.country1TextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cityLinkLabel);
            this.Controls.Add(country1Label);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(cityIdLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(activeLabel);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddEditCustomer";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddEditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.LinkLabel cityLinkLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox country1TextBox;
    }
}