using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the class that creates the window that the user will be using. Making things be invisible is rather annoying, I must say. That is what most of this code is.
// Also has the function to delete houses , which was fun.
namespace House_Maker
{
    public partial class HouseGenerator : Form
    {

//############################################ Variables ##############################################

        bool progStart = false;
        int houseCreate = 0;
        Create_House[] Houses = new Create_House[5];
        Image[] pictures = new Image[5];
        SettingsForHouseGenerator Settings = new SettingsForHouseGenerator();
        int button = 0;
        Random rndNum = new Random();
        int picNum = 0;

//########################################## Constructor ##############################################

        public HouseGenerator()
        {
            InitializeComponent();
            Width = 400;
            Height = 226;
            FormBorderStyle = FormBorderStyle.None;
            invisible();
            CenterToScreen();

            pictures[1] = Properties.Resources.houseOne;
            pictures[2] = Properties.Resources.houseTwo;
            pictures[3] = Properties.Resources.houseThree;
            pictures[4] = Properties.Resources.houseFour;

            BackgroundImage = Properties.Resources.windows;

        }

//####################################### Window Controls #############################################

        private void invisible()
        {
            picHouse1.Visible = false;
            picHouse2.Visible = false;
            picHouse3.Visible = false;
            picHouse4.Visible = false;
            btnCreate3.Visible = false;
            btnCreate4.Visible = false;
            btnCreateHouse.Visible = false;
            btnCreateHouse2.Visible = false;
            btnDelete.Visible = false;
            btnDelete2.Visible = false;
            btnDelete3.Visible = false;
            btnDelete4.Visible = false;
            lblDisplay2.Visible = false;
            lblDisplay3.Visible = false;
            lblDisplay4.Visible = false;
            lblHouseDescripction.Visible = false;
            btnSettings.Visible = false;
        }
        private void Main()
        {
            if (houseCreate == 0)
            {
                Width = 303;
                Height = 85;
                FormBorderStyle = FormBorderStyle.FixedSingle;
                progStart = true;
                btnCreateHouse.Visible = true;
                btnCreate3.Visible = true;
                btnCreate4.Visible = true;
                btnCreateHouse2.Visible = true;
            }
        }
        private void Window_Chooser(int b)
        {
            Width = 618;
            Height = 680;
            picNum = rndNum.Next(0, 4) + 1;
            if (b == 1)
            {
                btnCreateHouse.Visible = false;
                btnDelete.Visible = true;
                lblHouseDescripction.Visible = true;
                picHouse1.Visible = true;
                picHouse1.Image = pictures[picNum];
                lblHouseDescripction.Text = Houses[b].getBedrooms().ToString() + " Bedrooms and " + Houses[b].getBathrooms().ToString() + " Bathrooms";
            }
            else if (b == 2)
            {
                btnCreateHouse2.Visible = false;
                btnDelete2.Visible = true;
                lblDisplay2.Visible = true;
                picHouse2.Visible = true;
                picHouse2.Image = pictures[picNum];
                lblDisplay2.Text = Houses[b].getBedrooms().ToString() + " Bathrooms and " + Houses[b].getBathrooms().ToString() + " Bedrooms";
            }
            else if (b == 3)
            {
                btnCreate3.Visible = false;
                btnDelete3.Visible = true;
                lblDisplay3.Visible = true;
                picHouse3.Visible = true;
                picHouse3.Image = pictures[picNum];
                lblDisplay3.Text = Houses[b].getBedrooms().ToString() + " Bathrooms and " + Houses[b].getBathrooms().ToString() + " Bedrooms";
            }
            else if (b == 4)
            {
                btnCreate4.Visible = false;
                btnDelete4.Visible = true;
                lblDisplay4.Visible = true;
                picHouse4.Visible = true;
                picHouse4.Image = pictures[picNum];
                lblDisplay4.Text = Houses[b].getBedrooms().ToString() + " Bathrooms and " + Houses[b].getBathrooms().ToString() + " Bedrooms";
            }
        }
        private void House_Menu()
        {
            if (Settings.getBathrooms() == "" || Settings.getBedroom() == "")
            {
                MessageBox.Show("Please Set Values in the Settings", "Error");
                Settings.Show();
            }
            else
            {
                btnBuildHouse_Click();
                Window_Chooser(button);
            }
        }
        private void Delete_House(int button)
        {
            
            if (button == 1)
            {
                btnDelete.Visible = false;
                lblHouseDescripction.Visible = false;
                picHouse1.Visible = false;
                btnCreateHouse.Visible = true;
            }
            else if (button == 2)
            {
                btnDelete2.Visible = false;
                lblDisplay2.Visible = false;
                picHouse2.Visible = false;
                btnCreateHouse2.Visible = true;
            }
            else if (button == 3)
            {
                btnDelete3.Visible = false;
                lblDisplay3.Visible = false;
                picHouse3.Visible = false;
                btnCreate3.Visible = true;
            }
            else if (button == 4)
            {
                btnDelete4.Visible = false;
                lblDisplay4.Visible = false;
                picHouse4.Visible = false;
                btnCreate4.Visible = true;
            }
        }

//########################################### Button Calls ############################################

        private void Form1_Click(object sender, EventArgs e)
        {
            if (progStart == false)
            {
                Main();
            }
            BackgroundImage = null;
        }

        private void btnCreateHouse_Click(object sender, EventArgs e)
        {
            button = 1;
            House_Menu();
        }
        private void btnCreateHouse2_Click(object sender, EventArgs e)
        {
            button = 2;
            House_Menu();
        }
        private void btnCreate3_Click(object sender, EventArgs e)
        {
            button = 3;
            House_Menu();
        }
        private void btnCreate4_Click(object sender, EventArgs e)
        {
            button = 4;
            House_Menu();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete_House(1);
        }
        private void btnDelete2_Click(object sender, EventArgs e)
        {
            Delete_House(2);
        }
        private void btnDelete3_Click(object sender, EventArgs e)
        {
            Delete_House(3);
        }
        private void btnDelete4_Click(object sender, EventArgs e)
        {
            Delete_House(4);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Show();
        }

//###################################### Building the House ###########################################

        private void btnBuildHouse_Click()
        {
            int bathrooms = Convert.ToInt32(Settings.getBathrooms());
            int bedrooms = Convert.ToInt32(Settings.getBedroom());
            Houses[button] = new Create_House(bedrooms, bathrooms);
            Window_Chooser(button);
            houseCreate++;
            btnSettings.Visible = true;
        }
    }
}
