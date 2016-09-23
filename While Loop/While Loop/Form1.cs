using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is a good example of how to use while loops. GREAT EXAMPLE
namespace While_Loop
{
    public partial class Form1 : Form
    {
        int to = 10;
        int ti = 0;
        int s = 0;
        Boolean stat = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btnStart.PerformClick(); }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            to = Convert.ToInt32(txtIn.Text);
            to = int.Parse(txtIn.Text);

            lblOut.Text = "";
            if (stat == false)
            {
                ti = 1;
                to++;
                while (ti < to)
                {
                    while (s < ti) { lblOut.Text += "*"; s++; }
                    s = 0;
                    ti++;
                    lblOut.Text += "\n";
                }
            }
            else
            {
                ti = 10;
                while (ti >= to)
                {
                    while (s < ti) { lblOut.Text += "✿"; s++; }
                    s = 0;
                    ti--;
                    lblOut.Text += "\n";
                }
            }
            }
        private void btnShape_Click(object sender, EventArgs e)
        {
            if (stat == false)
            {
                stat = true;
            }
            else
            {
                stat = false;
            }
        }
  /**   NOTE:
  *       Please ignore the following lines,
  *       It gives me errors when I delete them
  **/
        private void lblOut_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
