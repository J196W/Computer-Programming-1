using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Description of Honors Project
For my honors project, I chose to take my adventure game and make it movement based. I only got to the first level, but it is a good concept. 

Word of advice:	
	NEVER CODE LIKE THIS. EVER. THIS IS NOT WHAT YOU SHOULD DO
	But I have to admit, it is pretty cool....
	
All of the movement is based on timers for the animation, and key presses. Beyond that, it is just an array of rectangles in a for loop that checks if
it intercepts with the carecter rectangle, which also corresponds to the picture box of the charecter. Key presses determine the direction the charecter
moves, and there is even a menu system. Otherwise, it is pretty simple. Like I said, NEVER DO THIS. SERIOUS GRAPHICAL GLITCHES WILL ENSUE. DO NOT DO IT.
*/

namespace Honors_Project___Game
{
    public partial class MainWindow : Form
    {
        //Constructor
        public MainWindow()
        {
            InitializeComponent();
            currentLocation = "New Bark Town";
            resume();
            pictureBox1.Width = 16;
            pictureBox1.Height = 29;
            BackgroundImageLayout = ImageLayout.Center;
            BackgroundImage = Properties.Resources.newBarkTownMain;
            CenterToScreen();
        }//The constructor, my dude

        //Timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            Movement();
            Draw();
            Rectangles();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (moveStatus == true)
            {
                timed++;
                if (timed >= 10)
                {
                    Change_Image();
                    timed = 0;
                }
            }
        }

        //Variables
        string direction;
        string currentLocation;
        int charX = 560;
        int charY = 250;
        int charDirection;
        int timed;
        
        Point charLocation;
        
        bool moveStatus;
        bool walkStill = true;
        bool menuStatus = false;
        Rectangle[] Borders = new Rectangle[18];
        Rectangle[] Doors = new Rectangle[2];

        //Constants
        static int charSpeed = 2;
        

