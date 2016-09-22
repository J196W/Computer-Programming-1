using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace madLib
{
    public partial class Form1 : Form
    {
        string total;
        string wordOne, wordTwo, wordThree, wordFour, wordFive, wordSix, wordSeven, wordEight, wordNine, wordTen, wordEleven, word12, word13, word14;
        private void lblAdjective4_Click(object sender, EventArgs e) { }
        public Form1()
        {
            InitializeComponent();
            lblHide.BringToFront();
            btnJulius.BringToFront();
            btnWeather.BringToFront();
            lblSelect.BringToFront();
            btnExit.BringToFront();

        }
        private void lblAdjective1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void lblAdverb1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            lblHide.BringToFront(); btnSubmitJulius.BringToFront(); btnBack.BringToFront(); btnExit.BringToFront();
            lblAdjective1.BringToFront(); lblAdverb1.BringToFront(); lblCapitolLetter1.BringToFront(); lblFamousPerson.BringToFront(); lblItalianWord1.BringToFront(); lblLocation1.BringToFront(); lblNoun1.BringToFront(); lblOccupation1.BringToFront(); lblPartOfBody.BringToFront(); lblPluralNoun.BringToFront(); lblNoun2.BringToFront();
            txtWordOne.BringToFront(); txtWordTwo.BringToFront(); txtWordThree.BringToFront(); txtWordFour.BringToFront(); txtWordFive.BringToFront(); txtWordSix.BringToFront(); txtWordSeven.BringToFront(); txtWordEight.BringToFront(); txtWordNine.BringToFront(); txtWordTen.BringToFront(); txtWordEleven.BringToFront();

        }
        private void btnWeather_Click(object sender, EventArgs e)
        {
            lblHide.BringToFront(); btnBack.BringToFront(); btnExit.BringToFront();
            lblAdjective1.BringToFront(); lblAdjective2.BringToFront(); lblAdjective3.BringToFront(); lblAdjective4.BringToFront(); lblAdjective5.BringToFront(); lblAdjective6.BringToFront(); lblAdverb1.BringToFront(); lblArticleOfClothing1.BringToFront(); lblArticleOfClothing2.BringToFront(); lblGeographical2.BringToFront(); lblLocation1.BringToFront(); lblNumber1.BringToFront(); lblPluralNoun.BringToFront(); lblPluralNoun2.BringToFront(); btnSubmitWeather.BringToFront();
            txtWordOne.BringToFront(); txtWordTwo.BringToFront(); txtWordThree.BringToFront(); txtWordFour.BringToFront(); txtWordFive.BringToFront(); txtWordSix.BringToFront(); txtWordSeven.BringToFront(); txtWordEight.BringToFront(); txtWordNine.BringToFront(); txtWordTen.BringToFront(); txtWordEleven.BringToFront(); txtWord12.BringToFront(); txtWord13.BringToFront(); txtWord14.BringToFront();
        }
        private void btnSubmitJulius_Click(object sender, EventArgs e)
        {
            wordOne = txtWordOne.Text; wordTwo = txtWordTwo.Text; wordThree = txtWordThree.Text; wordFour = txtWordFour.Text; wordFive = txtWordFive.Text; wordSix = txtWordSix.Text; wordSeven = txtWordSeven.Text; wordEight = txtWordEight.Text; wordNine = txtWordNine.Text; wordTen = txtWordTen.Text; wordEleven = txtWordEleven.Text;
            total = "Julius Caesar was born in 102 B." + wordEleven + ". He was an " + wordOne + " general, and between 49 and 58 B.C. he defeated the Gauls, the Goths, and the " + wordNine + ". After that, he " + wordTwo + " became more famous and defeated Pompey at the battle of " + wordFive + " at Pharsala.";
            total += " The Romans then elected him permanent " + wordTen + ", and he used to walk around wearing a circlet of ivy leaves on his " + wordEight + ". Then Caesar went to Egypt, where he met Cleopatra, the teenage Egyptian " + wordThree + ". When he conquered the Syrians in 46 B.C., he sent back a message saying, \"Veni, vedi, " + wordSix + "\" In 44 B.C., a soothsayer told Caesar";
            total += " to \"Beware the Ides of " + wordThree + "\" but he ignored the warning and in March he was stabbed in the " + wordSeven + " by a group of senators. His last words were, \"Et tu " + wordFour +"? \"";
            MessageBox.Show(total, "The Story of Julius Caesar");
            lblHide.BringToFront();
            btnJulius.BringToFront();
            btnWeather.BringToFront();
            lblSelect.BringToFront();
            btnExit.BringToFront();
        }
        private void btnSubmitWeather_Click(object sender, EventArgs e)
        {
            wordOne = txtWordOne.Text; wordTwo = txtWordTwo.Text; wordThree = txtWordThree.Text; wordFour = txtWordFour.Text; wordFive = txtWordFive.Text; wordSix = txtWordSix.Text; wordSeven = txtWordSeven.Text; wordEight = txtWordEight.Text; wordNine = txtWordNine.Text; wordTen = txtWordTen.Text; wordEleven = txtWordEleven.Text; word12 = txtWord12.Text; word13 = txtWord13.Text; word14 = txtWord14.Text;
            total = "Good evening, ladies and " + wordNine + ". Let's take a look at the weather picture. Right now the temperature is " + wordEight + " degrees and there are " + wordOne + " winds coming from the west. However, according to a report just received, a " + wordThree + " front is moving down from Canada. This " + wordTwo + " moving mass of " + wordSix + "air is headed directly for " + word12 + " and should result in an " + wordSeven + " pressure area over " + wordFive + " by early morning. Tomorrow we can expect temperatures in the " + wordOne + " forties. Also, it will generally be " + wordSeven + " and " + wordFour + " with a chance of scattered " + wordTen + " near the coast. If you are going out, be sure and wear your " + word14 + " and a heavier " + word13 + ", just in case.";
            MessageBox.Show(total, "Weather Report #3");
            lblHide.BringToFront();
            btnJulius.BringToFront();
            btnWeather.BringToFront();
            lblSelect.BringToFront();
            btnExit.BringToFront();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            lblHide.BringToFront(); btnExit.BringToFront(); btnJulius.BringToFront(); btnWeather.BringToFront(); lblSelect.BringToFront();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
