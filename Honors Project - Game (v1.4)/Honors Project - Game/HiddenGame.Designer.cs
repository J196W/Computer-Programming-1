namespace Honors_Project___Game
{
    partial class HiddenGame
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
            this.picTopPaddle = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picBottomPaddle = new System.Windows.Forms.PictureBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblTopScore = new System.Windows.Forms.Label();
            this.lblBottomScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTopPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomPaddle)).BeginInit();
            this.SuspendLayout();
            // 
            // picTopPaddle
            // 
            this.picTopPaddle.BackColor = System.Drawing.Color.Black;
            this.picTopPaddle.Location = new System.Drawing.Point(101, 19);
            this.picTopPaddle.Name = "picTopPaddle";
            this.picTopPaddle.Size = new System.Drawing.Size(101, 14);
            this.picTopPaddle.TabIndex = 0;
            this.picTopPaddle.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Black;
            this.picBall.Location = new System.Drawing.Point(148, 188);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(15, 15);
            this.picBall.TabIndex = 1;
            this.picBall.TabStop = false;
            // 
            // picBottomPaddle
            // 
            this.picBottomPaddle.BackColor = System.Drawing.Color.Black;
            this.picBottomPaddle.Location = new System.Drawing.Point(233, 338);
            this.picBottomPaddle.Name = "picBottomPaddle";
            this.picBottomPaddle.Size = new System.Drawing.Size(101, 14);
            this.picBottomPaddle.TabIndex = 2;
            this.picBottomPaddle.TabStop = false;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(172, 203);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(102, 13);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Press Enter To Start";
            // 
            // lblTopScore
            // 
            this.lblTopScore.AutoSize = true;
            this.lblTopScore.Location = new System.Drawing.Point(393, 8);
            this.lblTopScore.Name = "lblTopScore";
            this.lblTopScore.Size = new System.Drawing.Size(35, 13);
            this.lblTopScore.TabIndex = 4;
            this.lblTopScore.Text = "label1";
            // 
            // lblBottomScore
            // 
            this.lblBottomScore.AutoSize = true;
            this.lblBottomScore.Location = new System.Drawing.Point(396, 474);
            this.lblBottomScore.Name = "lblBottomScore";
            this.lblBottomScore.Size = new System.Drawing.Size(35, 13);
            this.lblBottomScore.TabIndex = 5;
            this.lblBottomScore.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HiddenGame
            // 
            this.ClientSize = new System.Drawing.Size(446, 489);
            this.Controls.Add(this.lblBottomScore);
            this.Controls.Add(this.lblTopScore);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.picBottomPaddle);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.picTopPaddle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HiddenGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picTopPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomPaddle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTopPaddle;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picBottomPaddle;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblTopScore;
        private System.Windows.Forms.Label lblBottomScore;
        private System.Windows.Forms.Timer timer1;
    }
}