namespace Adventure_Game
{
    partial class frmPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokemon));
            this.lblLoc = new System.Windows.Forms.Label();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.picLoc = new System.Windows.Forms.PictureBox();
            this.picTitleScreen = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoc
            // 
            this.lblLoc.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.Location = new System.Drawing.Point(-7, 353);
            this.lblLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(504, 19);
            this.lblLoc.TabIndex = 7;
            this.lblLoc.Text = "label1";
            this.lblLoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSix
            // 
            this.btnSix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSix.BackgroundImage")));
            this.btnSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSix.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(341, 472);
            this.btnSix.Margin = new System.Windows.Forms.Padding(2);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(156, 78);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "button6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFour.BackgroundImage")));
            this.btnFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFour.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(173, 472);
            this.btnFour.Margin = new System.Windows.Forms.Padding(2);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(154, 78);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "button4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTwo.BackgroundImage")));
            this.btnTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTwo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(5, 472);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(154, 78);
            this.btnTwo.TabIndex = 4;
            this.btnTwo.Text = "button2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFive.BackgroundImage")));
            this.btnFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFive.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(341, 374);
            this.btnFive.Margin = new System.Windows.Forms.Padding(2);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(156, 78);
            this.btnFive.TabIndex = 3;
            this.btnFive.Text = "button5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackgroundImage = global::Adventure_Game.Properties.Resources.individualButtonResize;
            this.btnThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThree.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(173, 374);
            this.btnThree.Margin = new System.Windows.Forms.Padding(2);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(154, 78);
            this.btnThree.TabIndex = 2;
            this.btnThree.Text = "button3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackgroundImage = global::Adventure_Game.Properties.Resources.individualButtonResize;
            this.btnOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOne.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(5, 374);
            this.btnOne.Margin = new System.Windows.Forms.Padding(2);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(154, 78);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "button1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // picLoc
            // 
            this.picLoc.BackColor = System.Drawing.Color.White;
            this.picLoc.Location = new System.Drawing.Point(-3, -1);
            this.picLoc.Margin = new System.Windows.Forms.Padding(2);
            this.picLoc.Name = "picLoc";
            this.picLoc.Size = new System.Drawing.Size(500, 352);
            this.picLoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoc.TabIndex = 0;
            this.picLoc.TabStop = false;
            this.picLoc.Click += new System.EventHandler(this.picLoc_Click);
            // 
            // picTitleScreen
            // 
            this.picTitleScreen.Image = global::Adventure_Game.Properties.Resources.pokememeTitleScreenGif;
            this.picTitleScreen.Location = new System.Drawing.Point(-3, 1);
            this.picTitleScreen.Margin = new System.Windows.Forms.Padding(2);
            this.picTitleScreen.Name = "picTitleScreen";
            this.picTitleScreen.Size = new System.Drawing.Size(500, 350);
            this.picTitleScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitleScreen.TabIndex = 8;
            this.picTitleScreen.TabStop = false;
            this.picTitleScreen.Click += new System.EventHandler(this.picTitleScreen_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 550);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.picTitleScreen);
            this.Controls.Add(this.picLoc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPokemon";
            this.Text = "Pokememes";
            ((System.ComponentModel.ISupportInitialize)(this.picLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLoc;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.PictureBox picTitleScreen;
        private System.Windows.Forms.Timer timer1;
    }
}

