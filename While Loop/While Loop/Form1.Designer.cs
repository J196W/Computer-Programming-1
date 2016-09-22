namespace While_Loop
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
            this.lblOut = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.lblChose = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnShape = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOut
            // 
            this.lblOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(257, 9);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(221, 246);
            this.lblOut.TabIndex = 2;
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(34, 28);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(217, 20);
            this.txtIn.TabIndex = 3;
            this.txtIn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lblChose
            // 
            this.lblChose.Font = new System.Drawing.Font("Comic Sans MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChose.Location = new System.Drawing.Point(85, 9);
            this.lblChose.Name = "lblChose";
            this.lblChose.Size = new System.Drawing.Size(103, 16);
            this.lblChose.TabIndex = 4;
            this.lblChose.Text = "Select your row";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(31, 54);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(220, 201);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnShape
            // 
            this.btnShape.Location = new System.Drawing.Point(4, 2);
            this.btnShape.Name = "btnShape";
            this.btnShape.Size = new System.Drawing.Size(75, 23);
            this.btnShape.TabIndex = 5;
            this.btnShape.Text = "Shape";
            this.btnShape.UseVisualStyleBackColor = true;
            this.btnShape.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 262);
            this.Controls.Add(this.btnShape);
            this.Controls.Add(this.lblChose);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Right Triangle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label lblChose;
        private System.Windows.Forms.Button btnShape;
    }
}

