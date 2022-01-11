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
        string[] word = { "test", "test", "bruh", "accurate", "accurate" };
        int index = 0;

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            // starting the game on form load
            game();
        }

        public void game()
        {
                // Clearing and hiding the answer buttons (all of the buttons in the group box)
                foreach(Control c in pnlAns.Controls)
                {    
                    c.Text = "";
                    c.Hide();
                }


                //Setting the images
                pic1.Image = imageListAccurate.Images[0];
                pic2.Image = imageListAccurate.Images[1];
                pic3.Image = imageListAccurate.Images[2];
                pic4.Image = imageListAccurate.Images[3];


                // splitting the word into characters and then randomising the array
                char[] wordChar = (word[index]).ToCharArray();
                Random random = new Random();
                wordChar = wordChar.OrderBy(x => random.Next()).ToArray();

            // setting the possible guess buttons to each item in the now random array
            int wordLength = wordChar.Count();
            switch (wordLength)
            {
                case 1:
                    g1.Text = (wordChar[0].ToString());
                    break;
                case 2:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[0].ToString());
                    break;
                case 3:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[1].ToString());
                    g3.Text = (wordChar[2].ToString());
                    break;
                case 4:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[1].ToString());
                    g3.Text = (wordChar[2].ToString());
                    g4.Text = (wordChar[3].ToString());
                    break;
                case 5:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[1].ToString());
                    g3.Text = (wordChar[2].ToString());
                    g4.Text = (wordChar[3].ToString());
                    g5.Text = (wordChar[4].ToString());
                    break;
                case 6:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[1].ToString());
                    g3.Text = (wordChar[2].ToString());
                    g4.Text = (wordChar[3].ToString());
                    g5.Text = (wordChar[4].ToString());
                    g6.Text = (wordChar[5].ToString());
                    break;
                case 7:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[1].ToString());
                    g3.Text = (wordChar[2].ToString());
                    g4.Text = (wordChar[3].ToString());
                    g5.Text = (wordChar[4].ToString());
                    g6.Text = (wordChar[5].ToString());
                    g7.Text = (wordChar[6].ToString());
                    break;
                case 8:
                    g1.Text = (wordChar[0].ToString());
                    g2.Text = (wordChar[1].ToString());
                    g3.Text = (wordChar[2].ToString());
                    g4.Text = (wordChar[3].ToString());
                    g5.Text = (wordChar[4].ToString());
                    g6.Text = (wordChar[5].ToString());
                    g7.Text = (wordChar[6].ToString());
                    g8.Text = (wordChar[7].ToString());
                    break;
                default:
                    MessageBox.Show("no word");
                    break;
            }            
        }

        public void checkAns()
        {
            string guess = (a1.Text + a2.Text + a3.Text + a4.Text + a5.Text + a6.Text + a7.Text + a8.Text);

            if (guess == word[index])
            {
                MessageBox.Show("nice" + index.ToString());
                index++;
                game();
            }
        }

        public void setAnsValue(Button c)
        {

            if (a1.Text.Equals(""))
            {
                a1.Text = c.Text;
            }
            else if (a2.Text.Equals(""))
            {
                a2.Text = c.Text;
            }
            else if (a3.Text.Equals(""))
            {
                a3.Text = c.Text;
            }
            else if (a4.Text.Equals(""))
            {
                a4.Text = c.Text;
            }
            else if (a5.Text.Equals(""))
            {
                a5.Text = c.Text;
            }
            else if (a6.Text.Equals(""))
            {
                a6.Text = c.Text;
            }
            else if (a7.Text.Equals(""))
            {
                a7.Text = c.Text;
            }
            else if (a8.Text.Equals(""))
            {
                a8.Text = c.Text;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { 
                    //Creating a class for the help window
                    Form1 frmMenu = new Form1();
                    //Showing the menu window
                    frmMenu.Show();
                    //Hiding the game (this form)
                    this.Hide();
            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Resets the level    
            game();
        }


        private void a1_Click(object sender, EventArgs e)
        {

            a1.Text = "";
        }

        private void a2_Click(object sender, EventArgs e)
        {
            a2.Text = "";
        }

        private void a3_Click(object sender, EventArgs e)
        {
            a3.Text = "";
        }

        private void a4_Click(object sender, EventArgs e)
        {
            a4.Text = "";
        }

        private void a5_Click(object sender, EventArgs e)
        {
            a5.Text = "";
        }

        private void a6_Click(object sender, EventArgs e)
        {
            a6.Text = "";
        }

        private void a7_Click(object sender, EventArgs e)
        {
            a7.Text = "";
        }

        private void a8_Click(object sender, EventArgs e)
        {
            a8.Text = "";
        }

        private void g1_Click(object sender, EventArgs e)
        {
            setAnsValue(g1);
            g1.Text = "";
            checkAns();
        }

        private void g2_Click(object sender, EventArgs e)
        {
            setAnsValue(g2);
            g2.Text = "";
            checkAns();

        }

        private void g3_Click(object sender, EventArgs e)
        {
            setAnsValue(g3);
            g3.Text = "";
            checkAns();
        }

        private void g4_Click(object sender, EventArgs e)
        {
            setAnsValue(g4);
            g4.Text = "";
            checkAns();
        }

        private void g5_Click(object sender, EventArgs e)
        {
            setAnsValue(g5);
            g5.Text = "";
            checkAns();
        }

        private void g6_Click(object sender, EventArgs e)
        {
            setAnsValue(g6);
            g6.Text = "";
            checkAns();
        }

        private void g7_Click(object sender, EventArgs e)
        {
            setAnsValue(g7);
            g7.Text = "";
            checkAns();
        }

        private void g8_Click(object sender, EventArgs e)
        {
            setAnsValue(g8);
            g8.Text = "";
            checkAns();
        }

        private void pnlGuess_Enter(object sender, EventArgs e)
        {

        }
    }
}
