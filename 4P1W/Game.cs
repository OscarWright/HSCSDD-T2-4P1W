﻿using System;
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