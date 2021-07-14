namespace C969_SchedulingSoftware.Forms
{
    partial class AddCountry
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
            System.Windows.Forms.Label country1Label;
            this.saveButton = new System.Windows.Forms.Button();
            this.country1TextBox = new System.Windows.Forms.TextBox();
            country1Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // country1Label
            // 
            country1Label.AutoSize = true;
            country1Label.Location = new System.Drawing.Point(24, 25);
            country1Label.Name = "country1Label";
            country1Label.Size = new System.Drawing.Size(51, 13);
            country1Label.TabIndex = 39;
            country1Label.Text = "country1:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(27, 52);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 51;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // country1TextBox
            // 
            this.country1TextBox.Location = new System.Drawing.Point(109, 22);
            this.country1TextBox.Name = "country1TextBox";
            this.country1TextBox.Size = new System.Drawing.Size(200, 20);
            this.country1TextBox.TabIndex = 40;
            this.country1TextBox.TextChanged += new System.EventHandler(this.country1TextBox_TextChanged);
            // 
            // AddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 97);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(country1Label);
            this.Controls.Add(this.country1TextBox);
            this.Name = "AddCountry";
            this.Text = "AddCountry";
            this.Load += new System.EventHandler(this.AddCountry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox country1TextBox;
    }
}