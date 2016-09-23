using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Adventure_Game
{
    public partial class frmPokemon : Form
    {
        private void Form1_Load(object sender, EventArgs e) { }

        /*PLEASE NOTE
            *The block comments in this code have been collapsed. Please open them to read them!
            *If you understand what something does, good! You don't have to read every comment, but please read some!
            *Though the code may look small while collapsed, it is 782 lines long!
          END NOTE*/


        /*Code Explanations
            *This is where the magic begins. 
            *In this code, you will see a few lines that you may not understand.
            *I will explain them here.
            
            * FormBorderStyle (line 30)
                *This is to make the user not be able to change the size of the window. Go ahead, try.
            
            * Size = new System.Drawing.Size(x,y) (first at line 32)
                *This sets the size of the window. Like I said, the user can not change the window size, so we do that
                *Here in code.
            
            * Lines 37-38
                *These lines of code set a custom image as the icon for the window. Go ahead, take a look!
            
            * nameSpace.PlayLooping() / nameSpace.Play() / nameSpace.Stop()
                *These are the controlles for the audio in code. Nothing really special about them!


        *A quick explination of methods.
            *Methods are what you call when you press a button. In this code, we created some of our own for the level info.
            
            *A method is simple, part of code that can be called by another part of code. This is exactly what the buttons are.
        */

        public frmPokemon()
        {
            InitializeComponent();
            picTitleScreen.Visible = true;
            picTitleScreen.BringToFront();
            Size = new System.Drawing.Size(512,390);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Bitmap bmp = Adventure_Game.Properties.Resources.icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            start.PlayLooping();

        }

        //Audio Files
        //This is where we created the code version of playing an audio file. We call this when we want to play audio.

        SoundPlayer start = new SoundPlayer(Properties.Resources.MLG_Pokemon_Theme__Extended_Intro_);
        SoundPlayer open = new SoundPlayer(Properties.Resources.mlg_credits);
        
        //Variables
            //Booleans
        bool pacifist = false;
        bool firstGame = false;
        bool waterPokemon = false;
        bool firstPokemon = false;
        bool fishPole = false;
        bool potionStatus = false;
        bool swimDisk = false;
        bool money = false;
        bool startGame = false;
            //Strings
        string currentTown = "None";
        string currentChar = "None";
            //Ints
        int fishTime = 0;
        int currentMiliTIme = 0;
        
        //Time Spans (Timers). This is the variable for the wait timers.
        TimeSpan twoSeconds = new TimeSpan(0, 0, 2);

        /*Level Info
            *Here, instead of recreating the level every time, we call whichever of these we want.
            *It works the same way as a button: when a button is pressed it goes to button1_click(); In code, we are
            *able to create those and call them within code. These are called Methods.
            *They are currently all collapsed for readability sake, but if you would like to read them, go ahead!
        */

        private void Final_Battle()
        {
            currentTown = "Final Battle";
            picLoc.Image = Properties.Resources.mainGymInside;
            lblLoc.Text = "Final Gym";
            btnOne.Visible = false;
            btnThree.Visible = false;
            btnThree.Visible = true; btnThree.Text = "FIGHT";
            if (pacifist == true)
            {
                btnFour.Visible = true; btnFour.Text = "Talk it out";
            }
            else
            {
                btnFour.Visible = false;
            }
            btnFive.Visible = false;
            btnSix.Visible = false;
        }
        private void Char_Selection()
        {
            Size = new System.Drawing.Size(512,588);
            currentTown = "Char Select";
            picTitleScreen.Visible = false;
            lblLoc.Text = "Charecter Selection";
            btnOne.Visible = true; btnOne.Text = "Grant";
            btnTwo.Visible = true; btnTwo.Text = "Colton";
            btnThree.Visible = false;
            btnFour.Visible = false;
            btnFive.Visible = true; btnFive.Text = "Jason";
            btnSix.Visible = true; btnSix.Text = "Miller";
            btnThree.Visible = true; btnThree.Text = "Start";
            btnFour.Visible = true; btnFour.Text = "Deselect";
            lblLoc.Text = "Grant Selected!";
            currentChar = "Grant";
            picLoc.Image = Properties.Resources.pixelGrantHovered;
        }
        private void Final_Gym()
        {
            currentTown = "Final Gym";
            lblLoc.Text = "Final Gym";
            picLoc.Image = Adventure_Game.Properties.Resources.mainGymOutside;
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Enter";
            btnFour.Visible = true; btnFour.Text = "Flee";
            btnFive.Visible = false;
            btnSix.Visible = false;
        }
        private void intro()
        {
            currentTown = "Intro";
            Size = new System.Drawing.Size(512, 390);
            timer1.Enabled = true;
            start.Stop();
            open.Play();
        }
        private void First_Ending()
        {
            currentTown = "First Ending";
            picLoc.Image = Properties.Resources.images;
            lblLoc.Text = "You beat the first ending.";
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Restart";
            btnFour.Visible = true; btnFour.Text = "Quit";
            btnFive.Visible = false;
            btnSix.Visible = false;
            firstGame = true;
            MessageBox.Show("Button is now unlocked in house one. Pay attention!", "Pokememe");
            pacifist = false;
            firstGame = true;
            waterPokemon = false;
            firstPokemon = false;
            fishPole = false;
            potionStatus = false;
            swimDisk = false;
            money = false;
        }
        private void First_Gym()
        {
            picLoc.Image = Properties.Resources.violetCityGym;
            currentTown = "First Gym";
            lblLoc.Text = "First Gym";
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "FIGHT";
            if (pacifist == true)
            {
                btnFour.Visible = true; btnFour.Text = "Talk it out";
            }
            else
            {
                btnFour.Visible = false;
            }
            btnFive.Visible = false;
            btnSix.Visible = false;
        }
        private void Fish()
        {
            picLoc.Image = Properties.Resources.fishing;
            currentTown = "Fish";
            lblLoc.Text = "Do you want to fish?";
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Back";
            btnFour.Visible = true; btnFour.Text = "Fish";
            btnFive.Visible = false;
            btnSix.Visible = false;
        }
        private void Fish_House()
        {
            picLoc.Image = Properties.Resources.firstHouse;
            currentTown = "Fish Pole House";
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Back";
            btnFour.Visible = false;
            btnFive.Visible = false;
            btnSix.Visible = false;
            if (fishPole == false)
            {
                lblLoc.Text = "The man inside gives you a fishing pole!";
                MessageBox.Show("You now have a Fishing Pole!", "Pokememe");
                fishPole = true;
            }
            else { lblLoc.Text = "The man questions why you return, and says \"GO FISH\"."; MessageBox.Show("You already have a Fishing Pole", "Pokememe"); }
        }
        private void Game_Over()
        {
            picLoc.Image = Properties.Resources.gameover;
            currentTown = "Game Over";
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Restart";
            btnFour.Visible = true; btnFour.Text = "Quit";
            btnFive.Visible = false;
            btnSix.Visible = false;
            //SET ALL TO FALSE
            firstGame = false;
            waterPokemon = false;
            firstPokemon = false;
            fishPole = false;
            potionStatus = false;
            swimDisk = false;
            money = false;
        }
        private void Goldenrod_City()
        {
            picLoc.Image = Properties.Resources.goldenrodMain;
            currentTown = "Goldenrod City";
            lblLoc.Text = "Welcome to Goldenrod City";
            btnOne.Visible = true; btnOne.Text = "Shop";
            btnTwo.Visible = true; btnTwo.Text = "House";
            btnThree.Visible = true; btnThree.Text = "Back";
            btnFour.Visible = true; btnFour.Text = "Job";
            btnFive.Visible = true; btnFive.Text = "House";
            btnSix.Visible = true; btnSix.Text = "Gym";
        }
        private void Heal()
        {
            picLoc.Image = Properties.Resources.memeCenter;
            currentTown = "Heal";
            lblLoc.Text = "Do you want to heal your pokememes?";
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Back";
            btnFour.Visible = true; btnFour.Text = "Heal";
            btnFive.Visible = false;
            btnSix.Visible = false;
        }
        private void Lake_Rage()
        {
            picLoc.Image = Properties.Resources.lakeOfRage;
            currentTown = "Lake of Rage";
            lblLoc.Text = "Lake of Rage";
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Dive";
            if (swimDisk == true && waterPokemon == true)
            {
                btnFour.Visible = true; btnFour.Text = "Use Swim";
            }
            else
            {
                btnFour.Visible = false;
            }
            btnFive.Visible = false;
            btnSix.Visible = false;
        }
        private void New_Bark()
        {
            picLoc.Image = Properties.Resources.newBarkTownMain;
            Size = new System.Drawing.Size(512,588);
            currentTown = "New Bark";
            lblLoc.Text = "New Bark Town";
            btnOne.Visible = true; btnOne.Text = "West";
            btnTwo.Visible = false;
            btnThree.Visible = false;
            btnFour.Visible = true; btnFour.Text = "Professor";
            btnFive.Visible = true; btnFive.Text = "East";
            btnSix.Visible = false;
        }
        private void Pac_House()
        {
            picLoc.Image = Properties.Resources.firstHouse;
            currentTown = "Pac House";
            lblLoc.Text = "You are in the house";
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Back";
            if (firstGame == true)
            {
                btnFour.Visible = true; btnFour.Text = "Pacifist";
            }
            else { btnFour.Visible = false; }
            btnFive.Visible = false;
            btnSix.Visible = false;
        }
        private void Professor()
        {
            picLoc.Image = Properties.Resources.professor;
            currentTown = "Professor";
            if (firstPokemon == true)
            {
                lblLoc.Text = "You already have a pokememe";
            }
            else
            {
                lblLoc.Text = "You now have a pokememe!"; firstPokemon = true;
            }
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Back";
            btnFour.Visible = false;
            btnFive.Visible = false;
            btnSix.Visible = false;
        }
        private void Violet_City()
        {
            picLoc.Image = Properties.Resources.violetCityMain;
            currentTown = "Violet City";
            lblLoc.Text = "Welcome to Violet City";
            btnOne.Visible = true; btnOne.Text = "House";
            btnTwo.Visible = true; btnTwo.Text = "Fish";
            btnThree.Visible = true; btnThree.Text = "New Bark Town";
            btnFour.Visible = true; btnFour.Text = "Gym";
            btnFive.Visible = true; btnFive.Text = "Heal";
            btnSix.Visible = true; btnSix.Text = "House";
        }
        private void Talk_It_Out()
        {
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Back";
            btnFour.Visible = true; btnFour.Text = "Next Town";
            btnFive.Visible = false;
            btnSix.Visible = false;
            firstGame = true;
        }
        private void Job()
        {
            picLoc.Image = Properties.Resources.radioStation;
            currentTown = "Job";
            lblLoc.Text = "Do you want to do the job to earn money for a potion?";
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Back";
            btnFour.Visible = true; btnFour.Text = "Do Job";
            btnFive.Visible = false;
            btnSix.Visible = false;
        }
        private void House()
        {
            picLoc.Image = Properties.Resources.secondHouse;
            currentTown = "House";
            lblLoc.Text = "You are in the house";
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Back";
            btnFour.Visible = false;
            btnFive.Visible = false;
            btnSix.Visible = false;
        }
        private void Shop()
        {
            picLoc.Image = Properties.Resources.memeCenter;
            currentTown = "Shop";
            lblLoc.Text = "Do you want to buy a potion?";
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Back";
            btnFour.Visible = true; btnFour.Text = "Buy Potion";
            btnFive.Visible = false;
            btnSix.Visible = false;
        }
        private void Second_Gym()
        {
            picLoc.Image = Properties.Resources.goldenrodGym;
            currentTown = "Second Gym";
            lblLoc.Text = "Second Gym";
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "FIGHT";
            if (pacifist == true)
            {
                btnFour.Visible = true; btnFour.Text = "Talk it out";
            }
            else
            {
                btnFour.Visible = false;
            }
            btnFive.Visible = false;
            btnSix.Visible = false;
        }
        private void Second_Ending()
        {
            picLoc.Image = Properties.Resources.Pokemon_Memes_06;
            currentTown = "Second Ending";
            lblLoc.Text = "You beat the game!. GOOD JOB!";
            btnOne.Visible = false;
            btnTwo.Visible = false;
            btnThree.Visible = true; btnThree.Text = "Restart";
            btnFour.Visible = true; btnFour.Text = "Quit";
            btnFive.Visible = false;
            btnSix.Visible = false;
            firstGame = true;
            pacifist = false;
            MessageBox.Show("GAME OVER! YOU WIN!", "Pokememe");
        }

        /*Back to town method
            *This method is just the same as the one above, but it handles all of the "Back" buttons. currentTown is the
            *string variable that allows us so tell what town we are in, just for this reason.
            *It is collapsed for readability, but feel free to look.
        */

        private void backToTown()
        {
            //ADD ALL LEVELS TO THIS. CALL THIS TO USE BACK FEATURE.
            if (currentTown == "Lake of Rage") { New_Bark();  }
            else if (currentTown == "Professor") { New_Bark(); }
            else if (currentTown == "Pac House" || currentTown == "Fish Pole House" || currentTown == "Fish") { Violet_City(); }
            else if (currentTown == "Heal" || currentTown == "First Gym") { Violet_City(); }
            else if (currentTown == "Goldenrod City") { Violet_City(); }
            else if (currentTown == "Job" || currentTown == "House" || currentTown == "Shop") { Goldenrod_City(); }
        }

        /*Button Calls
            *These are where the magic happens. When a button is pressed it calles one of these.
            *This is where a majority of the code is. In the button sections alone, we used 56 if and else if 
            *statements (not including "else" statements)
            * These are again, collapsed for readability, but go ahead and read!
        */

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (btnOne.Text == "West")
            {
                if (firstPokemon == false) { lblLoc.Text = "You didn't have a pokememe!"; Game_Over(); }
                else { Violet_City(); }
            }
            else if (btnOne.Text == "House")
            {
                Fish_House();
            }
            else if (btnOne.Text == "Shop")
            {
                Shop();
            }
            else if (btnOne.Text == "Start")
            {
                Char_Selection();
            }
            else if (btnOne.Text == "Grant")
            {
                btnThree.Visible = true; btnThree.Text = "Start";
                btnFour.Visible = true; btnFour.Text = "Deselect";
                lblLoc.Text = "Grant Selected!";
                currentChar = "Grant";
                picLoc.Image = Properties.Resources.pixelGrantHovered;
            }
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (btnTwo.Text == "Fish")
            {
                Fish();
            }
            else if (btnTwo.Text == "House")
            {
                House();
            }
            else if (btnTwo.Text == "Colton")
            {
                currentChar = "Colton";
                lblLoc.Text = "Charecter Locked";
                btnThree.Visible = false;
                btnFour.Visible = false;
                picLoc.Image = Properties.Resources.pixelColtonHovered;
            }
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            if (btnThree.Text == "Dive")
            {
                lblLoc.Text = "You Drowned";
                Game_Over();
            }
            else if (btnThree.Text == "Start")
            {
                if (currentChar == "Grant")
                {
                    picLoc.Image = Properties.Resources.pixelGrantSelected;
                }
                else if (currentChar == "Jason")
                {
                    picLoc.Image = Properties.Resources.pixelJasonSelected;
                }
                else if (currentChar == "Miller")
                {
                    picLoc.Image = Properties.Resources.pixelMillerSelected;
                }
                intro();
            }
            else if (btnThree.Text == "Restart")
            {
                pacifist = false;
                waterPokemon = false;
                New_Bark();
            }
            else if (btnThree.Text == "Enter")
            {
                Final_Battle();
            }
            else if (btnThree.Text == "Back")
            {
                backToTown();
            }
            else if (btnThree.Text == "New Bark Town")
            {
                New_Bark();
            }
            else if (btnThree.Text == "FIGHT")
            {
                pacifist = false;
                firstGame = false;
                if (currentTown == "First Gym")
                {
                    MessageBox.Show("You beat the gym leader, and he gives you your second pokememe!", "Pokememe");
                    MessageBox.Show("Pokememe Aquired!", "Pokememe");
                    MessageBox.Show("Heading to next town!", "Pokememe");
                    Goldenrod_City();
                }
                else if (currentTown == "Second Gym")
                {
                    if (potionStatus == true && waterPokemon == true)
                    {
                        MessageBox.Show("You beat the gym! The gym leader gives you swim!", "Pokememe");
                        MessageBox.Show("Potion Lost", "Pokememe");
                        potionStatus = false;
                        swimDisk = true;
                        MessageBox.Show("Going back into town!", "Pokememe");
                        Goldenrod_City();
                    }
                    else if (waterPokemon == false)
                    {
                        lblLoc.Text = "You didn't have a Water Type Pokemon. Try fishing next time!"; Game_Over();
                    }
                    else if (potionStatus == false)
                    {
                        lblLoc.Text = "You didn't have a potion, and your pokememes died!"; Game_Over();
                    }
                }
                else if (currentTown == "Final Battle")
                {
                    if (potionStatus == true)
                    {
                        First_Ending();
                    }
                    else if (potionStatus == false) { lblLoc.Text = "You didn't have a potion, and your pokememes died!"; Game_Over(); }
                }

            }
            else if (btnThree.Text == "Start")
            {
                intro();

            }
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            if (btnFour.Text == "Quit")
            {
                Close();
            }
            else if (btnFour.Text == "Use Swim")
            {
                Final_Gym();
            }
            else if (btnFour.Text == "Flee")
            {
                lblLoc.Text = "You Left The Game";
                Game_Over();
            }
            else if (btnFour.Text == "Talk it out")
            {
                lblLoc.Text = "You decide to talk it out with the Pokememe Gym leader.";
                Talk_It_Out();
                if (currentTown == "First Gym")
                {
                    MessageBox.Show("You talk it out with the gym leader, and he gives you your second pokememe!", "Pokememe");
                    MessageBox.Show("Pokememe Aquired!", "Pokememe");
                    MessageBox.Show("Heading to next town!", "Pokememe");
                    Goldenrod_City();
                }
                else if (currentTown == "Second Gym")
                {
                    MessageBox.Show("You talk it out with the gym leader, and he gives you the swim disk", "Pokememe");
                    swimDisk = true;
                    MessageBox.Show("Disk Aquired!", "Pokememe");
                    MessageBox.Show("Heading to New Bark!", "Pokememe");
                    New_Bark();
                }
                else if (currentTown == "Final Battle")
                {
                    Second_Ending();
                }
            }
            else if (btnFour.Text == "Professor")
            {
                Professor();
            }
            else if (btnFour.Text == "Heal")
            {
                lblLoc.Text = "This will take three seconds. Please wait...";
                MessageBox.Show("Your Pokememes will now be healed!", "Pokememe Centre");
                Thread.Sleep(twoSeconds);
                MessageBox.Show("Your Pokememes have been healed!", "Pokememe Centre");
                backToTown();
            }
            else if (btnFour.Text == "Pacifist")
            {
                pacifist = true;
                MessageBox.Show("Pacifist Ending now unlocked!", "Pokememe");
                backToTown();
            }
            else if (btnFour.Text == "Fish")
            {
                if (fishPole == true)
                {
                    fishTime++;
                    lblLoc.Text = "This will take three seconds. Please wait...";
                    MessageBox.Show("You start to fish", "Pokememe Lake");
                    Thread.Sleep(twoSeconds);
                    if (fishTime >= 2) { MessageBox.Show("You caught a fish pokememe!", "Pokememe Lake"); waterPokemon = true; lblLoc.Text = "You have a fish pokemon."; btnFour.Visible = false; }
                    else { MessageBox.Show("You did not catch a fish!", "Pokememe Lake"); Fish(); }
                }
                else if (fishPole == false){ MessageBox.Show("You do not have a fishing pole!", "Pokememe Lake"); backToTown(); }
            }
            else if (btnFour.Text == "Gym")
            {
                First_Gym();
            }
            else if (btnFour.Text == "Do Job")
            {
                lblLoc.Text = "This will take three seconds. Please wait...";
                MessageBox.Show("You start your new job!", "Pokememe Job Employment Centre");
                Thread.Sleep(twoSeconds);
                MessageBox.Show("Paycheck earned!", "Pokememe Job Employment Centre");
                money = true;
                btnFour.Visible = false;
                lblLoc.Text = "You did your job.";
            }
            else if (btnFour.Text == "Job")
            {
                Job();
            }
            else if (btnFour.Text == "Buy Potion")
            {
                if (money == true)
                {
                    MessageBox.Show("Potion Gained!", "Pokememe Potions Centre");
                    money = false;
                    potionStatus = true;
                    backToTown();
                }
                else
                {
                    MessageBox.Show("You don't have any money. The store owner thows you out!", "Pokememe Potions Centre");
                    backToTown();
                }
            }
            else if (btnFour.Text == "Deselect")
            {
                btnThree.Visible = false;
                btnFour.Visible = false;
                lblLoc.Text = "No Charecter Selected!";
            }
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            if (btnFive.Text == "East")
            {
                Lake_Rage();
            }
            else if (btnFive.Text == "Heal")
            {
                Heal();
            }
            else if (btnFive.Text == "House")
            {
                House();
            }
            else if (btnFive.Text == "Exit")
            {
                Close();
            }
            else if (btnFive.Text == "Jason")
            {
                btnThree.Visible = true; btnThree.Text = "Start";
                btnFour.Visible = true; btnFour.Text = "Deselect";
                lblLoc.Text = "Jason Selected!";
                currentChar = "Jason";
                picLoc.Image = Properties.Resources.pixelJasonHovered;
            }
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            if (btnSix.Text == "House")
            {
                Pac_House();
            }
            else if (btnSix.Text == "Gym")
            {
                Second_Gym();
            }
            else if (btnSix.Text == "Miller")
            {
                btnThree.Visible = true; btnThree.Text = "Start";
                btnFour.Visible = true; btnFour.Text = "Deselect";
                lblLoc.Text = "Miller Selected!";
                currentChar = "Miller";
                picLoc.Image = Properties.Resources.pixelMillerHovered;
            }
        }
        
        //This is where we detect if the title screen is clicked. This starts the game.
        private void picTitleScreen_Click_1(object sender, EventArgs e)
        {
            if (startGame == false)
            {
                Char_Selection();
                startGame = true;
            }
        }
        
        //This is the timer for our charecter intro. Nothing really special
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentMiliTIme += 21;

            if (currentMiliTIme >= 9855)
            {
                    open.Stop();
                    New_Bark();
                    timer1.Enabled = false;
                    currentMiliTIme = 0;

                
            }
        }
        
        //This is to exit out of the charecter intro. Again, nothing special.
        private void picLoc_Click(object sender, EventArgs e)
        {
            if (currentTown == "Intro")
            {
                open.Stop();
                New_Bark();
            }
        }
    }
}