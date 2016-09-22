namespace Variables
{
    partial class Form1
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
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(12, 12);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(100, 20);
            this.txtOne.TabIndex = 0;
            this.txtOne.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(12, 70);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(100, 20);
            this.txtTwo.TabIndex = 1;
            this.txtTwo.TextChanged += new System.EventHandler(this.txtTwo_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(12, 38);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 26);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Calculate";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOut
            // 
            this.lblOut.BackColor = System.Drawing.Color.Transparent;
            this.lblOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(118, 9);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(202, 86);
            this.lblOut.TabIndex = 3;
            this.lblOut.Click += new System.EventHandler(this.lblOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Variables.Properties.Resources.do_a_barrel_roll2;
            this.pictureBox1.Location = new System.Drawing.Point(118, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 104);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Leap Year Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

