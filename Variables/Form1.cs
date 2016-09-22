using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Variables
{
    public partial class Form1 : Form
    {
        SoundPlayer simpleSound = new SoundPlayer(Variables.Properties.Resources.Do_a_Barrel_Roll1);
        int yearOne;
        int yearTwo;
        public Form1() { InitializeComponent();}
        //Leap Years with NO IF STATEMENTS
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOne.Text == "" || txtTwo.Text == "") { return; }
            yearOne = Convert.ToInt32(txtOne.Text);
            yearOne = int.Parse(txtOne.Text); 
            yearTwo = Convert.ToInt32(txtTwo.Text);
            yearTwo = int.Parse(txtTwo.Text);
            int useYearOne = yearOne;
            int numberOfYears = 0;
            while (useYearOne <= yearTwo) { 
                while ((useYearOne % 4 == 0 && !(useYearOne % 100 == 0) && useYearOne <= yearTwo) || (useYearOne % 400 == 0 && useYearOne <= yearTwo))
                {
                    numberOfYears++;
                    useYearOne = useYearOne + 4;
                }
                useYearOne = useYearOne + 4;
            }
            pictureBox1.BringToFront();
            lblOut.Text = "There are probably " + numberOfYears.ToString() + " leap years between " + yearOne.ToString() + " and " + yearTwo.ToString();
            this.simpleSound.Play();
            MessageBox.Show("There are probably " + numberOfYears.ToString() + " leap years between " + yearOne.ToString() + " and " + yearTwo.ToString());
            pictureBox1.SendToBack();
            
            
        }
        private void lblOut_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void txtTwo_TextChanged(object sender, EventArgs e) { }
    }
}