        //Movement Methods
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            direction = e.KeyCode.ToString();
            if (e.KeyCode == Keys.Escape)
            {
                if (menuStatus == false)
                {
                    menu();
                }
                else if (menuStatus == true)
                {
                    resume();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (picArrowOne.Visible == true)
                {
                    resume();
                }
                else if (picArrowThree.Visible == true)
                {
                    exit();
                }
                else { }
            }
            else if (menuStatus == true)
            {
                if (direction == "Down")
                {
                    if (picArrowOne.Visible == true)
                    {
                        picArrowOne.Visible = false;
                        picArrowTwo.Visible = true;
                    }
                    else if (picArrowTwo.Visible == true)
                    {
                        picArrowTwo.Visible = false;
                        picArrowThree.Visible = true;
                    }
                }
                else if (direction == "Up")
                {
                    if (picArrowThree.Visible == true)
                    {
                        picArrowThree.Visible = false;
                        picArrowTwo.Visible = true;
                    }
                    else if (picArrowTwo.Visible == true)
                    {
                        picArrowTwo.Visible = false;
                        picArrowOne.Visible = true;
                    }
                }
                else { }
            }
        } //Checks if key is down
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            direction = "None";
        } //Checks if key is up
        private void Movement()
        {
            if (menuStatus == false)
            {
                    moveStatus = true;
                    if (direction == "Right")
                    {
                        charX += charSpeed;
                        charDirection = 1;
                    }
                    else if (direction == "Left")
                    {
                        charX -= charSpeed;
                        charDirection = 2;
                    }
                    else if (direction == "Up")
                    {
                        charY -= charSpeed;
                        charDirection = 3;
                    }
                    else if (direction == "Down")
                    {
                        charY += charSpeed;
                        charDirection = 4;
                    }
                    else
                    {
                        moveStatus = false;
                    }
            }
        } //Moves the charecter

        //Collision Methods
        private void Rectangles()
        {
            Rectangle charRectangle = new Rectangle(charX, charY, pictureBox1.Width, pictureBox1.Height);

            if (currentLocation == "New Bark Town")
            {
                Borders[0] = new Rectangle(612, 1, 77, 463);
                Borders[1] = new Rectangle(131, 263, 91, 68);
                Borders[2] = new Rectangle(395, 277, 89, 68);
                Borders[3] = new Rectangle(480, 92, 114, 95);
                Borders[4] = new Rectangle(240, 59, 108, 93);
                Borders[5] = new Rectangle(-6, 416, 692, 51);
                Borders[6] = new Rectangle(0, 46, 437, 51);
                Borders[7] = new Rectangle(429, 61, 253, 51);
                Borders[8] = new Rectangle(-2, 272, 131, 160);
                Borders[9] = new Rectangle(0, 0, 187, 173);
                Borders[10] = new Rectangle(173, 165, 22, 10);
                Borders[11] = new Rectangle(464, 170, 14, 16);
                Borders[12] = new Rectangle(223, 133, 14, 16);
                Borders[13] = new Rectangle(225, 283, 14, 18);
                Borders[14] = new Rectangle(487, 298, 14, 19);
                Borders[15] = new Rectangle(282, 246, 24, 16);
                Borders[16] = new Rectangle(371, 98, 20, 56);
                Borders[17] = new Rectangle(-6, 191, 10, 89);
                Doors[0] = new Rectangle(261, 148, 18, 10);
                Doors[1] = new Rectangle(0, 177, 10, 82);
                if (charRectangle.IntersectsWith(Doors[0]))
                {
                    BackgroundImage = Properties.Resources.firstHouse;
                    BackgroundImageLayout = ImageLayout.Stretch;
                    charX = 182;
                    charY = 394;
                    currentLocation = "First House";
                    pictureBox1.Width = 34;
                    pictureBox1.Height = 57;
                    charSpeed = 3;
                }
            }
            else if (currentLocation == "First House")
            {
                Borders[0] = new Rectangle(414, 253, 44, 23);
                Borders[1] = new Rectangle(1, 320, 44, 46);
                Borders[2] = new Rectangle(637, 326, 44, 51);
                Borders[3] = new Rectangle(281, 197, 115, 68);
                Borders[4] = new Rectangle(226, 249, 43, 19);
                Borders[5] = new Rectangle(225, 202, 43, 19);
                Borders[6] = new Rectangle(410, 203, 49, 19);
                Borders[7] = new Rectangle(1, 51, 196, 19);
                Borders[8] = new Rectangle(281, 53, 62, 19);
                Borders[9] = new Rectangle(194, 48, 31, 19);
                Borders[10] = new Rectangle(196, 26, 380, 19);
                Borders[11] = new Rectangle(570, 111, 118, 10);
                Borders[12] = new Rectangle(565, 81, 13, 15);
                Borders[13] = new Rectangle(-5, 113, 13, 351);
                Borders[14] = new Rectangle(673, 173, 13, 291);
                Borders[15] =
                Borders[16] =
                Borders[17] = new Rectangle(0, 0, 0, 0);
                Doors[0] = new Rectangle(151, 456, 90, 15);
                if (charRectangle.IntersectsWith(Doors[0]))
                {
                    charX = 261;
                    charY = 158;
                    pictureBox1.Width = 16;
                    pictureBox1.Height = 29;
                    BackgroundImageLayout = ImageLayout.Center;
                    BackgroundImage = Properties.Resources.newBarkTownMain;
                    currentLocation = "New Bark Town";
                    charSpeed = 2;
                }
                else if (charRectangle.IntersectsWith(Borders[8]))
                {
                    Form game = new HiddenGame();
                    game.Show();
                    charY -= 100;
                    moveStatus = false;
                    Hide();
                }
            }
            for (int i = 0; i <= 17; i++)
            {
                if (charRectangle.IntersectsWith(Borders[i]))
                {
                    if (charDirection == 1)
                    {
                        charX -= charSpeed;
                    }
                    else if (charDirection == 2)
                    {
                        charX += charSpeed;
                    }
                    else if (charDirection == 3)
                    {
                        charY += charSpeed;
                    }
                    else if (charDirection == 4)
                    {
                        charY -= charSpeed;
                    }
                }
            }
            

        } //Draws the rectangles, and detecs all collision

        //Graphic Methods
        private void Draw()
        {
            charLocation = new Point(charX, charY);
            pictureBox1.Location = charLocation;

        } //Draws the charecter
        private void Change_Image()
        {
            if (charDirection == 2)
            {
                if (walkStill == true)
                {
                    pictureBox1.Image = Properties.Resources.SideWalking;
                    walkStill = false;
                }
                else if (walkStill == false)
                {
                    pictureBox1.Image = Properties.Resources.SideLeftStill;
                    walkStill = true;
                }
            }
            else if (charDirection == 1)
            {
                if (walkStill == false)
                {
                    pictureBox1.Image = Properties.Resources.RightStill;
                    walkStill = true;
                }
                else if (walkStill == true)
                {
                    pictureBox1.Image = Properties.Resources.RightWalking;
                    walkStill = false;
                }
            }
            else if (charDirection == 3)
            {
                if (walkStill == true)
                {
                    pictureBox1.Image = Properties.Resources.BackWalking;
                    walkStill = false;
                }
                else if (walkStill == false)
                {
                    pictureBox1.Image = Properties.Resources.BackStill;
                    walkStill = true;
                }
            }
            else if (charDirection == 4)
            {
                if (walkStill == false)
                {
                    pictureBox1.Image = Properties.Resources.FrontStill;
                    walkStill = true;
                }
                else if (walkStill == true)
                {
                    pictureBox1.Image = Properties.Resources.FrontWalking;
                    walkStill = false;
                }
            }
        } //Changes the background image

        //Menu Methods
        private void menu()
        {
            menuStatus = true;
            picMenuBack.Visible = true;
            picArrowOne.Visible = true;
            picArrowTwo.Visible = false;
            picArrowThree.Visible = false;
            lblResume.Visible = true;
            lblExit.Visible = true;
            lblActions.Visible = true;
        } //Opens the menu
        private void exit()
        {
            Close();
        } //Closes the form
        private void resume()
        {
            menuStatus = false;
            picMenuBack.Visible = false;
            picArrowOne.Visible = false;
            picArrowTwo.Visible = false;
            picArrowThree.Visible = false;
            lblResume.Visible = false;
            lblExit.Visible = false;
            lblActions.Visible = false;
        } //Resumes the game (closes the menu)
    }
}
