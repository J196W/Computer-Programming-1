namespace Pong_for_school_
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
            this.components = new System.ComponentModel.Container();
            this.lblStart = new System.Windows.Forms.Label();
            this.picTopPaddle = new System.Windows.Forms.PictureBox();
            this.picBottomPaddle = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picBall = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTopScore = new System.Windows.Forms.Label();
            this.lblBottomScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTopPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(143, 218);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(147, 14);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Press Enter To Start";
            // 
            // picTopPaddle
            // 
            this.picTopPaddle.BackColor = System.Drawing.Color.Black;
            this.picTopPaddle.Location = new System.Drawing.Point(165, 8);
            this.picTopPaddle.Name = "picTopPaddle";
            this.picTopPaddle.Size = new System.Drawing.Size(101, 14);
            this.picTopPaddle.TabIndex = 4;
            this.picTopPaddle.TabStop = false;
            // 
            // picBottomPaddle
            // 
            this.picBottomPaddle.BackColor = System.Drawing.Color.Black;
            this.picBottomPaddle.Location = new System.Drawing.Point(165, 463);
            this.picBottomPaddle.Name = "picBottomPaddle";
            this.picBottomPaddle.Size = new System.Drawing.Size(101, 14);
            this.picBottomPaddle.TabIndex = 5;
            this.picBottomPaddle.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-4, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 497);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Black;
            this.picBall.Location = new System.Drawing.Point(206, 218);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(15, 15);
            this.picBall.TabIndex = 7;
            this.picBall.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // lblTopScore
            // 
            this.lblTopScore.AutoSize = true;
            this.lblTopScore.Location = new System.Drawing.Point(397, 9);
            this.lblTopScore.Name = "lblTopScore";
            this.lblTopScore.Size = new System.Drawing.Size(13, 13);
            this.lblTopScore.TabIndex = 10;
            this.lblTopScore.Text = "0";
            // 
            // lblBottomScore
            // 
            this.lblBottomScore.AutoSize = true;
            this.lblBottomScore.Location = new System.Drawing.Point(397, 467);
            this.lblBottomScore.Name = "lblBottomScore";
            this.lblBottomScore.Size = new System.Drawing.Size(13, 13);
            this.lblBottomScore.TabIndex = 11;
            this.lblBottomScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 489);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblBottomScore);
            this.Controls.Add(this.lblTopScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBottomPaddle);
            this.Controls.Add(this.picTopPaddle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picTopPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.PictureBox picTopPaddle;
        private System.Windows.Forms.PictureBox picBottomPaddle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTopScore;
        private System.Windows.Forms.Label lblBottomScore;
    }
}

