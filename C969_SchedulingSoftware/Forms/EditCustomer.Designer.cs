namespace C969_SchedulingSoftware.Forms
{
    partial class EditCustomer
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
            System.Windows.Forms.Label country1Label;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label cityIdLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label activeLabel;
            System.Windows.Forms.Label customerNameLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.cityLinkLabel = new System.Windows.Forms.LinkLabel();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            address1Label = new System.Windows.Forms.Label();
            country1Label = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityIdLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            activeLabel = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(29, 85);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(53, 13);
            address1Label.TabIndex = 58;
            address1Label.Text = "address1:";
            // 
            // country1Label
            // 
            country1Label.AutoSize = true;
            country1Label.Location = new System.Drawing.Point(29, 166);
            country1Label.Name = "country1Label";
            country1Label.Size = new System.Drawing.Size(51, 13);
            country1Label.TabIndex = 69;
            country1Label.Text = "country1:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(29, 111);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(53, 13);
            address2Label.TabIndex = 60;
            address2Label.Text = "address2:";
            // 
            // cityIdLabel
            // 
            cityIdLabel.AutoSize = true;
            cityIdLabel.Location = new System.Drawing.Point(29, 138);
            cityIdLabel.Name = "cityIdLabel";
            cityIdLabel.Size = new System.Drawing.Size(26, 13);
            cityIdLabel.TabIndex = 62;
            cityIdLabel.Text = "city:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(29, 192);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(40, 13);
            phoneLabel.TabIndex = 63;
            phoneLabel.Text = "phone:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(29, 218);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(66, 13);
            postalCodeLabel.TabIndex = 65;
            postalCodeLabel.Text = "postal Code:";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new System.Drawing.Point(43, 30);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new System.Drawing.Size(39, 13);
            activeLabel.TabIndex = 54;
            activeLabel.Text = "active:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(24, 58);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(84, 13);
            customerNameLabel.TabIndex = 56;
            customerNameLabel.Text = "customer Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 73;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cityLinkLabel
            // 
            this.cityLinkLabel.AutoSize = true;
            this.cityLinkLabel.Location = new System.Drawing.Point(320, 137);
            this.cityLinkLabel.Name = "cityLinkLabel";
            this.cityLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.cityLinkLabel.TabIndex = 71;
            this.cityLinkLabel.TabStop = true;
            this.cityLinkLabel.Text = "Add New";
            // 
            // countryComboBox
            // 
            this.countryComboBox.DataSource = this.countryBindingSource;
            this.countryComboBox.DisplayMember = "country1";
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(114, 162);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(200, 21);
            this.countryComboBox.TabIndex = 70;
            this.countryComboBox.ValueMember = "countryId";
            // 
            // countryLinkLabel
            // 
            this.countryLinkLabel.AutoSize = true;
            this.countryLinkLabel.Location = new System.Drawing.Point(320, 166);
            this.countryLinkLabel.Name = "countryLinkLabel";
            this.countryLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.countryLinkLabel.TabIndex = 72;
            this.countryLinkLabel.TabStop = true;
            this.countryLinkLabel.Text = "Add New";
            // 
            // cityComboBox
            // 
            this.cityComboBox.DataSource = this.cityBindingSource;
            this.cityComboBox.DisplayMember = "city1";
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(114, 134);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(200, 21);
            this.cityComboBox.TabIndex = 68;
            this.cityComboBox.ValueMember = "cityId";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(27, 248);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 67;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // address1TextBox
            // 
            this.address1TextBox.Location = new System.Drawing.Point(114, 82);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(200, 20);
            this.address1TextBox.TabIndex = 59;
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(114, 108);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(200, 20);
            this.address2TextBox.TabIndex = 61;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(114, 189);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 64;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(114, 215);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(200, 20);
            this.postalCodeTextBox.TabIndex = 66;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.Location = new System.Drawing.Point(114, 25);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activeCheckBox.TabIndex = 55;
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(114, 55);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerNameTextBox.TabIndex = 57;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(DatabaseModel.city);
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(DatabaseModel.country);
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cityLinkLabel);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(address1Label);
            this.Controls.Add(this.countryLinkLabel);
            this.Controls.Add(country1Label);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(cityIdLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(activeLabel);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel cityLinkLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.LinkLabel countryLinkLabel;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.BindingSource cityBindingSource;
    }
}