namespace C969_SchedulingSoftware.Forms
{
    partial class AddCity
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
            System.Windows.Forms.Label city1Label;
            System.Windows.Forms.Label country1Label;
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.city1TextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.cancelButton = new System.Windows.Forms.Button();
            city1Label = new System.Windows.Forms.Label();
            country1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // city1Label
            // 
            city1Label.AutoSize = true;
            city1Label.Location = new System.Drawing.Point(36, 22);
            city1Label.Name = "city1Label";
            city1Label.Size = new System.Drawing.Size(32, 13);
            city1Label.TabIndex = 1;
            city1Label.Text = "city1:";
            // 
            // country1Label
            // 
            country1Label.AutoSize = true;
            country1Label.Location = new System.Drawing.Point(36, 48);
            country1Label.Name = "country1Label";
            country1Label.Size = new System.Drawing.Size(51, 13);
            country1Label.TabIndex = 15;
            country1Label.Text = "country1:";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(DatabaseModel.city);
            // 
            // city1TextBox
            // 
            this.city1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "city1", true));
            this.city1TextBox.Location = new System.Drawing.Point(121, 19);
            this.city1TextBox.Name = "city1TextBox";
            this.city1TextBox.Size = new System.Drawing.Size(200, 20);
            this.city1TextBox.TabIndex = 2;
            this.city1TextBox.TextChanged += new System.EventHandler(this.city1TextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(121, 80);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // countryComboBox
            // 
            this.countryComboBox.DataSource = this.countryBindingSource;
            this.countryComboBox.DisplayMember = "country1";
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(121, 48);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(200, 21);
            this.countryComboBox.TabIndex = 39;
            this.countryComboBox.ValueMember = "countryId";
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataSource = typeof(DatabaseModel.country);
            // 
            // countryLinkLabel
            // 
            this.countryLinkLabel.AutoSize = true;
            this.countryLinkLabel.Location = new System.Drawing.Point(327, 51);
            this.countryLinkLabel.Name = "countryLinkLabel";
            this.countryLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.countryLinkLabel.TabIndex = 53;
            this.countryLinkLabel.TabStop = true;
            this.countryLinkLabel.Text = "Add New";
            this.countryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.countryLinkLabel_LinkClicked);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(246, 80);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 54;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 115);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.countryLinkLabel);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(country1Label);
            this.Controls.Add(city1Label);
            this.Controls.Add(this.city1TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCity";
            this.Text = "8";
            this.Load += new System.EventHandler(this.AddCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.TextBox city1TextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private System.Windows.Forms.LinkLabel countryLinkLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}