namespace C969_SchedulingSoftware.Forms
{
    partial class EditAppointment
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
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label customerIdLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label startLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label urlLabel;
            System.Windows.Forms.Label userIdLabel;
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.customerIdComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            contactLabel = new System.Windows.Forms.Label();
            customerIdLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            endLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            startLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            urlLabel = new System.Windows.Forms.Label();
            userIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(32, 58);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(46, 13);
            contactLabel.TabIndex = 3;
            contactLabel.Text = "contact:";
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Location = new System.Drawing.Point(32, 136);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new System.Drawing.Size(65, 13);
            customerIdLabel.TabIndex = 9;
            customerIdLabel.Text = "customer Id:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(32, 163);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 13);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "description:";
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Location = new System.Drawing.Point(32, 190);
            endLabel.Name = "endLabel";
            endLabel.Size = new System.Drawing.Size(28, 13);
            endLabel.TabIndex = 13;
            endLabel.Text = "end:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(31, 222);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(47, 13);
            locationLabel.TabIndex = 19;
            locationLabel.Text = "location:";
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Location = new System.Drawing.Point(31, 249);
            startLabel.Name = "startLabel";
            startLabel.Size = new System.Drawing.Size(30, 13);
            startLabel.TabIndex = 21;
            startLabel.Text = "start:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(31, 274);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(26, 13);
            titleLabel.TabIndex = 23;
            titleLabel.Text = "title:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(31, 300);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(30, 13);
            typeLabel.TabIndex = 25;
            typeLabel.Text = "type:";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new System.Drawing.Point(31, 326);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new System.Drawing.Size(21, 13);
            urlLabel.TabIndex = 27;
            urlLabel.Text = "url:";
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(31, 352);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(42, 13);
            userIdLabel.TabIndex = 29;
            userIdLabel.Text = "user Id:";
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(DatabaseModel.appointment);
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(118, 55);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(200, 20);
            this.contactTextBox.TabIndex = 4;
            // 
            // customerIdComboBox
            // 
            this.customerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "customerId", true));
            this.customerIdComboBox.FormattingEnabled = true;
            this.customerIdComboBox.Location = new System.Drawing.Point(118, 133);
            this.customerIdComboBox.Name = "customerIdComboBox";
            this.customerIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.customerIdComboBox.TabIndex = 10;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(118, 160);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "end", true));
            this.endDateTimePicker.Location = new System.Drawing.Point(118, 186);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateTimePicker.TabIndex = 14;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "location", true));
            this.locationTextBox.Location = new System.Drawing.Point(117, 219);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 20);
            this.locationTextBox.TabIndex = 20;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "start", true));
            this.startDateTimePicker.Location = new System.Drawing.Point(117, 245);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateTimePicker.TabIndex = 22;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "title", true));
            this.titleTextBox.Location = new System.Drawing.Point(117, 271);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 20);
            this.titleTextBox.TabIndex = 24;
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(117, 297);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(200, 20);
            this.typeTextBox.TabIndex = 26;
            // 
            // urlTextBox
            // 
            this.urlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "url", true));
            this.urlTextBox.Location = new System.Drawing.Point(117, 323);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(200, 20);
            this.urlTextBox.TabIndex = 28;
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "userId", true));
            this.userIdTextBox.Location = new System.Drawing.Point(117, 349);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.userIdTextBox.TabIndex = 30;
            // 
            // EditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(contactLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(customerIdLabel);
            this.Controls.Add(this.customerIdComboBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(endLabel);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(startLabel);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(urlLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(this.userIdTextBox);
            this.Name = "EditAppointment";
            this.Text = "EditAppointment";
            this.Load += new System.EventHandler(this.EditAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.ComboBox customerIdComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox userIdTextBox;
    }
}