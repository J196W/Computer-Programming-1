namespace House_Maker
{
    partial class SettingsForHouseGenerator
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBedrooms = new System.Windows.Forms.Label();
            this.txtBedrooms = new System.Windows.Forms.TextBox();
            this.txtBathrooms = new System.Windows.Forms.TextBox();
            this.lblBathrooms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(218, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBedrooms
            // 
            this.lblBedrooms.Location = new System.Drawing.Point(12, 9);
            this.lblBedrooms.Name = "lblBedrooms";
            this.lblBedrooms.Size = new System.Drawing.Size(224, 23);
            this.lblBedrooms.TabIndex = 2;
            this.lblBedrooms.Text = "Bedrooms";
            this.lblBedrooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBedrooms
            // 
            this.txtBedrooms.Location = new System.Drawing.Point(52, 35);
            this.txtBedrooms.Name = "txtBedrooms";
            this.txtBedrooms.Size = new System.Drawing.Size(139, 22);
            this.txtBedrooms.TabIndex = 3;
            // 
            // txtBathrooms
            // 
            this.txtBathrooms.Location = new System.Drawing.Point(49, 86);
            this.txtBathrooms.Name = "txtBathrooms";
            this.txtBathrooms.Size = new System.Drawing.Size(139, 22);
            this.txtBathrooms.TabIndex = 4;
            // 
            // lblBathrooms
            // 
            this.lblBathrooms.Location = new System.Drawing.Point(9, 60);
            this.lblBathrooms.Name = "lblBathrooms";
            this.lblBathrooms.Size = new System.Drawing.Size(224, 23);
            this.lblBathrooms.TabIndex = 5;
            this.lblBathrooms.Text = "Bathrooms";
            this.lblBathrooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 161);
            this.Controls.Add(this.lblBathrooms);
            this.Controls.Add(this.txtBathrooms);
            this.Controls.Add(this.txtBedrooms);
            this.Controls.Add(this.lblBedrooms);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBedrooms;
        private System.Windows.Forms.TextBox txtBedrooms;
        private System.Windows.Forms.TextBox txtBathrooms;
        private System.Windows.Forms.Label lblBathrooms;
    }
}