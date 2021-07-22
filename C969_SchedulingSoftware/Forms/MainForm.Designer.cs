namespace C969_SchedulingSoftware
{
    partial class MainForm
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
            this.navGroupBox = new System.Windows.Forms.GroupBox();
            this.viewReportsButton = new System.Windows.Forms.Button();
            this.mgrAppointmentsButton = new System.Windows.Forms.Button();
            this.mgrCustomerButton = new System.Windows.Forms.Button();
            this.calendarGroupBox = new System.Windows.Forms.GroupBox();
            this.monthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.weeklyRadioButton = new System.Windows.Forms.RadioButton();
            this.calendarDataGridView = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navGroupBox.SuspendLayout();
            this.calendarGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // navGroupBox
            // 
            this.navGroupBox.Controls.Add(this.viewReportsButton);
            this.navGroupBox.Controls.Add(this.mgrAppointmentsButton);
            this.navGroupBox.Controls.Add(this.mgrCustomerButton);
            this.navGroupBox.Location = new System.Drawing.Point(12, 12);
            this.navGroupBox.Name = "navGroupBox";
            this.navGroupBox.Size = new System.Drawing.Size(178, 240);
            this.navGroupBox.TabIndex = 0;
            this.navGroupBox.TabStop = false;
            this.navGroupBox.Text = "navGroupBox";
            // 
            // viewReportsButton
            // 
            this.viewReportsButton.Location = new System.Drawing.Point(6, 150);
            this.viewReportsButton.Name = "viewReportsButton";
            this.viewReportsButton.Size = new System.Drawing.Size(165, 23);
            this.viewReportsButton.TabIndex = 2;
            this.viewReportsButton.Text = "viewReports";
            this.viewReportsButton.UseVisualStyleBackColor = true;
            // 
            // mgrAppointmentsButton
            // 
            this.mgrAppointmentsButton.Location = new System.Drawing.Point(6, 121);
            this.mgrAppointmentsButton.Name = "mgrAppointmentsButton";
            this.mgrAppointmentsButton.Size = new System.Drawing.Size(165, 23);
            this.mgrAppointmentsButton.TabIndex = 1;
            this.mgrAppointmentsButton.Text = "mgrAppointments";
            this.mgrAppointmentsButton.UseVisualStyleBackColor = true;
            this.mgrAppointmentsButton.Click += new System.EventHandler(this.mgrAppointmentsButton_Click);
            // 
            // mgrCustomerButton
            // 
            this.mgrCustomerButton.Location = new System.Drawing.Point(6, 92);
            this.mgrCustomerButton.Name = "mgrCustomerButton";
            this.mgrCustomerButton.Size = new System.Drawing.Size(166, 23);
            this.mgrCustomerButton.TabIndex = 0;
            this.mgrCustomerButton.Text = "mgrCustomer";
            this.mgrCustomerButton.UseVisualStyleBackColor = true;
            this.mgrCustomerButton.Click += new System.EventHandler(this.mgrCustomerButton_Click);
            // 
            // calendarGroupBox
            // 
            this.calendarGroupBox.Controls.Add(this.monthlyRadioButton);
            this.calendarGroupBox.Controls.Add(this.weeklyRadioButton);
            this.calendarGroupBox.Controls.Add(this.calendarDataGridView);
            this.calendarGroupBox.Location = new System.Drawing.Point(363, 12);
            this.calendarGroupBox.Name = "calendarGroupBox";
            this.calendarGroupBox.Size = new System.Drawing.Size(628, 426);
            this.calendarGroupBox.TabIndex = 1;
            this.calendarGroupBox.TabStop = false;
            this.calendarGroupBox.Text = "calendarGroupBox";
            // 
            // monthlyRadioButton
            // 
            this.monthlyRadioButton.AutoSize = true;
            this.monthlyRadioButton.Location = new System.Drawing.Point(98, 17);
            this.monthlyRadioButton.Name = "monthlyRadioButton";
            this.monthlyRadioButton.Size = new System.Drawing.Size(61, 17);
            this.monthlyRadioButton.TabIndex = 2;
            this.monthlyRadioButton.TabStop = true;
            this.monthlyRadioButton.Text = "monthly";
            this.monthlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // weeklyRadioButton
            // 
            this.weeklyRadioButton.AutoSize = true;
            this.weeklyRadioButton.Location = new System.Drawing.Point(7, 17);
            this.weeklyRadioButton.Name = "weeklyRadioButton";
            this.weeklyRadioButton.Size = new System.Drawing.Size(58, 17);
            this.weeklyRadioButton.TabIndex = 1;
            this.weeklyRadioButton.TabStop = true;
            this.weeklyRadioButton.Text = "weekly";
            this.weeklyRadioButton.UseVisualStyleBackColor = true;
            this.weeklyRadioButton.CheckedChanged += new System.EventHandler(this.weeklyRadioButton_CheckedChanged);
            // 
            // calendarDataGridView
            // 
            this.calendarDataGridView.AllowUserToAddRows = false;
            this.calendarDataGridView.AllowUserToDeleteRows = false;
            this.calendarDataGridView.AutoGenerateColumns = false;
            this.calendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.lastUpdateDataGridViewTextBoxColumn,
            this.lastUpdateByDataGridViewTextBoxColumn});
            this.calendarDataGridView.DataSource = this.appointmentBindingSource;
            this.calendarDataGridView.Location = new System.Drawing.Point(7, 40);
            this.calendarDataGridView.Name = "calendarDataGridView";
            this.calendarDataGridView.ReadOnly = true;
            this.calendarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.calendarDataGridView.Size = new System.Drawing.Size(615, 380);
            this.calendarDataGridView.TabIndex = 0;
            this.calendarDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.calendarDataGridView_CellFormatting);
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(DatabaseModel.appointment);
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
            this.endDataGridViewTextBoxColumn.HeaderText = "end";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "createDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "createDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "createdBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "createdBy";
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            this.createdByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastUpdateDataGridViewTextBoxColumn
            // 
            this.lastUpdateDataGridViewTextBoxColumn.DataPropertyName = "lastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn.HeaderText = "lastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn.Name = "lastUpdateDataGridViewTextBoxColumn";
            this.lastUpdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastUpdateByDataGridViewTextBoxColumn
            // 
            this.lastUpdateByDataGridViewTextBoxColumn.DataPropertyName = "lastUpdateBy";
            this.lastUpdateByDataGridViewTextBoxColumn.HeaderText = "lastUpdateBy";
            this.lastUpdateByDataGridViewTextBoxColumn.Name = "lastUpdateByDataGridViewTextBoxColumn";
            this.lastUpdateByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.calendarGroupBox);
            this.Controls.Add(this.navGroupBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.navGroupBox.ResumeLayout(false);
            this.calendarGroupBox.ResumeLayout(false);
            this.calendarGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox navGroupBox;
        private System.Windows.Forms.Button viewReportsButton;
        private System.Windows.Forms.Button mgrAppointmentsButton;
        private System.Windows.Forms.Button mgrCustomerButton;
        private System.Windows.Forms.GroupBox calendarGroupBox;
        private System.Windows.Forms.DataGridView calendarDataGridView;
        private System.Windows.Forms.RadioButton monthlyRadioButton;
        private System.Windows.Forms.RadioButton weeklyRadioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
    }
}