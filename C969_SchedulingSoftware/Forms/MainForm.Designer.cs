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
            this.navGroupBox = new System.Windows.Forms.GroupBox();
            this.viewReportsButton = new System.Windows.Forms.Button();
            this.mgrAppointmentsButton = new System.Windows.Forms.Button();
            this.mgrCustomerButton = new System.Windows.Forms.Button();
            this.calendarGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.weeklyRadioButton = new System.Windows.Forms.RadioButton();
            this.monthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.navGroupBox.SuspendLayout();
            this.calendarGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.calendarGroupBox.Controls.Add(this.dataGridView1);
            this.calendarGroupBox.Location = new System.Drawing.Point(363, 12);
            this.calendarGroupBox.Name = "calendarGroupBox";
            this.calendarGroupBox.Size = new System.Drawing.Size(628, 426);
            this.calendarGroupBox.TabIndex = 1;
            this.calendarGroupBox.TabStop = false;
            this.calendarGroupBox.Text = "calendarGroupBox";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 380);
            this.dataGridView1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox navGroupBox;
        private System.Windows.Forms.Button viewReportsButton;
        private System.Windows.Forms.Button mgrAppointmentsButton;
        private System.Windows.Forms.Button mgrCustomerButton;
        private System.Windows.Forms.GroupBox calendarGroupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton monthlyRadioButton;
        private System.Windows.Forms.RadioButton weeklyRadioButton;
    }
}