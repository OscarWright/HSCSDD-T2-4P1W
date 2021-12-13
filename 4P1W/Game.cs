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
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            
            // #1 
       
            char[] word1Char = ("Accurate").ToCharArray();
            pic1.Image = imageListAccurate.Images[0];
            pic2.Image = imageListAccurate.Images[1];
            pic3.Image = imageListAccurate.Images[2];
            pic4.Image = imageListAccurate.Images[3];

            int i = 0;

            foreach(char characters in word1Char)
            {
                MessageBox.Show((word1Char[i]).ToString());
                i++;
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Creating a class for the help window
            Form1 frmMenu = new Form1();
            //Showing the menu window
            frmMenu.Show();
            //Hiding the game (this form)
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(Control c in grbxAns.Controls)
            {
                c.Text = "";
            }
        }
    }
}
