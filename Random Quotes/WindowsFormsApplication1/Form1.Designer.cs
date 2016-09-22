namespace WindowsFormsApplication1
{
    partial class Quote
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
            this.btnNext = new System.Windows.Forms.Button();
            this.lblQuoteDisplay = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnFree = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTrys = new System.Windows.Forms.Label();
            this.picDisplayPic = new System.Windows.Forms.PictureBox();
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.lblTrysRemaining = new System.Windows.Forms.Label();
            this.lblEaster = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(14, 378);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(693, 45);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblQuoteDisplay
            // 
            this.lblQuoteDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoteDisplay.Location = new System.Drawing.Point(23, 35);
            this.lblQuoteDisplay.Name = "lblQuoteDisplay";
            this.lblQuoteDisplay.Size = new System.Drawing.Size(691, 94);
            this.lblQuoteDisplay.TabIndex = 2;
            this.lblQuoteDisplay.Text = "To begin, press Next, submit answers by entering text and then pressing submit. U" +
    "se the \"I GOT IT RIGHT\" feature wisely.";
            this.lblQuoteDisplay.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInput
            // 
            this.txtInput.AcceptsReturn = true;
            this.txtInput.Location = new System.Drawing.Point(183, 352);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(356, 20);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(230, 433);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(88, 39);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            this.lblScore.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // btnFree
            // 
            this.btnFree.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFree.Location = new System.Drawing.Point(14, 334);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(163, 38);
            this.btnFree.TabIndex = 6;
            this.btnFree.Text = "I GOT IT RIGHT";
            this.btnFree.UseVisualStyleBackColor = true;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(14, 1);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(245, 31);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Modern No. 20", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(462, 1);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(245, 31);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click_1);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(545, 334);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(162, 38);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTrys
            // 
            this.lblTrys.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrys.Location = new System.Drawing.Point(416, 433);
            this.lblTrys.Name = "lblTrys";
            this.lblTrys.Size = new System.Drawing.Size(45, 45);
            this.lblTrys.TabIndex = 10;
            this.lblTrys.Text = "2";
            // 
            // picDisplayPic
            // 
            this.picDisplayPic.Location = new System.Drawing.Point(14, 132);
            this.picDisplayPic.Name = "picDisplayPic";
            this.picDisplayPic.Size = new System.Drawing.Size(700, 196);
            this.picDisplayPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDisplayPic.TabIndex = 1;
            this.picDisplayPic.TabStop = false;
            this.picDisplayPic.Click += new System.EventHandler(this.picDisplayPic_Click);
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScore.Location = new System.Drawing.Point(22, 436);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(208, 34);
            this.lblCurrentScore.TabIndex = 11;
            this.lblCurrentScore.Text = "Current Score";
            // 
            // lblTrysRemaining
            // 
            this.lblTrysRemaining.AutoSize = true;
            this.lblTrysRemaining.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrysRemaining.Location = new System.Drawing.Point(459, 436);
            this.lblTrysRemaining.Name = "lblTrysRemaining";
            this.lblTrysRemaining.Size = new System.Drawing.Size(248, 34);
            this.lblTrysRemaining.TabIndex = 12;
            this.lblTrysRemaining.Text = "Tries Remaining";
            // 
            // lblEaster
            // 
            this.lblEaster.Location = new System.Drawing.Point(677, 44);
            this.lblEaster.Name = "lblEaster";
            this.lblEaster.Size = new System.Drawing.Size(30, 23);
            this.lblEaster.TabIndex = 13;
            this.lblEaster.Click += new System.EventHandler(this.lblEaster_Click);
            // 
            // Quote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 483);
            this.Controls.Add(this.lblEaster);
            this.Controls.Add(this.lblTrysRemaining);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.lblTrys);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnFree);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblQuoteDisplay);
            this.Controls.Add(this.picDisplayPic);
            this.Controls.Add(this.btnNext);
            this.Name = "Quote";
            this.Text = "Guess That Quote!!!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox picDisplayPic;
        private System.Windows.Forms.Label lblQuoteDisplay;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnFree;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTrys;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Label lblTrysRemaining;
        private System.Windows.Forms.Label lblEaster;
    }
}

