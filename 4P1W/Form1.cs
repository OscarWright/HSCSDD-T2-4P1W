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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            //Creating a class for the game window
            frmGame gameWindow = new frmGame();
            //Showing the game window
            gameWindow.Show();
            //Hiding the menu (this form)
            this.Hide();   
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Creating a class for the help window
            frmHelp helpWindow = new frmHelp();
            //showing the help window
            helpWindow.Show();
            //Hiding the menu (this form)
            this.Hide();
        }
    }
}
