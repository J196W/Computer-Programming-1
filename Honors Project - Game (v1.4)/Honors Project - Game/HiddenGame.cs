using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Honors_Project___Game
{
    //This is the game that is accessed inside the game. It is just a copy of my pong code....
    public partial class HiddenGame : Form
    {
        public HiddenGame()
        {
            InitializeComponent();
            MenuLoad();
            Window[0] = new Rectangle(415, -6, 10, 497);
            Window[1] = new Rectangle(-4, -7, 10, 497);
            Window[2] = new Rectangle(-4, -7, 427, 10);
            Window[3] = new Rectangle(-4, 483, 420, 10);
            CenterToScreen();
        } //Constructor

        //Variables, in no particular order
        bool menu = true;
        Rectangle[] Window = new Rectangle[4];
        int charMove = 7;
        Point[] paddles = new Point[2];
        Rectangle[] padRect = new Rectangle[2];
        Random direct = new Random();
        int topX = 165;
        int bottomX = 165;
        int ballX = 206;
        int ballY = 218;
        Rectangle ballRect;
        int collDirection = 0;
        int ballDirection = 1;
        int[] points = new int[2];
        int directionT = 0;
        int directionB = 0;
        //Keyboard Input
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                directionT = 2;
            }
            else if (e.KeyCode == Keys.Left)
            {
                directionT = 1;
            }
            if (e.KeyCode == Keys.Z)
            {
                directionB = 1;
            }
            else if (e.KeyCode == Keys.C)
            {
                directionB = 2;
            }
            if (menu == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    StartGame();
                }
                else if (e.KeyCode == Keys.Shift)
                {
                    StartGame();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            directionT = 0;
            directionB = 0;
        }

        //Gameplay
        private void PaddleMovement()
        {
            if (directionT == 1)
            {
                topX -= charMove - 3;
            }
            else if (directionT == 2)
            {
                topX += charMove - 3;
            }
            if (directionB == 1)
            {
                bottomX -= charMove - 3;
            }
            else if (directionB == 2)
            {
                bottomX += charMove - 3;
            }
            paddles[0] = new Point(topX, 12);
            paddles[1] = new Point(bottomX, 463);
            picBottomPaddle.Location = paddles[0];
            picTopPaddle.Location = paddles[1];
            padRect[0] = new Rectangle(topX, 12, 101, 14);
            padRect[1] = new Rectangle(bottomX, 463, 101, 14);
        }//Move the paddles, duh
        private void BallCollision()
        {
            if (ballRect.IntersectsWith(Window[1]))
            {
                collDirection = 1;
            }
            else if (ballRect.IntersectsWith(Window[0]))
            {
                collDirection = 0;
            }
            else if (ballRect.IntersectsWith(padRect[0]))
            {
                ballDirection = 1;
            }
            else if (ballRect.IntersectsWith(padRect[1]) && ballY >= 11)
            {
                ballDirection = 0;
            }
            else if (ballRect.IntersectsWith(Window[2]) && ballY <= 449)
            {
                points[0] += 1;
                MenuLoad();
            }
            else if (ballRect.IntersectsWith(Window[3]))
            {
                points[1] += 1;
                MenuLoad();

            }




        }//Detects ball collisions
        private void BallMovement()
        {
            Point ball = new Point(ballX, ballY);
            ballRect = new Rectangle(ballX, ballY, 15, 15);
            picBall.Location = ball;
            if (ballDirection == 0)
            {
                ballY -= charMove - 4;
                if (collDirection == 0)
                {
                    ballX -= charMove - 2;
                }
                else if (collDirection == 1)
                {
                    ballX += charMove - 3;
                }
            }
            else if (ballDirection == 1)
            {
                ballY += charMove - 4;
                if (collDirection == 0)
                {
                    ballX -= charMove - 3;
                }
                else if (collDirection == 1)
                {
                    ballX += charMove - 1;
                }
            }


        }//Moves the ball
        private void Single_Player()
        {
            if (collDirection == 1)
            {
                directionB = 2;
            }
            else if (collDirection == 0)
            {
                directionB = 1;
            }
            else
            {
                directionB = 0;
            }
        }//Single Player paddle movement, not complicated enough
        private void StartGame()
        {
            menu = false;
            picTopPaddle.Visible = true;
            picBottomPaddle.Visible = true;
            lblStart.Visible = false;
            picBall.Visible = true;
            ballX = 206;
            ballY = 218;
            Point ball = new Point(ballX, ballY);
            picBall.Location = ball;
            menu = false;
            ballDirection = direct.Next(0, 2);
            collDirection = direct.Next(0, 2);
        }//Starts the game
        private void Quit()
        {
            Close();
        }//Exits the Game
        private void MenuLoad()
        {
            lblStart.Visible = true;
            picTopPaddle.Visible = false;
            picBottomPaddle.Visible = false;
            ballX = 206;
            ballY = 218;
            picBall.Visible = false;
            menu = true;
        }//Loads the Menu
        private void PaddleCollision()
        {
            if (padRect[0].IntersectsWith(Window[0]))
            {
                topX -= charMove;
            }
            else if (padRect[0].IntersectsWith(Window[1]))
            {
                topX += charMove;
            }
            else if (padRect[1].IntersectsWith(Window[0]))
            {
                bottomX -= charMove;
            }
            else if (padRect[1].IntersectsWith(Window[1]))
            {
                bottomX += charMove;
            }
        }//Detects the paddle collisions against the wall
        private void Update_Score()
        {
            lblTopScore.Text = points[1].ToString();
            lblBottomScore.Text = points[0].ToString();
        }//Updates the Score


        private void timer1_Tick(object sender, EventArgs e)
        {
            PaddleMovement();
            BallMovement();
            PaddleCollision();
            BallCollision();
            Update_Score();
            if (menu == true)
            {
                MenuLoad();
            }
            Single_Player();
        }//Timer, runs every tick, how I update everything

    }
}
