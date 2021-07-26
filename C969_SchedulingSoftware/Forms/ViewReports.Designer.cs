namespace C969_SchedulingSoftware.Forms
{
    partial class ViewReports
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
            this.reportsOutput = new System.Windows.Forms.TextBox();
            this.reportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportsOutput
            // 
            this.reportsOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsOutput.Location = new System.Drawing.Point(12, 57);
            this.reportsOutput.Multiline = true;
            this.reportsOutput.Name = "reportsOutput";
            this.reportsOutput.ReadOnly = true;
            this.reportsOutput.Size = new System.Drawing.Size(803, 542);
            this.reportsOutput.TabIndex = 0;
            // 
            // reportTypeComboBox
            // 
            this.reportTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportTypeComboBox.FormattingEnabled = true;
            this.reportTypeComboBox.Items.AddRange(new object[] {
            "Appointment Type by Month",
            "All Users Schedules",
            "Appointments Created Today"});
            this.reportTypeComboBox.Location = new System.Drawing.Point(12, 30);
            this.reportTypeComboBox.Name = "reportTypeComboBox";
            this.reportTypeComboBox.Size = new System.Drawing.Size(265, 21);
            this.reportTypeComboBox.TabIndex = 2;
            this.reportTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.reportTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Report Type:";
            // 
            // ViewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportTypeComboBox);
            this.Controls.Add(this.reportsOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ViewReports";
            this.Text = "ViewReports";
            this.Load += new System.EventHandler(this.ViewReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reportsOutput;
        private System.Windows.Forms.ComboBox reportTypeComboBox;
        private System.Windows.Forms.Label label1;
    }
}