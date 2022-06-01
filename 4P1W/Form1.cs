using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Student Name: Oscar Wright    Grade: 12
Assessment Task: 2    Year: 2022

Declaration:
I hereby certify that this assignment is entirely my own work, except where I have acknowledged all material and sources used in the preparation of the assignment. I certify that all typing/keystrokes have been done by me.

I also certify that the material contained in the assignment has not been previously submitted by more for assessment in any formal course of study and that I have not copied in par or whole or otherwise plagiarised the work of other students and or persons. 

This program is designed as a free user friendly interactive and recreational product.
*/

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
