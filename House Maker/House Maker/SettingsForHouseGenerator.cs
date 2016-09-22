using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Maker
{
    public partial class SettingsForHouseGenerator : Form
    {
        
//############################################ Constructor ############################################

        public SettingsForHouseGenerator()
        {
            InitializeComponent();
        }

//############################################### Accessor ############################################

        public string getBedroom()
        {
            return txtBedrooms.Text;
        }

        public string getBathrooms()
        {
            return txtBathrooms.Text;
        }

//########################################## Window Functions #########################################

        private void btnSave_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
