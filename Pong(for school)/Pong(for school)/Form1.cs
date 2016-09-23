using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Code Explinations
	This uses rectangles to determine the borders and paddles, and checks the keypress to move the charecter. THIS IS A GOOD EXAMPLE.
*/
namespace Pong_for_school_
{
    public partial class Form1 : Form
    {
        Rectangle[] Window = new Rectangle[4];
        public Form1()
        {
            InitializeComponent();
            MenuLoad();
			//Initializes the borders and paddles
            Window[0] = new Rectangle(415, -6, 10, 497);
            Window[1] = new Rectangle(-4, -7, 10, 497);
            Window[2] = new Rectangle(-4, -7, 427, 10);
            Window[3] = new Rectangle(-4, 483, 420, 10);
        }
		//Sets varaibles
        bool menu = true;
        int charMove = 5;
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
        bool single = false;
		
		//Checks for keypresses
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
                    single = false;
                }
                else if (e.KeyCode == Keys.Shift)
                {
                    StartGame();
                    single = true;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (points[0] > points[1])
                {
                    MessageBox.Show("Player 2 Wins!");
                }
                else if (points[0] < points[1])
                {
                    MessageBox.Show("Player 1 Wins");
                }
                else
                {
                    MessageBox.Show("ITS A TIE!!!!");
                }
                Quit();
            }
        }
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
        }
        private void Quit()
        {
            Close();
        }
        private void MenuLoad()
        {
            lblStart.Visible = true;
            picTopPaddle.Visible = false;
            picBottomPaddle.Visible = false;
            ballX = 206;
            ballY = 218;
            picBall.Visible = false;
            menu = true;
        }
        private void Collisions()
        {

        }
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
        }
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
            

            

        }
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

            
        }


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
        }
        private void Update_Score()
        {
            lblTopScore.Text = points[1].ToString();
            lblBottomScore.Text = points[0].ToString();
        }


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
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            directionT = 0;
            directionB = 0;
        }
    }
}
