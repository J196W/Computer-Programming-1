using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{

    public partial class Quote : Form
    {
        int trys = 2;
        int score = 0;
        int rndNum = 0;
        int free = 0;
        string[] Quotes = new string[11];
        Image[] Pictures = new Image[10];
        

        public Quote()
        {

            InitializeComponent();
            Quotes[1] = "The Dark Side of the Force is the pathway to many abilities some consider to be… Unnatural.";
            Quotes[2] = "He’s holding a thermal detonator!"; ;
            Quotes[3] = "Just before they went into warp, I beamed the whole kit and kaboodle into their engine room, where they'll be no tribble at all";
            Quotes[4] = "We simply must accept the fact that Captain Kirk is no longer alive";
            Quotes[5] = "You would kill your own parents? Your own brothers and sisters? Didn't you know Admiral? The Bak'u and the S'ona are the same race. You brought the Federation into the middle of a blood feud";
            Quotes[6] = "Never tell me the odds!";
            Quotes[7] = "Aren't you a little short for a storm trooper?";
            Quotes[8] = "Why you stuck-up, half-witted, scruffy-looking nerf-herder!";
            Quotes[9] = "These aren’t the droids you’re looking for...";
            Quotes[10] = "Traveling through hyperspace ain't like dusting crops, farm boy.";
            Quotes[0] = "YOU WIN!!!!!!!!                                                                                         Press Restart to start over or next to exit";

            Pictures[0] = Properties.Resources.Palpy;
            Pictures[1] = Properties.Resources.C_3P0;
            Pictures[2] = Properties.Resources.scotty;
            Pictures[3] = Properties.Resources.spock;
            Pictures[4] = Properties.Resources.piccard;
            Pictures[5] = Properties.Resources.han_solo;
            Pictures[6] = Properties.Resources.leia;
            Pictures[7] = Properties.Resources.leia;
            Pictures[8] = Properties.Resources.ben;
            Pictures[9] = Properties.Resources.han_solo;
        }
        //Please ignore the following lines with no code, It gives me errors when I delete them
        public void  btnRestart_Click(object sender, EventArgs e)
        {

            txtInput.Text = "";
            if (trys <= 0) { Close(); }
            if (lblQuoteDisplay.Text == "CORRECT!") {
                score = score + 1; lblQuoteDisplay.Text = ""; trys = 2; lblTrys.Text = trys.ToString();
                if (picDisplayPic.Image == null) { score = score + 1; }
                if (score >= 20) { lblQuoteDisplay.Text = "YOU WIN!!!!!!!!                                                                                         Press Restart to start over or next to exit"; }
            }
            picDisplayPic.Image = null;
            lblScore.Text = score.ToString();
            Random rndGen = new Random();
            rndNum = rndGen.Next(0, 10);
            if (rndNum == 0) { lblQuoteDisplay.Text = Quotes[1];  }
            else if (rndNum == 1) { lblQuoteDisplay.Text = Quotes[2];  }
            else if (rndNum == 2) { lblQuoteDisplay.Text = Quotes[3];}
            else if (rndNum == 3) { lblQuoteDisplay.Text = Quotes[4];  }
            else if (rndNum == 4) { lblQuoteDisplay.Text = Quotes[5]; }
            else if (rndNum == 5) { lblQuoteDisplay.Text = Quotes[6]; }
            else if (rndNum == 6) { lblQuoteDisplay.Text = Quotes[7];  }
            else if (rndNum == 7) { lblQuoteDisplay.Text = Quotes[8];  }
            else if (rndNum == 8) { lblQuoteDisplay.Text = Quotes[9];  }
            else if (rndNum == 9) { lblQuoteDisplay.Text = Quotes[10];  }
            if (score >= 20) { lblQuoteDisplay.Text = Quotes[0]; }
        }
        private void btnFree_Click(object sender, EventArgs e)
        {
            
            if (free < 4)
            {
                score = score + 1;
                lblQuoteDisplay.Text = "Press next, you got a free point";
                free = free + 1;
            }else { lblQuoteDisplay.Text = "NO MORE FREE POINTS!"; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string textin = txtInput.Text.ToLower();
            
            
                if (rndNum == 0) { if (textin == "palpatine" || textin == "palpy") { lblQuoteDisplay.Text = "CORRECT!"; btnNext.PerformClick(); } else { if (trys < 0) { Close(); } trys = trys - 1; lblTrys.Text = trys.ToString(); if (trys == 0) { lblQuoteDisplay.Text = "GAME OVER. Press Next to exit, or Restart."; } } }
                else if (rndNum == 1)
                {
                    if (textin == "c-3p0" || textin == "c-3po" || textin == "c3p0" || textin == "c3po") { lblQuoteDisplay.Text = "CORRECT!"; btnNext.PerformClick(); }
                    else { if (trys < 0) { Close(); } trys = trys - 1; lblTrys.Text = trys.ToString(); if (trys == 0) { lblQuoteDisplay.Text = "GAME OVER. Press Next to exit, or Restart."; } }
                }
                else if (rndNum == 2) { if (textin == "scotty" || textin == "scoty") { lblQuoteDisplay.Text = "CORRECT!"; btnNext.PerformClick(); } else { if (trys < 0) { Close(); } trys = trys - 1; lblTrys.Text = trys.ToString(); if (trys == 0) { lblQuoteDisplay.Text = "GAME OVER. Press Next to exit, or Restart."; } } }
                else if (rndNum == 3) { if (textin == "spock") { lblQuoteDisplay.Text = "CORRECT!"; btnNext.PerformClick(); } else { if (trys < 0) { Close(); } trys = trys - 1; lblTrys.Text = trys.ToString(); if (trys == 0) { lblQuoteDisplay.Text = "GAME OVER. Press Next to exit, or Restart."; } } }
                else if (rndNum == 4) { if (textin == "piccard" || textin == "captian piccard") { lblQuoteDisplay.Text = "CORRECT!"; btnNext.PerformClick(); } else { if (trys < 0) { Close(); } trys = trys - 1; lblTrys.Text = trys.ToString(); if (trys == 0) { lblQuoteDisplay.Text = "GAME OVER. Press Next to exit, or Restart."; } } }
                else if (rndNum == 5) { if (textin == "han solo" || textin == "solo") { lblQuoteDisplay.Text = "CORRECT!"; btnNext.PerformClick(); } else { if (trys < 0) { Close(); } trys = trys - 1; lblTrys.Text = trys.ToString(); if (trys == 0) { lblQuoteDisplay.Text = "GAME OVER. Press Next to exit, or Restart."; } } }
                else if (rndNum == 6) { if (textin == "leia" || textin == "princess leia") { lblQuoteDisplay.Text = "CORRECT!"; btnNext.PerformClick(); } else { if (trys < 0) { Close(); } trys = trys - 1; lblTrys.Text = trys.ToString(); if (trys == 0) { lblQuoteDisplay.Text = "GAME OVER. Press Next to exit, or Restart."; } } }
                else if (rndNum == 7) { if (textin == "leia" || textin == "princess leia") { lblQuoteDisplay.Text = "CORRECT!"; btnNext.PerformClick(); } else { if (trys < 0) { Close(); } trys = trys - 1; lblTrys.Text = trys.ToString(); if (trys == 0) { lblQuoteDisplay.Text = "GAME OVER. Press Next to exit, or Restart."; } } }
                else if (rndNum == 8) { if (textin == "old ben" || textin == "ben") { lblQuoteDisplay.Text = "CORRECT!"; btnNext.PerformClick(); } else { if (trys < 0) { Close(); } trys = trys - 1; lblTrys.Text = trys.ToString(); if (trys == 0) { lblQuoteDisplay.Text = "GAME OVER. Press Next to exit, or Restart."; } } }
                else if (rndNum == 9) { if (textin == "solo" || textin == "han solo") { lblQuoteDisplay.Text = "CORRECT!"; btnNext.PerformClick(); } else { if (trys < 0) { Close(); } trys = trys - 1; lblTrys.Text = trys.ToString(); if (trys == 0) { lblQuoteDisplay.Text = "GAME OVER. Press Next to exit, or Restart."; } } }



            if (trys == 1)
            {
                if (rndNum == 0) { picDisplayPic.Image = Pictures[0]; }
                else if (rndNum == 1) { picDisplayPic.Image = Pictures[1]; }
                else if (rndNum == 2) { picDisplayPic.Image = Pictures[2]; }
                else if (rndNum == 3) { picDisplayPic.Image = Pictures[3]; }
                else if (rndNum == 4) { picDisplayPic.Image = Pictures[4]; }
                else if (rndNum == 5) { picDisplayPic.Image = Pictures[5]; }
                else if (rndNum == 6) { picDisplayPic.Image = Pictures[6]; }
                else if (rndNum == 7) { picDisplayPic.Image = Pictures[7]; }
                else if (rndNum == 8) { picDisplayPic.Image = Pictures[8]; }
                else if (rndNum == 9) { picDisplayPic.Image = Pictures[9]; }
            }
            
        }    
        private void btnRestart_Click_1(object sender, EventArgs e)
        {
            lblQuoteDisplay.Text = "To begin, press Next, submit answers by entering text and then pressing submit. Use the 'I GOT IT RIGHT' feature wisely.";
            score = 0;
            lblScore.Text = "";
            lblScore.Text = "0";
            lblTrys.Text = trys.ToString();
        }
        private void lblEaster_Click(object sender, EventArgs e)
        {
            score = 100000;
            lblScore.Text = score.ToString();
            lblQuoteDisplay.Text = "You just had to click everywhere, didn't you?";
            lblEaster.Text = "You just had to click everywhere, didn't you?";
            btnRestart.Text = "1010101010101010101";
            btnNext.Text = "10101010101010101010101010";
            btnEnd.Text = "10101010101010101";
            lblCurrentScore.Text = "10101010101010101010101";
            lblTrysRemaining.Text = "10101010101010101010";
            lblTrys.Text = "100000000000";
            btnSubmit.Text = "1010101010101010";
            btnFree.Text = "1010101010101010";
        }
        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btnSubmit.PerformClick(); }
        }
    }

}
