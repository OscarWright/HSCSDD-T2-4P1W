using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4P1W
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Creating a class for the help window
            Form1 frmMenu = new Form1();
            //showing the menu window
            frmMenu.Show();
            //Hiding the help screen (this form)
            this.Hide();
        }
    }
}
